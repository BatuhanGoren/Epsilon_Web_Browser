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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToLongDateString();
            tarihToolStripMenuItem.Text = DateTime.Now.ToLongTimeString();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.hurriyet.com.tr");
        }

        private void sabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.sabah.com.tr");
        }

        private void cNNTürkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.cnnturk.com");
        }


        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.milliyet.com.tr");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.fanatik.com.tr");
        }

        private void sözcüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.sozcu.com.tr");
        }

        private void tRTHaberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.trthaber.com.tr");
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void sarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void sayfanınKaynağınıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentText);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            string zmn = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            string zmn2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            FileStream x = new FileStream("Geçmiş.txt", FileMode.Append);
            StreamWriter w = new StreamWriter(x);
            w.WriteLine(zmn + "/" + zmn2 + "/" + webBrowser1.Url);
            w.Close();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar1.Minimum = 0;
                
            }
        }

        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
        } 
        private void gecmiş()
        {
            
            StreamReader dosya = new StreamReader("Geçmiş.txt");
            while (!dosya.EndOfStream)
            {
                MessageBox.Show(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void menüArkaPlanRenkleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siyahToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Black;
        }

        private void beyazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.White;
        }

        private void maviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Red;
        }

        private void yeşilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Green;
        }

        private void morToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Purple;
        }

        private void sarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Yellow;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.youtube.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("tr.linkedin.com");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.instagram.com");
        }
    }
}
    
     
    
