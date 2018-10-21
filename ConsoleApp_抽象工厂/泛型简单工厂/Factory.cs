using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.泛型简单工厂
{
    public class Factory
    {
        //通过类名存储对象
        private static Dictionary<string, object> dic = new Dictionary<string, object>();

        public static T GetT<T>()
        {
            T t = default(T);
            string TName = typeof(T).ToString();
            if(dic.Keys.Contains(TName))
            {            
                object type = dic[TName];
                return (T)type;
            }
            else
            {
                object obj = new object();
                dic.Add(TName, (T)obj);
                return (T)obj;
            }
        }
    }
}
