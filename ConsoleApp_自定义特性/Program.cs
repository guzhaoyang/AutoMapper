#define DEBUG //这里定义条件

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_自定义特性
{    
    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        public static void function1()
        {
            MyClass.message("In Function 1.");
            function2();
        }

        public static void function2()
        {
            MyClass.message("In Function 1.");
        }

        [DebugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
        public class Me
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            //MyClass.message("In Main function.");
            //function1();

            Me me = new Me();
            me.ID = 1;
            me.Name = "gzy";

            System.Reflection.MemberInfo info = typeof(Me);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }

            Console.ReadKey();
        }
    }
}
