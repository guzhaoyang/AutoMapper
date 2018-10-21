using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_抽象工厂.简单工厂
{
    public class MobilePhoneFactory
    {
        public static MobilePhone CreateMobilePhone(string PhoneBrand)
        {
            MobilePhone mobilePhone = null;
            if (PhoneBrand.Equals("苹果"))
            {
                mobilePhone = new Iphone();
            }
            else if(PhoneBrand.Equals("小米"))
            {
                mobilePhone = new XiaoMI();
            }
            else if(PhoneBrand.Equals("锤子"))
            {
                mobilePhone = new SmarTisan();
            }
            else
            {

            }
            return mobilePhone;
        }
    }
}
