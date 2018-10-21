using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.WebService webService = new localhost.WebService();
            localhost.MySoapHeader header = new localhost.MySoapHeader();
            header.PassWord = "123456";
            header.UserName = "zxq";
            webService.MySoapHeaderValue = header;
            Response.Write(webService.HelloWorld("hello world!"));
        }
    }
}