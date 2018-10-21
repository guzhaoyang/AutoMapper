using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Helper帮助类及其测试
{
    class Program
    {
        static void Main(string[] args)
        {
            // EmailHelper.SendEmail("1219412799@qq.com", "2414396314@qq.com", "ztyeprsxkzfeibia","dasas", "test", EmailHelper.LoginHtmlBuilder());

            //阿里大鱼短信例子
            //调用方式
            //string phone = "";
            //string passwd = "";
            //var smsresult = AliDaYuSMS.SendSms(phone, "潮运动", "SMS_13000621", "{\"username\":\"" + phone + "\",\"passwd\":\"" + passwd + "\"}", phone);

            //生成二维码
            QRcode qRcode = new QRcode();
            qRcode.Create("http://192.168.0.107:8090/", 4, "/Content/Images/QrCode/");
            qRcode.Create("http://www.baidu.com/", 4, "/Content/Images/QrCode/");

            //生成条形码
            //TiaoXingMaTestForm tiaoXingMaTestForm = new TiaoXingMaTestForm();
            //tiaoXingMaTestForm.ShowDialog();
            Console.ReadKey();
        }
    }
}
