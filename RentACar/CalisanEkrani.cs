using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RentACar
{
    public partial class CalisanEkrani : Form
    {
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataReader dr;
        SqlCommand cmd;
        int AracDGVRowCount;

     
        bool EhliyetNoFlag;
        public CalisanEkrani()
        {
            InitializeComponent();
        }

        private void Calisan_Load(object sender, EventArgs e)
        {
            hideAll();
        }

        private void SqlBaglanti()
        {
            String connectionString = "Data Source=DESKTOP-OMDHQM5;Initial Catalog=AracKiralamaDB;Integrated Security=True;MultipleActiveResultSets=true;";
            con = new SqlConnection(connectionString);
            con.Open();
        }
        private void dataGridViewFill(string TableName, DataGridView dgv)
        {
            String sqlCommandQuery = "SELECT * FROM " + TableName;
            adpt = new SqlDataAdapter(sqlCommandQuery, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv.DataSource = dt;
            dgv.TopLeftHeaderCell.Value = "KayıtNo";
        }
        private void hideAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }
        private bool MBWarning(string str)
        {
            MessageBox.Show(str, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();
            return false;
        }
        private void MBShowInfo(string str)
        {
            MessageBox.Show(str, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBoxReadOnly(bool boool)
        {
            foreach (GroupBox gb in MusteriEklemePanel.Controls.OfType<GroupBox>())
            {
                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                {
                    tb.ReadOnly = boool;
                }
            }

        }
        private SqlDataReader executeRead(String query)
        {
            try { 
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            return cmd.ExecuteReader();
            }
            catch(Exception s)
            {
                MessageBox.Show("Bir hata oluştu: "+s.Message);
                return cmd.ExecuteReader();
            }
        }
        /// <summary>
        /// Program arayüzünden sağ üstteki çarpı butonuna tıklanıldığında
        /// giriş ekranına döndürüyor.
        /// </summary>
        private void CalisanEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {

            GirisEkrani GirisEkrani = new GirisEkrani();
            this.Hide();
            GirisEkrani.Show();
        }
        private void aracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            AracPanel.Show();
            SqlBaglanti();
            dataGridViewFill("Arac", AracDGV);
            AracDGVRowCount = AracDGV.RowCount - 1;
            con.Close();
        }
        private void AracEklemeButonu_Click(object sender, EventArgs e)
        {
            SqlBaglanti();
            for (int i = AracDGVRowCount; i < AracDGV.Rows.Count - 1; i++)
            {
                String query = "INSERT INTO Arac(PlakaNo, UygunlukDurumu, UretimYili, Marka, Model, Kilometre, VitesTuru, YakitTipi, GunlukUcret)" +
                      string.Format("  VALUES('{0}', '{1}',{2}, '{3}', '{4}', {5}, '{6}', '{7}', {8})",
                      AracDGV.Rows[i].Cells[0].Value, AracDGV.Rows[i].Cells[1].Value, AracDGV.Rows[i].Cells[2].Value,
                      AracDGV.Rows[i].Cells[3].Value, AracDGV.Rows[i].Cells[4].Value, AracDGV.Rows[i].Cells[5].Value,
                      AracDGV.Rows[i].Cells[6].Value, AracDGV.Rows[i].Cells[7].Value, AracDGV.Rows[i].Cells[8].Value);
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
            }

            MBShowInfo("Başarıyla eklenmiştir");
            con.Close();
        }
        /// <summary>
        ///  AracDGV'inin en solundaki RowHeader sütununa tıklanıldığı seçim modunu değiştirerek
        ///  tüm satırın seçilmesini sağlayan kod.
        /// </summary>
        private void AracDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AracDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        ///  AracDGV'inin en solundaki RowHeader sütununa tıklanıldığı seçim modunu değiştirerek
        ///  tek hücrenin seçilmesini sağlayan kod.
        /// </summary>
        private void AracDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AracDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        /// <summary>
        /// DataBase ile bağlantı kurarak seçili olan satırdaki ilk sütunda yer alan PlakaNo değerini
        /// silinmisArac tablosuna tüm satırı yedekliyor ve,    
        /// Arac tablosundan tüm satırı siliyor.               
        /// Ardından AracDGV objesinden de siliyor.    
        /// </summary>
        private void AracSilmeButonu_Click(object sender, EventArgs e)
        {
            SqlBaglanti();
            if (AracDGV.CurrentRow.Selected)
            {
                if (MessageBox.Show("Gerçekten Silmek İstiyor Musunuz?", "Silme Doğrulaması", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in AracDGV.SelectedRows)
                    {
                        String Command = String.Format("INSERT INTO SilinmisArac SELECT * FROM Arac WHERE PlakaNo='{0}'", AracDGV.CurrentRow.Cells["PlakaNo"].Value);
                        executeRead(Command);
                        Command = String.Format("DELETE FROM Arac WHERE PlakaNo = '{0}'", AracDGV.CurrentRow.Cells["PlakaNo"].Value);
                        executeRead(Command);
                        AracDGV.Rows.RemoveAt(row.Index);
                        con.Close();
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Yapabilmek İçin;\n Ya Tüm Satırı Seçiniz, " +
                        "\n Yada \"Numara\" Sütununa Çift Tıklayınız.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
            con.Close();
        }
        /// <summary>
        /// AracDGV objesinden bir eleman silindiği zaman RowHeader, ilk sütun, da yer alan numaralandırmaları yeniliyor
        /// </summary>
        private void AracDegistirmeButonu_Click(object sender, EventArgs e)
        {

            SqlBaglanti();
            String query = string.Format("UPDATE Arac SET {0} = '{1}' Where PLakaNo = '{2}'", AracDGV.Columns[AracDGV.CurrentCell.ColumnIndex].Name, AracDGV.CurrentCell.Value.ToString(), AracDGV.Rows[AracDGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            executeRead(query);
            MBShowInfo("Başarıyla Değiştirilmiştir");

            con.Close();
        }
        private void kiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            GirisLabel.SendToBack();
            KiralamaİslemiPanel.Show();
            KiralamaAddButton.Show();
            SqlBaglanti();
            dataGridViewFill("Kiralama", KiralamaDGV);

            //yeni kayıt combobox filler
            String sqlCommandQuery = "Select * From Musteri INNER JOIN Ikametgah on Musteri.EhliyetNo = Ikametgah.EhliyetNo";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sqlCommandQuery;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                if (!KiralamaEhliyetCB.Items.Contains(dr["EhliyetNo"]))
                {
                    KiralamaEhliyetCB.Items.Add(dr["EhliyetNo"]);
                }
            }
            KiralamaDGV.Columns[0].ReadOnly = true;
            for (int i = 4; i < KiralamaDGV.ColumnCount; i++)
            {
                KiralamaDGV.Columns[i].ReadOnly = true;
            }

            con.Close();
        }
        private void faturalamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GirisLabel.SendToBack();
            hideAll();
            FaturalamaPanel.Show();
            SqlBaglanti();
            dataGridViewFill("Faturalama", FaturalamaDGV);

            con.Close();
        }
        private void musteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GirisLabel.SendToBack();
            hideAll();
            MusteriPanel.Show();
            SqlBaglanti();
            
            String sqlCommandQuery = "Select * From Musteri INNER JOIN Ikametgah on Musteri.EhliyetNo = Ikametgah.EhliyetNo";
            adpt = new SqlDataAdapter(sqlCommandQuery, con);
            dt = new DataTable();
            adpt.Fill(dt);
            MusteriDGV.DataSource = dt;
            MusteriDGV.Columns[13].Visible = false;
            MusteriDGV.TopLeftHeaderCell.Value = "KayıtNo";

            con.Close();

        }
        private void MusteriEklemeButonu_Click(object sender, EventArgs e)
        {
            GirisLabel.SendToBack();
            kiralamaPlakaNo.Items.Clear();
            hideAll();
            MusteriEklemePanel.Show();
            KFMKaydet.Show();
            KiralamaEhliyetCB.Hide();
            label18.Hide();
            foreach (GroupBox gb in MusteriEklemePanel.Controls.OfType<GroupBox>())
            {
                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                {
                    tb.Clear() ;
                }
            }
            SqlBaglanti();
            dr = executeRead("SELECT PlakaNo FROM Arac Where UygunlukDurumu='Uygun';");
            while (dr.Read())
            {
                if (!kiralamaPlakaNo.Items.Contains(dr["PlakaNo"]))
                {
                    kiralamaPlakaNo.Items.Add(dr["PlakaNo"]);
                }
            }
            if (MessageBox.Show("Müşteri Daha Önce Araç Kiraladı Mı?", "Doğrulama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EhliyetNoFlag = true;
                KiralamaEhliyetCB.Show();
                label18.Show();
                textBoxReadOnly(true);                 
            }
            else
            {
                textBoxReadOnly(false);
                kiralamaEhliyetNo.Size = new System.Drawing.Size(238, 20);
            }
            con.Close();
        }
        //KFM -> Kullanıcı, Fatura, Müşteri. Yeni girilen veri doğruluğu kontrolü.
        private bool KFMChecker()
        {

            SqlBaglanti();
            dr = executeRead("SELECT PlakaNo FROM Arac;");

            if (this.kiralamaPlakaNo.SelectedIndex < 0)
            {
                return MBWarning("Lütfen Bir Plaka Seçiniz");
            }
            if (!(this.SigortaVarRB.Checked || this.SigortaYokRB.Checked))
            {
                return MBWarning("Lütfen Aracın Sigorta Durumunu Seçiniz");
            }


            if (!EhliyetNoFlag)
            {
                if (!int.TryParse(kiralamaEhliyetNo.Text, out int parsedValue1) || kiralamaEhliyetNo.Text.Length != 6)
                {
                    return MBWarning("Ehliyet Numarası 6 Rakamdan Oluşmalıdır.");

                }
                if (KiralamaEhliyetCB.Items.Contains(kiralamaEhliyetNo.Text))
                {

                    KiralamaEhliyetCB.Show();
                    label17.Show();

                    textBoxReadOnly(true);
                    KiralamaEhliyetCB.SelectedItem = kiralamaEhliyetNo.Text;
                    MessageBox.Show("Girmiş Olduğunuz Ehliyet Numarası Daha Önceden Kullanılmıştır.\nYukarıdan Bir Tanesini Seçin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
                KiralamaTelNo.Text = KiralamaTelNo.Text.Replace(" ", string.Empty);
                if (KiralamaTelNo.Text.Length != 11)
                {
                    return MBWarning("Telefon numarası 11 adet rakamdan oluşmalıdır.\nNumaranızın başında 0 olması gerekmektedir.\n05xx xxx xx xx veya 05xx xxx xxxx veya 05xxxxxxxxx formatında,\nTekrar deneyiniz.");
                }
                if (!int.TryParse(KiralamaAptNo.Text, out int parsedValue3))
                {
                    return MBWarning("Apartman Numarası sadece rakamlardan oluşmalıdır.");
                }
                if (!int.TryParse(KiralamaDaireNo.Text, out int parsedValue4))
                {
                    return MBWarning("Daire Numarası sadece rakamlardan oluşmalıdır.");
                }
                if (!int.TryParse(KiralamaPostaNo.Text, out int parsedValue5) || KiralamaPostaNo.Text.Length != 5)
                {
                    return MBWarning("Posta Kodu 5 adet rakamdan oluşmalıdır.\n Posta Kodunuzu Öğrenmek için mahalle muhtarlığına veya internete başvurabilirsiniz. \n Hatta belkide daha başka şekillerde de öğrenebilirsiniz...");
                }
                foreach (TextBox tb in MusteriEklemePanel.Controls.OfType<TextBox>())
                {
                    if (string.IsNullOrEmpty(tb.Text.Trim()) && tb != KiralamaMahalle && tb != KiralamaEmail)
                    {
                        return MBWarning("Başında * Olan Alanlar Boş Olamaz.");
                    }

                }
                if (KiralamaEmail.Text != null)
                {
                    var addr = new System.Net.Mail.MailAddress(KiralamaEmail.Text);
                    return addr.Address == KiralamaEmail.Text;
                }


                return true;
            }
            MusteriEklemeDataFiller();
           
            con.Close();
            return true;
        }
        private void KFMKaydet_Click(object sender, EventArgs e)
        {

            if (KFMChecker())
            {

                if (MessageBox.Show("Kaydetmeyi Onaylıyor Musunuz?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlBaglanti();

                    String FaturalamaQuery, MusteriQuery, IkametgahQuery, KiralamaQuery, AracQuery;

                    FaturalamaQuery = "INSERT INTO Faturalama(FaturaTarihi)" +
                                    string.Format("values('{0}')", (
                                    KiralamaKiralamaTarihi.Value.Year + "-" + KiralamaKiralamaTarihi.Value.Month + "-" + KiralamaKiralamaTarihi.Value.Day));
                    cmd = new SqlCommand(FaturalamaQuery, con);
                    cmd.ExecuteNonQuery();

                    if (!EhliyetNoFlag)
                    {
                        MusteriQuery = "INSERT INTO Musteri(EhliyetNo, Isim, SoyIsim, TelNo, EmailAdresi) " +
                                        string.Format("VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", kiralamaEhliyetNo.Text, KiralamaIsim.Text, KiralamaSoyIsım.Text, KiralamaTelNo.Text.Trim(' '), KiralamaEmail.Text);
                        cmd = new SqlCommand(MusteriQuery, con);
                        cmd.ExecuteNonQuery();

                        IkametgahQuery = "INSERT INTO Ikametgah(Mahalle, Cadde, Sokak, ApartmanNo, DaireNo, PostaKodu, Ilce, Sehir, EhliyetNo) " +
                                        string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}','{8}')", KiralamaMahalle.Text, KiralamaCadde.Text, KiralamaSokak.Text, KiralamaAptNo.Text,
                                        KiralamaDaireNo.Text, KiralamaPostaNo.Text, KiralamaIlce.Text, KiralamaIl.Text, kiralamaEhliyetNo.Text);
                        cmd = new SqlCommand(IkametgahQuery, con);
                        cmd.ExecuteNonQuery();

                        dr = executeRead("SELECT TOP 1 FaturaNumarası FROM Faturalama ORDER BY Faturalama.FaturaNumarası DESC");
                        string faturaNo = "";
                        while (dr.Read())
                        {
                            faturaNo = Convert.ToString(dr["FaturaNumarası"]);
                        }

                        KiralamaQuery = "INSERT INTO Kiralama( TeslimTarihi,KiralamaTarihi,SigortaDurumu,SigortaGunlukTutar,PlakaNo,EhliyetNo,FaturaNo) " +
                                        string.Format("VALUES('{0}', '{1}', '{2}', 20 ,'{3}', '{4}','{5}')",
                                         (KiralamaTeslimTarihi.Value.Year + "-" + KiralamaTeslimTarihi.Value.Month + "-" + KiralamaTeslimTarihi.Value.Day),
                                        (KiralamaKiralamaTarihi.Value.Year + "-" + KiralamaKiralamaTarihi.Value.Month + "-" + KiralamaKiralamaTarihi.Value.Day),
                                        (SigortaVarRB.Checked ? 'V' : 'Y'),
                                        kiralamaPlakaNo.SelectedItem.ToString(),
                                       kiralamaEhliyetNo.Text,
                                        faturaNo);
                        cmd = new SqlCommand(KiralamaQuery, con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {

                        dr = executeRead("SELECT TOP 1 FaturaNumarası FROM Faturalama ORDER BY Faturalama.FaturaNumarası DESC");
                        string faturaNo = "";
                        while (dr.Read())
                        {
                            faturaNo = Convert.ToString(dr["FaturaNumarası"]);
                        }
                        KiralamaQuery = "INSERT INTO Kiralama( TeslimTarihi,KiralamaTarihi,SigortaDurumu,SigortaGunlukTutar,PlakaNo,EhliyetNo,FaturaNo) " +
                                        string.Format("VALUES('{0}', '{1}', '{2}',20 ,'{3}', '{4}','{5}')",
                                         (KiralamaTeslimTarihi.Value.Year + "-" + KiralamaTeslimTarihi.Value.Month + "-" + KiralamaTeslimTarihi.Value.Day),
                                        (KiralamaKiralamaTarihi.Value.Year + "-" + KiralamaKiralamaTarihi.Value.Month + "-" + KiralamaKiralamaTarihi.Value.Day),
                                        (SigortaVarRB.Checked ? 'V' : 'Y'),
                                        kiralamaPlakaNo.SelectedItem.ToString(),
                                         KiralamaEhliyetCB.SelectedItem.ToString(),
                                        faturaNo);
                        cmd = new SqlCommand(KiralamaQuery, con);
                        cmd.ExecuteNonQuery();
                    }
                    string datediff = "UPDATE kiralama SET GunSayisi= DATEDIFF(day,Kiralama.kiralamaTarihi,Kiralama.TeslimTarihi) WHERE KiralamaNo = (SELECT TOP 1 KiralamaNo FROM Kiralama ORDER BY KiralamaNo DESC )";
                        cmd = new SqlCommand(datediff, con);
                        cmd.ExecuteNonQuery();
                    string gecikmeFaizi = "  UPDATE Kiralama SET GecikmeFaizi = (cast(d.gunlukucret as int) + 10) FROM Kiralama f INNER JOIN arac d ON d.plakaNo = f.PlakaNo ";
                        cmd = new SqlCommand(gecikmeFaizi, con);
                        cmd.ExecuteNonQuery();
                    
                    AracQuery = string.Format("UPDATE arac SET UygunlukDurumu = 'Uygun Değil' WHERE PlakaNo = '{0}';", kiralamaPlakaNo.SelectedItem.ToString());
                    cmd = new SqlCommand(AracQuery, con);
                    cmd.ExecuteNonQuery();

                    string toplamTutarQuery =
                        "UPDATE Kiralama  SET SigortaGunlukTutar=20 " +
                        "WHERE SigortaDurumu='V'; " +

                        "UPDATE Kiralama  SET SigortaGunlukTutar = 0 " +
                        "WHERE SigortaDurumu = 'Y'; " +

                        "UPDATE Faturalama SET ToplamTutar = (e.gunsayisi * (cast(d.gunlukucret as int) + e.SigortaGunlukTutar)) " +
                        "FROM faturalama f " +
                        "INNER JOIN kiralama e ON e.FaturaNo = f.FaturaNumarası " +
                        "INNER JOIN arac d ON d.PlakaNo = e.PlakaNo; ";
                    cmd = new SqlCommand(toplamTutarQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    foreach (TextBox tb in MusteriEklemePanel.Controls.OfType<TextBox>())
                    {
                        tb.Text = null;
                    }
                    kiralamaPlakaNo.Text = "Bir Plaka Seçiniz";
                    KiralamaEhliyetCB.Text = "Ehliyet Numarası Seçiniz";
                    SigortaVarRB.Checked = false;
                    SigortaYokRB.Checked = false;
                    KiralamaİslemiPanel.Show();
                    KiralamaİslemiPanel.BringToFront();

                    textBoxReadOnly(false);
                    SqlBaglanti();
                    dataGridViewFill("Kiralama", KiralamaDGV);
                }
            }

            con.Close();
        }

        private void DGV_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var DGV = sender as DataGridView;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void DGV_RowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var DGV = sender as DataGridView;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

        }
        private void MusteriEklemeDataFiller()
        {
            SqlBaglanti();
            dr = executeRead("Select * From Musteri INNER JOIN Ikametgah on Musteri.EhliyetNo = Ikametgah.EhliyetNo where musteri.EhliyetNo=" + KiralamaEhliyetCB.SelectedItem);

            while (dr.Read())
            {

                KiralamaIsim.Text = dr["Isim"].ToString();
                KiralamaSoyIsım.Text = dr["SoyIsim"].ToString();
                KiralamaTelNo.Text = dr["TelNo"].ToString();
                KiralamaEmail.Text = dr["EmailAdresi"].ToString();
                KiralamaMahalle.Text = dr["Mahalle"].ToString();
                KiralamaCadde.Text = dr["Cadde"].ToString();
                KiralamaSokak.Text = dr["Sokak"].ToString();
                KiralamaAptNo.Text = dr["ApartmanNo"].ToString();
                KiralamaDaireNo.Text = dr["DaireNo"].ToString();
                KiralamaPostaNo.Text = dr["PostaKodu"].ToString();
                KiralamaIlce.Text = dr["Ilce"].ToString();
                KiralamaIl.Text = dr["Sehir"].ToString();

            }
            textBoxReadOnly(true);


            con.Close();
        }
        private void KiralamaEhliyetCB_SelectedValueChanged(object sender, EventArgs e)
        {

            MusteriEklemeDataFiller();
        }


        //Çoklu değiştirme grid.
        private void MusDegistir_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = MusteriDGV.GetCellCount(DataGridViewElementStates.Selected);
            SqlBaglanti();
            if (selectedCellCount > 0)
            {

                for (int i = 0; i < selectedCellCount; i++)
                {
                    if (MusteriDGV.SelectedCells[i].ColumnIndex <= 4)
                    {
                        String query = string.Format("UPDATE Musteri SET {0} = '{1}' Where EhliyetNo = '{2}'",
                            MusteriDGV.SelectedCells[i].OwningColumn.HeaderText.ToString(),
                            MusteriDGV.SelectedCells[i].Value.ToString(),
                            MusteriDGV.Rows[MusteriDGV.SelectedCells[i].RowIndex].Cells[0].Value.ToString());
                        executeRead(query);
                    }
                    else
                    {
                        String query = string.Format("UPDATE Ikametgah SET {0} = '{1}' Where EhliyetNo = '{2}'",
                            MusteriDGV.SelectedCells[i].OwningColumn.HeaderText.ToString(),
                            MusteriDGV.SelectedCells[i].Value.ToString(),
                            MusteriDGV.Rows[MusteriDGV.SelectedCells[i].RowIndex].Cells[0].Value.ToString());
                        executeRead(query);
                    }

                }

            }
            MBShowInfo("Başarıyla Değiştirilmiştir");
            con.Close();
        }



        private void KirDegistir_Click(object sender, EventArgs e)
        {
            SqlBaglanti();
            Int32 selectedCellCount = KiralamaDGV.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                for (int i = 0; i < selectedCellCount; i++)
                {
                    String query = string.Format("UPDATE Kiralama SET {0} = '{1}' Where KiralamaNo = '{2}'",
                        KiralamaDGV.SelectedCells[i].OwningColumn.HeaderText.ToString(),
                        KiralamaDGV.CurrentCell.Value.ToString(),
                        KiralamaDGV.Rows[KiralamaDGV.SelectedCells[i].RowIndex].Cells[0].Value.ToString());
                    executeRead(query);


                }

            }
            string datediff = "UPDATE kiralama SET GunSayisi= DATEDIFF(day,Kiralama.kiralamaTarihi,Kiralama.TeslimTarihi) ";
            cmd = new SqlCommand(datediff, con);
            cmd.ExecuteNonQuery();
          
          
            MBShowInfo("Başarıyla Değiştirilmiştir");
            con.Close();
        }


    }

}
