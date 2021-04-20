
namespace Adiguzel.Soru3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxKisi = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtboxBolum = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtboxSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtboxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.gboxKisiListesi = new System.Windows.Forms.GroupBox();
            this.lblBolum2 = new System.Windows.Forms.Label();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lstBolum = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gboxKisi.SuspendLayout();
            this.gboxKisiListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxKisi
            // 
            this.gboxKisi.Controls.Add(this.btnGuncelle);
            this.gboxKisi.Controls.Add(this.txtboxBolum);
            this.gboxKisi.Controls.Add(this.btnSil);
            this.gboxKisi.Controls.Add(this.txtboxSoyad);
            this.gboxKisi.Controls.Add(this.btnEkle);
            this.gboxKisi.Controls.Add(this.txtboxAd);
            this.gboxKisi.Controls.Add(this.lblAd);
            this.gboxKisi.Controls.Add(this.lblBolum);
            this.gboxKisi.Controls.Add(this.lblSoyad);
            this.gboxKisi.Location = new System.Drawing.Point(12, 12);
            this.gboxKisi.Name = "gboxKisi";
            this.gboxKisi.Size = new System.Drawing.Size(334, 179);
            this.gboxKisi.TabIndex = 0;
            this.gboxKisi.TabStop = false;
            this.gboxKisi.Text = "Kişi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(221, 134);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtboxBolum
            // 
            this.txtboxBolum.Location = new System.Drawing.Point(107, 88);
            this.txtboxBolum.Name = "txtboxBolum";
            this.txtboxBolum.Size = new System.Drawing.Size(183, 23);
            this.txtboxBolum.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(141, 134);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtboxSoyad
            // 
            this.txtboxSoyad.Location = new System.Drawing.Point(107, 57);
            this.txtboxSoyad.Name = "txtboxSoyad";
            this.txtboxSoyad.Size = new System.Drawing.Size(183, 23);
            this.txtboxSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(61, 134);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(74, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtboxAd
            // 
            this.txtboxAd.Location = new System.Drawing.Point(107, 25);
            this.txtboxAd.Name = "txtboxAd";
            this.txtboxAd.Size = new System.Drawing.Size(183, 23);
            this.txtboxAd.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(33, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 15);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Adı : ";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(33, 91);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(55, 15);
            this.lblBolum.TabIndex = 1;
            this.lblBolum.Text = "Bölümü :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(33, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 15);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyadı :";
            // 
            // gboxKisiListesi
            // 
            this.gboxKisiListesi.Controls.Add(this.lblBolum2);
            this.gboxKisiListesi.Controls.Add(this.lstAdSoyad);
            this.gboxKisiListesi.Controls.Add(this.lblAdSoyad);
            this.gboxKisiListesi.Controls.Add(this.lstBolum);
            this.gboxKisiListesi.Location = new System.Drawing.Point(12, 197);
            this.gboxKisiListesi.Name = "gboxKisiListesi";
            this.gboxKisiListesi.Size = new System.Drawing.Size(334, 338);
            this.gboxKisiListesi.TabIndex = 1;
            this.gboxKisiListesi.TabStop = false;
            this.gboxKisiListesi.Text = "Kişi Listesi";
            // 
            // lblBolum2
            // 
            this.lblBolum2.AutoSize = true;
            this.lblBolum2.Location = new System.Drawing.Point(174, 40);
            this.lblBolum2.Name = "lblBolum2";
            this.lblBolum2.Size = new System.Drawing.Size(55, 15);
            this.lblBolum2.TabIndex = 2;
            this.lblBolum2.Text = "Bölümü :";
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.ItemHeight = 15;
            this.lstAdSoyad.Location = new System.Drawing.Point(6, 58);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(143, 259);
            this.lstAdSoyad.TabIndex = 6;
            this.lstAdSoyad.SelectedIndexChanged += new System.EventHandler(this.lstAdSoyad_SelectedIndexChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 40);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(69, 15);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Adı Soyadı :";
            // 
            // lstBolum
            // 
            this.lstBolum.FormattingEnabled = true;
            this.lstBolum.ItemHeight = 15;
            this.lstBolum.Location = new System.Drawing.Point(174, 58);
            this.lstBolum.Name = "lstBolum";
            this.lstBolum.Size = new System.Drawing.Size(143, 259);
            this.lstBolum.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 12);
            this.button1.MaximumSize = new System.Drawing.Size(73, 24);
            this.button1.MinimumSize = new System.Drawing.Size(73, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Renk Seç";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Font Seç";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboxKisiListesi);
            this.Controls.Add(this.gboxKisi);
            this.MaximumSize = new System.Drawing.Size(510, 586);
            this.MinimumSize = new System.Drawing.Size(510, 586);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxKisi.ResumeLayout(false);
            this.gboxKisi.PerformLayout();
            this.gboxKisiListesi.ResumeLayout(false);
            this.gboxKisiListesi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxKisi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtboxBolum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtboxSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtboxAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.GroupBox gboxKisiListesi;
        private System.Windows.Forms.Label lblBolum2;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.ListBox lstBolum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

