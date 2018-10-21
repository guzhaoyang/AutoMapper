using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.工厂方法模式
{
    public abstract class MobilePhoneFactory
    {
        public abstract MobilePhone Create();
    }

    public class IphoneFactory:MobilePhoneFactory
    {
        public override MobilePhone Create()
        {
            return new Iphone();
        }
    }

    public class XiaoMIFactory:MobilePhoneFactory
    {
        public override MobilePhone Create()
        {
            return new XiaoMI();
        }
    }

    public class SmarTisanFactory:MobilePhoneFactory
    {
        public override MobilePhone Create()
        {
            return new SmarTisan();
        }
    }
}
