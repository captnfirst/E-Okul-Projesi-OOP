namespace E_Okul
{
    partial class durum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(durum));
            this.ogrenci = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dersler = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devamsizlik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sinif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenci
            // 
            this.ogrenci.FormattingEnabled = true;
            this.ogrenci.Location = new System.Drawing.Point(198, 39);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(175, 21);
            this.ogrenci.TabIndex = 40;
            this.ogrenci.SelectedIndexChanged += new System.EventHandler(this.ogrenci_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 39);
            this.label3.TabIndex = 39;
            this.label3.Text = "Öğrenci :";
            // 
            // dersler
            // 
            this.dersler.AutoSize = true;
            this.dersler.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dersler.Location = new System.Drawing.Point(12, 223);
            this.dersler.Name = "dersler";
            this.dersler.Size = new System.Drawing.Size(156, 39);
            this.dersler.TabIndex = 45;
            this.dersler.Text = "DERSLER";
            // 
            // no
            // 
            this.no.Enabled = false;
            this.no.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.no.Location = new System.Drawing.Point(565, 97);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(338, 36);
            this.no.TabIndex = 53;
            this.no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soyad
            // 
            this.soyad.Enabled = false;
            this.soyad.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(565, 54);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(338, 36);
            this.soyad.TabIndex = 51;
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ad
            // 
            this.ad.Enabled = false;
            this.ad.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(565, 12);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(338, 36);
            this.ad.TabIndex = 49;
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 39);
            this.label5.TabIndex = 52;
            this.label5.Text = "No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 39);
            this.label4.TabIndex = 50;
            this.label4.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 39);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 39);
            this.label1.TabIndex = 54;
            this.label1.Text = "Devamsızlık :";
            // 
            // devamsizlik
            // 
            this.devamsizlik.Enabled = false;
            this.devamsizlik.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devamsizlik.Location = new System.Drawing.Point(565, 223);
            this.devamsizlik.Name = "devamsizlik";
            this.devamsizlik.Size = new System.Drawing.Size(338, 36);
            this.devamsizlik.TabIndex = 55;
            this.devamsizlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 39);
            this.label6.TabIndex = 56;
            this.label6.Text = "Durum :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(565, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 36);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sinif
            // 
            this.sinif.Enabled = false;
            this.sinif.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinif.Location = new System.Drawing.Point(565, 139);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(338, 36);
            this.sinif.TabIndex = 59;
            this.sinif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 39);
            this.label7.TabIndex = 58;
            this.label7.Text = "Sınıf :";
            // 
            // bolum
            // 
            this.bolum.Enabled = false;
            this.bolum.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolum.Location = new System.Drawing.Point(565, 181);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(338, 36);
            this.bolum.TabIndex = 61;
            this.bolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 39);
            this.label8.TabIndex = 60;
            this.label8.Text = "Bölüm :";
            // 
            // durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 418);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sinif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.devamsizlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dersler);
            this.Controls.Add(this.ogrenci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "durum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durum";
            this.Load += new System.EventHandler(this.Durum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ogrenci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dersler;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox devamsizlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox sinif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bolum;
        private System.Windows.Forms.Label label8;
    }
}