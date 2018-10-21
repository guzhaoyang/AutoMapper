/**************************
 * 
 * 单例模式
 * 
 * 
 * ***********************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Single s = Single.Instance();

            s.testInt = 1;
            Console.WriteLine(s.testInt);

            Single s2 = Single.Instance();
            Console.WriteLine(s2.testInt);
            s2.testInt = 2;

            Single s3 = Single.Instance();
            Console.WriteLine(s3.testInt);

            Console.ReadKey();
        }
    }
}
