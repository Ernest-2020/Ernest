using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
   static  class MyExtension
    {

        public static void Print(this string str)
        {
            int i = 0;
            foreach (char ch in str)
            {
                i++;
            }
            Console.WriteLine($"В строке str {i} символов");
            Console.ReadKey();
        }
    }
}
