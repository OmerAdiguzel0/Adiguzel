using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adiguzel.Soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Bu Alan Boş Bırakılamaz!!");
            }
            else
            {
               lstSol.Items.Add(textBox1.Text);
            }
            
            textBox1.Clear();
            textBox1.Focus();
            buttonkontrol();
        }
        void buttonkontrol()
        {
             btnSag.Enabled = lstSol.SelectedIndex > -1;
             btnSol.Enabled = lstSag.SelectedIndex > -1;

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonkontrol();
        }

        private void lstSol_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonkontrol();
        }

        private void lstSag_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonkontrol();
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            lstSag.Items.Add(lstSol.SelectedItem);
            lstSol.Items.Remove(lstSol.SelectedItem);
           
            buttonkontrol();
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            lstSol.Items.Add(lstSag.SelectedItem);
            lstSag.Items.Remove(lstSag.SelectedItem);

            buttonkontrol();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                int a = lstSag.SelectedIndex;
                if(a>0 & a!= -1)
                {
                    lstSag.Items.Insert(a - 1, lstSag.Items[a]);
                    lstSag.Items.RemoveAt(a + 1);
                    lstSag.SelectedIndex = a - 1;
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                int a = lstSag.SelectedIndex;
                if (a != -1 & a < lstSag.Items.Count - 1)
                {
                    lstSag.Items.Insert(a + 2, lstSag.Items[a]);
                    lstSag.Items.RemoveAt(a);
                    lstSag.SelectedIndex = a + 1;
                }
            
        }
    }
}
