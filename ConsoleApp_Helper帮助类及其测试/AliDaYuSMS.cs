using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace ConsoleApp_Helper帮助类及其测试
{
    public class AliDaYuSMS
    {
        //https://yq.aliyun.com/articles/242199?spm=a2c4e.11153940.blogcont343313.14.171e6917ro9Op6
        //https://blog.csdn.net/u014026084/article/details/78563036

        /// <summary>
        /// <summary>
        /// Url
        /// </summary>
        private static string Url = "http://gw.api.taobao.com/router/rest";
        /// AppKey
        /// </summary>
        private static string AppKey = "AppKey";
        /// <summary>
        /// AppSecret
        /// </summary>
        private static string AppSecret = "AppSecret";

        /// <summary>
        ///  发短信通用接口
        /// </summary>
        /// <param name="extend">公共回传参数，
        /// 在“消息返回”中会透传回该参数；举例：用户可以传入自己下级的会员ID，在消息返回时，
        /// 该会员ID会包含在内，用户可以根据该会员ID识别是哪位会员使用了你的应用</param>
        /// <param name="smsFreeSignName">短信签名</param>
        /// <param name="code">短信模板ID</param>
        /// <param name="smsParam">短信模板变量“验证码${code}，您正在进行${product}身份验证，打死不要告诉别人哦！”，
        /// 传参时需传入{"code":"1234","product":"alidayu"}</param>
        /// <param name="mobile">接收的手机号码,群发短信需传入多个号码，以英文逗号分隔，一次调用最多传入200个号码。</param>
        /// <returns>Json格式</returns> 
        public static string SendSms(string extend, string smsFreeSignName, string code, string smsParam, string mobile)
        {
            ITopClient client = new DefaultTopClient(Url, AppKey, AppSecret);
            AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
            req.Extend = extend;
            req.SmsType = "normal";
            req.SmsFreeSignName = smsFreeSignName;
            req.SmsParam = smsParam;
            req.RecNum = mobile;
            req.SmsTemplateCode = code;
            AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
            return rsp.SubErrMsg;
        }
    }
}
