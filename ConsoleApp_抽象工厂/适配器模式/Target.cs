using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.适配器模式
{
    /// <summary>
    /// Target 目标类
    /// </summary>
    public class Target
    {
        public virtual void TargetPrint()
        {
            Console.WriteLine("My name is Target!");
        }
    }

    /// <summary>
    /// Adaptee类 受改造的类
    /// </summary>
    public class Adaptee
    {
        public void AdapteePrint()
        {
            Console.WriteLine("My name is Adaptee.");
        }
    }

    /// <summary>
    /// Adapter 适配器类
    /// </summary>
    public class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void TargetPrint()
        {
            adaptee.AdapteePrint();
        }
    }
}
