using System;
using System.Collections.Generic;
using System.IO;
using static MLCsharp.Data.DataImportService;
using Deedle;
using MLCsharp.Python.Installer;
using System.Threading.Tasks;
using Keras.Models;

namespace MLCsharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var root = Directory.GetCurrentDirectory().Replace("\\MLCsharp", "").Replace("bin\\Debug\\netcoreapp2.2", "");
            var char2idx = getCharToIdx(root);
            var vocab = getVocab(root);
            var installer = new Installer(root);
            await installer.SetupPython(true);
            var model = Sequential.ModelFromJson(File.ReadAllText(Path.Combine(root, "MLPython\\model.json")));
            model.LoadWeight(Path.Combine(root, "MLPython\\model.h5"));
            
        }
    }
}
