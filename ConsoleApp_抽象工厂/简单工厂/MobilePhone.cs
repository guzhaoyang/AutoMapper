using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.简单工厂
{
    /// <summary>
    /// 抽象一个手机概念类，抽象手机共有的抽象方法，注意：这里是按照手机类别进行抽象的
    /// </summary>
    public abstract class MobilePhone
    {
        public abstract void Print();
    }

    public class Iphone :MobilePhone
    {
        public override void Print()
        {
            Console.WriteLine("我是苹果品牌！");
        }
    }

    public class XiaoMI:MobilePhone
    {
        public override void Print()
        {
            Console.WriteLine("我是小米手机");
        }
    }

    public class SmarTisan:MobilePhone
    {
        public override void Print()
        {
            Console.WriteLine("我是锤子手机");
        }
    }
}
