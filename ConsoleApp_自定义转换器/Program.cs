using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Reflection;

namespace ConsoleApp_自定义转换器
{
    class Program
    {
        static void Main(string[] args)
        {
            //有些情况下目标字段类型和源字段类型不一致，可以通过类型转换器实现映射，类型转换器有三种实现方式:
            //void ConvertUsing(Func<TSource, TDestination> mappingFunction);
            //void ConvertUsing(ITypeConverter<TSource, TDestination> converter);
            //void ConvertUsing<TTypeConverter>() where TTypeConverter : ITypeConverter<TSource, TDestination>;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, int>().ConvertUsing((string s) => System.Convert.ToInt32(s));
                cfg.CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConvert());
                cfg.CreateMap<string, Type>().ConvertUsing<TypeTypeConvert>();
                cfg.CreateMap<Source, Destination>();
            });

            config.AssertConfigurationIsValid();////验证映射是否成功

            var source = new Source()
            {
                Value1 = "20",
                Value2 = "2018/1/1",
                Value3 = "AutoMapperSummary.CustomerTypeConvert+Destination"
            };

            var mapper = config.CreateMapper();
            var destination = mapper.Map<Source, Destination>(source);

            Console.ReadKey();
        }
    }

    public class Source
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
    }

    public class Destination
    {
        public int Value1 { get; set; }
        public DateTime Value2 { get; set; }
        public Type Value3 { get; set; }
    }

    public class DateTimeTypeConvert: ITypeConverter<string, DateTime >
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return System.Convert.ToDateTime(source);
        }
    }

    public class TypeTypeConvert : ITypeConverter<string, Type>
    {
        public Type Convert(string source, Type destination, ResolutionContext context)
        {
            return Assembly.GetExecutingAssembly().GetType();
        }
    }
}
