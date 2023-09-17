using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
        }

		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OSNDT9I\SQLEXPRESS;Initial Catalog=stajtakip;Integrated Security=True");

		private void label1_Click(object sender, EventArgs e)
        {
			
		}

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

		private void personelNoTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(minimizeBtn, "Küçült");
		}

		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(exitBtn, "Kapat");
		}

		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sorgu = "SELECT * FROM Admin WITH(NOLOCK) where adminNick=@user AND  adminSifre=@pass";
			this.con = sqlbaglanti.baglanti;
			cmd = new SqlCommand(sorgu, con);
			cmd.Parameters.AddWithValue("@user", personelNoTxt.Text);
			cmd.Parameters.AddWithValue("@pass", personelSifreTxt.Text);
			con.Open();
			dr = cmd.ExecuteReader();
			try
			{
				if (dr.Read())
				{
					adminPanel adminpaneli = new adminPanel();
                    adminpaneli.Show();
					this.Hide();

				}
				else
				{
					labelError.Visible = true;
					picError.Visible = true;

				}
			}
			catch (Exception Unhandled)
			{
				labelError.Visible = true;
				picError.Visible = true;

			}

			con.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			girisSayfasi gsgiris = new girisSayfasi();
			gsgiris.Show();
			this.Hide();
		}

		private void picHide_Click(object sender, EventArgs e)
		{
			personelSifreTxt.UseSystemPasswordChar = true;
			picEye.Visible = true;
			picHide.Visible = false;
		}

		private void picEye_Click(object sender, EventArgs e)
		{
			personelSifreTxt.UseSystemPasswordChar = false;
			picEye.Visible = false;
			picHide.Visible = true;
		}

		private void adminGiris_Load(object sender, EventArgs e)
		{

		}
	}
}
