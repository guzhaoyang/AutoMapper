using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebForm
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        public MySoapHeader header; ////定义用户身份验证类变量header

        [WebMethod(Description = "用户验证测试")]
        [System.Web.Services.Protocols.SoapHeader("header")]//用户身份验证的soap头 
        public string HelloWorld(string contents)
        {
            //验证是否有权访问 
            if (header.ValideUser(header.UserName, header.PassWord))
            {
                return contents + "执行了";
            }
            else
            {
                return "您没有权限访问";
            }
            //return "Hello World";
        }
    }

    //https://blog.csdn.net/kingmax54212008/article/details/7280243     

    /// <summary>
    ///MySoapHeader 的摘要说明
    /// </summary>
    public class MySoapHeader : SoapHeader
    {
        public MySoapHeader()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool ValideUser(string in_UserName, string in_PassWord)
        {
            if ((in_UserName == "zxq") && (in_PassWord == "123456"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
