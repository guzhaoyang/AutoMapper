using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ConsoleApp_自定义解析器
{
    class Program
    {
        static void Main(string[] args)
        {
            //某些情况下，解析规则会很复杂，使用自带的解析规则无法实现。
            //这时可以自定义解析规则，可以通过以下三种方式使用自定义的解析器
            //ResolveUsing<TValueResolver>
            //ResolveUsing(typeof(CustomValueResolver))
            //ResolveUsing(aValueResolverInstance)

            Mapper.Initialize(cfg =>
                cfg.CreateMap<Source, Destination>()
                    .ForMember(dest => dest.Name, opt => opt.ResolveUsing<CustomResolver>()));

            Mapper.AssertConfigurationIsValid();

            var source = new Source()
            {
                FirstName = "Michael",
                LastName = "Jackson"
            };

            var destination = Mapper.Map<Source, Destination>(source);

            Console.ReadKey();
        }
    }

    public class Source
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
    }

    /// <summary>
    /// 自定义解析器: 组合姓名
    /// </summary>
    public class CustomResolver:IValueResolver<Source, Destination, string>
    {
        public string Resolve(Source source, Destination destination, string destMember, ResolutionContext context)
        {
            if(source != null && !string.IsNullOrEmpty(source.FirstName) && !string.IsNullOrEmpty(source.LastName))
            {
                return string.Format("{0} {1}", source.FirstName, source.LastName);
            }
            return string.Empty;
        }
    }
}
