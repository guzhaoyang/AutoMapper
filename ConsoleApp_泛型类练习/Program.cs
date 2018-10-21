using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_泛型类练习
{
    class Program
    {
        public class A
        {
            //public int a = 0;
            public int a = 0;
            public A()
            {
                a = 9;
            }

            public class B//这时B应该是内部类，类A相当于类B的命名空间
            {
                public B(){ }

                public int b = 5;
            }
        }

        public class C
        {
            public C()
            {

            }

            public int c = 0;
        }
        static void Main(string[] args)
        {
            //FunXingLei<int> i = new FunXingLei<int>();
            //i.Print(1);
            #region 泛型练习
            //FunXingLei<A> Aa = new FunXingLei<A>();
            //A a = new A();
            //Aa.Print(a);
            #endregion

            C c1 = new C();
            A a1 = new A();
            A.B b1 = new A.B();
            c1.c = a1.a + b1.b;
            Console.WriteLine(c1.c);

            Console.ReadKey();
        }
    }
}
