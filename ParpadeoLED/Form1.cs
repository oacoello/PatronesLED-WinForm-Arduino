using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Reflection;

namespace ParpadeoLED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            progressBar1.Value = 0;
            serialPort1.WriteLine("A");
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
                Thread.Sleep(7);
            }

        }
        private void button2_Click(object sender, MouseEventArgs e)
        {
            progressBar1.Value = 0;
            serialPort1.WriteLine("B");

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
                Thread.Sleep(100);
            }
        }
    }
}
