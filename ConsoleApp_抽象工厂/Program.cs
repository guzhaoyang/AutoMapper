using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_抽象工厂.抽象工厂;
using ConsoleApp_抽象工厂.简单工厂;
using ConsoleApp_抽象工厂.工厂方法模式;
using ConsoleApp_抽象工厂.原型模式;
using ConsoleApp_抽象工厂.适配器模式;
using ConsoleApp_抽象工厂.代理模式;

namespace ConsoleApp_抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 抽象工厂
            ////https://www.cnblogs.com/JiYF/p/6415426.html
            ////小米工厂生产小米手机的屏幕和主板
            //AbstractFactory xiaomiFactory = new XiaoMiFactory();
            //Screen xiaomiScreen = xiaomiFactory.CreateScreen();
            //xiaomiScreen.Print();
            //MotherBoard xiaomiMotherBoard = xiaomiFactory.CreateMotherBoard();
            //xiaomiMotherBoard.Print();

            ////苹果工厂生产苹果手机屏幕和主板
            //AbstractFactory appleFactory = new AppleFactory();
            //Screen appleScreen = appleFactory.CreateScreen();
            //appleScreen.Print();
            //MotherBoard appleMotherBoard = appleFactory.CreateMotherBoard();
            //appleMotherBoard.Print();
            #endregion

            #region 简单工厂
            ////http://www.cnblogs.com/JiYF/p/6405359.html
            //MobilePhone mobilePhone1 = MobilePhoneFactory.CreateMobilePhone("苹果");
            //if (mobilePhone1 != null)
            //    mobilePhone1.Print();
            //MobilePhone mobilePhone2 = MobilePhoneFactory.CreateMobilePhone("小米");
            //if (mobilePhone2 != null)
            //    mobilePhone2.Print();
            //MobilePhone mobilePhone3 = MobilePhoneFactory.CreateMobilePhone("锤子");
            //if (mobilePhone3 != null)
            //    mobilePhone3.Print();           
            #endregion

            #region 工厂方法模式
            ////http://www.cnblogs.com/JiYF/p/6409258.html
            ////创建苹果手机工厂
            //工厂方法模式.MobilePhoneFactory mobilePhoneFactoryIPhone = new IphoneFactory();
            ////苹果手机工厂创建手机
            //工厂方法模式.MobilePhone mobilePhoneIphone = mobilePhoneFactoryIPhone.Create();
            ////由苹果工厂创建苹果手机
            //mobilePhoneIphone.Prnt();

            ////小米工厂创建小米手机
            //工厂方法模式.MobilePhoneFactory mobilePhoneFactoryXiaoMI = new XiaoMIFactory();
            //工厂方法模式.MobilePhone mobilePhoneXiaoMI = mobilePhoneFactoryXiaoMI.Create();
            //mobilePhoneXiaoMI.Prnt();

            ////锤子手机工厂创建锤子手机
            //工厂方法模式.MobilePhoneFactory mobilePhoneFactorySmarTisan = new SmarTisanFactory();
            //工厂方法模式.MobilePhone mobilePhoneSmarTisan = mobilePhoneFactorySmarTisan.Create();
            //mobilePhoneSmarTisan.Prnt();
            #endregion

            #region 原型模式
            ////http://www.cnblogs.com/JiYF/p/6417787.html
            //ConcretePrototype1 p1 = new ConcretePrototype1("I");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            //Console.WriteLine("Cloned:{0}", c1.Id);

            //ConcretePrototype2 p2 = new ConcretePrototype2("II");
            //ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            //Console.WriteLine("Cloned:{0}", c2.Id);

            #endregion

            #region 原型模式手机举例
            //XiaoMiPrototype xiaomi = new XiaoMiPrototype("小米");
            //XiaoMiPrototype xiaomi2 = (XiaoMiPrototype)xiaomi.Clone();
            //Console.WriteLine(xiaomi2.Brand);

            //ApplePrototype iphone = new ApplePrototype("iPhone7 Plus");
            //ApplePrototype iphone2 = (ApplePrototype)iphone.Clone();
            //Console.WriteLine(iphone2.Brand);
            #endregion

            #region 适配器模式
            //Target target = new Adapter();//子类对象在堆上创建，并把子类对象的引用赋值给父类对象引用变量
            //target.TargetPrint();
            #endregion

            #region 代理模式
            //http://www.cnblogs.com/JiYF/p/6475080.html
            Proxy proxy = new Proxy();
            proxy.Print();
            #endregion

            Console.ReadLine();
        }
    }
}
