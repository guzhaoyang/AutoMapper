using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_泛型类练习
{
    public class FunXingLei<T>
    {
        public void Print(T a)
        {
            Console.WriteLine(a.ToString());
        }
    }
}
