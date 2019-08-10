using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;
using MLCsharp.Common;
using System.IO;

namespace MLCsharp.Algorithims
{
    public class BiDafService
    {
        public BiDafService(string seed, string question)
        {
            this.Seed = seed;
            this.Question = question;
        }
        public string Seed { get; set; }
        public string Question { get; set; }
        public void Execute()
        {
            var pthsvc = new PathService();
            var txtsvc = new TextService();

            //format the data
            var seedWords = txtsvc.tokenize(this.Seed);
            var qWords = txtsvc.tokenize(this.Question);
            var seedChars = txtsvc.charSequence(this.Seed, 16);
            var qChars = txtsvc.charSequence(this.Question, 16);
            
            //list the model for debugging.
            Console.WriteLine("Using machine learning model:");
            pthsvc.listFilesInDirectory(pthsvc.getMlModelsPath(), SearchOption.TopDirectoryOnly, "bidaf.onnx");


        }
    }
}
