using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adiguzel.Soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBolum.SelectedIndex = lstAdSoyad.SelectedIndex;
            
        }




        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtboxAd.Text == "" || txtboxSoyad.Text == "" || txtboxBolum.Text == "")
            {
                MessageBox.Show("Bu Alan ya da Alanlar Boş Bırakılamaz");
            }
            else
            {

                lstAdSoyad.Items.Add(txtboxAd.Text + " " + txtboxSoyad.Text);
                lstBolum.Items.Add(txtboxBolum.Text);

            }
               
                txtboxAd.Clear();
                txtboxSoyad.Clear();
                txtboxBolum.Clear();
                txtboxAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            

            DialogResult sonuc = MessageBox.Show("Seçili Kişiyi Silmek İstiyor Musunuz","Dikkat!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(sonuc==DialogResult.Yes)
            {
                int a = lstAdSoyad.SelectedIndex;
                lstAdSoyad.Items.RemoveAt(a);
                lstBolum.Items.RemoveAt(a);

            }
            




        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtboxAd.Text == "" || txtboxSoyad.Text == "" || txtboxBolum.Text == "")
            {
                MessageBox.Show("Bu Alan ya da Alanlar Boş Bırakılamaz");
             

            }
            else
            {
                
             int a = lstAdSoyad.SelectedIndex;
             lstAdSoyad.Items[a] = (txtboxAd.Text + " " + txtboxSoyad.Text);
             lstBolum.Items[a] = (txtboxBolum.Text);
             

            }
             



             txtboxAd.Clear();
             txtboxSoyad.Clear();
             txtboxBolum.Clear();


        }

        
    }
}
