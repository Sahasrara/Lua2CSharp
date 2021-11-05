using Language.Lua;

namespace LuaTranslator
{
    /// <summary>
    /// This file was generated. Do not edit.
    /// </summary>
    public class LuaTranslatorCode
    {
        public static LuaValue GeneratedLuaCode0()
        {
            return LuaTranslatorOps.EnvironmentLookup("Variable");
        }
        public static LuaValue GeneratedLuaCode1()
        {
            return LuaTranslatorOps.EnvironmentLookup("Actor");
        }
        public static LuaValue GeneratedLuaCode2()
        {
            return LuaTranslatorOps.EnvironmentLookup("Location");
        }
        public static LuaValue GeneratedLuaCode3()
        {
            return LuaTranslatorOps.EnvironmentLookup("Item");
        }
        public static LuaValue GeneratedLuaCode4()
        {
            return LuaTranslatorOps.EnvironmentLookup("StatusTable");
        }
        public static LuaValue GeneratedLuaCode5()
        {
            return LuaTranslatorOps.EnvironmentLookup("Conversation");
        }
        public static LuaValue GeneratedLuaCode6()
        {
            return LuaTranslatorOps.EnvironmentLookup("RelationshipTable");
        }
        public static LuaValue GeneratedLuaCode7()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_gordon")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode8()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_gordon")));
        }
        public static LuaValue GeneratedLuaCode9()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_gordon"));
        }
        public static LuaValue GeneratedLuaCode10()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_offered_gordon_deal"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_complained"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_smelled_forest")));
        }
        public static LuaValue GeneratedLuaCode11()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_offered_gordon_deal")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode12()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_explained_hes_dead"));
        }
        public static LuaValue GeneratedLuaCode13()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_complained")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode14()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_explained_hes_dead")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode15()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_started")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode16()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")));
        }
        public static LuaValue GeneratedLuaCode17()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_complete")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode18()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")))));
        }
        public static LuaValue GeneratedLuaCode19()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(6));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(8));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(13));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode20()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Ink Bottle"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode21()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(7));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(9));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(462), new LuaNumber(10));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode22()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode23()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked"))))), (LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")))));
        }
        public static LuaValue GeneratedLuaCode24()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")))));
        }
        public static LuaValue GeneratedLuaCode25()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked"));
        }
        public static LuaValue GeneratedLuaCode26()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted"));
        }
        public static LuaValue GeneratedLuaCode27()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_pendanted")));
        }
        public static LuaValue GeneratedLuaCode28()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied"));
        }
        public static LuaValue GeneratedLuaCode29()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")));
        }
        public static LuaValue GeneratedLuaCode30()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_inked")));
        }
        public static LuaValue GeneratedLuaCode31()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_monied")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode32()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("LeMoon Mausoleum Key")));
        }
        public static LuaValue GeneratedLuaCode33()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_active"));
        }
        public static LuaValue GeneratedLuaCode34()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_completed")));
        }
        public static LuaValue GeneratedLuaCode35()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_active")));
        }
        public static LuaValue GeneratedLuaCode36()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_completed"));
        }
        public static LuaValue GeneratedLuaCode37()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_lemoon_unlocked")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode38()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("LeMoon Mausoleum Key"));
        }
        public static LuaValue GeneratedLuaCode39()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("InvestigateLaughton"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_active")), LuaBoolean.False);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_completed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode40()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Owner Honer Pendant"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Pendant"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode41()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_eartha")));
        }
        public static LuaValue GeneratedLuaCode42()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_eartha"));
        }
        public static LuaValue GeneratedLuaCode43()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_met_eartha")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode44()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gave_eartha_shovel"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("InvestigateLaughton")));
        }
        public static LuaValue GeneratedLuaCode45()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_owns_cemetery")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode46()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_lemoon_unlocked")));
        }
        public static LuaValue GeneratedLuaCode47()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_eartha_wants_shovel")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode48()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gave_eartha_shovel")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Shovel"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode49()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_eartha_wants_shovel")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Shovel")));
        }
        public static LuaValue GeneratedLuaCode50()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("InvestigateLaughton"));
        }
        public static LuaValue GeneratedLuaCode51()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Faded Tombstones"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode52()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode53()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode54()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode55()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode56()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode57()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_esmereldas_coffin_open")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode58()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_esmereldas_coffin_open")));
        }
        public static LuaValue GeneratedLuaCode59()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_esmereldas_coffin_open"));
        }
        public static LuaValue GeneratedLuaCode60()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("mahi mahi"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mahi_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode61()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mahi_ordered")));
        }
        public static LuaValue GeneratedLuaCode62()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("snapper"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_snapper_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode63()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_snapper_ordered")));
        }
        public static LuaValue GeneratedLuaCode64()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mojito_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode65()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mojito_ordered")));
        }
        public static LuaValue GeneratedLuaCode66()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_martini_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode67()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_martini_ordered")));
        }
        public static LuaValue GeneratedLuaCode68()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_punch_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode69()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_punch_ordered")));
        }
        public static LuaValue GeneratedLuaCode70()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("fugo"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_ordered")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode71()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_ordered")));
        }
        public static LuaValue GeneratedLuaCode72()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_menu_known")));
        }
        public static LuaValue GeneratedLuaCode73()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_menu_known"));
        }
        public static LuaValue GeneratedLuaCode74()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SubtractMoney"), new LuaNumber(2));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(9), new LuaNumber(97));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode75()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_food_joke"));
        }
        public static LuaValue GeneratedLuaCode76()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SubtractMoney"), new LuaNumber(1));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(9), new LuaNumber(111));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode77()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_food_joke")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode78()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_food_joke")));
        }
        public static LuaValue GeneratedLuaCode79()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_drink_joke"));
        }
        public static LuaValue GeneratedLuaCode80()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_drink_joke")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode81()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_drink_joke")));
        }
        public static LuaValue GeneratedLuaCode82()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_punch_ordered")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mojito_ordered"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_martini_ordered")));
        }
        public static LuaValue GeneratedLuaCode83()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("fugo"));
        }
        public static LuaValue GeneratedLuaCode84()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_ordered"));
        }
        public static LuaValue GeneratedLuaCode85()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("mahi mahi"));
        }
        public static LuaValue GeneratedLuaCode86()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("food"), new LuaString("snapper"));
        }
        public static LuaValue GeneratedLuaCode87()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_punch_ordered")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mojito_ordered"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_martini_ordered")))));
        }
        public static LuaValue GeneratedLuaCode88()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mahi_ordered"));
        }
        public static LuaValue GeneratedLuaCode89()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_snapper_ordered"));
        }
        public static LuaValue GeneratedLuaCode90()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_martini_ordered"));
        }
        public static LuaValue GeneratedLuaCode91()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mojito_ordered"));
        }
        public static LuaValue GeneratedLuaCode92()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_punch_ordered"));
        }
        public static LuaValue GeneratedLuaCode93()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_menu_known")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode94()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_is_ready_to_talk")))));
        }
        public static LuaValue GeneratedLuaCode95()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_is_ready_to_talk")));
        }
        public static LuaValue GeneratedLuaCode96()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_is_ready_to_talk")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(8), new LuaNumber(149));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode97()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_is_ready_to_talk")));
        }
        public static LuaValue GeneratedLuaCode98()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_learned_of_kiki"));
        }
        public static LuaValue GeneratedLuaCode99()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode100()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_saw_pendant")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode101()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("FindPendantOwner"));
        }
        public static LuaValue GeneratedLuaCode102()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_told_lemoon_story")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_told_lemoon_story")));
        }
        public static LuaValue GeneratedLuaCode103()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_refused_to_talk"));
        }
        public static LuaValue GeneratedLuaCode104()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_refused_to_talk")));
        }
        public static LuaValue GeneratedLuaCode105()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_left_restaurant")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode106()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gave_eartha_shovel"));
        }
        public static LuaValue GeneratedLuaCode107()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_saw_pendant"));
        }
        public static LuaValue GeneratedLuaCode108()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_saw_pendant")));
        }
        public static LuaValue GeneratedLuaCode109()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_learned_of_kiki")));
        }
        public static LuaValue GeneratedLuaCode110()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_left_restaurant")));
        }
        public static LuaValue GeneratedLuaCode111()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_left_restaurant"));
        }
        public static LuaValue GeneratedLuaCode112()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki")));
        }
        public static LuaValue GeneratedLuaCode113()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki"));
        }
        public static LuaValue GeneratedLuaCode114()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_is_ready_to_talk"));
        }
        public static LuaValue GeneratedLuaCode115()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_gland_acquired"));
        }
        public static LuaValue GeneratedLuaCode116()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_gland_acquired")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode117()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_fugo_gland_acquired")));
        }
        public static LuaValue GeneratedLuaCode118()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_know_need_room_key"));
        }
        public static LuaValue GeneratedLuaCode119()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_elevator_unlocked")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Kiki's Room Key"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode120()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Kiki's Room Key"));
        }
        public static LuaValue GeneratedLuaCode121()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_know_need_room_key")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode122()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_can_enter_marys_room")));
        }
        public static LuaValue GeneratedLuaCode123()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Kiki's Room Key")));
        }
        public static LuaValue GeneratedLuaCode124()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_elevator_unlocked"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_know_need_room_key")));
        }
        public static LuaValue GeneratedLuaCode125()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_took_flower")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode126()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_took_flower")));
        }
        public static LuaValue GeneratedLuaCode127()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_took_flower"));
        }
        public static LuaValue GeneratedLuaCode128()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_kiki_photos")));
        }
        public static LuaValue GeneratedLuaCode129()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Incriminating Photos"));
        }
        public static LuaValue GeneratedLuaCode130()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Incriminating Photos"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_kiki_photos")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode131()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_kiki_photos"));
        }
        public static LuaValue GeneratedLuaCode132()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_theodore_photos"));
        }
        public static LuaValue GeneratedLuaCode133()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mary_ready_for_stake_out")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode134()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mary_ready_for_stake_out")));
        }
        public static LuaValue GeneratedLuaCode135()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gordon_owns_cemetery"));
        }
        public static LuaValue GeneratedLuaCode136()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_told_lemoon_story")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_told_lemoon_story")));
        }
        public static LuaValue GeneratedLuaCode137()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_told_lemoon_story"));
        }
        public static LuaValue GeneratedLuaCode138()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_told_lemoon_story"));
        }
        public static LuaValue GeneratedLuaCode139()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_mary_knows_lemoon"));
        }
        public static LuaValue GeneratedLuaCode140()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("ConfrontVictorAboutJournal")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("BombDeployed")));
        }
        public static LuaValue GeneratedLuaCode141()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_explained_laughton_to_mary")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode142()
        {
            return LuaTranslatorOps.Or((LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_explained_laughton_to_mary")))), (LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_cant_fit_in_shaft"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_explained_laughton_to_mary")))));
        }
        public static LuaValue GeneratedLuaCode143()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_is_stake_out")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode144()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_explained_laughton_to_mary")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_cant_fit_in_shaft")));
        }
        public static LuaValue GeneratedLuaCode145()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_mary_ready_for_stake_out"));
        }
        public static LuaValue GeneratedLuaCode146()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_photos_taken")));
        }
        public static LuaValue GeneratedLuaCode147()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_mary_about_pendant")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode148()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_mary_about_pendant")));
        }
        public static LuaValue GeneratedLuaCode149()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_told_mary_about_pendant"));
        }
        public static LuaValue GeneratedLuaCode150()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AcquireJournal"));
        }
        public static LuaValue GeneratedLuaCode151()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("InvestigateLaughton")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AcquireJournal")));
        }
        public static LuaValue GeneratedLuaCode152()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_mary_knows_lemoon")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode153()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_mary_knows_lemoon")));
        }
        public static LuaValue GeneratedLuaCode154()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Camera")));
        }
        public static LuaValue GeneratedLuaCode155()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Camera"));
        }
        public static LuaValue GeneratedLuaCode156()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_can_enter_kikis_room")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode157()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_learned_kiki_door_name")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode158()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_can_enter_marys_room")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode159()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Apply Item to Unapplyable"), new LuaNumber(2)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode160()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Combine Uncombinable"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode161()
        {
            return (LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Forest (Entrance)")));
        }
        public static LuaValue GeneratedLuaCode162()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_govi_active"))), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Govi")));
        }
        public static LuaValue GeneratedLuaCode163()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Govi")));
        }
        public static LuaValue GeneratedLuaCode164()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode165()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode166()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Talk to Tourist"), new LuaNumber(4)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode167()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_early_gun_talk_prevented"));
        }
        public static LuaValue GeneratedLuaCode168()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(4));
        }
        public static LuaValue GeneratedLuaCode169()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_early_gun_talk_prevented")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(2));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode170()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_early_gun_talk_prevented")));
        }
        public static LuaValue GeneratedLuaCode171()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Talk to Zombie"), new LuaNumber(6)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode172()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_talked_to_zombie"));
        }
        public static LuaValue GeneratedLuaCode173()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(5));
        }
        public static LuaValue GeneratedLuaCode174()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(6));
        }
        public static LuaValue GeneratedLuaCode175()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(3));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_talked_to_zombie")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode176()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_talked_to_zombie")));
        }
        public static LuaValue GeneratedLuaCode177()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Use Unusable"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode178()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("Tutorial"));
        }
        public static LuaValue GeneratedLuaCode179()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AnswerTelephone"));
        }
        public static LuaValue GeneratedLuaCode180()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("Opening"));
        }
        public static LuaValue GeneratedLuaCode181()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("ConfrontVictorAboutJournal"));
        }
        public static LuaValue GeneratedLuaCode182()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("BombDeployed"));
        }
        public static LuaValue GeneratedLuaCode183()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("VDWasBombed"));
        }
        public static LuaValue GeneratedLuaCode184()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("FollowBadGuys"));
        }
        public static LuaValue GeneratedLuaCode185()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("PowerTheCrane"));
        }
        public static LuaValue GeneratedLuaCode186()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("DrainTheLake"));
        }
        public static LuaValue GeneratedLuaCode187()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("HandleTheHounfo"));
        }
        public static LuaValue GeneratedLuaCode188()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("ReturnToBeach"));
        }
        public static LuaValue GeneratedLuaCode189()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("GetTheGovi"));
        }
        public static LuaValue GeneratedLuaCode190()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("OpenTheSafe"));
        }
        public static LuaValue GeneratedLuaCode191()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("SaveBaronSamedi"));
        }
        public static LuaValue GeneratedLuaCode192()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("EndGame"));
        }
        public static LuaValue GeneratedLuaCode193()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_eartha_wants_shovel"));
        }
        public static LuaValue GeneratedLuaCode194()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gave_eartha_shovel")));
        }
        public static LuaValue GeneratedLuaCode195()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_photos_taken"));
        }
        public static LuaValue GeneratedLuaCode196()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_kiki_photos")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_theodore_photos")))));
        }
        public static LuaValue GeneratedLuaCode197()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_kiki_photos")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_theodore_photos")));
        }
        public static LuaValue GeneratedLuaCode198()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_personal_passcode")), new LuaString(""));
        }
        public static LuaValue GeneratedLuaCode199()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_personal_passcode")), new LuaString(""));
        }
        public static LuaValue GeneratedLuaCode200()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_lifeboat")));
        }
        public static LuaValue GeneratedLuaCode201()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_lifeboat"));
        }
        public static LuaValue GeneratedLuaCode202()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_fusebox_fixed")));
        }
        public static LuaValue GeneratedLuaCode203()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_fusebox_fixed"));
        }
        public static LuaValue GeneratedLuaCode204()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_fusebox")));
        }
        public static LuaValue GeneratedLuaCode205()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_fusebox"));
        }
        public static LuaValue GeneratedLuaCode206()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_ritual_over")));
        }
        public static LuaValue GeneratedLuaCode207()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_ritual_over"));
        }
        public static LuaValue GeneratedLuaCode208()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_gave_quest")));
        }
        public static LuaValue GeneratedLuaCode209()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_gave_quest"));
        }
        public static LuaValue GeneratedLuaCode210()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_finished_possession")));
        }
        public static LuaValue GeneratedLuaCode211()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_finished_possession"));
        }
        public static LuaValue GeneratedLuaCode212()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_lied")));
        }
        public static LuaValue GeneratedLuaCode213()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_lied"));
        }
        public static LuaValue GeneratedLuaCode214()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used")))));
        }
        public static LuaValue GeneratedLuaCode215()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used")));
        }
        public static LuaValue GeneratedLuaCode216()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_eartha_wants_shovel")));
        }
        public static LuaValue GeneratedLuaCode217()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsDoorKnocking")));
        }
        public static LuaValue GeneratedLuaCode218()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsDoorKnocking"));
        }
        public static LuaValue GeneratedLuaCode219()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_smelled_forest")));
        }
        public static LuaValue GeneratedLuaCode220()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_smelled_forest"));
        }
        public static LuaValue GeneratedLuaCode221()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_safe_open")));
        }
        public static LuaValue GeneratedLuaCode222()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_safe_open"));
        }
        public static LuaValue GeneratedLuaCode223()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_fire_started")));
        }
        public static LuaValue GeneratedLuaCode224()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_fire_started"));
        }
        public static LuaValue GeneratedLuaCode225()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_have_grammys_book")));
        }
        public static LuaValue GeneratedLuaCode226()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_have_grammys_book"));
        }
        public static LuaValue GeneratedLuaCode227()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_met_gordon")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode228()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_met_gordon")));
        }
        public static LuaValue GeneratedLuaCode229()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_met_gordon"));
        }
        public static LuaValue GeneratedLuaCode230()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_knows_lemoon")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(201));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode231()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_knows_lemoon")));
        }
        public static LuaValue GeneratedLuaCode232()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_told_lemoon_story")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode233()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_can_ask_about_chocolate")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode234()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_executive_approval_explained"));
        }
        public static LuaValue GeneratedLuaCode235()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_is_poisoned")));
        }
        public static LuaValue GeneratedLuaCode236()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_blamed_gordon"));
        }
        public static LuaValue GeneratedLuaCode237()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(142));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(210));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(211));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode238()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_can_ask_about_chocolate"));
        }
        public static LuaValue GeneratedLuaCode239()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Poisoned Chocolates"));
        }
        public static LuaValue GeneratedLuaCode240()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(209));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(179));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode241()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_mentioned_chocolates")));
        }
        public static LuaValue GeneratedLuaCode242()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_mentioned_chocolates")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(180));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(209));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode243()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_is_poisoned"));
        }
        public static LuaValue GeneratedLuaCode244()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(206));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(207));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode245()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_knows_lemoon"));
        }
        public static LuaValue GeneratedLuaCode246()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(121), new LuaNumber(199));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode247()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_mentioned_chocolates"));
        }
        public static LuaValue GeneratedLuaCode248()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_is_poisoned")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode249()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_acquired_override"));
        }
        public static LuaValue GeneratedLuaCode250()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_acquired_override")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode251()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_acquired_override")));
        }
        public static LuaValue GeneratedLuaCode252()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_read_francois_journal")));
        }
        public static LuaValue GeneratedLuaCode253()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(245)), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Executive Approval Form")))));
        }
        public static LuaValue GeneratedLuaCode254()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_argument_finished"));
        }
        public static LuaValue GeneratedLuaCode255()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(245)), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Executive Approval Form")));
        }
        public static LuaValue GeneratedLuaCode256()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_personal_passcode")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_passcode_buffer")));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_passcode_buffer")), new LuaString(""));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode257()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(120), new LuaNumber(46));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode258()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_crumbsford_gone_after_journal"));
        }
        public static LuaValue GeneratedLuaCode259()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_executive_approval_explained")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode260()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Executive Approval Form")));
        }
        public static LuaValue GeneratedLuaCode261()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AcquireJournal"));
        }
        public static LuaValue GeneratedLuaCode262()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_executive_approval_explained")));
        }
        public static LuaValue GeneratedLuaCode263()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_argument_finished")));
        }
        public static LuaValue GeneratedLuaCode264()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Candle"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Black Candle"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode265()
        {
            return LuaTranslatorOps.GT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode266()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_passcode_buffer")), new LuaString(""));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode267()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsSafeDepositCodeCorrect")));
        }
        public static LuaValue GeneratedLuaCode268()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsSafeDepositCodeCorrect"));
        }
        public static LuaValue GeneratedLuaCode269()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_read_francois_journal")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode270()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("ConfrontVictorAboutJournal"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode271()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_read_francois_journal"));
        }
        public static LuaValue GeneratedLuaCode272()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_completed"));
        }
        public static LuaValue GeneratedLuaCode273()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_completed")));
        }
        public static LuaValue GeneratedLuaCode274()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_required"));
        }
        public static LuaValue GeneratedLuaCode275()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_required")));
        }
        public static LuaValue GeneratedLuaCode276()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_have_grammys_book")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode277()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_victor")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_mentioned_victor_and_gordon")));
        }
        public static LuaValue GeneratedLuaCode278()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_met_gordon")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_mentioned_victor_and_gordon")));
        }
        public static LuaValue GeneratedLuaCode279()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_required")), LuaBoolean.False);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_level")), new LuaNumber(2));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode280()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_level")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode281()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_level")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode282()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_required")), LuaBoolean.False);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_upgrade_level")), new LuaNumber(3));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode283()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Awake"));
        }
        public static LuaValue GeneratedLuaCode284()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Awake"));
        }
        public static LuaValue GeneratedLuaCode285()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dbh_voodoo_station_unlocked")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode286()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_minigame_completed")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dbh_voodoo_station_unlocked"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_took_mortar_and_pestle")));
        }
        public static LuaValue GeneratedLuaCode287()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_met_ricky")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("exit_after_mint"), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode288()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("VDWasBombed"));
        }
        public static LuaValue GeneratedLuaCode289()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_victor"));
        }
        public static LuaValue GeneratedLuaCode290()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_asked_ricky_about_benny")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode291()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_benny"));
        }
        public static LuaValue GeneratedLuaCode292()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_met_kiki")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_learned_of_kiki")));
        }
        public static LuaValue GeneratedLuaCode293()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_met_gordon")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_mentioned_victor_and_gordon"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_argument_finished")));
        }
        public static LuaValue GeneratedLuaCode294()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_took_mortar_and_pestle")));
        }
        public static LuaValue GeneratedLuaCode295()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_offered_mortar_for_mint"));
        }
        public static LuaValue GeneratedLuaCode296()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_offered_mortar_for_mint")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode297()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_offered_mortar_for_mint")));
        }
        public static LuaValue GeneratedLuaCode298()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Mint"));
        }
        public static LuaValue GeneratedLuaCode299()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_took_mortar_and_pestle")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode300()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Mint")));
        }
        public static LuaValue GeneratedLuaCode301()
        {
            return LuaTranslatorOps.GT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode302()
        {
            return LuaTranslatorOps.LTE(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode303()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode304()
        {
            return LuaTranslatorOps.LT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode305()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_ricky_mentioned_victor_and_gordon")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode306()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Ricky's Letter")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_unlocked")))));
        }
        public static LuaValue GeneratedLuaCode307()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_unlocked"))), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Ricky's Letter")));
        }
        public static LuaValue GeneratedLuaCode308()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_unlocked"));
        }
        public static LuaValue GeneratedLuaCode309()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_mentioned_hounfo")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode310()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("FindPendantOwner"));
        }
        public static LuaValue GeneratedLuaCode311()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_visited_post_bombing")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode312()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), LuaTranslatorOps.Subtraction(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(1)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode313()
        {
            return LuaTranslatorOps.LTE(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode314()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Tear Stained Letter"));
        }
        public static LuaValue GeneratedLuaCode315()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Tear Stained Letter")));
        }
        public static LuaValue GeneratedLuaCode316()
        {
            return LuaTranslatorOps.GT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_drink_count")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode317()
        {
            return LuaTranslatorOps.EnvironmentLookup("exit_after_mint");
        }
        public static LuaValue GeneratedLuaCode318()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.EnvironmentLookup("exit_after_mint"));
        }
        public static LuaValue GeneratedLuaCode319()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Wet"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode320()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Hurt"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Chair"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode321()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Awake"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode322()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Slapped"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Metal Gauntlet"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode323()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("exit_after_mint"), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode324()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Bucket of Water"));
        }
        public static LuaValue GeneratedLuaCode325()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Bucket of Water")));
        }
        public static LuaValue GeneratedLuaCode326()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Wet"));
        }
        public static LuaValue GeneratedLuaCode327()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Wet"));
        }
        public static LuaValue GeneratedLuaCode328()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Chair"));
        }
        public static LuaValue GeneratedLuaCode329()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Chair")));
        }
        public static LuaValue GeneratedLuaCode330()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Hurt"));
        }
        public static LuaValue GeneratedLuaCode331()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Hurt"));
        }
        public static LuaValue GeneratedLuaCode332()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_met_ricky"));
        }
        public static LuaValue GeneratedLuaCode333()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_met_ricky")));
        }
        public static LuaValue GeneratedLuaCode334()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dbh_voodoo_station_unlocked")));
        }
        public static LuaValue GeneratedLuaCode335()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dbh_voodoo_station_unlocked"));
        }
        public static LuaValue GeneratedLuaCode336()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_finished_possession")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Ason"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode337()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_drew_veve")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_ason_complete")));
        }
        public static LuaValue GeneratedLuaCode338()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_drew_veve")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_ason_complete")))));
        }
        public static LuaValue GeneratedLuaCode339()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_drew_veve")));
        }
        public static LuaValue GeneratedLuaCode340()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Broken Ason"));
        }
        public static LuaValue GeneratedLuaCode341()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Broken Ason")));
        }
        public static LuaValue GeneratedLuaCode342()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_drew_veve"));
        }
        public static LuaValue GeneratedLuaCode343()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_drew_veve")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode344()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_explained_death")));
        }
        public static LuaValue GeneratedLuaCode345()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_explained_death"));
        }
        public static LuaValue GeneratedLuaCode346()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_teeth")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode347()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_teeth")));
        }
        public static LuaValue GeneratedLuaCode348()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_teeth"));
        }
        public static LuaValue GeneratedLuaCode349()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_met_francois"));
        }
        public static LuaValue GeneratedLuaCode350()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_recognized_mary")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode351()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_met_francois")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode352()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_met_francois")));
        }
        public static LuaValue GeneratedLuaCode353()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_lake_drained")));
        }
        public static LuaValue GeneratedLuaCode354()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_lake_drained"));
        }
        public static LuaValue GeneratedLuaCode355()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_recognized_mary")));
        }
        public static LuaValue GeneratedLuaCode356()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_recognized_mary"));
        }
        public static LuaValue GeneratedLuaCode357()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_told_long_story")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode358()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_gave_quest")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode359()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_told_long_story"));
        }
        public static LuaValue GeneratedLuaCode360()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Sign of Papa Legba")));
        }
        public static LuaValue GeneratedLuaCode361()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_explained_death")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode362()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_francois_lied")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode363()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Sign of Papa Legba"));
        }
        public static LuaValue GeneratedLuaCode364()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_can_touch_francois_stuff")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode365()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_pot_contains_pyrite")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode366()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_charcoal")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode367()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_charcoal")));
        }
        public static LuaValue GeneratedLuaCode368()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_charcoal"));
        }
        public static LuaValue GeneratedLuaCode369()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_cupboard_open")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode370()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_cupboard_open")));
        }
        public static LuaValue GeneratedLuaCode371()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_cupboard_open"));
        }
        public static LuaValue GeneratedLuaCode372()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_cereal")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode373()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_cereal")));
        }
        public static LuaValue GeneratedLuaCode374()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_cereal"));
        }
        public static LuaValue GeneratedLuaCode375()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_pot_contains_pyrite")));
        }
        public static LuaValue GeneratedLuaCode376()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_stove_on")));
        }
        public static LuaValue GeneratedLuaCode377()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_stove_on"));
        }
        public static LuaValue GeneratedLuaCode378()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_pot_contains_pyrite"));
        }
        public static LuaValue GeneratedLuaCode379()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_stove_on")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode380()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_stove_on")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_pot_contains_pyrite")));
        }
        public static LuaValue GeneratedLuaCode381()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_stove_on")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_pot_contains_pyrite")))));
        }
        public static LuaValue GeneratedLuaCode382()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_sulfur")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode383()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_sulfur")));
        }
        public static LuaValue GeneratedLuaCode384()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_sulfur"));
        }
        public static LuaValue GeneratedLuaCode385()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_washed_up")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode386()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_feather")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Kooka Bunches Cereal"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode387()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_bird_scared"));
        }
        public static LuaValue GeneratedLuaCode388()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_bird_scared")));
        }
        public static LuaValue GeneratedLuaCode389()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_lake_drained")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Blasting Plunger"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("HandleTheHounfo"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode390()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_guano")));
        }
        public static LuaValue GeneratedLuaCode391()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_guano"));
        }
        public static LuaValue GeneratedLuaCode392()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_guano")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode393()
        {
            return LuaTranslatorOps.LTE(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode394()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_toilet_handle")));
        }
        public static LuaValue GeneratedLuaCode395()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Middle Deck (Exquisite Bathroom)"));
        }
        public static LuaValue GeneratedLuaCode396()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Middle Deck (Exquisite Bathroom)"));
        }
        public static LuaValue GeneratedLuaCode397()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_toilet_handle")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode398()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle"));
        }
        public static LuaValue GeneratedLuaCode399()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), LuaTranslatorOps.Subtraction(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(1)));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode400()
        {
            return LuaTranslatorOps.GT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode401()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_toilet_handle"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle")));
        }
        public static LuaValue GeneratedLuaCode402()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle")));
        }
        public static LuaValue GeneratedLuaCode403()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_drank_stimulant")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode404()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode405()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_stall_closed")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_vd_in_stall")));
        }
        public static LuaValue GeneratedLuaCode406()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_stall_closed")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_vd_in_stall")))));
        }
        public static LuaValue GeneratedLuaCode407()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_was_resurrected")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode408()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_portal_flag")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode409()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Papa Legba Realm (Sign Crossroads)"));
        }
        public static LuaValue GeneratedLuaCode410()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanUseSignOfPapaLegba")));
        }
        public static LuaValue GeneratedLuaCode411()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanUseSignOfPapaLegba"));
        }
        public static LuaValue GeneratedLuaCode412()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Papa Legba Realm (Sign Crossroads)"));
        }
        public static LuaValue GeneratedLuaCode413()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Factory (Floor South)"));
        }
        public static LuaValue GeneratedLuaCode414()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SceneName")), new LuaString("Factory (Floor South)"));
        }
        public static LuaValue GeneratedLuaCode415()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Baron Samedi Essence")));
        }
        public static LuaValue GeneratedLuaCode416()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Baron Samedi Essence"));
        }
        public static LuaValue GeneratedLuaCode417()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("StopVictor"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode418()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Cored Apple"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Apple of my Eye"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode419()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Autograph"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_autographed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode420()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_syruped")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_autographed")));
        }
        public static LuaValue GeneratedLuaCode421()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Simple Syrup"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_syruped")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode422()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Apple of my Eye"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Knife"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Apple of my Eye (Left)"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Apple of my Eye (Right)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode423()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Fire"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Gum Wrapper"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Battery"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode424()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Molotov Cocktail (Lit)"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Molotov Cocktail"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Fire"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode425()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Molotov Cocktail"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Aged Rum"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Washcloth"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode426()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Bat Guano"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Metal Cup"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Metal Cup (Mixture)"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode427()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur")));
        }
        public static LuaValue GeneratedLuaCode428()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode429()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Charcoal"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Metal Cup"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Metal Cup (Mixture)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode430()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Grammy's Flamin' Hot Sauce"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Metal Cup (Mixture)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode431()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Sulfur"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Metal Cup"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Metal Cup (Mixture)"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode432()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Teeth"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Broken Ason"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Ason"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_ason_complete")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode433()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_black_candle")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Black Candle"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Mortar and Pestle"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Mortar and Pestle (Mixture)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode434()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_magnet")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_lemon"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_black_candle")));
        }
        public static LuaValue GeneratedLuaCode435()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Lemon"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Mortar and Pestle"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Mortar and Pestle (Mixture)"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_lemon")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode436()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Pendant"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Owner Honer"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Owner Honer Pendant"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_active")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode437()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Permanent Magnet"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Mortar and Pestle"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Mortar and Pestle (Mixture)"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_magnet")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode438()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Permanent Magnet"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Radio Speaker"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_acquired_permanent_magnet")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode439()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_vent_is_open"));
        }
        public static LuaValue GeneratedLuaCode440()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Screwdriver"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode441()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Owner Honer"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Mortar and Pestle (Mixture)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode442()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Poisoned Chocolates"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Fugo Fish Gland"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Chocolates"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode443()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Coffee Cup (Spiked)"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Coffee Cup (Full)"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Centennial Dragon Heart Plumeria"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode444()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_ason_complete"));
        }
        public static LuaValue GeneratedLuaCode445()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_ason_complete")));
        }
        public static LuaValue GeneratedLuaCode446()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_mind_numb")));
        }
        public static LuaValue GeneratedLuaCode447()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_mind_numb")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode448()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_mind_numb"));
        }
        public static LuaValue GeneratedLuaCode449()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_syruped")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_autographed")))));
        }
        public static LuaValue GeneratedLuaCode450()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_syruped"));
        }
        public static LuaValue GeneratedLuaCode451()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_autographed"));
        }
        public static LuaValue GeneratedLuaCode452()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_toilet_handle")));
        }
        public static LuaValue GeneratedLuaCode453()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_toilet_handle"));
        }
        public static LuaValue GeneratedLuaCode454()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur")))));
        }
        public static LuaValue GeneratedLuaCode455()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur")));
        }
        public static LuaValue GeneratedLuaCode456()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano")));
        }
        public static LuaValue GeneratedLuaCode457()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")));
        }
        public static LuaValue GeneratedLuaCode458()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")));
        }
        public static LuaValue GeneratedLuaCode459()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal")));
        }
        public static LuaValue GeneratedLuaCode460()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_charcoal"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_bat_guano"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_combined_sulfur")));
        }
        public static LuaValue GeneratedLuaCode461()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_magnet")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_lemon"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("owner_honer_ingredient_black_candle")))));
        }
        public static LuaValue GeneratedLuaCode462()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("using_desk"), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode463()
        {
            return LuaTranslatorOps.EnvironmentLookup("using_desk");
        }
        public static LuaValue GeneratedLuaCode464()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Talk to Shopkeeper"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode465()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_is_poisoned")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Chocolates"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cc_gordon_mentioned_chocolates")));
        }
        public static LuaValue GeneratedLuaCode466()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode467()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_helped_with_shovel"));
        }
        public static LuaValue GeneratedLuaCode468()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(15));
        }
        public static LuaValue GeneratedLuaCode469()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_need_victor_for_shovel")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode470()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_gave_eartha_shovel")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Shovel"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_eartha_wants_shovel")));
        }
        public static LuaValue GeneratedLuaCode471()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_helped_with_shovel")));
        }
        public static LuaValue GeneratedLuaCode472()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_clicked_shirts"));
        }
        public static LuaValue GeneratedLuaCode473()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_clicked_shirts")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode474()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_clicked_shirts")));
        }
        public static LuaValue GeneratedLuaCode475()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Island Trader Shirt Rack"), new LuaNumber(5)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode476()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_acquired_camera")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode477()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(10));
        }
        public static LuaValue GeneratedLuaCode478()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_acquired_camera")));
        }
        public static LuaValue GeneratedLuaCode479()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_acquired_camera"));
        }
        public static LuaValue GeneratedLuaCode480()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("CanAfford"), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode481()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_photos_taken")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode482()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_refused_to_talk")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode483()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_theodore_photos")));
        }
        public static LuaValue GeneratedLuaCode484()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("FindPendantOwner"));
        }
        public static LuaValue GeneratedLuaCode485()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_gave_theodore_photos")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AcquireJournal"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode486()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_cabinet_open")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode487()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AcquireJournal"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode488()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("LeMoon Bank Account Receipt"));
        }
        public static LuaValue GeneratedLuaCode489()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("LeMoon Bank Account Receipt")));
        }
        public static LuaValue GeneratedLuaCode490()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_is_stake_out")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode491()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_vent_is_open")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode492()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_acquired_permanent_magnet"));
        }
        public static LuaValue GeneratedLuaCode493()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_cant_fit_in_shaft")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode494()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_mentioned_hounfo")));
        }
        public static LuaValue GeneratedLuaCode495()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_mentioned_hounfo"));
        }
        public static LuaValue GeneratedLuaCode496()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_saw_hoodoo_book")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode497()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_bennys_drawer_open"));
        }
        public static LuaValue GeneratedLuaCode498()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_bennys_drawer_open")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode499()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_bennys_drawer_open")));
        }
        public static LuaValue GeneratedLuaCode500()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("using_desk"), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode501()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_gained_entry")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode502()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_argument_finished")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode503()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_delivered_ricky_letter")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode504()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Ricky's Letter"));
        }
        public static LuaValue GeneratedLuaCode505()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Greenhouse Key")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_unlocked"))))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_attempted")));
        }
        public static LuaValue GeneratedLuaCode506()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_delivered_ricky_letter")));
        }
        public static LuaValue GeneratedLuaCode507()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_delivered_ricky_letter"));
        }
        public static LuaValue GeneratedLuaCode508()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_victor")));
        }
        public static LuaValue GeneratedLuaCode509()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_saw_hoodoo_book"));
        }
        public static LuaValue GeneratedLuaCode510()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_saw_hoodoo_book")));
        }
        public static LuaValue GeneratedLuaCode511()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_unlocked")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode512()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Greenhouse Key"));
        }
        public static LuaValue GeneratedLuaCode513()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_greenhouse_attempted")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode514()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Greenhouse Key")));
        }
        public static LuaValue GeneratedLuaCode515()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_benny")));
        }
        public static LuaValue GeneratedLuaCode516()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_benny")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode517()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("BombDeployed"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode518()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_mint")));
        }
        public static LuaValue GeneratedLuaCode519()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_mint")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode520()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_mint"));
        }
        public static LuaValue GeneratedLuaCode521()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_lemon")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode522()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_lemon")));
        }
        public static LuaValue GeneratedLuaCode523()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_took_lemon"));
        }
        public static LuaValue GeneratedLuaCode524()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Lemon"));
        }
        public static LuaValue GeneratedLuaCode525()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Lemon")));
        }
        public static LuaValue GeneratedLuaCode526()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_met_victor")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode527()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_told_lemoon_story")));
        }
        public static LuaValue GeneratedLuaCode528()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_learned_of_kiki")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode529()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(77), new LuaNumber(28));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(77), new LuaNumber(75));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_told_lemoon_story")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode530()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_blamed_gordon")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode531()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_helped_with_shovel")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode532()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("mansion_victor_helped_with_shovel"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("it_need_victor_for_shovel")));
        }
        public static LuaValue GeneratedLuaCode533()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Angry Patient"), new LuaNumber(6)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode534()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Happy Patient"), new LuaNumber(5)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode535()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Acquired"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Book of Tax Law"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode536()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode537()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode538()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_have_visited")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode539()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode540()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode541()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode542()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.And(LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used")), LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"))), LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used")));
        }
        public static LuaValue GeneratedLuaCode543()
        {
            return LuaTranslatorOps.And((LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used")))), (LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Used")), LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Used"))), LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_pipe_state")), new LuaString("Used")))));
        }
        public static LuaValue GeneratedLuaCode544()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Acquired"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode545()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode546()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_cane_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode547()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_gc_examined")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode548()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_gc_examined")));
        }
        public static LuaValue GeneratedLuaCode549()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_gc_examined"));
        }
        public static LuaValue GeneratedLuaCode550()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_mf_examined")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode551()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_mf_examined")));
        }
        public static LuaValue GeneratedLuaCode552()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_mf_examined"));
        }
        public static LuaValue GeneratedLuaCode553()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_tl_examined")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode554()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_tl_examined")));
        }
        public static LuaValue GeneratedLuaCode555()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_tl_examined"));
        }
        public static LuaValue GeneratedLuaCode556()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_vd_examined")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode557()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_vd_examined")));
        }
        public static LuaValue GeneratedLuaCode558()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_west_vd_examined"));
        }
        public static LuaValue GeneratedLuaCode559()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_statue_room_state")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_statue_room_success_state")));
        }
        public static LuaValue GeneratedLuaCode560()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_statue_room_state")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_statue_room_success_state")));
        }
        public static LuaValue GeneratedLuaCode561()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Acquired"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode562()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode563()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_hat_state")), new LuaString("Stolen"));
        }
        public static LuaValue GeneratedLuaCode564()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_explained_arms")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode565()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_explained_arms")));
        }
        public static LuaValue GeneratedLuaCode566()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(818), new LuaNumber(2));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(818), new LuaNumber(3));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(818), new LuaNumber(6));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode567()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_explained_arms"));
        }
        public static LuaValue GeneratedLuaCode568()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(3));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode569()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_pl_needs_help")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode570()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_pl_knows_mary"));
        }
        public static LuaValue GeneratedLuaCode571()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_pl_knows_mary")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode572()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_pl_needs_help"));
        }
        public static LuaValue GeneratedLuaCode573()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryAddItem"), new LuaString("Sign of Papa Legba"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode574()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("ReturnToBeach"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(2));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode575()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_was_resurrected")));
        }
        public static LuaValue GeneratedLuaCode576()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_was_resurrected"));
        }
        public static LuaValue GeneratedLuaCode577()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Sign of Baron Samedi"));;
        }
        public static LuaValue GeneratedLuaCode578()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_ending_woke_up")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode579()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_title_flaming")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode580()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("Tutorial"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode581()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Knock on Office Door"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode582()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_donned_coat")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(2));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode583()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_met_mary")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode584()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Pendant"))), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_told_story")));
        }
        public static LuaValue GeneratedLuaCode585()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_is_dreaming")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode586()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_refused_case_mary")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode587()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_told_story")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("SetDialogueMemory"), new LuaNumber(110), new LuaNumber(112));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode588()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_told_story")));
        }
        public static LuaValue GeneratedLuaCode589()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("FindPendantOwner"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode590()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("ChangeActorName"), new LuaString("Mary Fontule"), new LuaString("New Client"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode591()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_is_dreaming")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode592()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_mary_told_story"));
        }
        public static LuaValue GeneratedLuaCode593()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Pendant")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_met_mary")));
        }
        public static LuaValue GeneratedLuaCode594()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_radio_broken")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode595()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_radio_broken")));
        }
        public static LuaValue GeneratedLuaCode596()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_radio_broken"));
        }
        public static LuaValue GeneratedLuaCode597()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Seltzer Bottle"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_title_flaming")), LuaBoolean.False);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_candle_extinguished")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AnswerTelephone"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode598()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_acquired_seltzer"));
        }
        public static LuaValue GeneratedLuaCode599()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_acquired_seltzer")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode600()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_acquired_seltzer")));
        }
        public static LuaValue GeneratedLuaCode601()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("EndGame"));
        }
        public static LuaValue GeneratedLuaCode602()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode603()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("VDWasBombed"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode604()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_hidden_button_location")), new LuaString("Baron Samedi"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode605()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_hidden_button_location")), new LuaString("Baron Samedi Selected"));
        }
        public static LuaValue GeneratedLuaCode606()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_met_mary")));
        }
        public static LuaValue GeneratedLuaCode607()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_met_mary"));
        }
        public static LuaValue GeneratedLuaCode608()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_hidden_button_location")), new LuaString("Papa Legba"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode609()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_hidden_button_location")), new LuaString("Papa Legba Selected"));
        }
        public static LuaValue GeneratedLuaCode610()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_fire_started")));
        }
        public static LuaValue GeneratedLuaCode611()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_fire_started"));
        }
        public static LuaValue GeneratedLuaCode612()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_start_used_skull")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode613()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_start_used_skull")));
        }
        public static LuaValue GeneratedLuaCode614()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_message_played")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode615()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_ending_used_skull")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode616()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_ending_used_skull"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("EndGame")));
        }
        public static LuaValue GeneratedLuaCode617()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode618()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("EndGame")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_ending_used_skull")));
        }
        public static LuaValue GeneratedLuaCode619()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_start_used_skull"));
        }
        public static LuaValue GeneratedLuaCode620()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("AnswerTelephone"));
        }
        public static LuaValue GeneratedLuaCode621()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("Opening"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode622()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsPlayerTurn"));
        }
        public static LuaValue GeneratedLuaCode623()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("IsPlayerTurn")));
        }
        public static LuaValue GeneratedLuaCode624()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("AreCombatantsAlive")));
        }
        public static LuaValue GeneratedLuaCode625()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("TryResetStatus"));LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("GetDialogueType")));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode626()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("AreCombatantsAlive"));
        }
        public static LuaValue GeneratedLuaCode627()
        {
            return LuaTranslatorOps.LTE(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorHealth")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode628()
        {
            return LuaTranslatorOps.LTE(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VoodooHealth")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode629()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Voodoo Taunt"), new LuaNumber(5)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode630()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), new LuaString("Voodoo Taunt"));
        }
        public static LuaValue GeneratedLuaCode631()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Victor Confused"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode632()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), new LuaString("Victor Confused"));
        }
        public static LuaValue GeneratedLuaCode633()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Voodoo Blocking"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode634()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), new LuaString("Voodoo Blocking"));
        }
        public static LuaValue GeneratedLuaCode635()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Victor Blocking"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode636()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), new LuaString("Victor Blocking"));
        }
        public static LuaValue GeneratedLuaCode637()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Victor Taunt"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode638()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("dialogue_type"), new LuaString("Victor Taunt"));
        }
        public static LuaValue GeneratedLuaCode639()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("x"), new LuaNumber(7));
        }
        public static LuaValue GeneratedLuaCode640()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("EndGame"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Baron Samedi Essence"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Halligan"));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Govi"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode641()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("victor_move"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("PickVictorMove")));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode642()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Soul Food Salve"));
        }
        public static LuaValue GeneratedLuaCode643()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Hostile Takeover"));
        }
        public static LuaValue GeneratedLuaCode644()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Victor Compliment"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode645()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Backhanded Compliment"));
        }
        public static LuaValue GeneratedLuaCode646()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Field of Honor"));
        }
        public static LuaValue GeneratedLuaCode647()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Gentleman's Cower"));
        }
        public static LuaValue GeneratedLuaCode648()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.EnvironmentLookup("victor_move"), new LuaString("Reload"));
        }
        public static LuaValue GeneratedLuaCode649()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorBecameConfused"));
        }
        public static LuaValue GeneratedLuaCode650()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Battle Voodoo Attack Ineffective"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode651()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorBecameConfused")));
        }
        public static LuaValue GeneratedLuaCode652()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("DidVictorsWeaknessChange"));
        }
        public static LuaValue GeneratedLuaCode653()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("DidVictorsWeaknessChange")));
        }
        public static LuaValue GeneratedLuaCode654()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("z"), new LuaNumber(0));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode655()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessAtIndex"), LuaTranslatorOps.EnvironmentLookup("z")), new LuaString("Apple of my Eye"));
        }
        public static LuaValue GeneratedLuaCode656()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessAtIndex"), LuaTranslatorOps.EnvironmentLookup("z")), new LuaString("Grammy's Flamin' Hot Sauce"));
        }
        public static LuaValue GeneratedLuaCode657()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessAtIndex"), LuaTranslatorOps.EnvironmentLookup("z")), new LuaString("Nine Tenths of the Lwa"));
        }
        public static LuaValue GeneratedLuaCode658()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessAtIndex"), LuaTranslatorOps.EnvironmentLookup("z")), new LuaString("Urn a Soul"));
        }
        public static LuaValue GeneratedLuaCode659()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessAtIndex"), LuaTranslatorOps.EnvironmentLookup("z")), new LuaString("Private Dick Kick"));
        }
        public static LuaValue GeneratedLuaCode660()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("z"), LuaTranslatorOps.Addition(LuaTranslatorOps.EnvironmentLookup("z"), new LuaNumber(1)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode661()
        {
            return LuaTranslatorOps.LT(LuaTranslatorOps.EnvironmentLookup("z"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessCount")));
        }
        public static LuaValue GeneratedLuaCode662()
        {
            return LuaTranslatorOps.GTE(LuaTranslatorOps.EnvironmentLookup("z"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("VictorWeaknessCount")));
        }
        public static LuaValue GeneratedLuaCode663()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("uw_battle_started")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode664()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup")));
        }
        public static LuaValue GeneratedLuaCode665()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup"));
        }
        public static LuaValue GeneratedLuaCode666()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_drank_stimulant"));
        }
        public static LuaValue GeneratedLuaCode667()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_drank_stimulant")));
        }
        public static LuaValue GeneratedLuaCode668()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup (Spiked)")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup (Full)")));
        }
        public static LuaValue GeneratedLuaCode669()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup (Spiked)")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Coffee Cup (Full)")))));
        }
        public static LuaValue GeneratedLuaCode670()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_have_washcloth")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode671()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_have_washcloth")));
        }
        public static LuaValue GeneratedLuaCode672()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_have_washcloth"));
        }
        public static LuaValue GeneratedLuaCode673()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_used_govi")), LuaBoolean.True);LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("OpenTheSafe"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode674()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_sabotaged")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode675()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_victor_entered_room")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode676()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_room_manhole_open")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode677()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_room_manhole_open")));
        }
        public static LuaValue GeneratedLuaCode678()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_room_manhole_open"));
        }
        public static LuaValue GeneratedLuaCode679()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_sabotaged")));
        }
        public static LuaValue GeneratedLuaCode680()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(11));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(12));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(26));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode681()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(11));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode682()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(14));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(27));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(32));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(26));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode683()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_crane_holding_barrel")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode684()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_crane_holding_barrel")));
        }
        public static LuaValue GeneratedLuaCode685()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_crane_holding_barrel")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode686()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_crane_holding_barrel"));
        }
        public static LuaValue GeneratedLuaCode687()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_exhaust_sabotaged"));
        }
        public static LuaValue GeneratedLuaCode688()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(11));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(18));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(30));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode689()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(34));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(15));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(597), new LuaNumber(26));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode690()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_victor_entered_room")));
        }
        public static LuaValue GeneratedLuaCode691()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_victor_entered_room"));
        }
        public static LuaValue GeneratedLuaCode692()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_fell_from_window")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode693()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_barrel_room_manhole_open")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode694()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_barrel_room_manhole_open")));
        }
        public static LuaValue GeneratedLuaCode695()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_barrel_room_manhole_open"));
        }
        public static LuaValue GeneratedLuaCode696()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Victor's Machine Broken"), new LuaNumber(4)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode697()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_power_redistributed")));
        }
        public static LuaValue GeneratedLuaCode698()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_machine_destroyed")));
        }
        public static LuaValue GeneratedLuaCode699()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_machine_destroyed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode700()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_power_redistributed"));
        }
        public static LuaValue GeneratedLuaCode701()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_machine_destroyed"));
        }
        public static LuaValue GeneratedLuaCode702()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_halligan_acquired")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode703()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_halligan_acquired")));
        }
        public static LuaValue GeneratedLuaCode704()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_halligan_acquired"));
        }
        public static LuaValue GeneratedLuaCode705()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_power_redistributed")), (LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")))));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode706()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_power_redistributed")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode707()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode708()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up"))), LuaTranslatorOps.GT(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("FactoryReservePower")), new LuaNumber(0)));
        }
        public static LuaValue GeneratedLuaCode709()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up")), LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("FactoryReservePower")), new LuaNumber(0)));
        }
        public static LuaValue GeneratedLuaCode710()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode711()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up"));
        }
        public static LuaValue GeneratedLuaCode712()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_juicer_powered_up")));
        }
        public static LuaValue GeneratedLuaCode713()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode714()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up"))), LuaTranslatorOps.GT(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("FactoryReservePower")), new LuaNumber(0)));
        }
        public static LuaValue GeneratedLuaCode715()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")), LuaTranslatorOps.Equality(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("FactoryReservePower")), new LuaNumber(0)));
        }
        public static LuaValue GeneratedLuaCode716()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode717()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up"));
        }
        public static LuaValue GeneratedLuaCode718()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")));
        }
        public static LuaValue GeneratedLuaCode719()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up")));
        }
        public static LuaValue GeneratedLuaCode720()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_beacon_powered_up"));
        }
        public static LuaValue GeneratedLuaCode721()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(851), new LuaNumber(2));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode722()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(851), new LuaNumber(3));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode723()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Victor Enters Room"), new LuaNumber(5)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode724()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Victor Loads Gun"), new LuaNumber(6)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode725()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Victor Approaching"), new LuaNumber(6)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode726()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_cowering")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode727()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Diamond"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_window_cut")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode728()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_cowering")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode729()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_fire_started")), LuaBoolean.True);LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Molotov Cocktail (Lit)"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode730()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_painting_moved")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode731()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_painting_moved")));
        }
        public static LuaValue GeneratedLuaCode732()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_painting_moved"));
        }
        public static LuaValue GeneratedLuaCode733()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_battery")));
        }
        public static LuaValue GeneratedLuaCode734()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_battery"));
        }
        public static LuaValue GeneratedLuaCode735()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_battery")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode736()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_safe_open")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode737()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Diamond"));
        }
        public static LuaValue GeneratedLuaCode738()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Diamond")));
        }
        public static LuaValue GeneratedLuaCode739()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_cowering")));
        }
        public static LuaValue GeneratedLuaCode740()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_cowering"));
        }
        public static LuaValue GeneratedLuaCode741()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_gum_wrapper")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode742()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_gum_wrapper"));
        }
        public static LuaValue GeneratedLuaCode743()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_acquired_gum_wrapper")));
        }
        public static LuaValue GeneratedLuaCode744()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_window_cut")));
        }
        public static LuaValue GeneratedLuaCode745()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_fire_started"));
        }
        public static LuaValue GeneratedLuaCode746()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_window_cut"));
        }
        public static LuaValue GeneratedLuaCode747()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_3_quest_stage")), new LuaString("SaveBaronSamedi"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode748()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_smelled_forest")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode749()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_visited_island")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode750()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_visited_island")));
        }
        public static LuaValue GeneratedLuaCode751()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_govi_active")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode752()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Govi"));
        }
        public static LuaValue GeneratedLuaCode753()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_hannah_state")), new LuaString("Distracted"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode754()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_engine_room_state")), new LuaString("Jammed"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_hannah_state")), new LuaString("Subdued"));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode755()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_hannah_state")), new LuaString("Distracted"));
        }
        public static LuaValue GeneratedLuaCode756()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_hannah_state")), new LuaString("Distracted"));
        }
        public static LuaValue GeneratedLuaCode757()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_firebox_open")));
        }
        public static LuaValue GeneratedLuaCode758()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_firebox_open"));
        }
        public static LuaValue GeneratedLuaCode759()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_firebox_open")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode760()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_firebox_open")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode761()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_pat_down_complete")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode762()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Golden Toilet Handle")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle")))));
        }
        public static LuaValue GeneratedLuaCode763()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_stall_closed")));
        }
        public static LuaValue GeneratedLuaCode764()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_stall_closed"));
        }
        public static LuaValue GeneratedLuaCode765()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Golden Toilet Handle")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_swallowed_toilet_handle")));
        }
        public static LuaValue GeneratedLuaCode766()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_stall_entered"));
        }
        public static LuaValue GeneratedLuaCode767()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Yacht Plead with Billy"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode768()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_mary_is_dead")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode769()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_ritual_over")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode770()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Gunshot Whoa"), new LuaNumber(3)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode771()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("DrainTheLake"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(3));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode772()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("PowerTheCrane"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode773()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("FollowBadGuys"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode774()
        {
            return LuaTranslatorOps.Negate((LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed")))));
        }
        public static LuaValue GeneratedLuaCode775()
        {
            return LuaTranslatorOps.LT(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode776()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), LuaTranslatorOps.Subtraction(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(1)));LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("UnsetDialogueMemory"), new LuaNumber(270), new LuaNumber(3));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode777()
        {
            return LuaTranslatorOps.GTE(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_drink_count")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode778()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_syrup")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode779()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_acquired_syrup")));
        }
        public static LuaValue GeneratedLuaCode780()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_mentioned_kenneth")), LuaBoolean.True);return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode781()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_mentioned_kenneth"));
        }
        public static LuaValue GeneratedLuaCode782()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed")), LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed")));
        }
        public static LuaValue GeneratedLuaCode783()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("should_return_to_barb_convo"), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode784()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed"))), (LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Apple of my Eye (Left)")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Apple of my Eye (Right)")))));
        }
        public static LuaValue GeneratedLuaCode785()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("should_return_to_kenneth_convo"), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode786()
        {
            return LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Pencil and Paper"));;
        }
        public static LuaValue GeneratedLuaCode787()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed"))), (LuaTranslatorOps.Or(LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Apple of my Eye (Left)")), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryContains"), new LuaString("Apple of my Eye (Right)")))));
        }
        public static LuaValue GeneratedLuaCode788()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("should_return_to_barb_convo"), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode789()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode790()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed"));
        }
        public static LuaValue GeneratedLuaCode791()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed"));
        }
        public static LuaValue GeneratedLuaCode792()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_barb_hexed")));
        }
        public static LuaValue GeneratedLuaCode793()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed")));
        }
        public static LuaValue GeneratedLuaCode794()
        {
            return LuaTranslatorOps.EnvironmentLookup("should_return_to_barb_convo");
        }
        public static LuaValue GeneratedLuaCode795()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.EnvironmentLookup("should_return_to_barb_convo"));
        }
        public static LuaValue GeneratedLuaCode796()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_kenneth_hexed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode797()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("should_return_to_kenneth_convo"), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode798()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.EnvironmentLookup("should_return_to_kenneth_convo"));
        }
        public static LuaValue GeneratedLuaCode799()
        {
            return LuaTranslatorOps.EnvironmentLookup("should_return_to_kenneth_convo");
        }
        public static LuaValue GeneratedLuaCode800()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.EnvironmentLookup("x"), LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("RandomChoice"), new LuaString("Examine Party Guests"), new LuaNumber(2)));;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode801()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_acquired")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode802()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_acquired")));
        }
        public static LuaValue GeneratedLuaCode803()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_apple_acquired"));
        }
        public static LuaValue GeneratedLuaCode804()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_hannah_state")), new LuaString("Alert"));LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_firebox_open")), LuaBoolean.False);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode805()
        {
            LuaTranslatorOps.Invoke(LuaTranslatorOps.EnvironmentLookup("InventoryRemoveItem"), new LuaString("Golden Toilet Handle"));return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode806()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_fusebox_fixed")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode807()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_fusebox")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode808()
        {
            LuaTranslatorOps.Assignment(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("yacht_examined_lifeboat")), LuaBoolean.True);;return LuaNil.Nil;
        }
        public static LuaValue GeneratedLuaCode809()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(0));
        }
        public static LuaValue GeneratedLuaCode810()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode811()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode812()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_vd_outfit")), new LuaNumber(3));
        }
        public static LuaValue GeneratedLuaCode813()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(2));
        }
        public static LuaValue GeneratedLuaCode814()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("office_donned_coat")));
        }
        public static LuaValue GeneratedLuaCode815()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1)), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("BombDeployed")));
        }
        public static LuaValue GeneratedLuaCode816()
        {
            return LuaBoolean.False;
        }
        public static LuaValue GeneratedLuaCode817()
        {
            return LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("NewGame"));
        }
        public static LuaValue GeneratedLuaCode818()
        {
            return LuaTranslatorOps.Subtraction(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1));
        }
        public static LuaValue GeneratedLuaCode819()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1)), LuaTranslatorOps.Inequality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_1_quest_stage")), new LuaString("VDWasBombed")));
        }
        public static LuaValue GeneratedLuaCode820()
        {
            return LuaTranslatorOps.Or(LuaTranslatorOps.Or(LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Hurt")), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Slapped"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("dhb_trance_stage")), new LuaString("Awake")));
        }
        public static LuaValue GeneratedLuaCode821()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_is_stake_out"));
        }
        public static LuaValue GeneratedLuaCode822()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_is_stake_out")));
        }
        public static LuaValue GeneratedLuaCode823()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("ll_cabinet_open"));
        }
        public static LuaValue GeneratedLuaCode824()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_govi_complete")));
        }
        public static LuaValue GeneratedLuaCode825()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("cemetery_lemoon_unlocked"));
        }
        public static LuaValue GeneratedLuaCode826()
        {
            return LuaTranslatorOps.And(LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_kiki_left_restaurant"))), LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_current_act")), new LuaNumber(1)));
        }
        public static LuaValue GeneratedLuaCode827()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("chic_elevator_unlocked")));
        }
        public static LuaValue GeneratedLuaCode828()
        {
            return LuaTranslatorOps.Equality(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("global_act_2_quest_stage")), new LuaString("Slideshow"));
        }
        public static LuaValue GeneratedLuaCode829()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("if_acquired_feather")));
        }
        public static LuaValue GeneratedLuaCode830()
        {
            return LuaTranslatorOps.Negate(LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_have_visited")));
        }
        public static LuaValue GeneratedLuaCode831()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("pl_have_visited"));
        }
        public static LuaValue GeneratedLuaCode832()
        {
            return LuaTranslatorOps.Lookup(LuaTranslatorOps.EnvironmentLookup("Variable"), new LuaString("factory_used_govi"));
        }
    }
}
