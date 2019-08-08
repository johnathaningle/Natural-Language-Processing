using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLCsharp.Common
{
    public class PathService
    {
        public static string GetRootPath()
        {
            return Directory.GetCurrentDirectory().Replace("\\MLCsharp", "").Replace("bin\\Debug\\netcoreapp2.2", "");
        }
    }
}
