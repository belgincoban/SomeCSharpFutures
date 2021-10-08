using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
       public static double GetSquare(this int number)
        {
            return Math.Pow(number, 2);

        }


        public static string RemoveAllSpaces(this string value)
        {
            return value.Replace(" ", string.Empty);
        }
    }
}
