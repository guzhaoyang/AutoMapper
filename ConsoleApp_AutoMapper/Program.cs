using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoMapper 使用总结   https://www.cnblogs.com/arvinzhang/p/8214493.html

            //如果每层都使用不同的类，则层与层调用时，一个字段一个字段的赋值又会很麻烦。针对第二种情况，可以使用AutoMapper来帮助我们实现类字段的赋值及转换

            #region 初始化
            //var productEntity = new ProductEntity
            //{
            //    Name = "Product" + DateTime.Now.Ticks,
            //    Amount = 10
            //};

            //使用静态方式
            //AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<ProductEntity, ProductDto>());
            //var productDto = AutoMapper.Mapper.Map<ProductDto>(productEntity);

            //使用实例方法
            //MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.CreateMap<ProductEntity, ProductDto>());
            //var mapper = configuration.CreateMapper();
            //var productDto = mapper.Map<ProductDto>(productEntity);

            //Profiles设置
            //MapperConfiguration configuration = new MapperConfiguration( cfg => cfg.AddProfile<MyProfile>());
            //var productDto = configuration.CreateMapper().Map<ProductDto>(productEntity);
            //Console.WriteLine(productDto.Name + "\r\n" + productDto.Amount);
            #endregion


            #region 扁平化映射

            #endregion


            Console.ReadKey();
        }
    }
}
