namespace E_Okul
{
    partial class Sınıf_Bölüm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sınıf_Bölüm));
            this.snf_ekle = new System.Windows.Forms.Button();
            this.bolum = new System.Windows.Forms.TextBox();
            this.sinif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blm_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snf_sil = new System.Windows.Forms.Button();
            this.blm_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // snf_ekle
            // 
            this.snf_ekle.Font = new System.Drawing.Font("Myriad Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snf_ekle.Location = new System.Drawing.Point(12, 54);
            this.snf_ekle.Name = "snf_ekle";
            this.snf_ekle.Size = new System.Drawing.Size(473, 80);
            this.snf_ekle.TabIndex = 2;
            this.snf_ekle.Text = "EKLE";
            this.snf_ekle.UseVisualStyleBackColor = true;
            this.snf_ekle.Click += new System.EventHandler(this.snf_ekle_Click);
            // 
            // bolum
            // 
            this.bolum.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolum.Location = new System.Drawing.Point(626, 12);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(338, 36);
            this.bolum.TabIndex = 4;
            this.bolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sinif
            // 
            this.sinif.Font = new System.Drawing.Font("Matteo Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinif.Location = new System.Drawing.Point(147, 12);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(338, 36);
            this.sinif.TabIndex = 1;
            this.sinif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matteo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıf :";
            // 
            // blm_ekle
            // 
            this.blm_ekle.Font = new System.Drawing.Font("Myriad Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blm_ekle.Location = new System.Drawing.Point(491, 54);
            this.blm_ekle.Name = "blm_ekle";
            this.blm_ekle.Size = new System.Drawing.Size(473, 80);
            this.blm_ekle.TabIndex = 5;
            this.blm_ekle.Text = "EKLE";
            this.blm_ekle.UseVisualStyleBackColor = true;
            this.blm_ekle.Click += new System.EventHandler(this.blm_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 440);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(491, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(473, 440);
            this.dataGridView2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // snf_sil
            // 
            this.snf_sil.Font = new System.Drawing.Font("Myriad Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snf_sil.Location = new System.Drawing.Point(12, 586);
            this.snf_sil.Name = "snf_sil";
            this.snf_sil.Size = new System.Drawing.Size(473, 79);
            this.snf_sil.TabIndex = 7;
            this.snf_sil.Text = "SİL";
            this.snf_sil.UseVisualStyleBackColor = true;
            this.snf_sil.Click += new System.EventHandler(this.snf_sil_Click);
            // 
            // blm_sil
            // 
            this.blm_sil.Font = new System.Drawing.Font("Myriad Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blm_sil.Location = new System.Drawing.Point(491, 586);
            this.blm_sil.Name = "blm_sil";
            this.blm_sil.Size = new System.Drawing.Size(473, 79);
            this.blm_sil.TabIndex = 6;
            this.blm_sil.Text = "SİL";
            this.blm_sil.UseVisualStyleBackColor = true;
            this.blm_sil.Click += new System.EventHandler(this.blm_sil_Click);
            // 
            // Sınıf_Bölüm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 677);
            this.Controls.Add(this.blm_sil);
            this.Controls.Add(this.snf_sil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.blm_ekle);
            this.Controls.Add(this.snf_ekle);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.sinif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Sınıf_Bölüm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf Bölüm";
            this.Load += new System.EventHandler(this.Sınıf_Bölüm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snf_ekle;
        private System.Windows.Forms.TextBox bolum;
        private System.Windows.Forms.TextBox sinif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button blm_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button snf_sil;
        private System.Windows.Forms.Button blm_sil;
    }
}