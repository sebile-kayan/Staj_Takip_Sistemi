using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
	public partial class personelPanel : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti;
		public personelPanel()
		{
			InitializeComponent();
		}

		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(exitBtn, "Kapat");
		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(minimizeBtn, "Küçült");
		}

		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			kullaniciGiris kGiris = new kullaniciGiris();
			kGiris.Show();
			this.Hide();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
		}

		private void button2_Click(object sender, EventArgs e)
		{
			stajyerBilgi sBilgi = new stajyerBilgi();
			sBilgi.Show();
			this.Hide();
		}

		private void ekleButton_Click(object sender, EventArgs e)
		{

			if (stajyerAdtxt.Text == "" || stajyerSoyadtxt.Text == "" || stajyerDepartmantxt.Text=="" || stajyerNotxt.Text == "" || startTime.Text == ""|| finishTime.Text == "")
			{
                MessageBox.Show("Eksik bilgileri tamamlayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
			{

                string sorgu = "Insert into Stajyer(stajyerAd, stajyerSoyad, DepartmanID, stajyerNo, baslangicTarih, bitisTarih) " +
                               "Values (@name, @surname, @departman, @stajyerNo, @baslangicTarih, @bitisTarih);";
                this.con = sqlbaglanti.baglanti;
                con.Open();
                cmd = new SqlCommand(sorgu, con);

                cmd.Parameters.AddWithValue("@name", stajyerAdtxt.Text);
                cmd.Parameters.AddWithValue("@surname", stajyerSoyadtxt.Text);
                cmd.Parameters.AddWithValue("@departman", Convert.ToInt32(stajyerDepartmantxt.Text));
                cmd.Parameters.AddWithValue("@stajyerNo", Convert.ToInt32(stajyerNotxt.Text));
                cmd.Parameters.AddWithValue("@baslangicTarih", startTime.Value); // Use startTime.Value directly
                cmd.Parameters.AddWithValue("@bitisTarih", finishTime.Value);   // Use finishTime.Value directly
                cmd.ExecuteNonQuery();
                con.Close();

                try
                {
                    if (cmd != null)
                    {
                        addedLabel.Visible = true;
                        picError.Visible = true;

                    }
                    else
                    {
                        addedLabel.Visible = false;
                        picError.Visible = true;
                    }
                }
                catch (Exception Unhandled)
                {

                }
            }
		}

        private void personelPanel_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}