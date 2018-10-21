using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.抽象工厂
{
    /// <summary>
    /// 抽象工厂类：提供创建不同品牌的手机屏幕和手机主板
    /// gzy:这个抽象工厂类是将手机屏幕和手机主板抽象了，不分具体厂家的
    /// </summary>
    public abstract class AbstractFactory
    {
        //工厂生产屏幕
        public abstract Screen CreateScreen();
        //工厂生产主板
        public abstract MotherBoard CreateMotherBoard();
    }

    /// <summary>
    /// 屏幕抽象类：提供每一品牌的屏幕的继承
    /// </summary>
    public abstract class Screen
    {
        public abstract void Print();
    }

    /// <summary>
    /// 主板抽象类：提供每一品牌的主板的继承
    /// </summary>
    public abstract class MotherBoard
    {
        public abstract void Print();
    }
}
