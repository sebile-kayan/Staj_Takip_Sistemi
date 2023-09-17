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
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti;
        private void picEye_Click(object sender, EventArgs e)
        {
            personelSifreTxt.UseSystemPasswordChar = false;
            picEye.Visible = false;
            picHide.Visible = true;
        }
       /* private void girisKontrol()
        {

        }*/

        private void picHide_Click(object sender, EventArgs e)
        {
            personelSifreTxt.UseSystemPasswordChar = true;
            picEye.Visible = true;
            picHide.Visible = false;
        }

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void personelNoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void personelBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Personel WITH(NOLOCK) where personelNo=@user AND  personelSifre=@pass";
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
					personelPanel pPanel = new personelPanel();
					pPanel.Show();
					this.Hide();

				}
				else
				{
					labelError.Visible = true;
					picError.Visible = true;
					label3.Visible = false;
				}
			}
            catch (Exception Unhandled) 
            {
				labelError.Visible = false;
				label3.Visible = true;
				picError.Visible = true;
			}
			
			con.Close();
			
            
        }

		private void labelError_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			girisSayfasi gsgiris = new girisSayfasi();
			gsgiris.Show();
			this.Hide();
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

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void personelSifreTxt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
