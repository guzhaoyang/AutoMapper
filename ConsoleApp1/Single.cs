using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Single
    {
        //构造方法私有化
        private Single()
        {

        }

        public static readonly object obj = new object();

        //定义一个字段
        private static Single single = null;

        //定义一个产生对象的方法
        public static Single Instance()
        {
            lock(obj)
            {
                if (single == null)
                {
                    single = new Single();
                }

                return single;
            }
        }

        //定义一个测试字段，用于查看单例的效果，就是看其是否是一个对象
        public int testInt { get; set; }
    }
}
