using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*@ is called verbatim Literal we use it to translate skip sequnce as normal printable charcters*/
namespace String_Tips
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotes = "str1";
            string NewlineWithskipSeq = "before\nAfter";
            string toPrintSlah = "\\one Slah";
            string toIgnoreSkipSeq = @"\\two slash ..skip seq is ignored";
            Console.WriteLine(quotes);
            Console.WriteLine();
            Console.WriteLine(NewlineWithskipSeq);
            Console.WriteLine();
            Console.WriteLine(toPrintSlah);
            Console.WriteLine();
            Console.WriteLine(toIgnoreSkipSeq);

        }
    }
}
