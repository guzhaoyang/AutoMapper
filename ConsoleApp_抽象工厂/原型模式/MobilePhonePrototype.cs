using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.原型模式
{
    /// <summary>
    /// MobilePhonePrototype类 手机原型基类
    /// </summary>
    public abstract class MobilePhonePrototype
    {
        private string _brand;
        public string Brand
        {
            get { return _brand; }
        }
        public MobilePhonePrototype(string brand)
        {
            this._brand = brand;
        }
        public abstract MobilePhonePrototype Clone();
    }

    /// <summary>
    /// XiaoMiPrototype类 小米手机原型类
    /// </summary>
    public class XiaoMiPrototype : MobilePhonePrototype
    {
        public XiaoMiPrototype(string brand)
            :base(brand)
        {

        }
        public override MobilePhonePrototype Clone()
        {
            return (MobilePhonePrototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// ApplePrototype类 苹果手机原型类
    /// </summary>
    public class ApplePrototype : MobilePhonePrototype
    {
        public ApplePrototype(string brand):
            base(brand)
        {

        }
        public override MobilePhonePrototype Clone()
        {
            return (MobilePhonePrototype)this.MemberwiseClone();
        }
    }
}
