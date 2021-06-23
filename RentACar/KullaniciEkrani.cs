using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentACar
{
    public partial class KullaniciEkrani : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataReader dr;

        public KullaniciEkrani()
        {
            InitializeComponent();
            String connectionString = "Data Source=DESKTOP-OMDHQM5;Initial Catalog=AracKiralamaDB;Integrated Security=True;MultipleActiveResultSets=true;";
            con = new SqlConnection(connectionString);
            showData();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            con.Open();

            adpt = new SqlDataAdapter("SELECT * FROM Arac;", con);
            dt = new DataTable();
            adpt.Fill(dt);

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Arac;";
            ArrayList companylist = new ArrayList();
            dr = cmd.ExecuteReader();
            // Arac tablosundaki verileri comboBox'lara ekleyen komut.

            while (dr.Read())
            {
                if ((Convert.ToString(dr["UygunlukDurumu"]) == "Uygun"))
                {
                    if (!AracMarka.Items.Contains(dr["Marka"]))
                    {
                        AracMarka.Items.Add(dr["Marka"]);
                    }

                    if (!AracModel.Items.Contains(dr["Model"]))
                    {
                        AracModel.Items.Add(dr["Model"]);
                    }

                    if (!AracVitesTuru.Items.Contains(dr["VitesTuru"].ToString().Trim(' ')))
                    {
                        AracVitesTuru.Items.Add(dr["VitesTuru"].ToString().Trim(' '));
                    }

                    if (!AracYakitTuru.Items.Contains(dr["YakitTipi"]))
                    {
                        AracYakitTuru.Items.Add(dr["YakitTipi"]);
                    }
                }
            }
            con.Close();
        }

        // tablodaki dataları dataGridView'e yazdıran kod.
        public void showData()
        {
            con.Open();
            // Kullanıcıya gösterilmemesi gereken, tabloda bulunan sütunları kaldırmak için gerekli Temp. tablo query stringi
            adpt = new SqlDataAdapter("SELECT * FROM Arac Where UygunlukDurumu='Uygun';", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["UygunlukDurumu"].Visible = false;
            con.Close();
        }
        // Data ve selectedItem değişkenlerini alarak bunları Arac tablosundaki verilere göre
        // filtreleyen ve dataGridView1'de gösteren kod.
        // Data = Arac tablosundaki sütun
        // selectedItem = ComboBox'ta seçilen item
        public void filter(string Data, string selectedItem)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("UygunlukDurumu='Uygun' AND {0} LIKE '%{1}%'", Data, selectedItem);
            dataGridView1.DataSource = DV;
            this.dataGridView1.Columns["UygunlukDurumu"].Visible = false;
        }
        // query değişkenini alarak bunu Arac tablosundaki verilere göre
        // filtreleyen ve dataGridView1'de gösteren kod.
        // query= database'de çalışacak kod.
        public void filter(string query)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = query;
            dataGridView1.DataSource = DV;
            this.dataGridView1.Columns["UygunlukDurumu"].Visible = false;
        }
        // AracMarka ComboBox'unda seçilen değer değişir ise buna uygun fitrelemeyi yapan Event.
        private void AracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            filter("Marka", AracMarka.SelectedItem.ToString());
            AracModel.Items.Clear();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = String.Format("SELECT Model FROM Arac Where Marka='{0}' ;", AracMarka.SelectedItem);
            ArrayList companylist = new ArrayList();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (!AracModel.Items.Contains(dr["Model"]))
                {
                    AracModel.Items.Add(dr["Model"]);
                }

            }
            con.Close();
        }
        // AracModel ComboBox'unda seçilen değer değişir ise buna uygun fitrelemeyi yapan Event.
        private void AracModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter("Model", AracModel.SelectedItem.ToString());
        }
        //  AracVitesTuru ComboBox'unda seçilen değer değişir ise buna uygun fitrelemeyi yapan Event.
        private void AracVitesTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter("VitesTuru", AracVitesTuru.SelectedItem.ToString());
        }
        // AracYakitTuru ComboBox'unda seçilen değer değişir ise buna uygun fitrelemeyi yapan Event.
        private void AracYakitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter("YakitTipi", AracYakitTuru.SelectedItem.ToString());
        }
        // Filtreleme tuşudur, combobox'larda seçilen seçeneklere göre dataları bir stringe atayarak
        // tablodaki nesneleri seçeneklere göre filtreler.
        private void AracCokluFiltrelemeButonu_Click(object sender, EventArgs e)
        {
            // DataView classına gönderilecek olan stringi tutan değişken
            string filterQuery = " UygunlukDurumu='Uygun' AND ";
            // if'lerin amacı, eğer combobox'lardan bir item seçildi ise ekler, seçilmedi ise eklemez
            if (AracMarka.SelectedItem != null)
            {
                filterQuery += " Marka = '" + AracMarka.SelectedItem + "' AND ";
            }
            if (AracModel.SelectedItem != null)
            {
                filterQuery += " Model = '" + AracModel.SelectedItem + "' AND ";
            }
            if (AracVitesTuru.SelectedItem != null)
            {
                filterQuery += " VitesTuru = '" + AracVitesTuru.SelectedItem + "' AND ";
            }
            if (AracYakitTuru.SelectedItem != null)
            {
                filterQuery += " YakitTipi = '" + AracYakitTuru.SelectedItem + "' AND ";
            }

            if (KmMin.Value <= KmMax.Value)
            {
                filterQuery += " Kilometre >=" + KmMin.Value + " AND Kilometre <=" + KmMax.Value + " AND ";
            }
            else
            {

                filterQuery += " Kilometre >=" + KmMax.Value + " AND Kilometre <=" + KmMin.Value + " AND ";
            }

            if (YilMin.Value <= YilMax.Value)
            {
                filterQuery += " UretimYili >=" + YilMin.Value + " AND UretimYili <=" + YilMax.Value + " AND ";
            }
            else
            {

                filterQuery += " UretimYili >=" + YilMax.Value + " AND UretimYili <=" + YilMin.Value + " AND ";
            }

            // Filtrelemede verilen seçenekler AND ile bitebiliyor, eğer AND ile bitilen tek bir seçenek
            // seçilirse sistem patlıyor, aşşağıdaki if ile eğer string "AND " ile bitiyor ise sondan "AND " char dizisini siliyor.
            if (filterQuery.EndsWith("AND "))
            {
                filterQuery = filterQuery.Substring(0, filterQuery.Length - 4);
            }
            filter(filterQuery);

        }
        //Filtreleme seçeneklerini sıfırlayan komut
        private void AracFiltreTemizlemebutonu_Click(object sender, EventArgs e)
        {
            showData();
        }
        // KmMin ve KmMax isimli numericUpDown objelerinin değerlerini karşılaştırıp,
        // eğer kullanıcı KmMax objesine KmMin objesinden küçük rakam verirse label'lerin yerini değiştiriyor,
        // ayrıca KmMin ve KmMax değerlerini filter fonksiyonuna göndererek filtreyi gerçekleştiriyor.
        public void KmFilter()
        {
            if (KmMin.Value <= KmMax.Value)
            {
                label3.Text = "Min =";
                label4.Text = "Max =";
                String query = String.Format("Kilometre >= {0} AND Kilometre <= {1} ", KmMin.Value, KmMax.Value);
                filter(query);
            }
            else
            {
                label4.Text = "Min =";
                label3.Text = "Max =";
                String query = String.Format("Kilometre >= {1} AND Kilometre <= {0} ", KmMin.Value, KmMax.Value);
                filter(query);
            }
        }
        // Kilometre filtreleme seçeneğindeki min değeri ile değişiklik yapıldığında çalışan komut
        private void KmMax_ValueChanged(object sender, EventArgs e)
        {
            KmFilter();
        }
        // Kilometre filtreleme seçeneğindeki min değeri ile değişiklik yapıldığında çalışan komut
        private void KmMin_ValueChanged(object sender, EventArgs e)
        {
            KmFilter();
        }
        // YilMin ve YilMax isimli numericUpDown objelerinin değerlerini karşılaştırıp,
        // eğer kullanıcı YilMax objesine YilMin objesinden küçük rakam verirse label'lerin yerini değiştiriyor,
        // ayrıca YilMin ve YilMax değerlerini filter fonksiyonuna göndererek filtreyi gerçekleştiriyor.
        public void YilFilter()
        {
            if (YilMin.Value <= YilMax.Value)
            {

                label6.Text = "Min =";
                label7.Text = "Max =";
                String query = String.Format("UretimYili >= {0} AND UretimYili <= {1} ", YilMin.Value, YilMax.Value);
                filter(query);
            }
            else
            {
                label7.Text = "Min =";
                label6.Text = "Max =";
                String query = String.Format("UretimYili >= {1} AND UretimYili <= {0} ", YilMin.Value, YilMax.Value);
                filter(query);
            }
        }

        // Yıl filtreleme seçeneğindeki min değeri ile değişiklik yapıldığında çalışan komut
        private void YilMin_ValueChanged(object sender, EventArgs e)
        {
            YilFilter();
        }
        // Yıl filtreleme seçeneğindeki max değeri ile değişiklik yapıldığında çalışan komut
        private void YilMax_ValueChanged(object sender, EventArgs e)
        {
            YilFilter();
        }
        // Program kapatıldığında giriş ekranının tekrar açılmasını sağlıyor.
        private void KullaniciEkrani_FormClosed(object sender, FormClosingEventArgs e)
        {

            GirisEkrani GirisEkrani = new GirisEkrani();
            this.Hide();
            GirisEkrani.Show();
        }
        //Desktop file location almayı sağlıyor.
        string saveFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        private void FilterExportButton_Click(object sender, EventArgs e)
        {
            string FileFullPath = saveFilePath + "\\AracTableExport_" + DateTime.Now.ToString("dd/MM/yyyy_hh-mm-ss") + ".xlsx";


            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;

            worksheet = workbook.Sheets["Sayfa1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "AracKiralama ";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs(FileFullPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            MessageBox.Show("Başarılı Bir Şekilde " + FileFullPath + "\nDosyasına Veriler Exportlanmıştır.");
        }
    }
}
