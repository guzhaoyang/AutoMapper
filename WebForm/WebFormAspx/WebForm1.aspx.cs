using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm.WebFormAspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm.WebService webService = new WebService();//web引用
            MySoapHeader header = new MySoapHeader();//web引用创建soap头对象

            //设置soap头变量
            header.UserName = "zxq";//"jht";
            header.PassWord = "123456";//"jhtpass";

            webService.header = header;

            //调用web 方法
            Response.Write(webService.HelloWorld("我是Jimmy Huang, how are you?"));

        }
    }
}