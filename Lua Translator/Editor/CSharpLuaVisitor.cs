using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace LuaTranslator
{
    public partial class CSharpLuaVisitor : LuaBaseVisitor<string>
    {

        public override string VisitChunk([NotNull] LuaParser.ChunkContext context)
        {
            string result = Visit(context.children[0]);
            return result;
        }

        public override string VisitBlock([NotNull] LuaParser.BlockContext context)
        {
            string result = "";
            for (int i = 0; i < context.ChildCount; i++)
            {
                result += Visit(context.children[i]);
            }
            return result;
        }

        //    : 'return' explist? ';'?
        public override string VisitRetstat([NotNull] LuaParser.RetstatContext context)
        {
            string result = "return ";
            for (int i = 1; i < context.ChildCount; i++)
            {
                result += Visit(context.children[i]);
            }
            return result;
        }

        // Supported
        // : ';'
        // | varlist '=' explist
        // | functioncall
        // Unsupported
        // | label
        // | 'break'
        // | 'goto' NAME
        // | 'do' block 'end'
        // | 'while' exp 'do' block 'end'
        // | 'repeat' block 'until' exp
        // | 'if' exp 'then' block ('elseif' exp 'then' block)* ('else' block)? 'end'
        // | 'for' NAME '=' exp ',' exp (',' exp)? 'do' block 'end'
        // | 'for' namelist 'in' explist 'do' block 'end'
        // | 'function' funcname funcbody
        // | 'local' 'function' NAME funcbody
        // | 'local' attnamelist ('=' explist)?
        public override string VisitStat([NotNull] LuaParser.StatContext context)
        {
            string result = null;
            if (context.functioncall() != null)
            {
                // Function Call
                result = Visit(context.functioncall());
            }
            else if (context.varlist() != null)
            {
                // Assignment
                string left = Visit(context.children[0]);
                string right = Visit(context.children[2]);
                result = $"LuaTranslatorOps.Assignment({left}, {right})";
            }
            else if (context.ChildCount == 1)
            {
                // Semicolon
                if (Visit(context.children[0]) == ";") result = ";";
            }
            if (result == null)
            {
                throw new System.Exception($"Unsupported statement type: {context.ToString()}");
            }
            return result;
        }

        // Supported
        // | boolean
        // | number
        // | string
        // | prefixexp
        // | operatorUnary exp
        // | exp operatorMulDivMod exp
        // | exp operatorAddSub exp
        // | exp operatorComparison exp
        // | exp operatorAnd exp
        // | exp operatorOr exp
        // Unsupported
        // | <assoc=right> exp operatorPower exp
        // | <assoc=right> exp operatorStrcat exp
        // | exp operatorBitwise exp
        // | '...'
        // | nil
        // | functiondef
        // | tableconstructor
        public override string VisitExp([NotNull] LuaParser.ExpContext context)
        {
            if (context.boolean() != null)
            {
                return Visit(context.boolean());
            }
            else if (context.number() != null)
            {
                return Visit(context.number());
            }
            else if (context.@string() != null)
            {
                return Visit(context.@string());
            }
            else if (context.prefixexp() != null)
            {
                return Visit(context.prefixexp());
            }
            else if (context.operatorUnary() != null)
            {
                //    : 'not' | '#' | '-' | '~';
                string unary = Visit(context.children[0]);
                string exp = Visit(context.children[1]);
                switch (unary)
                {
                    case "not":
                        return $"LuaTranslatorOps.Negate({exp})";
                    case "-":
                        return $"LuaTranslatorOps.Negative({exp})";
                    default:
                        throw new System.Exception($"Unsupported unary: {unary}");
                }
            }
            else if (context.operatorMulDivMod() != null)
            {
                //	: '*' | '/' | '%' | '//';
                string expLeft = Visit(context.children[0]);
                string op = Visit(context.children[1]);
                string expRight = Visit(context.children[2]);
                switch (op)
                {
                    case "*":
                        return $"LuaTranslatorOps.Multiplication({expLeft}, {expRight})";
                    case "/":
                        return $"LuaTranslatorOps.Division({expLeft}, {expRight})";
                    default:
                        throw new System.Exception($"Unsupported operator: {op}");
                }
            }
            else if (context.operatorAddSub() != null)
            {
                //	: '+' | '-';
                string expLeft = Visit(context.children[0]);
                string op = Visit(context.children[1]);
                string expRight = Visit(context.children[2]);
                switch (op)
                {
                    case "+":
                        return $"LuaTranslatorOps.Addition({expLeft}, {expRight})";
                    case "-":
                        return $"LuaTranslatorOps.Subtraction({expLeft}, {expRight})";
                    default:
                        throw new System.Exception($"Unsupported operator: {op}");
                }
            }
            else if (context.operatorComparison() != null)
            {
                //	: '<' | '>' | '<=' | '>=' | '~=' | '==';
                string expLeft = Visit(context.children[0]);
                string op = Visit(context.children[1]);
                string expRight = Visit(context.children[2]);
                switch (op)
                {
                    case "<":
                        return $"LuaTranslatorOps.LT({expLeft}, {expRight})";
                    case ">":
                        return $"LuaTranslatorOps.GT({expLeft}, {expRight})";
                    case "<=":
                        return $"LuaTranslatorOps.LTE({expLeft}, {expRight})";
                    case ">=":
                        return $"LuaTranslatorOps.GTE({expLeft}, {expRight})";
                    case "~=":
                        return $"LuaTranslatorOps.Inequality({expLeft}, {expRight})";
                    case "==":
                        return $"LuaTranslatorOps.Equality({expLeft}, {expRight})";
                    default:
                        throw new System.Exception($"Unsupported operator: {op}");
                }
            }
            else if (context.operatorAnd() != null)
            {
                // 	: 'and';
                string expLeft = Visit(context.children[0]);
                string expRight = Visit(context.children[2]);
                return $"LuaTranslatorOps.And({expLeft}, {expRight})";
            }
            else if (context.operatorOr() != null)
            {
                //	: 'or';
                string expLeft = Visit(context.children[0]);
                string expRight = Visit(context.children[2]);
                return $"LuaTranslatorOps.Or({expLeft}, {expRight})";
            }
            else
            {
                throw new System.Exception($"Unsupported expression type: {context.ToString()}");
            }
        }

        // varOrExp nameAndArgs*
        public override string VisitPrefixexp([NotNull] LuaParser.PrefixexpContext context)
        {
            string variableOrExpression = Visit(context.children[0]);
            if (context.ChildCount == 1)
            // Variable or Expression
            {
                return variableOrExpression;
            }
            else if (context.ChildCount == 2)
            // Invoke
            {
                string args = Visit(context.children[1]);
                if (string.IsNullOrEmpty(args))
                {
                    return $"LuaTranslatorOps.Invoke({variableOrExpression})";
                }
                return $"LuaTranslatorOps.Invoke({variableOrExpression}, {args})";
            }
            else throw new System.Exception("Nested function invocations not supported");
        }

        // varOrExp nameAndArgs+
        public override string VisitFunctioncall([NotNull] LuaParser.FunctioncallContext context)
        {
            if (context.ChildCount == 2)
            // Invoke
            {
                string functionName = Visit(context.children[0]);
                string args = Visit(context.children[1]);
                if (string.IsNullOrEmpty(args))
                {
                    return $"LuaTranslatorOps.Invoke({functionName})";
                }
                return $"LuaTranslatorOps.Invoke({functionName}, {args})";
            }
            else throw new System.Exception("Nested function invocations not supported");
        }

        //    : var_ | '(' exp ')'
        public override string VisitVarOrExp([NotNull] LuaParser.VarOrExpContext context)
        {
            if (context.var_() != null)
            {
                // Var_
                return Visit(context.children[0]);
            }
            else
            {
                // Parenthetical Expression
                string exp = Visit(context.children[1]);
                return $"({exp})";
            }
        }

        // '(' explist? ')' | tableconstructor | string
        public override string VisitArgs([NotNull] LuaParser.ArgsContext context)
        {
            string expList = "";
            if (context.ChildCount == 3)
            {
                expList = Visit(context.children[1]);
            }
            return expList;
        }

        // exp (',' exp)*
        public override string VisitExplist([NotNull] LuaParser.ExplistContext context)
        {
            string expList = "";
            for (int i = 0; i < context.ChildCount; i += 2)
            {
                if (i != 0) expList += ", ";
                expList += Visit(context.children[i]);
            }
            return expList;
        }

        //
        // Global Variable 
        // Table Lookups 
        // NOTE: I don't allow complicated lookups
        //
        public override string VisitVar_([NotNull] LuaParser.Var_Context context)
        {
            // Sanity
            if (context.children.Count > 2) throw new System.Exception("Nested lookups not supported");

            // Get Name
            string name = context.children[0].ToString();
            string envLookup = $"LuaTranslatorOps.EnvironmentLookup(\"{name}\")";

            if (context.children.Count == 2)
            // Table Lookup
            {
                string expressionResult = Visit(context.children[1]);
                return $"LuaTranslatorOps.Lookup({envLookup}, {expressionResult})";
            }
            else
            // Global Lookup
            {
                return envLookup;
            }
        }

        public override string VisitVarSuffix([NotNull] LuaParser.VarSuffixContext context)
        {
            string result = Visit(context.children[1]);
            return result;
        }

        public override string VisitNumber([NotNull] LuaParser.NumberContext context)
        {
            return $"new LuaNumber({context.children[0].ToString()})";
        }

        public override string VisitString([NotNull] LuaParser.StringContext context)
        {
            return $"new LuaString({context.children[0].ToString()})";
        }

        public override string VisitBoolean([NotNull] LuaParser.BooleanContext context)
        {
            if (context.children[0].ToString() == "true")
            {
                return "LuaBoolean.True";
            }
            else
            {
                return "LuaBoolean.False";
            }
        }

        public override string VisitNil([NotNull] LuaParser.NilContext context)
        {
            return "LuaNil.Nil";
        }

        public override string VisitTerminal(ITerminalNode node)
        {
            string terminalNode = node.GetText();
            return terminalNode;
        }
    }
}
