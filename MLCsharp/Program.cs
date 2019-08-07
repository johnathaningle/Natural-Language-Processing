using System;
using System.Collections.Generic;
using System.IO;
using Deedle;

namespace MLCsharp
{
    class Program
    {
        public static Dictionary<string, int> getCharToIdx(string baseDir)
        {
            var retval = new Dictionary<string, int>();
            string path = Path.Combine(baseDir, "MLPython\\char2idx.csv");
            Console.WriteLine(path);
            var char2idx = Frame.ReadCsv(path, hasHeaders: false);
            foreach (var val in char2idx.Rows.Values)
            {
                retval.Add((string)val.GetAt(0), (int)val.GetAt(1));
            }
            return retval;
        }
        public static List<string> getVocab(string baseDir)
        {
            return new List<string>();
        }
        static void Main(string[] args)
        {
            var root = Directory.GetCurrentDirectory().Replace("\\MLCsharp", "").Replace("bin\\Debug\\netcoreapp2.2", "");
            var char2idx = getCharToIdx(root);
        }
    }
}
