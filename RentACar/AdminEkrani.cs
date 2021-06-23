using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentACar
{
    public partial class AdminEkrani : Form
    {
        SqlConnection con;
        SqlDataAdapter adpt;

        DataTable table = new DataTable();
        public AdminEkrani()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hideAll();
            VeriImportButton.Enabled = false;
            RestoreButton.Enabled = false;
            table.Columns.Add("PlakaNo", typeof(string));
            table.Columns.Add("UygunlukDurumu", typeof(string));
            table.Columns.Add("UretimYili", typeof(string));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Kilometre", typeof(string));
            table.Columns.Add("VitesTuru", typeof(string));
            table.Columns.Add("YakitTipi", typeof(string));
            table.Columns.Add("GunlukUcret", typeof(string));
        }
        private void hideAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }
        private void SqlBaglanti()
        {
            try
            {
                String connectionString = "Data Source=DESKTOP-OMDHQM5;Initial Catalog=AracKiralamaDB;Integrated Security=True;MultipleActiveResultSets=true;";
                con = new SqlConnection(connectionString);
                con.Open();

            }
            catch (Exception s)
            {
                MessageBox.Show("Bir Hata Oluştu: " + s.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void executeSqlCmd(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception s)
            {
                MessageBox.Show("Bir Hata Oluştu: " + s.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Program arayüzünden sağ üstteki çarpı butonuna tıklanıldığında
        /// programın doğru olarak kapatılmasını sağlayan kod.
        /// </summary>
        private void AdminEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirisEkrani GirisEkrani = new GirisEkrani();
            this.Hide();
            GirisEkrani.Show();
        }

        string saveFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        string saveYDKFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        private void BackupFileLocButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            saveYDKFilePath = folderBrowserDialog1.SelectedPath;
        }
        private void YedeklemeButton_Click(object sender, EventArgs e)
        {

            SqlBaglanti();


            string saveYDKFull = saveYDKFilePath + @"\Backup_" + DateTime.Now.ToString("dd/MM/yyyy_hh-mm-ss") + ".bak";

            string query = "BACKUP DATABASE [AracKiralamaDB] TO  DISK = N'" + saveYDKFull +
               "' WITH NOFORMAT, NOINIT,  NAME = N'AracKiralamaDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";

            executeSqlCmd(query);


            MessageBox.Show("Başarılı Bir Şekilde " + saveYDKFull + "\n Dosyasına Yedeklenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }


        //YEDEKTEN GERİ DÖNME DOSYA SEÇİMİ
        string openFileString;
        private void ydgnOpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileString = openFileDialog1.FileName;
            RestoreButton.Enabled = true;
        }
        //YEDEKTEN GERİ DÖNME.
        private void YdkgdButton_Click(object sender, EventArgs e)
        {

            BackupButton.Enabled = true;
            SqlBaglanti();
            string query = "USE [master] ALTER DATABASE[AracKiralamaDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
            "BACKUP LOG[AracKiralamaDB] TO DISK = N'" + @"C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\AracKiralamaDB_LogBackup_2020-12-24_14-16-51.bak'" + 
            "WITH NOFORMAT, NOINIT, NAME = N'AracKiralamaDB_LogBackup_2020-12-24_14-16-51', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5 " +
            "RESTORE DATABASE[AracKiralamaDB] FROM DISK = N'" + openFileString + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5 " +
            "ALTER DATABASE[AracKiralamaDB] SET MULTI_USER";
            executeSqlCmd(query);
            MessageBox.Show("Başarılı Bir Şekilde " + openFileString + "\n Dosyasından Restorelanmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileString = string.Empty;
            con.Close();
        }

        //VERİ IMPORT ETME VAKASI
        private void VeriImportBtn_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Listedeki Veriler Arac Tablosuna Eklenecektir. Emin Misiniz?", "Doğrulama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VeriImportButton.Enabled = true;

                SqlBaglanti();

                for (int i = 0; i <= ImportDGV.Rows.Count - 1; i++)
                {
                    String query = "INSERT INTO Arac(PlakaNo, UygunlukDurumu, UretimYili, Marka, Model, Kilometre, VitesTuru, YakitTipi, GunlukUcret)" +
                          string.Format("  VALUES('{0}', '{1}',{2}, '{3}', '{4}', {5}, '{6}', '{7}', {8})",
                          ImportDGV.Rows[i].Cells[0].Value, ImportDGV.Rows[i].Cells[1].Value, ImportDGV.Rows[i].Cells[2].Value,
                          ImportDGV.Rows[i].Cells[3].Value, ImportDGV.Rows[i].Cells[4].Value, ImportDGV.Rows[i].Cells[5].Value,
                          ImportDGV.Rows[i].Cells[6].Value, ImportDGV.Rows[i].Cells[7].Value, ImportDGV.Rows[i].Cells[8].Value);
                    executeSqlCmd(query);
                }
                con.Close();

                MessageBox.Show("Başarılı Bir Şekilde " + openFileString + "\n Dosyasından Veriler Import Edilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ImportDGV.DataSource = null;
                table.Rows.Clear();
                ImportDGV.Rows.Clear();
                openFileString = string.Empty;


            }
        }

        //VERİ İMPORT DOSYASI SEÇME
        private void VeriImportFL_Click(object sender, EventArgs e)
        {
            ImportDGV.DataSource = null;
            ImportDGV.Rows.Clear();
            openFileDialog1.ShowDialog();
            openFileString = openFileDialog1.FileName;


            string[] lines = System.IO.File.ReadAllLines(openFileString);
            string[] values;


            for (int i = 1; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
            ImportDGV.DataSource = table;
            VeriImportButton.Enabled = true;

        }
        private void FileLocButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            saveFilePath = folderBrowserDialog1.SelectedPath;
        }

        string fileExtenstion = ".txt";
        //default txt atıyor.
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            fileExtenstion = comboBox2.SelectedItem.ToString();
        }
        private void VeriExportButton_Click(object sender, EventArgs e)
        {

            DataTable d_table = new DataTable();
            string TableName = "Dbo.Arac";
            string query = "Select * From " + TableName;
            try
            {
                String connectionString = "Data Source=DESKTOP-OMDHQM5;Initial Catalog=AracKiralamaDB;Integrated Security=True;MultipleActiveResultSets=true;";
                con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                d_table.Load(cmd.ExecuteReader());
                con.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show("Bir Hata Oluştu" + s.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string FileFullPath = saveFilePath + "\\AracTableExport_" + DateTime.Now.ToString("dd/MM/yyyy_hh-mm-ss") + fileExtenstion;

            System.IO.StreamWriter sw = null;
            sw = new System.IO.StreamWriter(FileFullPath, false);


            int ColumnCount = d_table.Columns.Count;
            for (int ic = 0; ic < ColumnCount; ic++)
            {
                sw.Write(d_table.Columns[ic]);
                if (ic < ColumnCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);


            foreach (DataRow dr in d_table.Rows)
            {
                for (int ir = 0; ir < ColumnCount; ir++)
                {
                    if (!Convert.IsDBNull(dr[ir]))
                    {
                        sw.Write(dr[ir].ToString());
                    }
                    if (ir < ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);

            }

            sw.Close();

            MessageBox.Show("Başarılı Bir Şekilde " + FileFullPath + "\nDosyasına Veriler Exportlanmıştır.");

        }

        private void silinmişKayıtlarıGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            showDeletedRecords.Show();
            showDeletedRecords.BringToFront();
            SqlBaglanti();

            String sqlCommandQuery = "SELECT * FROM SilinmisArac";
            adpt = new SqlDataAdapter(sqlCommandQuery, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            silinmisAracDGV.DataSource = dt;

            con.Close();
        }

        private void kullanıcıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            KullaniciAddPanel.Show();
            KullaniciAddPanel.BringToFront();
            usersDGVFiller();
        }

        private void yedeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            BackupRestorePanel.Show();
            BackupRestorePanel.BringToFront();
        }

        private void exportImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            ImportExportPanel.Show();
            ImportExportPanel.BringToFront();
        }


        //kullanıcı ekleme kaydetme.
        private void KEKaydetButton_Click(object sender, EventArgs e)
        {

            string username = KEKullaniciAdiTB.Text;
            string password = KESifreTB.Text;
            string tip = "";
            if (comboBox1.SelectedIndex == -1)
            {
                tip = "kullanici";
            }
            else
            {
                tip = comboBox1.SelectedItem.ToString();
            }

            SqlBaglanti();

            string query = "INSERT INTO Users(UserName, Passwords, Tip)" +
                           string.Format("  VALUES('{0}', '{1}','{2}')",
                           username, password, tip);
            executeSqlCmd(query);
            usersDGVFiller();
            con.Close();

            string addQuery = "";
            SqlBaglanti();
            if (tip == "admin")
            {
               
                addQuery = "USE [master] " +
                    "CREATE LOGIN[" + username + "] WITH PASSWORD = N'" + password + "',  " +
                    "DEFAULT_DATABASE =[AracKiralamaDB], CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF " +
                    "ALTER SERVER ROLE[bulkadmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[diskadmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[processadmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[securityadmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[serveradmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[setupadmin] ADD MEMBER[" + username + "] " +
                    "ALTER SERVER ROLE[sysadmin] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] CREATE USER[" + username + "] FOR LOGIN[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_accessadmin] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_backupoperator] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_datareader] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_datawriter] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_securityadmin] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_accessadmin] TO[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_backupoperator] TO[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_datawriter] TO[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_securityadmin] TO[" + username + "]";
            }
            else if (tip == "calisan")
            {
                addQuery = "USE [master] CREATE LOGIN[" + username + "] WITH PASSWORD = N'" + password + "', " +
                    "DEFAULT_DATABASE =[AracKiralamaDB], CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF " +
                    "USE[AracKiralamaDB] CREATE USER[" + username + "] FOR LOGIN[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_datareader] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER ROLE[db_datawriter] ADD MEMBER[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO[" + username + "] " +
                    "USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_datawriter] TO[" + username + "]";
            }
            else
            {
                addQuery = "USE [master] CREATE LOGIN [" + username + "] WITH PASSWORD=N'" + password + "'," +
                    " DEFAULT_DATABASE=[AracKiralamaDB], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF " +
                    " USE[AracKiralamaDB] CREATE USER[" + username + "] FOR LOGIN[" + username + "] " +
                    " USE[AracKiralamaDB] ALTER USER[" + username + "] WITH DEFAULT_SCHEMA =[guest] " +
                    " USE[AracKiralamaDB] ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO[" + username + "] " +
                    " USE[AracKiralamaDB] ALTER ROLE[db_datareader] ADD MEMBER[" + username + "]";

            }
            executeSqlCmd(addQuery);
            con.Close();
        }

        private void usersDGVFiller()
        {
            SqlBaglanti();

            String sqlCommandQuery = "SELECT * FROM Users";
            adpt = new SqlDataAdapter(sqlCommandQuery, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            usersDGV.DataSource = dt;
            con.Close();

        }

        
    }
}
