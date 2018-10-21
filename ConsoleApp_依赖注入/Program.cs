using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_依赖注入
{
    class Program
    {
        static void Main(string[] args)
        {
            //依赖注入的简单理解
            //https://www.cnblogs.com/alltime/p/6729295.html
            //依赖倒转原则：其核心思想就是要将这种具体类之间的依赖，尽量转换成抽象依赖

            //需求：一个人（Person类对象）去开一辆toyota车

            #region 刚学编程的程序员
            //Person boy = new Person();
            //boy.Drive();
            #endregion

            #region 构造方法注入
            //Toyota toyota = new Toyota();
            //Person boy = new Person(toyota);
            //boy.Drive();
            #endregion

            #region 属性注入
            //Toyota toyota = new Toyota();
            //Person boy = new Person();
            //boy.Car = toyota;
            //boy.Drive();
            #endregion


            //其他博客
            //https://www.cnblogs.com/chenwolong/p/DI.html
            //接口注入
            Toyota toyota = new Toyota();//在外部创建依赖对象
            PersonTest personTest = new PersonTest();
            personTest.SetCar(toyota);
            personTest.Drive();

            Console.WriteLine("boy对象在开车");
            Console.ReadKey();
        }
    }

    #region 接口注入方式
    public interface ICarTest
    {
        void SetCar(ICar car);//设置依赖项
    }

    public class PersonTest:ICarTest
    {
        private ICar car;//定义一个私有变量保存抽象

        //实现接口
        public void SetCar(ICar car)
        {
            this.car = car;
        }

        public void Drive()
        {
            car.挂挡();
            car.踩油门();
            car.打方向();
        }
    }
    #endregion


    #region 构造方法或属性注入
    public class Person
    {
        //private readonly ICar car;
        private ICar car;
        public ICar Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }

        public Person(){ }

        /// <summary>
        /// 构造方法注入
        /// </summary>
        /// <param name="onecar">传入要注入的对象</param>
        public Person(ICar onecar)
        {
            this.car = onecar;
        }
        public void Drive()
        {
            #region 刚学编程的程序员
            ////这里Drive方法内部实例化Car对象，表示控制这个对象的生成。
            ////如果采用控制反转的思想，那么Car对象的创建是在该方法的外部去创建，Drive方法只是获取Car对象的引用，
            ////这时创建Car对象的主动权转到了Drive方法的外部
            //Car toyota = new Car("toyota");
            //toyota.挂挡();
            //toyota.踩油门();
            //toyota.打方向();
            #endregion

            #region 构造方法或属性注入
            car.挂挡();
            car.踩油门();
            car.打方向();
            #endregion

        }
    }    

    public class Car
    {
        public string Name { get; set; }
        public Car(string carName)
        {
            this.Name = carName;
        }

        public void 挂挡() {}
        public void 踩油门() { }
        public void 打方向() { }
    }

    public interface ICar
    {
        void 挂挡();
        void 踩油门();
        void 打方向();

    }

    public class Toyota:ICar
    {
        public void 挂挡(){ }

        public void 踩油门() { }

        public void 打方向() { }
    }

    #endregion
}
