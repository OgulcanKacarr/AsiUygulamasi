namespace AsiUygulamasi
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            label_giris_yapmis_görevli = new Label();
            label_hasta_kayit = new Label();
            label_hasta_adi = new Label();
            textBox_hasta_adi = new TextBox();
            label_hasta_soyadi = new Label();
            textBox_hasta_soyadi = new TextBox();
            dateTimePicker_hasta_dogum_tarihi = new DateTimePicker();
            label_hasta_dogum_tarihi = new Label();
            label_hasta_cinsiyet = new Label();
            comboBox_hasta_cinsiyet = new ComboBox();
            label_hasta_telefon = new Label();
            textBox_hasta_telefon = new TextBox();
            button_yeni_hasta_ekle = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView_secilen_hasta_randevular = new DataGridView();
            dataGridView3 = new DataGridView();
            button_asi_randevu_ver = new Button();
            dateTimePicker_asi_randevu_tarihi = new DateTimePicker();
            comboBox_asi_sec = new ComboBox();
            label_hastaya_ait_randevular = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView1 = new DataGridView();
            dataGridView5 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_secilen_hasta_randevular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // label_giris_yapmis_görevli
            // 
            label_giris_yapmis_görevli.AutoSize = true;
            label_giris_yapmis_görevli.Location = new Point(12, 19);
            label_giris_yapmis_görevli.Name = "label_giris_yapmis_görevli";
            label_giris_yapmis_görevli.Size = new Size(47, 15);
            label_giris_yapmis_görevli.TabIndex = 0;
            label_giris_yapmis_görevli.Text = "Görevli:";
            // 
            // label_hasta_kayit
            // 
            label_hasta_kayit.AutoSize = true;
            label_hasta_kayit.Font = new Font("Segoe UI", 20F);
            label_hasta_kayit.Location = new Point(144, 19);
            label_hasta_kayit.Name = "label_hasta_kayit";
            label_hasta_kayit.Size = new Size(150, 37);
            label_hasta_kayit.TabIndex = 1;
            label_hasta_kayit.Text = "Hasta Kayıt";
            // 
            // label_hasta_adi
            // 
            label_hasta_adi.AutoSize = true;
            label_hasta_adi.Location = new Point(49, 69);
            label_hasta_adi.Name = "label_hasta_adi";
            label_hasta_adi.Size = new Size(25, 15);
            label_hasta_adi.TabIndex = 2;
            label_hasta_adi.Text = "Ad:";
            // 
            // textBox_hasta_adi
            // 
            textBox_hasta_adi.Location = new Point(138, 61);
            textBox_hasta_adi.Name = "textBox_hasta_adi";
            textBox_hasta_adi.Size = new Size(156, 23);
            textBox_hasta_adi.TabIndex = 3;
            // 
            // label_hasta_soyadi
            // 
            label_hasta_soyadi.AutoSize = true;
            label_hasta_soyadi.Location = new Point(49, 102);
            label_hasta_soyadi.Name = "label_hasta_soyadi";
            label_hasta_soyadi.Size = new Size(42, 15);
            label_hasta_soyadi.TabIndex = 6;
            label_hasta_soyadi.Text = "Soyad:";
            // 
            // textBox_hasta_soyadi
            // 
            textBox_hasta_soyadi.Location = new Point(138, 99);
            textBox_hasta_soyadi.Name = "textBox_hasta_soyadi";
            textBox_hasta_soyadi.Size = new Size(156, 23);
            textBox_hasta_soyadi.TabIndex = 7;
            // 
            // dateTimePicker_hasta_dogum_tarihi
            // 
            dateTimePicker_hasta_dogum_tarihi.Location = new Point(138, 129);
            dateTimePicker_hasta_dogum_tarihi.Name = "dateTimePicker_hasta_dogum_tarihi";
            dateTimePicker_hasta_dogum_tarihi.Size = new Size(158, 23);
            dateTimePicker_hasta_dogum_tarihi.TabIndex = 8;
            // 
            // label_hasta_dogum_tarihi
            // 
            label_hasta_dogum_tarihi.AutoSize = true;
            label_hasta_dogum_tarihi.Location = new Point(49, 135);
            label_hasta_dogum_tarihi.Name = "label_hasta_dogum_tarihi";
            label_hasta_dogum_tarihi.Size = new Size(81, 15);
            label_hasta_dogum_tarihi.TabIndex = 9;
            label_hasta_dogum_tarihi.Text = "Doğum Tarihi:";
            // 
            // label_hasta_cinsiyet
            // 
            label_hasta_cinsiyet.AutoSize = true;
            label_hasta_cinsiyet.Location = new Point(49, 205);
            label_hasta_cinsiyet.Name = "label_hasta_cinsiyet";
            label_hasta_cinsiyet.Size = new Size(49, 15);
            label_hasta_cinsiyet.TabIndex = 10;
            label_hasta_cinsiyet.Text = "Cinsiyet";
            // 
            // comboBox_hasta_cinsiyet
            // 
            comboBox_hasta_cinsiyet.FormattingEnabled = true;
            comboBox_hasta_cinsiyet.Location = new Point(138, 202);
            comboBox_hasta_cinsiyet.Name = "comboBox_hasta_cinsiyet";
            comboBox_hasta_cinsiyet.Size = new Size(156, 23);
            comboBox_hasta_cinsiyet.TabIndex = 11;
            // 
            // label_hasta_telefon
            // 
            label_hasta_telefon.AutoSize = true;
            label_hasta_telefon.Location = new Point(50, 168);
            label_hasta_telefon.Name = "label_hasta_telefon";
            label_hasta_telefon.Size = new Size(24, 15);
            label_hasta_telefon.TabIndex = 12;
            label_hasta_telefon.Text = "Tel:";
            // 
            // textBox_hasta_telefon
            // 
            textBox_hasta_telefon.Location = new Point(140, 165);
            textBox_hasta_telefon.Name = "textBox_hasta_telefon";
            textBox_hasta_telefon.Size = new Size(156, 23);
            textBox_hasta_telefon.TabIndex = 13;
            // 
            // button_yeni_hasta_ekle
            // 
            button_yeni_hasta_ekle.Location = new Point(138, 239);
            button_yeni_hasta_ekle.Name = "button_yeni_hasta_ekle";
            button_yeni_hasta_ekle.Size = new Size(156, 23);
            button_yeni_hasta_ekle.TabIndex = 14;
            button_yeni_hasta_ekle.Text = "Kaydet";
            button_yeni_hasta_ekle.UseVisualStyleBackColor = true;
            button_yeni_hasta_ekle.Click += button_yeni_hasta_ekle_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 299);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(865, 234);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(dataGridView5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(857, 206);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tüm Hastalar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(857, 206);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Çocuklar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView_secilen_hasta_randevular);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(857, 206);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bebekler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_secilen_hasta_randevular
            // 
            dataGridView_secilen_hasta_randevular.AllowUserToAddRows = false;
            dataGridView_secilen_hasta_randevular.AllowUserToDeleteRows = false;
            dataGridView_secilen_hasta_randevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_secilen_hasta_randevular.Location = new Point(472, 8);
            dataGridView_secilen_hasta_randevular.Name = "dataGridView_secilen_hasta_randevular";
            dataGridView_secilen_hasta_randevular.ReadOnly = true;
            dataGridView_secilen_hasta_randevular.Size = new Size(379, 192);
            dataGridView_secilen_hasta_randevular.TabIndex = 20;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1, 8);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(465, 192);
            dataGridView3.TabIndex = 0;
            // 
            // button_asi_randevu_ver
            // 
            button_asi_randevu_ver.Location = new Point(602, 129);
            button_asi_randevu_ver.Name = "button_asi_randevu_ver";
            button_asi_randevu_ver.Size = new Size(175, 23);
            button_asi_randevu_ver.TabIndex = 17;
            button_asi_randevu_ver.Text = "Randevu oluştur";
            button_asi_randevu_ver.UseVisualStyleBackColor = true;
            button_asi_randevu_ver.Click += button_asi_randevu_ver_Click;
            // 
            // dateTimePicker_asi_randevu_tarihi
            // 
            dateTimePicker_asi_randevu_tarihi.Location = new Point(602, 69);
            dateTimePicker_asi_randevu_tarihi.Name = "dateTimePicker_asi_randevu_tarihi";
            dateTimePicker_asi_randevu_tarihi.Size = new Size(175, 23);
            dateTimePicker_asi_randevu_tarihi.TabIndex = 18;
            // 
            // comboBox_asi_sec
            // 
            comboBox_asi_sec.FormattingEnabled = true;
            comboBox_asi_sec.Location = new Point(602, 98);
            comboBox_asi_sec.Name = "comboBox_asi_sec";
            comboBox_asi_sec.Size = new Size(175, 23);
            comboBox_asi_sec.TabIndex = 19;
            // 
            // label_hastaya_ait_randevular
            // 
            label_hastaya_ait_randevular.AutoSize = true;
            label_hastaya_ait_randevular.Location = new Point(651, 281);
            label_hastaya_ait_randevular.Name = "label_hastaya_ait_randevular";
            label_hastaya_ait_randevular.Size = new Size(66, 15);
            label_hastaya_ait_randevular.TabIndex = 1;
            label_hastaya_ait_randevular.Text = "Randevular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Randevu Tarihi";
            // 
            // button1
            // 
            button1.Location = new Point(1145, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Randevu oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_asi_randevu_ver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 101);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Aşı Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(589, 19);
            label3.Name = "label3";
            label3.Size = new Size(188, 37);
            label3.TabIndex = 1;
            label3.Text = "Aşı Randevusu";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(474, 7);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(379, 192);
            dataGridView2.TabIndex = 22;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 7);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.Size = new Size(465, 192);
            dataGridView4.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(474, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(379, 192);
            dataGridView1.TabIndex = 22;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 7);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.Size = new Size(465, 192);
            dataGridView5.TabIndex = 21;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 545);
            Controls.Add(comboBox_asi_sec);
            Controls.Add(dateTimePicker_asi_randevu_tarihi);
            Controls.Add(button1);
            Controls.Add(button_asi_randevu_ver);
            Controls.Add(tabControl1);
            Controls.Add(button_yeni_hasta_ekle);
            Controls.Add(textBox_hasta_telefon);
            Controls.Add(label_hasta_telefon);
            Controls.Add(comboBox_hasta_cinsiyet);
            Controls.Add(label_hasta_cinsiyet);
            Controls.Add(label_hasta_dogum_tarihi);
            Controls.Add(dateTimePicker_hasta_dogum_tarihi);
            Controls.Add(textBox_hasta_soyadi);
            Controls.Add(label_hasta_soyadi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_hasta_adi);
            Controls.Add(label_hasta_adi);
            Controls.Add(label_hastaya_ait_randevular);
            Controls.Add(label3);
            Controls.Add(label_hasta_kayit);
            Controls.Add(label_giris_yapmis_görevli);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_secilen_hasta_randevular).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_giris_yapmis_görevli;
        private Label label_hasta_kayit;
        private Label label_hasta_adi;
        private TextBox textBox_hasta_adi;
        private Label label_hasta_soyadi;
        private TextBox textBox_hasta_soyadi;
        private DateTimePicker dateTimePicker_hasta_dogum_tarihi;
        private Label label_hasta_dogum_tarihi;
        private Label label_hasta_cinsiyet;
        private ComboBox comboBox_hasta_cinsiyet;
        private Label label_hasta_telefon;
        private TextBox textBox_hasta_telefon;
        private Button button_yeni_hasta_ekle;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Button button_asi_randevu_ver;
        private DateTimePicker dateTimePicker_asi_randevu_tarihi;
        private ComboBox comboBox_asi_sec;
        private DataGridView dataGridView_secilen_hasta_randevular;
        private Label label_hastaya_ait_randevular;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView5;
        private DataGridView dataGridView2;
        private DataGridView dataGridView4;
    }
}