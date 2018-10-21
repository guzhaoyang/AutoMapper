using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.原型模式
{
    /// <summary>
    /// Prototype类 原型基类
    /// </summary>
    public abstract class Prototype
    {
        private string _id;
        public Prototype(string id)
        {
            this._id = id;
        }
        public string Id
        {
            get { return _id; }
        }
        public abstract Prototype Clone();
    }

    /// <summary>
    /// ConcretePrototype1类 具体的原型类实现Clone方法
    /// </summary>
    public class ConcretePrototype1:Prototype
    {
        public ConcretePrototype1(string id)
            :base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// ConcretePrototype2类 具体的原型类实现Clone方法
    /// </summary>
    public class ConcretePrototype2:Prototype
    {
        public ConcretePrototype2(string id)
            :base(id)
        {

        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
