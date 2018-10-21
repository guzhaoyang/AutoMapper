using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_值转换
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new Source()
            {
                Name = "Bob"
            };

            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Source, Destination>();
            //    cfg.ValueTransformers.Add<string>(val => string.Format("@{0}@", val));
            //});

            //也可以使用ForMember做值转换,和上面注释的部分效果等价
            Mapper.Initialize(cfg => cfg
                .CreateMap<Source, Destination>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name != null ? string.Format("@{0}@", src.Name) : "")));

            var destation = Mapper.Map<Destination>(source);

            Console.ReadKey();
        }
    }

    public class Source
    {
        public string Name { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
    }
}
