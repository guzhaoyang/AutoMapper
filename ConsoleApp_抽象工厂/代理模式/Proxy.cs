using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.代理模式
{
    /// <summary>
    /// 代理类和对象的共用接口
    /// </summary>
    public abstract class Subject
    {
        public abstract void Print();
    }

    /// <summary>
    /// 代理类所创建的对象
    /// </summary>
    public class ConcreteSubject:Subject
    {
        public override void Print()
        {
            Console.WriteLine("ConcreteSubject");
        }
    }

    /// <summary>
    /// 代理类
    /// </summary>
    public class Proxy:Subject
    {
        private ConcreteSubject _concreteSubject;
        public override void Print()
        {
            if(_concreteSubject == null)
            {
                _concreteSubject = new ConcreteSubject();
            }
            _concreteSubject.Print();
        }
    }
}
