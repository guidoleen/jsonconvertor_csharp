using System;
using System.Collections.Generic;
using System.Text;

namespace JsonObjectConvertor
{
    class RemoveCharFromString
    {
        public String getRemoveCharFromString(Char[] chars, char removal)
        {
            String output = "";
            Char flagVar;
            for(int i = 0; i<chars.Length; i++)
            {
                flagVar = chars[i];
                if (flagVar.Equals(removal))
                    flagVar = ' ';

                output += flagVar.ToString();
            }
            return output;
        }
    }
}
