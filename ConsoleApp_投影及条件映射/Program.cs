using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_投影及条件映射
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 投影

            //var calender = new Calender()
            //{
            //    Title = "2018年日历",
            //    CalenderDate = new DateTime(2018, 1, 1, 11, 59, 59)
            //};

            //Mapper.Initialize(cfg => cfg
            //.CreateMap<Calender, CalenderModel>()
            //.ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CalenderDate.Date))
            //.ForMember(dest => dest.Hour, opt => opt.MapFrom(src => src.CalenderDate.Hour))
            //.ForMember(dest => dest.Minute, opt => opt.MapFrom(src => src.CalenderDate.Minute)));

            //var calenderModel = Mapper.Map<CalenderModel>(calender);

            #endregion

            # region 条件映射

            var source = new Source()
            {
                Value = 3
            };

            //如果Source.Value > 0, 则执行映射；否则，映射失败
            Mapper.Initialize(cfg => cfg
                .CreateMap<Source, Destination>()
                .ForMember(dest => dest.Value, opt => opt.Condition(src => src.Value > 0)));

            var destation = Mapper.Map<Destination>(source);//如果不符合条件，则抛出异常
            #endregion

            Console.ReadKey();
        }
    }

    #region 投影
    public class Calender
    {
        public DateTime CalenderDate { get; set; }
        public string Title { get; set; }
    }

    public class CalenderModel
    {
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string Title { get; set; }
    }

    #endregion


    #region 条件映射

    public class Source
    {
        public int Value { get; set; }
    }

    public class Destination
    {
        public uint Value { get; set; }
    }

    #endregion

}
