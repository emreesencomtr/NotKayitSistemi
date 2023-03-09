
namespace NotKayitSistemi
{
    partial class FrmOgrenciDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sinav1 = new System.Windows.Forms.Label();
            this.AdSoyad = new System.Windows.Forms.Label();
            this.Numara = new System.Windows.Forms.Label();
            this.Sinav2 = new System.Windows.Forms.Label();
            this.Sinav3 = new System.Windows.Forms.Label();
            this.Ortalama = new System.Windows.Forms.Label();
            this.Durum = new System.Windows.Forms.Label();
            this.LblSinav2 = new System.Windows.Forms.Label();
            this.LblSinav1 = new System.Windows.Forms.Label();
            this.LblSinav3 = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.LblNumara = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sinav1
            // 
            this.Sinav1.AutoSize = true;
            this.Sinav1.Location = new System.Drawing.Point(32, 89);
            this.Sinav1.Name = "Sinav1";
            this.Sinav1.Size = new System.Drawing.Size(64, 18);
            this.Sinav1.TabIndex = 0;
            this.Sinav1.Text = "Sınav 1:";
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSize = true;
            this.AdSoyad.ForeColor = System.Drawing.Color.White;
            this.AdSoyad.Location = new System.Drawing.Point(12, 24);
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Size = new System.Drawing.Size(84, 18);
            this.AdSoyad.TabIndex = 1;
            this.AdSoyad.Text = "Adı Soyad:";
            this.AdSoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // Numara
            // 
            this.Numara.AutoSize = true;
            this.Numara.Location = new System.Drawing.Point(25, 53);
            this.Numara.Name = "Numara";
            this.Numara.Size = new System.Drawing.Size(71, 18);
            this.Numara.TabIndex = 2;
            this.Numara.Text = "Numara:";
            // 
            // Sinav2
            // 
            this.Sinav2.AutoSize = true;
            this.Sinav2.Location = new System.Drawing.Point(31, 119);
            this.Sinav2.Name = "Sinav2";
            this.Sinav2.Size = new System.Drawing.Size(65, 18);
            this.Sinav2.TabIndex = 3;
            this.Sinav2.Text = "Sınav 2:";
            // 
            // Sinav3
            // 
            this.Sinav3.AutoSize = true;
            this.Sinav3.Location = new System.Drawing.Point(31, 150);
            this.Sinav3.Name = "Sinav3";
            this.Sinav3.Size = new System.Drawing.Size(65, 18);
            this.Sinav3.TabIndex = 4;
            this.Sinav3.Text = "Sınav 3:";
            // 
            // Ortalama
            // 
            this.Ortalama.AutoSize = true;
            this.Ortalama.Location = new System.Drawing.Point(16, 182);
            this.Ortalama.Name = "Ortalama";
            this.Ortalama.Size = new System.Drawing.Size(80, 18);
            this.Ortalama.TabIndex = 5;
            this.Ortalama.Text = "Ortalama:";
            // 
            // Durum
            // 
            this.Durum.AutoSize = true;
            this.Durum.Location = new System.Drawing.Point(33, 212);
            this.Durum.Name = "Durum";
            this.Durum.Size = new System.Drawing.Size(63, 18);
            this.Durum.TabIndex = 6;
            this.Durum.Text = "Durum:";
            // 
            // LblSinav2
            // 
            this.LblSinav2.AutoSize = true;
            this.LblSinav2.Location = new System.Drawing.Point(91, 119);
            this.LblSinav2.Name = "LblSinav2";
            this.LblSinav2.Size = new System.Drawing.Size(28, 18);
            this.LblSinav2.TabIndex = 7;
            this.LblSinav2.Text = "00";
            // 
            // LblSinav1
            // 
            this.LblSinav1.AutoSize = true;
            this.LblSinav1.Location = new System.Drawing.Point(91, 89);
            this.LblSinav1.Name = "LblSinav1";
            this.LblSinav1.Size = new System.Drawing.Size(28, 18);
            this.LblSinav1.TabIndex = 8;
            this.LblSinav1.Text = "00";
            // 
            // LblSinav3
            // 
            this.LblSinav3.AutoSize = true;
            this.LblSinav3.Location = new System.Drawing.Point(91, 150);
            this.LblSinav3.Name = "LblSinav3";
            this.LblSinav3.Size = new System.Drawing.Size(28, 18);
            this.LblSinav3.TabIndex = 9;
            this.LblSinav3.Text = "00";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(91, 182);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(28, 18);
            this.LblOrtalama.TabIndex = 10;
            this.LblOrtalama.Text = "00";
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(91, 53);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(48, 18);
            this.LblNumara.TabIndex = 11;
            this.LblNumara.Text = "0000";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(91, 212);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(52, 18);
            this.LblDurum.TabIndex = 12;
            this.LblDurum.Text = "NULL";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(91, 24);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(52, 18);
            this.LblAdSoyad.TabIndex = 13;
            this.LblAdSoyad.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(241, 259);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblNumara);
            this.Controls.Add(this.LblOrtalama);
            this.Controls.Add(this.LblSinav3);
            this.Controls.Add(this.LblSinav1);
            this.Controls.Add(this.LblSinav2);
            this.Controls.Add(this.Durum);
            this.Controls.Add(this.Ortalama);
            this.Controls.Add(this.Sinav3);
            this.Controls.Add(this.Sinav2);
            this.Controls.Add(this.Numara);
            this.Controls.Add(this.AdSoyad);
            this.Controls.Add(this.Sinav1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgrenciDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenciDetay";
            this.Load += new System.EventHandler(this.FrmOgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sinav1;
        private System.Windows.Forms.Label AdSoyad;
        private System.Windows.Forms.Label Numara;
        private System.Windows.Forms.Label Sinav2;
        private System.Windows.Forms.Label Sinav3;
        private System.Windows.Forms.Label Ortalama;
        private System.Windows.Forms.Label Durum;
        private System.Windows.Forms.Label LblSinav2;
        private System.Windows.Forms.Label LblSinav1;
        private System.Windows.Forms.Label LblSinav3;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label LblAdSoyad;
    }
}