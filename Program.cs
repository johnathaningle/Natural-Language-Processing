using Microsoft.ML;
using Microsoft.ML.Data;
using System;

namespace Natural_Language_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            var mlContext = new MLContext();
            char[] data = "China decided to raise".ToCharArray();
            var dataView = mlContext.Data.LoadFromEnumerable(data)
        }
    }
    public class ContentSeed
    {
        public string SeedText { get; set; }
        [VectorType]
        public int[] VariableLengthFeatures { get; set; }
    }
}
