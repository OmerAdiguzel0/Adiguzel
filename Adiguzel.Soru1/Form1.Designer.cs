
namespace Adiguzel.Soru1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstSol = new System.Windows.Forms.ListBox();
            this.lstSag = new System.Windows.Forms.ListBox();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSol
            // 
            this.lstSol.FormattingEnabled = true;
            this.lstSol.ItemHeight = 15;
            this.lstSol.Location = new System.Drawing.Point(36, 93);
            this.lstSol.Name = "lstSol";
            this.lstSol.Size = new System.Drawing.Size(209, 319);
            this.lstSol.TabIndex = 2;
            this.lstSol.SelectedIndexChanged += new System.EventHandler(this.lstSol_SelectedIndexChanged);
            // 
            // lstSag
            // 
            this.lstSag.FormattingEnabled = true;
            this.lstSag.ItemHeight = 15;
            this.lstSag.Location = new System.Drawing.Point(374, 93);
            this.lstSag.Name = "lstSag";
            this.lstSag.Size = new System.Drawing.Size(209, 319);
            this.lstSag.TabIndex = 5;
            this.lstSag.SelectedIndexChanged += new System.EventHandler(this.lstSag_SelectedIndexChanged);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(263, 261);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(92, 37);
            this.btnSol.TabIndex = 4;
            this.btnSol.Text = "<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(263, 194);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(92, 37);
            this.btnSag.TabIndex = 3;
            this.btnSag.Text = ">>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(604, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(604, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "↓";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 460);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.lstSag);
            this.Controls.Add(this.lstSol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(699, 499);
            this.MinimumSize = new System.Drawing.Size(699, 499);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSol;
        private System.Windows.Forms.ListBox lstSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

