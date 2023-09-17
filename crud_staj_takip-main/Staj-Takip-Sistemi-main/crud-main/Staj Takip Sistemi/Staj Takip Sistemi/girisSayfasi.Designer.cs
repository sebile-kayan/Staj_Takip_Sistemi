namespace Staj_Takip_Sistemi
{
    partial class girisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisSayfasi));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.girisBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.PictureBox();
			this.minimizeBtn = new System.Windows.Forms.PictureBox();
			this.yoneticiBtn = new System.Windows.Forms.Button();
			this.adminBtn = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(377, 1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 500);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1256, 670);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(116, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// girisBtn
			// 
			this.girisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.girisBtn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.girisBtn.ForeColor = System.Drawing.Color.White;
			this.girisBtn.Location = new System.Drawing.Point(924, 583);
			this.girisBtn.Margin = new System.Windows.Forms.Padding(4);
			this.girisBtn.Name = "girisBtn";
			this.girisBtn.Size = new System.Drawing.Size(277, 50);
			this.girisBtn.TabIndex = 4;
			this.girisBtn.Text = "Personel Girişi";
			this.girisBtn.UseVisualStyleBackColor = false;
			this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
			this.exitBtn.Location = new System.Drawing.Point(1320, 15);
			this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(37, 28);
			this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.exitBtn.TabIndex = 5;
			this.exitBtn.TabStop = false;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.Location = new System.Drawing.Point(1275, 17);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(4);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(37, 21);
			this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimizeBtn.TabIndex = 6;
			this.minimizeBtn.TabStop = false;
			this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
			this.minimizeBtn.MouseHover += new System.EventHandler(this.minimizeBtn_MouseHover);
			// 
			// yoneticiBtn
			// 
			this.yoneticiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.yoneticiBtn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.yoneticiBtn.ForeColor = System.Drawing.Color.White;
			this.yoneticiBtn.Location = new System.Drawing.Point(553, 583);
			this.yoneticiBtn.Margin = new System.Windows.Forms.Padding(4);
			this.yoneticiBtn.Name = "yoneticiBtn";
			this.yoneticiBtn.Size = new System.Drawing.Size(277, 50);
			this.yoneticiBtn.TabIndex = 7;
			this.yoneticiBtn.Text = "Yönetici Girişi";
			this.yoneticiBtn.UseVisualStyleBackColor = false;
			this.yoneticiBtn.Click += new System.EventHandler(this.yoneticiBtn_Click);
			// 
			// adminBtn
			// 
			this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.adminBtn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.adminBtn.ForeColor = System.Drawing.Color.White;
			this.adminBtn.Location = new System.Drawing.Point(172, 583);
			this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
			this.adminBtn.Name = "adminBtn";
			this.adminBtn.Size = new System.Drawing.Size(277, 50);
			this.adminBtn.TabIndex = 8;
			this.adminBtn.Text = "Admin Girişi";
			this.adminBtn.UseVisualStyleBackColor = false;
			this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
			// 
			// girisSayfasi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
			this.ClientSize = new System.Drawing.Size(1373, 769);
			this.Controls.Add(this.adminBtn);
			this.Controls.Add(this.yoneticiBtn);
			this.Controls.Add(this.minimizeBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.girisBtn);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "girisSayfasi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Button yoneticiBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

