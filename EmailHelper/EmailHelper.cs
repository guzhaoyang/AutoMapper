using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Helper帮助类及其测试
{
    public static class EmailHelper
    {
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
