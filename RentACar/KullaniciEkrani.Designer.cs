namespace RentACar
{
    partial class KullaniciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkrani));
            this.label2 = new System.Windows.Forms.Label();
            this.KmMax = new System.Windows.Forms.NumericUpDown();
            this.AracFiltreTemizlemebutonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AracCokluFiltrelemeButonu = new System.Windows.Forms.Button();
            this.YilMax = new System.Windows.Forms.NumericUpDown();
            this.AracYakitTuru = new System.Windows.Forms.ComboBox();
            this.KmMin = new System.Windows.Forms.NumericUpDown();
            this.AracVitesTuru = new System.Windows.Forms.ComboBox();
            this.YilMin = new System.Windows.Forms.NumericUpDown();
            this.AracModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AracMarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KmMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YilMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KmMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YilMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kilometre";
            // 
            // KmMax
            // 
            this.KmMax.Location = new System.Drawing.Point(72, 209);
            this.KmMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.KmMax.Name = "KmMax";
            this.KmMax.Size = new System.Drawing.Size(71, 20);
            this.KmMax.TabIndex = 7;
            this.KmMax.Value = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.KmMax.ValueChanged += new System.EventHandler(this.KmMax_ValueChanged);
            // 
            // AracFiltreTemizlemebutonu
            // 
            this.AracFiltreTemizlemebutonu.Location = new System.Drawing.Point(33, 334);
            this.AracFiltreTemizlemebutonu.Name = "AracFiltreTemizlemebutonu";
            this.AracFiltreTemizlemebutonu.Size = new System.Drawing.Size(121, 23);
            this.AracFiltreTemizlemebutonu.TabIndex = 11;
            this.AracFiltreTemizlemebutonu.Text = "Filtreleri Temizle";
            this.AracFiltreTemizlemebutonu.UseVisualStyleBackColor = true;
            this.AracFiltreTemizlemebutonu.Click += new System.EventHandler(this.AracFiltreTemizlemebutonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yıl";
            // 
            // AracCokluFiltrelemeButonu
            // 
            this.AracCokluFiltrelemeButonu.Location = new System.Drawing.Point(33, 305);
            this.AracCokluFiltrelemeButonu.Name = "AracCokluFiltrelemeButonu";
            this.AracCokluFiltrelemeButonu.Size = new System.Drawing.Size(121, 23);
            this.AracCokluFiltrelemeButonu.TabIndex = 10;
            this.AracCokluFiltrelemeButonu.Text = "Çoklu Filtreleme";
            this.AracCokluFiltrelemeButonu.UseVisualStyleBackColor = true;
            this.AracCokluFiltrelemeButonu.Click += new System.EventHandler(this.AracCokluFiltrelemeButonu_Click);
            // 
            // YilMax
            // 
            this.YilMax.Location = new System.Drawing.Point(72, 279);
            this.YilMax.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YilMax.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.YilMax.Name = "YilMax";
            this.YilMax.Size = new System.Drawing.Size(71, 20);
            this.YilMax.TabIndex = 9;
            this.YilMax.Value = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YilMax.ValueChanged += new System.EventHandler(this.YilMax_ValueChanged);
            // 
            // AracYakitTuru
            // 
            this.AracYakitTuru.FormattingEnabled = true;
            this.AracYakitTuru.Location = new System.Drawing.Point(33, 133);
            this.AracYakitTuru.Name = "AracYakitTuru";
            this.AracYakitTuru.Size = new System.Drawing.Size(121, 21);
            this.AracYakitTuru.TabIndex = 5;
            this.AracYakitTuru.Text = "Yakıt Türü";
            this.AracYakitTuru.SelectedIndexChanged += new System.EventHandler(this.AracYakitTuru_SelectedIndexChanged);
            // 
            // KmMin
            // 
            this.KmMin.Location = new System.Drawing.Point(72, 183);
            this.KmMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.KmMin.Name = "KmMin";
            this.KmMin.Size = new System.Drawing.Size(71, 20);
            this.KmMin.TabIndex = 6;
            this.KmMin.ValueChanged += new System.EventHandler(this.KmMin_ValueChanged);
            // 
            // AracVitesTuru
            // 
            this.AracVitesTuru.FormattingEnabled = true;
            this.AracVitesTuru.Location = new System.Drawing.Point(33, 106);
            this.AracVitesTuru.Name = "AracVitesTuru";
            this.AracVitesTuru.Size = new System.Drawing.Size(121, 21);
            this.AracVitesTuru.TabIndex = 4;
            this.AracVitesTuru.Text = "Vites Türü";
            this.AracVitesTuru.SelectedIndexChanged += new System.EventHandler(this.AracVitesTuru_SelectedIndexChanged);
            // 
            // YilMin
            // 
            this.YilMin.Location = new System.Drawing.Point(72, 253);
            this.YilMin.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.YilMin.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.YilMin.Name = "YilMin";
            this.YilMin.Size = new System.Drawing.Size(71, 20);
            this.YilMin.TabIndex = 8;
            this.YilMin.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.YilMin.ValueChanged += new System.EventHandler(this.YilMin_ValueChanged);
            // 
            // AracModel
            // 
            this.AracModel.FormattingEnabled = true;
            this.AracModel.Location = new System.Drawing.Point(33, 79);
            this.AracModel.Name = "AracModel";
            this.AracModel.Size = new System.Drawing.Size(121, 21);
            this.AracModel.TabIndex = 3;
            this.AracModel.Text = "Model";
            this.AracModel.SelectedIndexChanged += new System.EventHandler(this.AracModel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min =";
            // 
            // AracMarka
            // 
            this.AracMarka.FormattingEnabled = true;
            this.AracMarka.Location = new System.Drawing.Point(33, 52);
            this.AracMarka.Name = "AracMarka";
            this.AracMarka.Size = new System.Drawing.Size(121, 21);
            this.AracMarka.TabIndex = 2;
            this.AracMarka.Text = "Marka";
            this.AracMarka.SelectedIndexChanged += new System.EventHandler(this.AracMarka_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Min =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Filtreleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max =";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(691, 353);
            this.dataGridView1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Max =";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilterExportButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AracMarka);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AracModel);
            this.panel1.Controls.Add(this.YilMin);
            this.panel1.Controls.Add(this.AracVitesTuru);
            this.panel1.Controls.Add(this.KmMin);
            this.panel1.Controls.Add(this.AracYakitTuru);
            this.panel1.Controls.Add(this.YilMax);
            this.panel1.Controls.Add(this.AracCokluFiltrelemeButonu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AracFiltreTemizlemebutonu);
            this.panel1.Controls.Add(this.KmMax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 454);
            this.panel1.TabIndex = 14;
            // 
            // FilterExportButton
            // 
            this.FilterExportButton.Location = new System.Drawing.Point(33, 363);
            this.FilterExportButton.Name = "FilterExportButton";
            this.FilterExportButton.Size = new System.Drawing.Size(121, 23);
            this.FilterExportButton.TabIndex = 14;
            this.FilterExportButton.Text = "Verileri Dışarı Aktarın";
            this.FilterExportButton.UseVisualStyleBackColor = true;
            this.FilterExportButton.Click += new System.EventHandler(this.FilterExportButton_Click);
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 489);
            this.MinimumSize = new System.Drawing.Size(954, 489);
            this.Name = "KullaniciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciEkrani_FormClosed);
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KmMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YilMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KmMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YilMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown KmMax;
        private System.Windows.Forms.Button AracFiltreTemizlemebutonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AracCokluFiltrelemeButonu;
        private System.Windows.Forms.NumericUpDown YilMax;
        private System.Windows.Forms.ComboBox AracYakitTuru;
        private System.Windows.Forms.NumericUpDown KmMin;
        private System.Windows.Forms.ComboBox AracVitesTuru;
        private System.Windows.Forms.NumericUpDown YilMin;
        private System.Windows.Forms.ComboBox AracModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AracMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FilterExportButton;
    }
}