using System;

namespace Language.Lua
{
    /// <summary>
    /// An intermediate value only used in LuaTranslator to remember how to assign
    /// to a variable.
    /// </summary>
    public class LuaVariable : LuaValue
    {
        private LuaValue key;
        private LuaTable table;

        public LuaVariable(LuaTable table, LuaValue key)
        {
            this.key = key;
            this.table = table;
        }

        public void Assign(LuaValue val)
        {
            Type thatType = val.GetType();

            // Variable = Variable
            if (thatType == typeof(LuaVariable))
            {
                Assign(((LuaVariable)val).Dereference());
                return;
            }

            // Variable = Value
            LuaValue thisValue = Dereference();
            if (thisValue == LuaNil.Nil)
            // New Value
            {
                table.SetKeyValue(key, val);
            }
            // Overwrite
            else
            {
                // Ensure Types Match
                Type thisType = thisValue.GetType();
                if (thisType != thatType) throw new Exception($"Can't assign {thatType} to {thisType}");

                // Assign
                table.SetKeyValue(key, val);
            }
        }

        public override object Value { get => table.GetValue(key).Value; }
        public override string GetTypeCode() => "variable";

        public LuaValue Dereference()
        {
            return table.GetValue(key);
        }
    }
}
