using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MLCsharp.Common
{
    public class TextService
    {
        public List<string> tokenize(string text)
        {
            text = Regex.Replace(text, @"[^\w\s]", "");
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
        public List<char[]> charSequence(string text, int sequencelen)
        {
            var retal = new List<char[]>();
            int index = 0;
            int leftover = text.Length % sequencelen;
            for(int i = 0; i < (sequencelen - leftover); i++)
            {
                text = text + " ";
            }
            for(int i = 0; i < text.Length; i+=sequencelen)
            {
                var sub = text.Substring(i, sequencelen);
                var seq = sub.ToCharArray();
                retal.Add(seq);
            }
            return retal;
        }
    }
}
