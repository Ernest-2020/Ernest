using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program { 
    
        static void Main(string[] args)
        {
            string str = "Реализовать метод расширения для поиска количество символов в строке";
            List<int> _list = new List<int>();
            _list.AddRange(new int[] { 1, 2, 3, 3, 4, 5 });
            foreach (int i in _list.Distinct())
            {
              Console.WriteLine(i + " - " + _list.Where(x => x == i).Count() + " раз");
            }
            Console.ReadKey();
            str.Print();
        }
    }
}
