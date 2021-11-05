using System.Collections.Generic;
using System.Globalization;
using System.IO;
using AnimationControl;
using Antlr4.Runtime;
using Global;
using Interactables;
using LuaTranslator;
using PixelCrushers.DialogueSystem;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EditorMods
{
    public class LuaTranslationTool : MonoBehaviour
    {
        private const string LuaLocation = "Assets/Plugins/Pixel Crushers/Dialogue System/Scripts/Lua/Lua Translator";
        private const string DatabaseLocation = "Assets/Dialogue";
        private const string DialogueDatabaseName = "Voodoo Detective Dialogue Database.asset";
        private const string OutputLocation = "";
        private const string OutputScriptNameLuaCode = "LuaTranslatorCode";
        private const string OutputScriptNameLuaCodeMap = "LuaTranslatorCodeMap";
        private const string LanguageCode = "en-US";
        private const string GeneratedMethodPrefix = "GeneratedLuaCode";

        [MenuItem("Assets/Voodoo Helpers/Translate Dialogue Lua to C#")]
        public static void AntlrTest()
        {
            // Fetch Database
            Object[] assets = AssetDatabase.LoadAllAssetsAtPath(DatabaseLocation + "/" + DialogueDatabaseName);
            if (assets.Length != 1) throw new System.Exception("Could not find database.");
            DialogueDatabase database = assets[0] as DialogueDatabase;
            if (database == null) throw new System.Exception("Dialogue database could not be loaded.");
            TextInfo textInfo = new CultureInfo(LanguageCode, false).TextInfo;

            // Create File
            string codeFilePath = LuaLocation + "/" + OutputScriptNameLuaCode + ".cs";
            string mapFilePath = LuaLocation + "/" + OutputScriptNameLuaCodeMap + ".cs";
            if (File.Exists(codeFilePath)) File.Delete(codeFilePath);
            if (File.Exists(mapFilePath)) File.Delete(mapFilePath);

            // Generate All Code
            HashSet<string> duplicateDetector = new HashSet<string>();
            List<string> luaCode = new List<string>();
            List<string> cSharpCode = new List<string>();
            HandleTableLookups(duplicateDetector, luaCode, cSharpCode);
            HandleDialogueDatabase(duplicateDetector, database, luaCode, cSharpCode);
            HandleComponentsUsingLua(duplicateDetector, luaCode, cSharpCode);

            // Write Map File
            HandleMapFile(mapFilePath, OutputScriptNameLuaCodeMap, luaCode, cSharpCode);
            // Write Code File
            HandleCodeFile(codeFilePath, OutputScriptNameLuaCode, luaCode, cSharpCode);

            // Refresh Database
            AssetDatabase.Refresh();
        }

        private static void HandleMapFile(string mapFilePath, string className, List<string> luaCode, List<string> cSharpCode)
        {
            using (StreamWriter writer = new StreamWriter(mapFilePath))
            {
                writer.WriteLine("using Language.Lua;");
                writer.WriteLine();
                writer.WriteLine("namespace LuaTranslator");
                writer.WriteLine("{");
                writer.WriteLine("    /// <summary>");
                writer.WriteLine("    /// This file was generated. Do not edit.");
                writer.WriteLine("    /// </summary>");
                writer.WriteLine("    public class " + className);
                writer.WriteLine("    {");
                writer.WriteLine("        public static LuaValue EvaluateCachedCode(string luaString)");
                writer.WriteLine("        {");
                writer.WriteLine("            Func<LuaValue> luaValueCreator = null;");
                writer.WriteLine("            if (Code.TryGetValue(luaString, out luaValueCreator))");
                writer.WriteLine("            {");
                writer.WriteLine("                LuaValue result = luaValueCreator();");
                writer.WriteLine("                if (result.GetType() == typeof(LuaVariable)) result = ((LuaVariable)result).Dereference();");
                writer.WriteLine("                return result;");
                writer.WriteLine("            }");
                writer.WriteLine("            return null;");
                writer.WriteLine("        }");
                writer.WriteLine();
                writer.WriteLine("        public readonly static Dictionary<string, Func<LuaValue>> Code = new Dictionary<string, Func<LuaValue>>()");
                writer.WriteLine("        {");
                for (int i = 0; i < luaCode.Count; i++)
                {
                    writer.Write("            { \"");
                    writer.Write(luaCode[i].Replace(@"""", @"\""").Replace("\n", "\\n"));
                    writer.Write("\", ");
                    writer.Write("LuaTranslatorCode.");
                    writer.Write(GeneratedMethodPrefix);
                    writer.Write(i);
                    writer.WriteLine(" },");
                }
                writer.WriteLine("        };");
                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }

        private static void HandleCodeFile(string codeFilePath, string className, List<string> luaCode, List<string> cSharpCode)
        {
            using (StreamWriter writer = new StreamWriter(codeFilePath))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using Language.Lua;");
                writer.WriteLine();
                writer.WriteLine("namespace LuaTranslator");
                writer.WriteLine("{");
                writer.WriteLine("    /// <summary>");
                writer.WriteLine("    /// This file was generated. Do not edit.");
                writer.WriteLine("    /// </summary>");
                writer.WriteLine("    public class " + className);
                writer.WriteLine("    {");
                for (int i = 0; i < luaCode.Count; i++)
                {
                    writer.Write("        public static LuaValue ");
                    writer.Write(GeneratedMethodPrefix);
                    writer.Write(i);
                    writer.WriteLine("()");
                    writer.WriteLine("        {");
                    writer.Write("            ");
                    writer.WriteLine(cSharpCode[i]);
                    writer.WriteLine("        }");
                }
                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }

        private static void HandleTableLookups(HashSet<string> duplicateDetector, List<string> luaCode, List<string> cSharpCode)
        {
            // Table Lookups
            foreach (string tableName in new string[] { "Variable", "Actor", "Location", "Item", "StatusTable", "Conversation", "RelationshipTable" })
            {
                HandleConditionString(duplicateDetector, tableName, luaCode, cSharpCode);
            }
        }

        private static void HandleDialogueDatabase(HashSet<string> duplicateDetector, DialogueDatabase database, List<string> luaCode, List<string> cSharpCode)
        {
            foreach (Conversation conversation in database.conversations)
            {
                foreach (DialogueEntry entry in conversation.dialogueEntries)
                {
                    // User Script
                    HandleVoidScriptString(duplicateDetector, entry.userScript, luaCode, cSharpCode);

                    // Condition
                    HandleConditionString(duplicateDetector, entry.conditionsString, luaCode, cSharpCode);
                }
            }
        }

        private static void HandleComponentsUsingLua(HashSet<string> duplicateDetector, List<string> luaCode, List<string> cSharpCode)
        {
            string originalPath = EditorSceneManager.GetActiveScene().path;
            foreach (EditorBuildSettingsScene sceneId in EditorBuildSettings.scenes)
            {
                Scene scene = EditorSceneManager.OpenScene(sceneId.path, OpenSceneMode.Single);
                Debug.Log("Searching Scene: " + scene.name);
                foreach (GameObject obj in scene.GetRootGameObjects())
                {
                    // ActiveGateLua.cs
                    foreach (ActiveGateLua comp in obj.GetComponentsInChildren<ActiveGateLua>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.isActiveLuaExpression, luaCode, cSharpCode);
                    }
                    // AnimancerAutomaticPlay.cs
                    foreach (AnimancerAutomaticPlay comp in obj.GetComponentsInChildren<AnimancerAutomaticPlay>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.shouldActiveLua, luaCode, cSharpCode);
                        HandleConditionString(duplicateDetector, comp.shouldAnimateLua, luaCode, cSharpCode);
                    }

                    foreach (ActiveGateQuestState comp in obj.GetComponentsInChildren<ActiveGateQuestState>(true))
                    {
                        foreach (ActiveGateQuestState.ActOneGate gate in comp.act1ActiveStages)
                        {
                            HandleConditionString(duplicateDetector, gate.luaCondition, luaCode, cSharpCode);
                        }
                        foreach (ActiveGateQuestState.ActTwoGate gate in comp.act2ActiveStages)
                        {
                            HandleConditionString(duplicateDetector, gate.luaCondition, luaCode, cSharpCode);
                        }
                        foreach (ActiveGateQuestState.ActThreeGate gate in comp.act3ActiveStages)
                        {
                            HandleConditionString(duplicateDetector, gate.luaCondition, luaCode, cSharpCode);
                        }
                    }
                    // DoorController.cs
                    foreach (DoorController comp in obj.GetComponentsInChildren<DoorController>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.luaOpenOnLoad, luaCode, cSharpCode);
                    }
                    // LuaPortalLocationOverride.cs
                    foreach (LuaPortalLocationOverride comp in obj.GetComponentsInChildren<LuaPortalLocationOverride>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.luaShouldOverride, luaCode, cSharpCode);
                    }
                    // SimpleConversationInteractable.cs
                    foreach (SimpleConversationInteractable comp in obj.GetComponentsInChildren<SimpleConversationInteractable>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.isActiveLuaExpression, luaCode, cSharpCode);
                    }
                    // VoodooDetectiveMover.cs
                    foreach (VoodooDetectiveMover comp in obj.GetComponentsInChildren<VoodooDetectiveMover>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.isApproachRequiredLua, luaCode, cSharpCode);
                    }
                    // WalkWaitAnimationSoundCycler.cs
                    foreach (WalkWaitAnimationSoundCycler comp in obj.GetComponentsInChildren<WalkWaitAnimationSoundCycler>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.isActiveLuaExpression, luaCode, cSharpCode);
                    }
                    // LuaConditionSpriteSwitcher.cs
                    foreach (LuaConditionSpriteSwitcher comp in obj.GetComponentsInChildren<LuaConditionSpriteSwitcher>(true))
                    {
                        HandleConditionString(duplicateDetector, comp.luaTriggerCondition, luaCode, cSharpCode);
                    }
                    // StateLocomotionOutfitAddressable.cs
                    foreach (StateLocomotionOutfitAddressable comp in obj.GetComponentsInChildren<StateLocomotionOutfitAddressable>(true))
                    {
                        Debug.Log(comp.luaOutfitNumberCode);
                        HandleNonVoidScriptString(duplicateDetector, comp.luaOutfitNumberCode, luaCode, cSharpCode);
                    }
                    // StatePickRandomOutfitAddressable.cs
                    foreach (StatePickRandomOutfitAddressable comp in obj.GetComponentsInChildren<StatePickRandomOutfitAddressable>(true))
                    {
                        Debug.Log(comp.luaOutfitNumberCode);
                        HandleNonVoidScriptString(duplicateDetector, comp.luaOutfitNumberCode, luaCode, cSharpCode);
                    }
                    // StateSingleDirectionalSetOutfitAddressable.cs
                    foreach (StateSingleDirectionalSetOutfitAddressable comp in obj.GetComponentsInChildren<StateSingleDirectionalSetOutfitAddressable>(true))
                    {
                        Debug.Log(comp.luaOutfitNumberCode);
                        HandleNonVoidScriptString(duplicateDetector, comp.luaOutfitNumberCode, luaCode, cSharpCode);
                    }
                    // StateSingleOutfitAddressable.cs
                    foreach (StateSingleOutfitAddressable comp in obj.GetComponentsInChildren<StateSingleOutfitAddressable>(true))
                    {
                        Debug.Log(comp.luaOutfitNumberCode);
                        HandleNonVoidScriptString(duplicateDetector, comp.luaOutfitNumberCode, luaCode, cSharpCode);
                    }
                }
            }

            // Return to Original Scene
            EditorSceneManager.OpenScene(originalPath, OpenSceneMode.Single);
        }

        private static void HandleVoidScriptString(HashSet<string> duplicateDetector, string scriptString, List<string> luaCode, List<string> cSharpCode)
        {
            if (!string.IsNullOrEmpty(scriptString) && !string.IsNullOrWhiteSpace(scriptString))
            {
                string script = scriptString;
                if (!duplicateDetector.Contains(script))
                {
                    duplicateDetector.Add(script);
                    string userScriptResult = Evaluate(script);
                    userScriptResult = userScriptResult + "return LuaNil.Nil;";
                    if (userScriptResult != null)
                    {
                        luaCode.Add(script);
                        cSharpCode.Add(userScriptResult);
                    }
                }
            }
        }

        private static void HandleNonVoidScriptString(HashSet<string> duplicateDetector, string scriptString, List<string> luaCode, List<string> cSharpCode)
        {
            if (!string.IsNullOrEmpty(scriptString) && !string.IsNullOrWhiteSpace(scriptString))
            {
                string script = scriptString;
                if (!duplicateDetector.Contains(script))
                {
                    duplicateDetector.Add(script);
                    string userScriptResult = Evaluate(script);
                    if (userScriptResult != null)
                    {
                        luaCode.Add(script);
                        cSharpCode.Add(userScriptResult);
                    }
                }
            }
        }

        private static void HandleConditionString(HashSet<string> duplicateDetector, string conditionsString, List<string> luaCode, List<string> cSharpCode)
        {
            if (!string.IsNullOrEmpty(conditionsString) && !string.IsNullOrWhiteSpace(conditionsString))
            {
                string script = "return " + conditionsString;
                if (!duplicateDetector.Contains(script))
                {
                    duplicateDetector.Add(script);
                    string conditionResult = Evaluate(script);
                    if (conditionResult != null)
                    {
                        luaCode.Add(script);
                        cSharpCode.Add(conditionResult);
                    }
                }
            }
        }

        private static string Evaluate(string luaCode)
        {
            string result = null;
            try
            {
                ICharStream stream = CharStreams.fromString(luaCode);
                ITokenSource lexer = new LuaLexer(stream);
                ITokenStream tokens = new CommonTokenStream(lexer);
                LuaParser parser = new LuaParser(tokens);
                parser.BuildParseTree = true;
                CSharpLuaVisitor visitor = new CSharpLuaVisitor();
                result = visitor.Visit(parser.chunk());
            }
            catch
            {
                Debug.LogError($"Failed to parse lua: {luaCode}");
            }
            return result + ";";
        }
    }
}
