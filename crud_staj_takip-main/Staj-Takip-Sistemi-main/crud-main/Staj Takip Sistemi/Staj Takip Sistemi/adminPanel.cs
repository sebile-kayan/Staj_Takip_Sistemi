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
    public partial class adminPanel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti;
        public adminPanel()
        {
            InitializeComponent();
        }
        private void kayitGetirYonetici() {

            this.con = sqlbaglanti.baglanti;
            con.Open();
            string kayit = "SELECT yoneticiID, yoneticiAd , yoneticiSoyad , yoneticiEposta , yoneticiSifre from Yonetici with(nolock) ";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void kayitGetirPersonel()
        {

            this.con = sqlbaglanti.baglanti;
            con.Open();
            string kayit = "SELECT PersonelID , personelAd , personelSoyad , personelNo , personelSifre from Personel with(nolock) ";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void adminPanel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'staj_Takip_SistemiDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.staj_Takip_SistemiDataSet.Personel);
            // TODO: Bu kod satırı 'staj_Takip_SistemiDataSet.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminGiris admingiris = new adminGiris();
            admingiris.Show();
            this.Hide();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.con = sqlbaglanti.baglanti;
                con.Open();
                string kayit = "SELECT yoneticiID, yoneticiAd , yoneticiSoyad , yoneticiEposta , yoneticiSifre from Yonetici with(nolock) ";
                SqlCommand komut = new SqlCommand(kayit, con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;
                con.Close();

                yoneticiSil.Visible = true;
                personelSil.Visible = false;
                personelEkle.Visible = false;
                personelIDlbl.Visible = false;
                personelIDtxt.Visible = false;
                yon2.Visible = true;
                yon3.Visible = true;
                yoneticiEkle.Visible = true;
                yonticiIDlbl.Visible = true;
                yoneticiIDtxt.Visible = true;
                yoneticiYazi.Visible = true;
                yon4.Visible = true;
                yon5.Visible = true;
                personelYazi.Visible = false;
                yoneticiAdTxt.Visible = true;
                yoneticiSoyadTxt.Visible = true;
                yoneticiEpostaTxt.Visible = true;
                yoneticiSifreTxt.Visible = true;
                per2.Visible = false;
                per3.Visible = false;
                per4.Visible = false;
                per5.Visible = false;
                personelAdTxt.Visible = false;
                personelSoyadTxt.Visible = false;
                personelSifreTxt.Visible = false;
                personelNoTxt.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.con = sqlbaglanti.baglanti;
                con.Open();
                string kayit = "SELECT PersonelID , personelAd , personelSoyad , personelNo , personelSifre from Personel with(nolock)";
                SqlCommand komut = new SqlCommand(kayit, con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;
                con.Close();
                personelSil.Visible = true;
                per2.Visible = true;
                per3.Visible = true;
                per4.Visible = true;
                per5.Visible = true;
                personelIDtxt.Visible = true;
                personelIDlbl.Visible = true;
                yoneticiSil.Visible = false;
                yoneticiEkle.Visible = false;
                yoneticiIDtxt.Visible = false;
                yonticiIDlbl.Visible = false;
                yoneticiYazi.Visible = false;
                personelYazi.Visible = true;
                personelAdTxt.Visible = true;
                personelSoyadTxt.Visible = true;
                personelSifreTxt.Visible = true;
                personelNoTxt.Visible = true;
                personelEkle.Visible = true;
                yon2.Visible = false;
                yon3.Visible = false;
                yon4.Visible = false;
                yon5.Visible = false;
                yoneticiAdTxt.Visible = false;
                yoneticiSoyadTxt.Visible = false;
                yoneticiEpostaTxt.Visible = false;
                yoneticiSifreTxt.Visible = false;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stajyerAdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void personelEkle_Click(object sender, EventArgs e)
        {
            //if else yapısı olacak
            string sorgu = "Insert into Personel(personelAd ,personelSoyad ,personelNo , personelSifre) " +
                           "Values (@personelAd , @personelSoyad , @personelNo , @personelSifre)";
            this.con = sqlbaglanti.baglanti;
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@personelAd", personelAdTxt.Text);
            cmd.Parameters.AddWithValue("@personelSoyad", personelSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@personelNo",Convert.ToInt32(personelNoTxt.Text));
            cmd.Parameters.AddWithValue("@personelSifre", personelSifreTxt.Text);

            con.Close();
            kayitGetirPersonel();
        }   

        private void yoneticiEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Yonetici(yoneticiAd , yoneticiSoyad , yoneticiEposta,yoneticiSifre) " +
                          "Values (@yoneticiAd , @yoneticiSoyad , @yoneticiEposta , @yoneticiSifre)";
            this.con = sqlbaglanti.baglanti;
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@yoneticiAd", yoneticiAdTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiSoyad", yoneticiSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiEposta", yoneticiEpostaTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiSifre", yoneticiSifreTxt.Text);
            con.Close();
            kayitGetirYonetici();
        }

        private void personelSil_Click(object sender, EventArgs e)
        {
            this.con = sqlbaglanti.baglanti;
            con.Open();

            string kayit = "delete from Personel where personelID = @silPersonelID ";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@silPersonelID", personelIDtxt.Text);
            cmd.ExecuteNonQuery();
            string kayit1 = "SELECT personelID, personelAd , personelSoyad , personelNo , personelSifre from Personel with(nolock) ";
            SqlCommand komut = new SqlCommand(kayit1, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            kayitGetirPersonel();
        }

        private void yoneticiSil_Click(object sender, EventArgs e)
        {
            this.con = sqlbaglanti.baglanti;
            con.Open();

            string kayit = "delete from Yonetici where yoneticiID = @silYoneticiID ";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@silYoneticiID", yoneticiIDtxt.Text);
            cmd.ExecuteNonQuery();
            string kayit1 = "SELECT yoneticiID, yoneticiAd , yoneticiSoyad , yoneticiEposta , yoneticiSifre from Yonetici with(nolock) ";
            SqlCommand komut = new SqlCommand(kayit1,con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;

            con.Close();
        }
       
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                yoneticiIDtxt.Text = DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                yoneticiAdTxt.Text = DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                yoneticiSoyadTxt.Text = DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                yoneticiEpostaTxt.Text = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                yoneticiSifreTxt.Text = DataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                personelIDtxt.Text = DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                personelAdTxt.Text = DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                personelSoyadTxt.Text = DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                personelNoTxt.Text = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                personelSifreTxt.Text = DataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void personelNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                MessageBox.Show("Lütfen sadece rakam kullanınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yoneticiYazi_Click(object sender, EventArgs e)
        {

        }
    }
}
