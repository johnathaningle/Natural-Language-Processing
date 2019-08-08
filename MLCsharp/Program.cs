using System;
using System.Collections.Generic;
using System.IO;
using static MLCsharp.Data.DataImportService;
using Deedle;
using MLCsharp.Python.Installer;
using System.Threading.Tasks;
using Keras.Models;
using Python;

namespace MLCsharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var root = Directory.GetCurrentDirectory().Replace("\\MLCsharp", "").Replace("bin\\Debug\\netcoreapp2.2", "");
            var char2idx = getCharToIdx(root);
            var vocab = getVocab(root);
            
        }
        private async void runKeras(string rootDir)
        {
            var installer = new Installer();
            await installer.SetupPython(true);
            var model = Sequential.ModelFromJson(File.ReadAllText(Path.Combine(rootDir, "MLPython\\model.json")));
            model.LoadWeight(Path.Combine(rootDir, "MLPython\\model.h5"));
        }
    }
}
