﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Util;

namespace ConsoleApp_Helper帮助类及其测试
{
    public class QRcode
    {
        /// <summary>
        /// 生成二维码图片
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="size">图片大小</param>
        /// <param name="path">图片位置 
        /// 例如  /abc/abc/
        /// </param>
        /// <returns>返回生成的二维码图片路径</returns>
        public string Create(string str, int size, string path)
        {
            try
            {
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                //设置编码模式
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                //设置编码测量度
                qrCodeEncoder.QRCodeScale = size;
                //设置编码版本
                qrCodeEncoder.QRCodeVersion = 8;
                //设置编码错误纠正
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                System.Drawing.Image image = qrCodeEncoder.Encode(str);

                #region 貌似是网站后台接收的图片
                //string filename = "~" + path + Guid.NewGuid() + ".jpg";

                //image.Save(HttpContext.Current.Request.MapPath(filename));

                //return filename.Replace("~", "");
                #endregion

                #region 保存图片到本地
                string filename = "D:" + Guid.NewGuid() + ".jpg";
                image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                return filename;
                #endregion

            }
            catch (Exception ex)
            {
                return "";
            }

        }

        /// <summary>    
        /// 调用此函数后使此两种图片合并，类似相册，有个    
        /// 背景图，中间贴自己的目标图片    
        /// </summary>    
        /// <param name="imgBack">粘贴的源图片</param>    
        /// <param name="destImg">粘贴的目标图片</param>    
        public static System.Drawing.Image CombinImage(System.Drawing.Image imgBack, string destImg)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(destImg);        //照片图片      
            if (img.Height != 65 || img.Width != 65)
            {
                img = KiResizeImage(img, 65, 65, 0);
            }
            Graphics g = Graphics.FromImage(imgBack);

            g.DrawImage(imgBack, 0, 0, imgBack.Width, imgBack.Height);      //g.DrawImage(imgBack, 0, 0, 相框宽, 相框高);     

            //g.FillRectangle(System.Drawing.Brushes.White, imgBack.Width / 2 - img.Width / 2 - 1, imgBack.Width / 2 - img.Width / 2 - 1,1,1);//相片四周刷一层黑色边框    

            //g.DrawImage(img, 照片与相框的左边距, 照片与相框的上边距, 照片宽, 照片高);    

            g.DrawImage(img, imgBack.Width / 2 - img.Width / 2, imgBack.Width / 2 - img.Width / 2, img.Width, img.Height);
            GC.Collect();
            return imgBack;
        }

        /// <summary>    
        /// Resize图片    
        /// </summary>    
        /// <param name="bmp">原始Bitmap</param>    
        /// <param name="newW">新的宽度</param>    
        /// <param name="newH">新的高度</param>    
        /// <param name="Mode">保留着，暂时未用</param>    
        /// <returns>处理以后的图片</returns>    
        public static System.Drawing.Image KiResizeImage(System.Drawing.Image bmp, int newW, int newH, int Mode)
        {
            try
            {
                System.Drawing.Image b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);
                // 插值算法的质量    
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch
            {
                return null;
            }
        }
    }
}
