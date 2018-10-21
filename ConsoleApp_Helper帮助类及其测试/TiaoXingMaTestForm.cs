using com.google.zxing;
using com.google.zxing.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_Helper帮助类及其测试
{
    public partial class TiaoXingMaTestForm : Form
    {
        public TiaoXingMaTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MultiFormatWriter mutiWriter = new com.google.zxing.MultiFormatWriter();
                //ByteMatrix bm = mutiWriter.encode(txtMsg.Text, com.google.zxing.BarcodeFormat.QR_CODE, 300, 300);//二维码
                ByteMatrix bm = mutiWriter.encode(txtMsg.Text, com.google.zxing.BarcodeFormat.EAN_8, 300, 300);//8位数字
                Bitmap img = bm.ToBitmap();

                pictureBox1.Width = img.Width;
                pictureBox1.Height = img.Height;
                pictureBox1.Image = img;

                //自动保存图片到当前目录  
                string filename = System.Environment.CurrentDirectory + "\\QR" + DateTime.Now.Ticks.ToString() + ".jpg";
                img.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                lbshow.Text = "图片已保存到：" + filename;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
