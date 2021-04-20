using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adiguzel.Soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rd = new Random();
            sayi = rd.Next(0, listBox1.Items.Count);
            label1.Text = listBox1.Items[sayi].ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if(txtboxAdSoyad.Text == "")
            {
                MessageBox.Show("Ad Soyad Girmek Zorunludur!!");
            }
            else
            {
               listBox1.Items.Add(txtboxAdSoyad.Text);
            }
             txtboxAdSoyad.Clear();
             buttonkontrol();
            txtboxAdSoyad.Focus();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            
        }

       
        void buttonkontrol()
        {
            btn_Sil.Enabled = listBox1.SelectedIndex > -1;
            button3.Enabled = listBox1.Items.Count > 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonkontrol();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonkontrol();
        }
    }
}
