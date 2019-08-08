using Deedle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLCsharp.Data
{
    public class DataImportService
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
            var retval = new List<string>();
            var path = Path.Combine(baseDir, "MLPython\\vocab.csv");
            var vocab = Frame.ReadCsv(path, hasHeaders: false);
            foreach (var val in vocab.Rows.Values)
            {
                retval.Add((string)val.GetAt(1));
            }
            return retval;
        }
    }
}
