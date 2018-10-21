using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Helper帮助类及其测试
{
    public class EmailHelper
    {        
        public static string HtmlBuilder()
        {
            StringBuilder sb = new StringBuilder();

        string formatType = "utf-8";
            sb.Append("<!DOCTYPE html>");
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<title> 页签切换 </title>");
            sb.Append("<meta charset = \"utf-8\"/>");
            sb.Append("<style type = \"text/css\" >");
            sb.Append(@"#lab{            
                        margin: 0;
                        padding: 0;
                        }");
            sb.Append(@"#lab li{            
                    list -style:none;
			        float: left;
			        width: 100px;
			        height: 35px;
			        line-height: 35px;
			        text-align: center;
			        background-color: #ccc;
			        border-right: 1px solid #caa;
		            }");
            sb.Append(@"# lab li.cur{            
                background -color: #cee;
	            }");
            sb.Append(@"# content{
                            clear: both;
			                width: 382px;
			                height: 180px;
			                padding: 10px;
			                text-indent: 2em;
			                border: 1px solid #ccc;
		                }");
            sb.Append("</style>");
            sb.Append("<script type = \"text/javascript\">");
            sb.Append(@"window.onload = function(){    
                var oUl = document.getElementById('lab');
                var oLis = oUl.getElementsByTagName('li');
                var oContent = document.getElementById('content');
                var message = ['新闻', '娱乐', '体育', '互联网'];

			    for(var i=0;i<oLis.length;i++){
				    oLis[i].index = i;
				    oLis[i].onmouseover = function()
                    {
                        for (var j = 0; j < oLis.length; j++)
                        {
                            oLis[j].className = '';
                        }
                        this.className = 'cur';
                        oContent.innerHTML = message[this.index];
                    };
			    }
		    };");
            sb.Append("</script>");
            sb.Append(@"</head>
                            <body>");
                        sb.Append("<ul id = \"lab\">");
                            sb.Append("<li class=\"cur\">新闻</li>");
                            sb.Append(@"<li>娱乐</li>
                                        <li>体育</li>
		                                <li>互联网</li>
	                                </ul>");
            sb.Append("<div id =\"content\" style-float:left>新闻</div>");
            sb.Append(@"</body>
                </html>");
            return sb.ToString();
        }

        public static string LoginHtmlBuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"<!DOCTYPE html>
                        <html>
                        <head>
                            <title> 登录 </title>");
                    sb.Append("<meta charset =\"utf-8\"/>");
            sb.Append(@"</head>
                        <body>");
            sb.Append("<table border=\"1px\" width=\"400px\" cellpadding=\"10px\" cellspacing=\"0\" >");
            sb.Append("<tr>");
                sb.Append("<td colspan=\"2\" style=\"text-align: center;\">");
            sb.Append(@"<p> 登录 </p>
                            </td>
                        </tr>
                        <tr>
                            <td> 用户名：</td>");
                sb.Append("<td><input type=\"text\"/></td>");
            sb.Append(@"</tr>
                        <tr>
                            <td> 密码：</td >");
            sb.Append("<td><input type=\"text\"/></td>");
            sb.Append(@"</tr>
                      <tr>");
            sb.Append("<td><a style=\"width:100px;height: 40px; display:block;text-decoration:none;\" target=\"_blank\" href='http://www.baidu.com'>登录</a></td>");
            sb.Append("<td><a style=\"width:100px;height: 40px;\" href='http://www.baidu.com'>注册</a></td>");
        sb.Append(@"</tr>
                </table>
            </body>
            </html> ");

            return sb.ToString();
        }

        #region 参照博客
        //http://www.stormcn.cn/post/1912.html
        //https://zhidao.baidu.com/question/1989441970663026987.html
        #endregion

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="from">发件人信箱</param>
        /// <param name="to">收件人信箱</param>
        /// <param name="password">发件人信箱的登录密码，如果是qq邮箱发送，则使用qq邮箱的授权码</param>
        /// <param name="displayName">显示名，即邮箱昵称</param>
        /// <param name="title">主题</param>
        /// <param name="body">邮件正文</param>
        /// <param name="smtpServer">SMTP服务器，默认为qq服务器</param>
        /// <param name="isHtml">邮件正文是否是html格式，默认是</param>
        public static void SendEmail(string from, string to, string password, string displayName,
            string title, string body, string smtpServer = "smtp.qq.com", bool isHtml = true)
        {
            //textBoxSmtpServer.Text = "smtp.qq.com";
            //textBoxSend.Text = "1219412799@qq.com";
            //textBoxDisplayName.Text = "dasas";
            //textBoxPassword.Text = "cgcrlfyightgiifa";
            //textBoxReceive.Text = "526457385@qq.com";
            //textBoxSubject.Text = "测试mytest";
            //textBoxBody.Text = "This is a test（测试）";


            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(from, displayName, System.Text.Encoding.UTF8);
            mailMessage.To.Add(to);
            mailMessage.Subject = title;
            mailMessage.SubjectEncoding = System.Text.Encoding.Default;
            mailMessage.Body = body;
            mailMessage.BodyEncoding = System.Text.Encoding.Default;
            mailMessage.IsBodyHtml = isHtml;
            mailMessage.Priority = MailPriority.Normal;

            #region 添加附件，已注释
            //添加附件
            //Attachment attachment = null;
            //if (listBoxFileName.Items.Count > 0)
            //{
            //    for (int i = 0; i < listBoxFileName.Items.Count; i++)
            //    {
            //        string pathFileName = listBoxFileName.Items[i].ToString();
            //        string extName = Path.GetExtension(pathFileName).ToLower();
            //        //这里仅举例说明如何判断附件类型
            //        if (extName == ".rar" || extName == ".zip")
            //        {
            //            attachment = new Attachment(pathFileName, MediaTypeNames.Application.Zip);
            //        }
            //        else
            //        {
            //            attachment = new Attachment(pathFileName, MediaTypeNames.Application.Octet);
            //        }
            //        ContentDisposition cd = attachment.ContentDisposition;
            //        cd.CreationDate = File.GetCreationTime(pathFileName);
            //        cd.ModificationDate = File.GetLastWriteTime(pathFileName);
            //        cd.ReadDate = File.GetLastAccessTime(pathFileName);
            //        mailMessage.Attachments.Add(attachment);
            //    }
            //}
            #endregion

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = smtpServer;
            smtpClient.Port = 25;//SMTP服务器需要身份验证，端口号是25
            //是否使用安全套接字层加密连接
            smtpClient.EnableSsl = true;
            //不使用默认凭证,注意此句必须放在client.Credentials的上面   为啥？
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(from, password);
            //邮件通过网络直接发送到服务器
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtpClient.Send(mailMessage);

            }
            catch (SmtpException smtpError)
            {
                throw smtpError;
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient = null;

            }
        }
    }
}
