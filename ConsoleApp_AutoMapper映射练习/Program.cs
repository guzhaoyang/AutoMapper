//using AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AutoMapper映射练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////初始化配置文件
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Aliens, Person>();
            //    cfg.AddProfile<AliensPersonProfile>();//添加一个配置文件
            //});

            //Mapper.CreateMap<Source, Destination>();

            //Mapper.CreateMap<Aliens, Person>().ForMember(dest => dest.Age, opt => opt.Condition(src => src.Age > 0 && src.Age < 149));

        }
    }

    public class Person
    {
        public Person()
        {
            Age = 22;
        }
        public uint Age { set; get; }//Person的Age属性默认值是22
    }

    public class Aliens
    {
        public Aliens()
        {
            Age = -23;
        }
        public int Age { get; set; }//Aliens的Age属性默认值是-23
    }

    public class Source
    {
        public string SomeValue { get; set; }
        public string AnotherValue { get; set; }
    }

    public class Destination
    {
        public int SomeValue { get; set; }
    }
}
