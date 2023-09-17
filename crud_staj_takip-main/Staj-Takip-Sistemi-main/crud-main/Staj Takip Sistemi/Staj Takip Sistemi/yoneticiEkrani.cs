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
    public partial class yoneticiEkrani : Form
    {
        public yoneticiEkrani()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OSNDT9I\SQLEXPRESS;Initial Catalog=stajtakip;Integrated Security=True");
        private void lblmesaj_Click(object sender, EventArgs e)
        {

        }
        private void kayitGetirStajyer()
        {
            string kayit = "SELECT  s.DepartmanID, s.personelID, s.stajyerNo,  s.bitisTarih , s.baslangicTarih  , s.stajyerSoyad , s.stajyerAd ,s.stajyerID  from Stajyer as s WITH(NOLOCK) ";
            //Stajyer tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            stajyerData.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
        private void kayıtsilButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string kayit = "delete from Stajyer  where stajyerID = @silID ";
            cmd = new SqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@silID", stajyerIDtxt.Text);
            cmd.ExecuteNonQuery();
            kayitGetirStajyer();
            baglanti.Close();
            
            MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void yoneticiEkrani_Load(object sender, EventArgs e)
        {
            saatlabel.Text = DateTime.Now.ToLongDateString();
            kayitGetirStajyer();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yoneticiGiris yoneticigiris = new yoneticiGiris();
            yoneticigiris.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void stajyerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stajyerIDtxt.Text = stajyerData.Rows[e.RowIndex].Cells[7].Value.ToString();
            stajyerAdTxt.Text = stajyerData.Rows[e.RowIndex].Cells[6].Value.ToString();
            stajyerSoyadTxt.Text = stajyerData.Rows[e.RowIndex].Cells[5].Value.ToString();
            baslangicTxt.Text = stajyerData.Rows[e.RowIndex].Cells[4].Value.ToString();
            bitisTxt.Text = stajyerData.Rows[e.RowIndex].Cells[3].Value.ToString();
            stajyerNoTxt.Text = stajyerData.Rows[e.RowIndex].Cells[2].Value.ToString();
            personelTxt.Text = stajyerData.Rows[e.RowIndex].Cells[1].Value.ToString();
            departmanTxt.Text = stajyerData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void personelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void stajyerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
