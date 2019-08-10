
using Microsoft.ML;
using MLCsharp.Algorithims;
using System.Threading.Tasks;

namespace MLCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dafService = new BiDafService("The brown fox jumped over the fence.", "What color is the fox?");
            dafService.Execute();
        }
       
    }
}
