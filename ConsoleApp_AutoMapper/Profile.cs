using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AutoMapper
{
    public class MyProfile:Profile
    {
        public MyProfile()
        {
            CreateMap<ProductEntity, ProductDto>();
        }
    }
}
