
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adiguzel.Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Van");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Kayseri");
            comboBox1.Items.Add("Hakkari");
            comboBox1.Items.Add("Bilecik");
            comboBox1.Items.Add("Muş"); 
            comboBox1.Items.Add("Ankara"); 
            comboBox1.Items.Add("Bursa");
        }
    }
}
