using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            var value = x.GetSquare();

            string value2 = "Devnot CSharp Bootcamp";
            Console.WriteLine(value2.RemoveAllSpaces());

            Console.ReadLine();
        }
    }
}
