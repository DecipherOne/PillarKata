using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalc
{
    class Program
    {
      
        static void Main(string[] args)
        {
            PrintHeader();

            PrintFooter();
        }

       static void PrintHeader()
        {
            string head = "($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$)";
            head += "\n \t          Baby Sitter Calculator";
            head += "\n($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$) \n";
            head += "\n  Please enter in the requested information below to \n" +
                      "  calculate your earned wages for the evening. \n\n";
            Console.Write(head);
        }

       static void PrintFooter()
        {
            string head = "($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$)";
            head += "\n          By Baby Co, where your baby is our business.";
            head += "\n($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$) \n";
            Console.Write(head);
            Console.ReadKey();
        }
    }
}
