using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatation
{
    public static class Filter
    {
        //public delegate bool critaria(int value);  gerek kalmadı

        

        public static int[] FilterNumbers(int[] array,Func<int,bool> critariaFunction)
        {
            List<int> result = new List<int>();
            foreach (var item in array)
            {
                if (critariaFunction(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
