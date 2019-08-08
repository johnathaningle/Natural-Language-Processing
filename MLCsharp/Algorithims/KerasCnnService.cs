using Keras.Models;
using MLCsharp.Python.Installer;
using MLCsharp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLCsharp.Algorithims
{
    public class KerasCnnService
    {
        public async void Execute(string rootDir)
        {
            var char2idx = DataImportService.getCharToIdx(rootDir);
            var vocab = DataImportService.getVocab(rootDir);
            var installer = new Installer();
            await installer.SetupPython(true);
            var model = Sequential.ModelFromJson(File.ReadAllText(Path.Combine(rootDir, "MLPython\\model.json")));
            model.LoadWeight(Path.Combine(rootDir, "MLPython\\model.h5"));
        }
    }
}
