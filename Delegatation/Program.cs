using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatation
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static void Main(string[] args)
        {
            //.NET 1.6
            var evenNumbers = Filter.FilterNumbers(numbers, getEvenNumbers);
            //show(evenNumbers);

            //.NET 2.8
            var multiplyThree = Filter.FilterNumbers(numbers, delegate (int x) { return x % 3 == 0; });
            //show(multiplyThree);

            //.NET 3.0
            var multiplyFive = Filter.FilterNumbers(numbers, q => q % 5 == 0);
            alternativeShow(multiplyFive);

            Console.ReadLine();

            
        }


        private static void show(int[] evenNumbers)
        {
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }


        private static void alternativeShow(int[] filteredNumbers)
        {
            filteredNumbers.ToList().ForEach(x => Console.WriteLine(x));
        }

        static bool getEvenNumbers(int value)
        {
            return value % 2 == 0;
        }
    }
}
