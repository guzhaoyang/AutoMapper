using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.工厂方法模式
{
    /// <summary>
    /// MobilePhone类手机类
    /// </summary>
    public abstract class MobilePhone
    {
        public abstract void Prnt();
    }

    public class Iphone : MobilePhone
    {
        public override void Prnt()
        {
            Console.WriteLine("我是苹果手机！");
        }
    }

    public class XiaoMI : MobilePhone
    {
        public override void Prnt()
        {
            Console.WriteLine("我是小米手机");
        }
    }

    public class SmarTisan : MobilePhone
    {
        public override void Prnt()
        {
            Console.WriteLine("我是锤子手机！");
        }
    }
}
