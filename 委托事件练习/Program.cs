using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托事件练习
{
    class Program
    {
        public static event EventHandler EventTest;

        private static void Test(object sender, EventArgs e)
        {
            Console.WriteLine("test1");
        }

        static void Main(string[] args)
        {
            //注册事件
            EventTest += Test;

            while(true)
            {
                Console.WriteLine("当用户输入a时，触发EventTest事件");
                string read = Console.ReadLine();

                if(read == "a")
                {
                    Console.WriteLine("Hello World");
                    EventTest(null, EventArgs.Empty);
                }
            }

            return;
        }
    }
}
