using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLCsharp.Models
{
    class QuestionTextData
    {
        [LoadColumn(0)]
        public string Seed { get; set; }
        [LoadColumn(1)]
        public String Question { get; set; }
    }
}
