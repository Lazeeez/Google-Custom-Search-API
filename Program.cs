using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1.Data;

namespace TestGoogleSearch
{
class Program
{
    static void Main(string[] args)
    {
       
        string query = "https://en.wikipedia.org/wiki/Dior";

        var results = GoogleSearch.Search(query);
            foreach (Result result in results)
        {
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(result.Snippet);
            }
        Console.ReadKey();
    }
}
}
