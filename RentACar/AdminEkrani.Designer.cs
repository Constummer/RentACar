namespace RentACar
{
    partial class AdminEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkrani));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupRestorePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.YedektenDonGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.RestoreOpenFileButton = new System.Windows.Forms.Button();
            this.YedeklemeGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackupSaveLocButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.ImportExportPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VeriExportButton = new System.Windows.Forms.Button();
            this.VeriExportSaveLocButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VeriImportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VeriImportFileLocButton = new System.Windows.Forms.Button();
            this.ImportDGV = new System.Windows.Forms.DataGridView();
            this.showDeletedRecords = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.silinmisAracDGV = new System.Windows.Forms.DataGridView();
            this.KullaniciAddPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.KEKaydetButton = new System.Windows.Forms.Button();
            this.KEKullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.KESifreTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.BackupRestorePanel.SuspendLayout();
            this.YedektenDonGroupBox.SuspendLayout();
            this.YedeklemeGroupBox.SuspendLayout();
            this.ImportExportPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportDGV)).BeginInit();
            this.showDeletedRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silinmisAracDGV)).BeginInit();
            this.KullaniciAddPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yedeklemeToolStripMenuItem,
            this.exportImportToolStripMenuItem,
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem,
            this.kullanıcıEklemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.yedeklemeToolStripMenuItem.Text = "Backup/Restore";
            this.yedeklemeToolStripMenuItem.Click += new System.EventHandler(this.yedeklemeToolStripMenuItem_Click);
            // 
            // exportImportToolStripMenuItem
            // 
            this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
            this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.exportImportToolStripMenuItem.Text = "Import/Export";
            this.exportImportToolStripMenuItem.Click += new System.EventHandler(this.exportImportToolStripMenuItem_Click);
            // 
            // silinmişKayıtlarıGörüntülemeToolStripMenuItem
            // 
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem.Name = "silinmişKayıtlarıGörüntülemeToolStripMenuItem";
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem.Text = "Silinmiş Kayıtları Görüntüleme";
            this.silinmişKayıtlarıGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.silinmişKayıtlarıGörüntülemeToolStripMenuItem_Click);
            // 
            // kullanıcıEklemeToolStripMenuItem
            // 
            this.kullanıcıEklemeToolStripMenuItem.Name = "kullanıcıEklemeToolStripMenuItem";
            this.kullanıcıEklemeToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.kullanıcıEklemeToolStripMenuItem.Text = "Kullanıcı Ekleme";
            this.kullanıcıEklemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEklemeToolStripMenuItem_Click);
            // 
            // BackupRestorePanel
            // 
            this.BackupRestorePanel.Controls.Add(this.label11);
            this.BackupRestorePanel.Controls.Add(this.YedektenDonGroupBox);
            this.BackupRestorePanel.Controls.Add(this.YedeklemeGroupBox);
            this.BackupRestorePanel.Location = new System.Drawing.Point(0, 27);
            this.BackupRestorePanel.Name = "BackupRestorePanel";
            this.BackupRestorePanel.Size = new System.Drawing.Size(1155, 424);
            this.BackupRestorePanel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Backup/Restore:";
            // 
            // YedektenDonGroupBox
            // 
            this.YedektenDonGroupBox.Controls.Add(this.label2);
            this.YedektenDonGroupBox.Controls.Add(this.RestoreButton);
            this.YedektenDonGroupBox.Controls.Add(this.RestoreOpenFileButton);
            this.YedektenDonGroupBox.Location = new System.Drawing.Point(492, 26);
            this.YedektenDonGroupBox.Name = "YedektenDonGroupBox";
            this.YedektenDonGroupBox.Size = new System.Drawing.Size(403, 375);
            this.YedektenDonGroupBox.TabIndex = 1;
            this.YedektenDonGroupBox.TabStop = false;
            this.YedektenDonGroupBox.Text = "Restore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yedekten Dönmek İstediğiniz Dosyayı Seçiniz:";
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(214, 150);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(119, 23);
            this.RestoreButton.TabIndex = 1;
            this.RestoreButton.Text = "Yedekten Geri Dön";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.YdkgdButton_Click);
            // 
            // RestoreOpenFileButton
            // 
            this.RestoreOpenFileButton.Location = new System.Drawing.Point(237, 67);
            this.RestoreOpenFileButton.Name = "RestoreOpenFileButton";
            this.RestoreOpenFileButton.Size = new System.Drawing.Size(85, 23);
            this.RestoreOpenFileButton.TabIndex = 0;
            this.RestoreOpenFileButton.Text = "Dosya Seçme";
            this.RestoreOpenFileButton.UseVisualStyleBackColor = true;
            this.RestoreOpenFileButton.Click += new System.EventHandler(this.ydgnOpenFileButton_Click);
            // 
            // YedeklemeGroupBox
            // 
            this.YedeklemeGroupBox.Controls.Add(this.label7);
            this.YedeklemeGroupBox.Controls.Add(this.label1);
            this.YedeklemeGroupBox.Controls.Add(this.BackupSaveLocButton);
            this.YedeklemeGroupBox.Controls.Add(this.BackupButton);
            this.YedeklemeGroupBox.Location = new System.Drawing.Point(33, 26);
            this.YedeklemeGroupBox.Name = "YedeklemeGroupBox";
            this.YedeklemeGroupBox.Size = new System.Drawing.Size(401, 376);
            this.YedeklemeGroupBox.TabIndex = 0;
            this.YedeklemeGroupBox.TabStop = false;
            this.YedeklemeGroupBox.Text = "Backup:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "*Lokasyon seçilmez ise default olarak,\r\n  masaüstüne yedekler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yedeklemek İstediğiniz Klasör Konumunu Seçiniz:";
            // 
            // BackupSaveLocButton
            // 
            this.BackupSaveLocButton.Location = new System.Drawing.Point(256, 67);
            this.BackupSaveLocButton.Name = "BackupSaveLocButton";
            this.BackupSaveLocButton.Size = new System.Drawing.Size(96, 23);
            this.BackupSaveLocButton.TabIndex = 4;
            this.BackupSaveLocButton.Text = "Klasör Seçme";
            this.BackupSaveLocButton.UseVisualStyleBackColor = true;
            this.BackupSaveLocButton.Click += new System.EventHandler(this.BackupFileLocButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(256, 144);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(108, 29);
            this.BackupButton.TabIndex = 1;
            this.BackupButton.Text = "Yedekle";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.YedeklemeButton_Click);
            // 
            // ImportExportPanel
            // 
            this.ImportExportPanel.Controls.Add(this.label8);
            this.ImportExportPanel.Controls.Add(this.groupBox2);
            this.ImportExportPanel.Controls.Add(this.groupBox1);
            this.ImportExportPanel.Location = new System.Drawing.Point(0, 27);
            this.ImportExportPanel.Name = "ImportExportPanel";
            this.ImportExportPanel.Size = new System.Drawing.Size(1155, 424);
            this.ImportExportPanel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Import/Export:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.VeriExportButton);
            this.groupBox2.Controls.Add(this.VeriExportSaveLocButton);
            this.groupBox2.Location = new System.Drawing.Point(831, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Exportlama:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(83, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "*Uzantı seçilmez ise default olarak,\r\n   \'.txt\' uzantılı bir şekilde exportlar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Dosya Uzantısı Seçiniz:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            ".txt",
            ".csv"});
            this.comboBox2.Location = new System.Drawing.Point(141, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Uzantı seçiniz";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "*Lokasyon seçilmez ise default olarak,\r\n  masaüstüne exportlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verileri Exportlayacağınız Konumu Seçiniz:";
            // 
            // VeriExportButton
            // 
            this.VeriExportButton.Location = new System.Drawing.Point(92, 223);
            this.VeriExportButton.Name = "VeriExportButton";
            this.VeriExportButton.Size = new System.Drawing.Size(128, 50);
            this.VeriExportButton.TabIndex = 1;
            this.VeriExportButton.Text = "Export";
            this.VeriExportButton.UseVisualStyleBackColor = true;
            this.VeriExportButton.Click += new System.EventHandler(this.VeriExportButton_Click);
            // 
            // VeriExportSaveLocButton
            // 
            this.VeriExportSaveLocButton.Location = new System.Drawing.Point(136, 67);
            this.VeriExportSaveLocButton.Name = "VeriExportSaveLocButton";
            this.VeriExportSaveLocButton.Size = new System.Drawing.Size(84, 23);
            this.VeriExportSaveLocButton.TabIndex = 0;
            this.VeriExportSaveLocButton.Text = "Klasör Seçimi";
            this.VeriExportSaveLocButton.UseVisualStyleBackColor = true;
            this.VeriExportSaveLocButton.Click += new System.EventHandler(this.FileLocButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VeriImportButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VeriImportFileLocButton);
            this.groupBox1.Controls.Add(this.ImportDGV);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Importlama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Onayla ve Importla:";
            // 
            // VeriImportButton
            // 
            this.VeriImportButton.Location = new System.Drawing.Point(676, 296);
            this.VeriImportButton.Name = "VeriImportButton";
            this.VeriImportButton.Size = new System.Drawing.Size(75, 23);
            this.VeriImportButton.TabIndex = 16;
            this.VeriImportButton.Text = "Import";
            this.VeriImportButton.UseVisualStyleBackColor = true;
            this.VeriImportButton.Click += new System.EventHandler(this.VeriImportBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Veri Importlayacağınız Konumu Seçiniz:";
            // 
            // VeriImportFileLocButton
            // 
            this.VeriImportFileLocButton.Location = new System.Drawing.Point(672, 19);
            this.VeriImportFileLocButton.Name = "VeriImportFileLocButton";
            this.VeriImportFileLocButton.Size = new System.Drawing.Size(75, 23);
            this.VeriImportFileLocButton.TabIndex = 14;
            this.VeriImportFileLocButton.Text = "Dosya Seç";
            this.VeriImportFileLocButton.UseVisualStyleBackColor = true;
            this.VeriImportFileLocButton.Click += new System.EventHandler(this.VeriImportFL_Click);
            // 
            // ImportDGV
            // 
            this.ImportDGV.AllowUserToAddRows = false;
            this.ImportDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ImportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImportDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ImportDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ImportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportDGV.Location = new System.Drawing.Point(18, 46);
            this.ImportDGV.Name = "ImportDGV";
            this.ImportDGV.ReadOnly = true;
            this.ImportDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ImportDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ImportDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ImportDGV.Size = new System.Drawing.Size(733, 244);
            this.ImportDGV.TabIndex = 13;
            // 
            // showDeletedRecords
            // 
            this.showDeletedRecords.Controls.Add(this.label9);
            this.showDeletedRecords.Controls.Add(this.silinmisAracDGV);
            this.showDeletedRecords.Location = new System.Drawing.Point(0, 27);
            this.showDeletedRecords.Name = "showDeletedRecords";
            this.showDeletedRecords.Size = new System.Drawing.Size(1155, 424);
            this.showDeletedRecords.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Silinmiş Kayıtları Görüntüleme:";
            // 
            // silinmisAracDGV
            // 
            this.silinmisAracDGV.AllowUserToAddRows = false;
            this.silinmisAracDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.silinmisAracDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.silinmisAracDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.silinmisAracDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.silinmisAracDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.silinmisAracDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.silinmisAracDGV.Location = new System.Drawing.Point(42, 26);
            this.silinmisAracDGV.Name = "silinmisAracDGV";
            this.silinmisAracDGV.ReadOnly = true;
            this.silinmisAracDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.silinmisAracDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.silinmisAracDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.silinmisAracDGV.Size = new System.Drawing.Size(1077, 376);
            this.silinmisAracDGV.TabIndex = 14;
            // 
            // KullaniciAddPanel
            // 
            this.KullaniciAddPanel.Controls.Add(this.groupBox3);
            this.KullaniciAddPanel.Controls.Add(this.label10);
            this.KullaniciAddPanel.Location = new System.Drawing.Point(0, 27);
            this.KullaniciAddPanel.Name = "KullaniciAddPanel";
            this.KullaniciAddPanel.Size = new System.Drawing.Size(1155, 424);
            this.KullaniciAddPanel.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.usersDGV);
            this.groupBox3.Controls.Add(this.KEKaydetButton);
            this.groupBox3.Controls.Add(this.KEKullaniciAdiTB);
            this.groupBox3.Controls.Add(this.KESifreTB);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(119, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 322);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(204, 26);
            this.label18.TabIndex = 27;
            this.label18.Text = "* Bir User Tipi seçilmez ise default olarak,\r\n                                   " +
    "  kullanici tipi seçilir.";
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.usersDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(251, 22);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.ReadOnly = true;
            this.usersDGV.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.usersDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(515, 260);
            this.usersDGV.TabIndex = 26;
            // 
            // KEKaydetButton
            // 
            this.KEKaydetButton.Location = new System.Drawing.Point(149, 137);
            this.KEKaydetButton.Name = "KEKaydetButton";
            this.KEKaydetButton.Size = new System.Drawing.Size(75, 23);
            this.KEKaydetButton.TabIndex = 25;
            this.KEKaydetButton.Text = "Kaydet";
            this.KEKaydetButton.UseVisualStyleBackColor = true;
            this.KEKaydetButton.Click += new System.EventHandler(this.KEKaydetButton_Click);
            // 
            // KEKullaniciAdiTB
            // 
            this.KEKullaniciAdiTB.Location = new System.Drawing.Point(83, 26);
            this.KEKullaniciAdiTB.Name = "KEKullaniciAdiTB";
            this.KEKullaniciAdiTB.Size = new System.Drawing.Size(141, 20);
            this.KEKullaniciAdiTB.TabIndex = 22;
            // 
            // KESifreTB
            // 
            this.KESifreTB.Location = new System.Drawing.Point(83, 51);
            this.KESifreTB.Name = "KESifreTB";
            this.KESifreTB.PasswordChar = '*';
            this.KESifreTB.Size = new System.Drawing.Size(141, 20);
            this.KESifreTB.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Kullanıcı Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Şifre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "User Tipi:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "kullanici",
            "calisan",
            "admin"});
            this.comboBox1.Location = new System.Drawing.Point(83, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Kullanıcı Tipi Seçiniz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kullanıcı Ekleme:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 40);
            this.label12.TabIndex = 16;
            this.label12.Text = "Sisteme Hoşgeldiniz.\r\nYukarıdaki Seçeneklerden Birini Seçiniz.";
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BackupRestorePanel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KullaniciAddPanel);
            this.Controls.Add(this.ImportExportPanel);
            this.Controls.Add(this.showDeletedRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1171, 489);
            this.MinimumSize = new System.Drawing.Size(1171, 489);
            this.Name = "AdminEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminEkrani_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BackupRestorePanel.ResumeLayout(false);
            this.BackupRestorePanel.PerformLayout();
            this.YedektenDonGroupBox.ResumeLayout(false);
            this.YedektenDonGroupBox.PerformLayout();
            this.YedeklemeGroupBox.ResumeLayout(false);
            this.YedeklemeGroupBox.PerformLayout();
            this.ImportExportPanel.ResumeLayout(false);
            this.ImportExportPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportDGV)).EndInit();
            this.showDeletedRecords.ResumeLayout(false);
            this.showDeletedRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silinmisAracDGV)).EndInit();
            this.KullaniciAddPanel.ResumeLayout(false);
            this.KullaniciAddPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişKayıtlarıGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.Panel BackupRestorePanel;
        private System.Windows.Forms.GroupBox YedektenDonGroupBox;
        private System.Windows.Forms.GroupBox YedeklemeGroupBox;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackupSaveLocButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button RestoreOpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel ImportExportPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VeriExportButton;
        private System.Windows.Forms.Button VeriExportSaveLocButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button VeriImportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VeriImportFileLocButton;
        private System.Windows.Forms.DataGridView ImportDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel showDeletedRecords;
        private System.Windows.Forms.DataGridView silinmisAracDGV;
        private System.Windows.Forms.Panel KullaniciAddPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox KEKullaniciAdiTB;
        private System.Windows.Forms.TextBox KESifreTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button KEKaydetButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
    }
}