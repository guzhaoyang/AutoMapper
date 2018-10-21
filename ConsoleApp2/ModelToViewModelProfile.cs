using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ModelToViewModelProfile: Profile
    {
        protected override void Configure()
        {
            CreateMap<OrderModel, OrderViewModel>();
        }
    }
}
