using System;
using System.Collections.Generic;
using System.Text;

namespace MLCsharp.Common
{
    class TextService
    {
        static List<string> tokenize(string text)
        {
            var split = text.Split(" ");
            var retval = new List<string>();
            retval.AddRange(split);
            for (int i = 0; i < retval.Count; i++)
            {
                var s = retval[i];
                //if the string is an empty space, remove it
                if(s.Equals(" "))
                {
                    retval.RemoveAt(i);
                }
                retval[i] = retval[i].ToLower();
            }
            return retval;
        }
    }
}
