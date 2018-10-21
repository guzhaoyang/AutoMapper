using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.抽象工厂
{
    /// <summary>
    /// 苹果手机屏幕
    /// </summary>
    public class AppleScreen:Screen
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机屏幕！");
        }
    }

    /// <summary>
    /// 苹果手机主板
    /// </summary>
    public class AppleMotherBoard:MotherBoard
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机主板！");
        }
    }

    /// <summary>
    /// 苹果手机工厂
    /// </summary>
    public class AppleFactory:AbstractFactory
    {
        /// <summary>
        /// 生产苹果手机屏幕
        /// </summary>
        /// <returns></returns>
        public override Screen CreateScreen()
        {
            return new AppleScreen();
        }
        /// <summary>
        /// 生产苹果手机主板
        /// </summary>
        /// <returns></returns>
        public override MotherBoard CreateMotherBoard()
        {
            return new AppleMotherBoard();
        }
    }
}
