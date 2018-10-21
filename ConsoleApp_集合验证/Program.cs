using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_集合验证
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoMapper除了可以映射单个对象外，也可以映射集合对象。AutoMapper源集合类型支持以下几种：
            //IEnumerable
            //IEnumerable<T>
            //ICollection
            //ICollection<T>
            //IList
            //IList<T>
            //List<T>
            //Arrays

            #region 集合
            //Mapper.Initialize(cfg => cfg.CreateMap<Source, Destination>());

            //var source = new[]
            //{
            //    new Source{ Value = 1 },
            //    new Source{Value = 2},
            //    new Source{Value = 3},
            //};

            //IEnumerable<Destination> ienumerableDest = Mapper.Map<Source[], IEnumerable<Destination>>(source);

            //ICollection<Destination> icollectionDest = Mapper.Map<Source[], ICollection<Destination>>(source);

            //IList<Destination> ilistDest = Mapper.Map<Source[], IList<Destination>>(source);

            //List<Destination> listDest = Mapper.Map<Source[], List<Destination>>(source);

            //Destination[] arrayDest = Mapper.Map<Source[], Destination[]>(source);

            #endregion


            #region 复杂对象映射：

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<OrderLine, OrderLineDTO>();
            });

            Order order = new Order();
            order.AddLineItem(new OrderLine { Quantity = 10 });
            order.AddLineItem(new OrderLine { Quantity = 20 });
            order.AddLineItem(new OrderLine { Quantity = 30 });

            OrderDTO orderDTO = Mapper.Map<OrderDTO>(order);
            #endregion

            Console.ReadKey();
        }
    }

    public class Source
    {
        public int Value { get; set; }
    }

    public class Destination
    {
        public int Value { get; set; }
    }


    #region 复杂对象映射
    public class Order
    {
        private IList<OrderLine> _lineItems = new List<OrderLine>();
        public OrderLine[] LineItems { get { return _lineItems.ToArray(); } }
        public void AddLineItem(OrderLine orderLine)
        {
            _lineItems.Add(orderLine);
        }
    }

    public class OrderLine
    {
        public int Quantity { get; set; }
    }

    public class OrderDTO
    {
        public OrderLineDTO[] LineItems { get; set; }
    }

    public class OrderLineDTO
    {
        public int Quantity { get; set; }
    }
    #endregion
}
