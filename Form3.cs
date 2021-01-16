using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Browser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gecmiş();

        }
        private void gecmiş()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("Geçmiş.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("Geçmiş.txt");
            dosya.Write("");
            dosya.Close();
            listBox1.Items.Clear();
        }
    }
}
     
