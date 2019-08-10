using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLCsharp.Common
{
    public class PathService
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory().Replace("\\MLCsharp", "").Replace("bin\\Debug\\netcoreapp2.2", "");
        }
        public string GetProjectPath()
        {
            return GetRootPath() + "MLCsharp\\";
        }
        public string getMlModelsPath()
        {
            return GetProjectPath() + "MLModels\\";
        }
        public void listFilesInDirectory(string path, SearchOption searchOption, string filetype)
        {
            var files = Directory.GetFiles(path, filetype, searchOption);
            foreach(var f in files)
            {
                Console.WriteLine(f);
            };
        }
        public string getFullFilePath(string path, SearchOption searchOption, string filename)
        {
            var files = Directory.GetFiles(path, filename, searchOption);
            foreach (string f in files)
            {
                var name = f.Replace(path, "");
                if (name.Equals(filename))
                    return f;
            };
            return "";
        }
        
    }
}
