using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_反向映射
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Name = "Tom"
            };

            var order = new Order()
            {
                Customer = customer,
                Total = 20
            };

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))//正向映射规则
                .ReverseMap();//设置反向映射
            });

            //正向映射
            var orderDTO = Mapper.Map<OrderDTO>(order);

            //反向映射：使用ReverseMap,不用再创建OrderDTO -> Order的映射，而且还能保留正向的映射规则
            var orderConverted = Mapper.Map<Order>(orderDTO);

            Console.ReadKey();
        }
    }

    public class Order
    {
        public decimal Total { get; set; }
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderDTO
    {
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
    }
}
