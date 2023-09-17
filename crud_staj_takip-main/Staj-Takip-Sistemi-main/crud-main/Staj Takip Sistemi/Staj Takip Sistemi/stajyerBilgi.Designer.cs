namespace Staj_Takip_Sistemi
{
	partial class stajyerBilgi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stajyerBilgi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.stajProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajProjeDataSet = new Staj_Takip_Sistemi.stajtakipDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.stajyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerTableAdapter = new Staj_Takip_Sistemi.stajtakipDataSetTableAdapters.StajyerTableAdapter();
            this.stajyerData = new System.Windows.Forms.DataGridView();
            this.stajyerIDtxt = new System.Windows.Forms.TextBox();
            this.stajyerSoyadTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stajyerAdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmanTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.baslangicTxt = new System.Windows.Forms.TextBox();
            this.stajyerNoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bitisTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.guncelleButon = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 235);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1341, 13);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 28);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBtn.TabIndex = 24;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(1292, 20);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(37, 21);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 23;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseHover += new System.EventHandler(this.minimizeBtn_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // stajProjeDataSetBindingSource
            // 
            this.stajProjeDataSetBindingSource.DataSource = this.stajProjeDataSet;
            this.stajProjeDataSetBindingSource.Position = 0;
            // 
            // stajProjeDataSet
            // 
            this.stajProjeDataSet.DataSetName = "StajProjeDataSet";
            this.stajProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stajyerBindingSource
            // 
            this.stajyerBindingSource.DataMember = "Stajyer";
            this.stajyerBindingSource.DataSource = this.stajProjeDataSetBindingSource;
            // 
            // stajyerTableAdapter
            // 
            this.stajyerTableAdapter.ClearBeforeFill = true;
            // 
            // stajyerData
            // 
            this.stajyerData.AllowUserToAddRows = false;
            this.stajyerData.AllowUserToOrderColumns = true;
            this.stajyerData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stajyerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stajyerData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.stajyerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stajyerData.Location = new System.Drawing.Point(483, 55);
            this.stajyerData.Name = "stajyerData";
            this.stajyerData.ReadOnly = true;
            this.stajyerData.RowHeadersWidth = 51;
            this.stajyerData.Size = new System.Drawing.Size(778, 175);
            this.stajyerData.TabIndex = 44;
            this.stajyerData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stajyerData_CellClick);
            this.stajyerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stajyerData_CellContentClick);
            // 
            // stajyerIDtxt
            // 
            this.stajyerIDtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.stajyerIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stajyerIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stajyerIDtxt.Location = new System.Drawing.Point(527, 276);
            this.stajyerIDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.stajyerIDtxt.Name = "stajyerIDtxt";
            this.stajyerIDtxt.Size = new System.Drawing.Size(353, 27);
            this.stajyerIDtxt.TabIndex = 73;
            this.stajyerIDtxt.TextChanged += new System.EventHandler(this.stajyerIDtxt_TextChanged);
            // 
            // stajyerSoyadTxt
            // 
            this.stajyerSoyadTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.stajyerSoyadTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stajyerSoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stajyerSoyadTxt.Location = new System.Drawing.Point(527, 353);
            this.stajyerSoyadTxt.Margin = new System.Windows.Forms.Padding(4);
            this.stajyerSoyadTxt.Name = "stajyerSoyadTxt";
            this.stajyerSoyadTxt.Size = new System.Drawing.Size(353, 27);
            this.stajyerSoyadTxt.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(330, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 38);
            this.label5.TabIndex = 71;
            this.label5.Text = ":Stajyer ID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 38);
            this.label3.TabIndex = 69;
            this.label3.Text = ":Soyadı";
            // 
            // stajyerAdTxt
            // 
            this.stajyerAdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.stajyerAdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stajyerAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stajyerAdTxt.Location = new System.Drawing.Point(527, 314);
            this.stajyerAdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.stajyerAdTxt.Name = "stajyerAdTxt";
            this.stajyerAdTxt.Size = new System.Drawing.Size(353, 27);
            this.stajyerAdTxt.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 67;
            this.label1.Text = ":Adı";
            // 
            // departmanTxt
            // 
            this.departmanTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.departmanTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanTxt.Location = new System.Drawing.Point(527, 391);
            this.departmanTxt.Margin = new System.Windows.Forms.Padding(4);
            this.departmanTxt.Name = "departmanTxt";
            this.departmanTxt.Size = new System.Drawing.Size(353, 27);
            this.departmanTxt.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 77;
            this.label2.Text = ":Departman";
            // 
            // personelTxt
            // 
            this.personelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.personelTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelTxt.Location = new System.Drawing.Point(527, 543);
            this.personelTxt.Margin = new System.Windows.Forms.Padding(4);
            this.personelTxt.Name = "personelTxt";
            this.personelTxt.Size = new System.Drawing.Size(353, 27);
            this.personelTxt.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 541);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 38);
            this.label4.TabIndex = 85;
            this.label4.Text = ":Sorumlu Personel";
            // 
            // baslangicTxt
            // 
            this.baslangicTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.baslangicTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baslangicTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangicTxt.Location = new System.Drawing.Point(527, 428);
            this.baslangicTxt.Margin = new System.Windows.Forms.Padding(4);
            this.baslangicTxt.Name = "baslangicTxt";
            this.baslangicTxt.Size = new System.Drawing.Size(353, 27);
            this.baslangicTxt.TabIndex = 84;
            // 
            // stajyerNoTxt
            // 
            this.stajyerNoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.stajyerNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stajyerNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stajyerNoTxt.Location = new System.Drawing.Point(527, 505);
            this.stajyerNoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.stajyerNoTxt.Name = "stajyerNoTxt";
            this.stajyerNoTxt.Size = new System.Drawing.Size(353, 27);
            this.stajyerNoTxt.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 38);
            this.label6.TabIndex = 82;
            this.label6.Text = ":Başlangıç Tarihi";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(330, 503);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 38);
            this.label7.TabIndex = 81;
            this.label7.Text = ":Stajyer No";
            // 
            // bitisTxt
            // 
            this.bitisTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.bitisTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bitisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTxt.Location = new System.Drawing.Point(527, 466);
            this.bitisTxt.Margin = new System.Windows.Forms.Padding(4);
            this.bitisTxt.Name = "bitisTxt";
            this.bitisTxt.Size = new System.Drawing.Size(353, 27);
            this.bitisTxt.TabIndex = 80;
            this.bitisTxt.TextChanged += new System.EventHandler(this.bitisTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(330, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 38);
            this.label8.TabIndex = 79;
            this.label8.Text = ":Bitiş Tarihi";
            // 
            // lblmesaj
            // 
            this.lblmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesaj.ForeColor = System.Drawing.Color.White;
            this.lblmesaj.Location = new System.Drawing.Point(928, 413);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(175, 23);
            this.lblmesaj.TabIndex = 87;
            this.lblmesaj.Text = "!Kayıt Güncellendi";
            this.lblmesaj.Visible = false;
            // 
            // guncelleButon
            // 
            this.guncelleButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.guncelleButon.FlatAppearance.BorderSize = 0;
            this.guncelleButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guncelleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guncelleButon.Location = new System.Drawing.Point(967, 306);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(121, 30);
            this.guncelleButon.TabIndex = 90;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = false;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteButton.Location = new System.Drawing.Point(967, 359);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 30);
            this.deleteButton.TabIndex = 91;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // stajyerBilgi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1391, 781);
            this.ControlBox = false;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.personelTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.baslangicTxt);
            this.Controls.Add(this.stajyerNoTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bitisTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departmanTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stajyerIDtxt);
            this.Controls.Add(this.stajyerSoyadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stajyerAdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stajyerData);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stajyerBilgi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stajyerBilgi";
            this.Load += new System.EventHandler(this.stajyerBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox exitBtn;
		private System.Windows.Forms.PictureBox minimizeBtn;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.BindingSource stajProjeDataSetBindingSource;
		private stajtakipDataSet stajProjeDataSet;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource stajyerBindingSource;
        private stajtakipDataSetTableAdapters.StajyerTableAdapter stajyerTableAdapter;
        private System.Windows.Forms.DataGridView stajyerData;
        private System.Windows.Forms.TextBox stajyerIDtxt;
        private System.Windows.Forms.TextBox stajyerSoyadTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stajyerAdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departmanTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personelTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baslangicTxt;
        private System.Windows.Forms.TextBox stajyerNoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bitisTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmesaj;
        private System.Windows.Forms.Button guncelleButon;
        private System.Windows.Forms.Button deleteButton;
    }
}