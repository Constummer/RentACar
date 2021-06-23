using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RentACar
{
    public partial class GirisEkrani : Form
    {
        SqlConnection con;
        String connectionString;
        SqlCommand cmd;
        SqlDataReader dr;


        public GirisEkrani()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void GirisButonu_Click(object sender, EventArgs e)
        {
            //mssql bağlantı stringi buraya tanımlanmalı
            connectionString = "Data Source=DESKTOP-OMDHQM5;Initial Catalog=AracKiralamaDB;Integrated Security=True;";

            string user = textBox1.Text;
            string pass = textBox2.Text;
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Users where UserName='" + user + "' AND Passwords='" + pass + "'";

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    if (dr.GetValue(2).ToString() == "admin")
                    {
                        AdminEkrani AdminEkrani = new AdminEkrani();
                        this.Hide();
                        AdminEkrani.Show();

                    }
                    else if (dr.GetValue(2).ToString() == "calisan")
                    {
                        CalisanEkrani CalisanEkrani = new CalisanEkrani();
                        this.Hide();
                        CalisanEkrani.Show();

                    }
                    else if (dr.GetValue(2).ToString() == "kullanici")
                    {
                        KullaniciEkrani KullaniciEkrani = new KullaniciEkrani();
                        this.Hide();
                        KullaniciEkrani.Show();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show("Bir hata oluştu: " + s.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GirisButonu_Click(sender, e);
        }

        private void MisafirButonu_Click(object sender, EventArgs e)
        {
            KullaniciEkrani KullaniciEkrani = new KullaniciEkrani();
            this.Hide();
            KullaniciEkrani.Show();
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araç Kiralama Programı");
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim İçin Adminle İletişime Geçiniz");
        }

        private void programVersiyonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 0.0.1.1423");
        }
    }


}

