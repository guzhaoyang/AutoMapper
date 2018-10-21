using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_扁平化映射
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoMapper会自动实现Product.Supplier.Name->ProductDTO.SupplierName,
            //Product.GetAmount->ProductDTO.Amount的映射

            var supplier = new Supplier
            {
                Name = "Supplier" + DateTime.Now.Ticks
            };

            var product = new Product
            {
                supplier = supplier,
                Name = "Product" + DateTime.Now.Ticks
            };

            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductDTO>());
            var productDto = Mapper.Map<ProductDTO>(product);

            Console.WriteLine(productDto.Amount + "\t" + productDto.SupplierName);
            Console.ReadKey();
        }
    }

    public class Product
    {
        public Supplier supplier { get; set; }

        public string Name { get; set; }

        public decimal GetAmount()
        {
            return 10;
        }
    }

    public class Supplier
    {
        public string Name { get; set; }
    }

    public class ProductDTO
    {
        public string SupplierName { get; set; }
        public decimal Amount { get; set; } 
    }
}
