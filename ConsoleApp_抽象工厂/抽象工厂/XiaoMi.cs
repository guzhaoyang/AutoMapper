using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.抽象工厂
{
    /// <summary>
    /// 小米手机屏幕
    /// </summary>
    public class XiaoMiScreen:Screen
    {
        public override void Print()
        {
            Console.WriteLine("小米手机屏幕！");
        }
    }

    /// <summary>
    /// 小米手机主板类
    /// </summary>
    public class XiaoMiMotherBoard:MotherBoard
    {
        public override void Print()
        {
            Console.WriteLine("小米手机主板！");
        }
    }

    /// <summary>
    /// 小米手机工厂类
    /// </summary>
    public class XiaoMiFactory : AbstractFactory
    {
        /// <summary>
        /// 生产小米手机主板
        /// </summary>
        /// <returns></returns>
        public override MotherBoard CreateMotherBoard()
        {
            return new XiaoMiMotherBoard();
        }
        /// <summary>
        /// 生产小米手机屏幕
        /// </summary>
        /// <returns></returns>
        public override Screen CreateScreen()
        {
            return new XiaoMiScreen();
        }
    }
}
