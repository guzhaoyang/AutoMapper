using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_设置转换前后行为
{
    class Program
    {
        static void Main(string[] args)
        {
            //有的时候你可能会在创建映射前后对数据做一些处理，AutoMapper就提供了这种方式

            var source = new Source()
            {
                Name = "Product" + DateTime.Now.Ticks
            };

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Source, Destination>()
                .BeforeMap((src, dest) => src.Value = src.Value + 10)
                .AfterMap((src, dest) => dest.Name = "Pobin");
            });

            var productModel = Mapper.Map<Destination>(source);

            Console.ReadKey();
        }
    }

    public class Source
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
