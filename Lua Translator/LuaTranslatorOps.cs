using System;
using Language.Lua;
using PixelCrushers.DialogueSystem;

namespace LuaTranslator
{
    public class LuaTranslatorOps
    {
        public static LuaValue EnvironmentLookup(string key)
        {
            return new LuaVariable(Lua.Environment, new LuaString(key));
        }

        public static LuaValue Lookup(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaTable))
            {
                return new LuaVariable((LuaTable)left, right);
            }
            else throw new System.Exception($"{typeInfo} does not support table lookups");
        }


        public static LuaValue Invoke(LuaValue left, params LuaValue[] args)
        {
            left = Dereference(left);
            for (int i = 0; i < args.Length; i++) args[i] = Dereference(args[i]);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaMethodFunction))
            {
                return ((LuaMethodFunction)left).InvokeMethod(args);
            }
            else throw new System.Exception($"{typeInfo} does not support division");
        }

        public static LuaValue Assignment(LuaValue left, LuaValue right)
        {
            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaVariable))
            {
                ((LuaVariable)left).Assign(right);
            }
            else throw new System.Exception($"{typeInfo} does not support assignment");
            return LuaNil.Nil;
        }

        public static LuaValue Negate(LuaValue left)
        {
            left = Dereference(left);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaBoolean))
            {
                return !((LuaBoolean)left).BoolValue
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support negation");
        }

        public static LuaValue Negative(LuaValue left)
        {
            left = Dereference(left);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return new LuaNumber(-((LuaNumber)left).Number);
            }
            else throw new System.Exception($"{typeInfo} does not support negative");
        }

        public static LuaValue And(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaBoolean))
            {
                return ((LuaBoolean)left).BoolValue && ((LuaBoolean)right).BoolValue
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support and");
        }

        public static LuaValue Or(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaBoolean))
            {
                return ((LuaBoolean)left).BoolValue || ((LuaBoolean)right).BoolValue
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support or");
        }

        public static LuaValue Equality(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaBoolean))
            {
                return ((LuaBoolean)left).BoolValue == ((LuaBoolean)right).BoolValue
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else if (typeInfo == typeof(LuaString))
            {
                return ((LuaString)left).Text == ((LuaString)right).Text
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number == ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support equality");
        }

        public static LuaValue Inequality(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaBoolean))
            {
                return ((LuaBoolean)left).BoolValue != ((LuaBoolean)right).BoolValue
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else if (typeInfo == typeof(LuaString))
            {
                return ((LuaString)left).Text != ((LuaString)right).Text
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number != ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support inequality");
        }

        public static LuaValue GTE(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number >= ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support GTE");
        }

        public static LuaValue LTE(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number <= ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support LTE");
        }

        public static LuaValue GT(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number > ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support GT");
        }

        public static LuaValue LT(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return ((LuaNumber)left).Number < ((LuaNumber)right).Number
                    ? LuaBoolean.True
                    : LuaBoolean.False;
            }
            else throw new System.Exception($"{typeInfo} does not support LT");
        }

        public static LuaValue Addition(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return new LuaNumber(((LuaNumber)left).Number + ((LuaNumber)right).Number);
            }
            else throw new System.Exception($"{typeInfo} does not support addition");
        }

        public static LuaValue Subtraction(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return new LuaNumber(((LuaNumber)left).Number - ((LuaNumber)right).Number);
            }
            else throw new System.Exception($"{typeInfo} does not support subtraction");
        }

        public static LuaValue Multiplication(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return new LuaNumber(((LuaNumber)left).Number * ((LuaNumber)right).Number);
            }
            else throw new System.Exception($"{typeInfo} does not support multiplication");
        }

        public static LuaValue Division(LuaValue left, LuaValue right)
        {
            left = Dereference(left);
            right = Dereference(right);

            Type typeInfo = left.GetType();
            if (typeInfo == typeof(LuaNumber))
            {
                return new LuaNumber(((LuaNumber)left).Number / ((LuaNumber)right).Number);
            }
            else throw new System.Exception($"{typeInfo} does not support division");
        }

        private static LuaValue Dereference(LuaValue val) => (val.GetType() == typeof(LuaVariable)) ? ((LuaVariable)val).Dereference() : val;
    }
}
