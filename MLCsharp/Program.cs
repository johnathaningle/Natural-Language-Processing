
using Microsoft.ML;
using MLCsharp.Algorithims;
using System.Threading.Tasks;

namespace MLCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dafService = new BiDafService();
            dafService.Execute();
        }
       
    }
}
