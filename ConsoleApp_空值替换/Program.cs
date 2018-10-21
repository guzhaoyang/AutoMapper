using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ConsoleApp_空值替换
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new Source()
            {

            };

            //Mapper.Initialize(cfg => cfg
            //.CreateMap<Source, Destination>()
            //.ForMember(dest => dest.Name, opt => opt.NullSubstitute("其他值")));

            //下面的效果和上面的效果是等价的
            Mapper.Initialize(cfg => cfg.CreateMap<Source, Destination>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name == null ? "其他值" : src.Name)));

            var destination = Mapper.Map<Destination>(source);

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
