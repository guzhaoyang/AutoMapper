using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AutoMapper
{
    public class ProductEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }

    public class ProductDto
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
