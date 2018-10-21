using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ConsoleApp_配置验证及设置
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product()
            {
                Name = "Product" + DateTime.Now.Ticks,
                Amount = 10
            };

            Mapper.Initialize(cfg =>
            {
                //1. 指定字段映射方式
                cfg.CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.ViewName, opt => opt.Ignore());//如果不添加此设置，会抛出异常

                //2. 指定整个对象映射方式
                //MemberList:
                //  Source: 检查源对象所有字段映射成功
                //  Destination：检查目标对象所有字段映射成功
                //  None: 跳过验证
                cfg.CreateMap<Product, ProductDTO>(MemberList.Source);                
            });

            var productModel = Mapper.Map<ProductModel>(product);
            var productDTO = Mapper.Map<ProductDTO>(product);

            //验证映射是否成功
            Mapper.AssertConfigurationIsValid();

            Console.ReadKey();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }

    public class ProductModel
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string ViewName { get; set; }
    }

    public class ProductDTO
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string ViewName { get; set; }
    }
}
