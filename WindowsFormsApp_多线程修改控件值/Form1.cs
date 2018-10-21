using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_多线程修改控件值
{
    public partial class Form1 : Form
    {
        private Random r1 = new Random();
        private Random r2 = new Random();
        private Random r3 = new Random();
        private Random r4 = new Random();
        private Random r5 = new Random();

        Thread thread1, thread2;
        Class1 class1;
       
        public Form1()
        {
            InitializeComponent();
            this.class1 = new Class1(this);
            simpleButton1.Click += new EventHandler(SimpleButton1_Click);
        }

        /// <summary>
        /// 开始线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            class1.shouldStop = false;
            thread1 = new Thread(class1.Method1);
            thread1.IsBackground = true;
            thread2 = new Thread(class1.Method2);
            thread2.IsBackground = true;
            thread1.Start("a method start\n");
            thread2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.textBox1.Text = r1.Next(0, 100).ToString();
            return;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private delegate void AddMessageDelete(string message);

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        public void AddMessage(string message)
        {
            if(textBox1.InvokeRequired)
            {
                AddMessageDelete d = AddMessage;
                textBox1.Invoke(d, message);
            }
            else
            {
                textBox1.AppendText(message);
            }
        }
    }
}
