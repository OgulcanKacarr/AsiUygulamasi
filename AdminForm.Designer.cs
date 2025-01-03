namespace AsiUygulamasi
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            textBox_görevli_adi = new TextBox();
            label_görevli_adi = new Label();
            label_görevli_kullanici_adi = new Label();
            textBox_görevli_kullanici_adi = new TextBox();
            textBox_görevli_kullanici_sifre = new TextBox();
            label_görevli_sifre = new Label();
            comboBox_görevli_rol = new ComboBox();
            label_görevli_rol = new Label();
            button_yeni_görevli_ekle = new Button();
            label1 = new Label();
            label_yeni_asi_ekle = new Label();
            label_asi_adi = new Label();
            textBox_asi_adi = new TextBox();
            textBox_asi_aciklamasi = new TextBox();
            label_asi_aciklamasi = new Label();
            button_yeni_asi_ekle = new Button();
            button_cikis = new Button();
            dataGridView1 = new DataGridView();
            label_tüm_görevliler = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_görevli_adi
            // 
            textBox_görevli_adi.Location = new Point(132, 103);
            textBox_görevli_adi.Name = "textBox_görevli_adi";
            textBox_görevli_adi.Size = new Size(175, 23);
            textBox_görevli_adi.TabIndex = 0;
            // 
            // label_görevli_adi
            // 
            label_görevli_adi.AutoSize = true;
            label_görevli_adi.Location = new Point(54, 107);
            label_görevli_adi.Name = "label_görevli_adi";
            label_görevli_adi.Size = new Size(66, 15);
            label_görevli_adi.TabIndex = 1;
            label_görevli_adi.Text = "Görevli adı:";
            // 
            // label_görevli_kullanici_adi
            // 
            label_görevli_kullanici_adi.AutoSize = true;
            label_görevli_kullanici_adi.Location = new Point(46, 140);
            label_görevli_kullanici_adi.Name = "label_görevli_kullanici_adi";
            label_görevli_kullanici_adi.Size = new Size(74, 15);
            label_görevli_kullanici_adi.TabIndex = 2;
            label_görevli_kullanici_adi.Text = "Kullanıcı adı:";
            // 
            // textBox_görevli_kullanici_adi
            // 
            textBox_görevli_kullanici_adi.Location = new Point(133, 137);
            textBox_görevli_kullanici_adi.Name = "textBox_görevli_kullanici_adi";
            textBox_görevli_kullanici_adi.Size = new Size(174, 23);
            textBox_görevli_kullanici_adi.TabIndex = 3;
            // 
            // textBox_görevli_kullanici_sifre
            // 
            textBox_görevli_kullanici_sifre.Location = new Point(132, 172);
            textBox_görevli_kullanici_sifre.Name = "textBox_görevli_kullanici_sifre";
            textBox_görevli_kullanici_sifre.Size = new Size(173, 23);
            textBox_görevli_kullanici_sifre.TabIndex = 4;
            // 
            // label_görevli_sifre
            // 
            label_görevli_sifre.AutoSize = true;
            label_görevli_sifre.Location = new Point(90, 175);
            label_görevli_sifre.Name = "label_görevli_sifre";
            label_görevli_sifre.Size = new Size(33, 15);
            label_görevli_sifre.TabIndex = 5;
            label_görevli_sifre.Text = "Şifre:";
            // 
            // comboBox_görevli_rol
            // 
            comboBox_görevli_rol.FormattingEnabled = true;
            comboBox_görevli_rol.Location = new Point(132, 201);
            comboBox_görevli_rol.Name = "comboBox_görevli_rol";
            comboBox_görevli_rol.Size = new Size(175, 23);
            comboBox_görevli_rol.TabIndex = 6;
            // 
            // label_görevli_rol
            // 
            label_görevli_rol.AutoSize = true;
            label_görevli_rol.Location = new Point(93, 204);
            label_görevli_rol.Name = "label_görevli_rol";
            label_görevli_rol.Size = new Size(27, 15);
            label_görevli_rol.TabIndex = 7;
            label_görevli_rol.Text = "Rol:";
            // 
            // button_yeni_görevli_ekle
            // 
            button_yeni_görevli_ekle.Location = new Point(176, 239);
            button_yeni_görevli_ekle.Name = "button_yeni_görevli_ekle";
            button_yeni_görevli_ekle.Size = new Size(75, 23);
            button_yeni_görevli_ekle.TabIndex = 8;
            button_yeni_görevli_ekle.Text = "Oluştur";
            button_yeni_görevli_ekle.UseVisualStyleBackColor = true;
            button_yeni_görevli_ekle.Click += button_yeni_görevli_ekle_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(79, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.TabIndex = 9;
            label1.Text = "Yeni Görevli Ekle";
            // 
            // label_yeni_asi_ekle
            // 
            label_yeni_asi_ekle.AutoSize = true;
            label_yeni_asi_ekle.Font = new Font("Segoe UI", 25F);
            label_yeni_asi_ekle.Location = new Point(532, 33);
            label_yeni_asi_ekle.Name = "label_yeni_asi_ekle";
            label_yeni_asi_ekle.Size = new Size(203, 46);
            label_yeni_asi_ekle.TabIndex = 10;
            label_yeni_asi_ekle.Text = "Yeni Aşı Ekle";
            // 
            // label_asi_adi
            // 
            label_asi_adi.AutoSize = true;
            label_asi_adi.Location = new Point(489, 107);
            label_asi_adi.Name = "label_asi_adi";
            label_asi_adi.Size = new Size(47, 15);
            label_asi_adi.TabIndex = 11;
            label_asi_adi.Text = "Aşı Adı:";
            // 
            // textBox_asi_adi
            // 
            textBox_asi_adi.Location = new Point(542, 103);
            textBox_asi_adi.Name = "textBox_asi_adi";
            textBox_asi_adi.Size = new Size(193, 23);
            textBox_asi_adi.TabIndex = 12;
            // 
            // textBox_asi_aciklamasi
            // 
            textBox_asi_aciklamasi.Location = new Point(542, 140);
            textBox_asi_aciklamasi.Name = "textBox_asi_aciklamasi";
            textBox_asi_aciklamasi.Size = new Size(193, 23);
            textBox_asi_aciklamasi.TabIndex = 13;
            // 
            // label_asi_aciklamasi
            // 
            label_asi_aciklamasi.AutoSize = true;
            label_asi_aciklamasi.Location = new Point(480, 145);
            label_asi_aciklamasi.Name = "label_asi_aciklamasi";
            label_asi_aciklamasi.Size = new Size(59, 15);
            label_asi_aciklamasi.TabIndex = 14;
            label_asi_aciklamasi.Text = "Açıklama:";
            // 
            // button_yeni_asi_ekle
            // 
            button_yeni_asi_ekle.Location = new Point(597, 175);
            button_yeni_asi_ekle.Name = "button_yeni_asi_ekle";
            button_yeni_asi_ekle.Size = new Size(75, 23);
            button_yeni_asi_ekle.TabIndex = 15;
            button_yeni_asi_ekle.Text = "Ekle";
            button_yeni_asi_ekle.UseVisualStyleBackColor = true;
            button_yeni_asi_ekle.Click += button_yeni_asi_ekle_Click;
            // 
            // button_cikis
            // 
            button_cikis.Location = new Point(12, 12);
            button_cikis.Name = "button_cikis";
            button_cikis.Size = new Size(75, 23);
            button_cikis.TabIndex = 16;
            button_cikis.Text = "Çıkış";
            button_cikis.UseVisualStyleBackColor = true;
            button_cikis.Click += button_cikis_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 150);
            dataGridView1.TabIndex = 17;
            // 
            // label_tüm_görevliler
            // 
            label_tüm_görevliler.AutoSize = true;
            label_tüm_görevliler.Location = new Point(362, 270);
            label_tüm_görevliler.Name = "label_tüm_görevliler";
            label_tüm_görevliler.Size = new Size(83, 15);
            label_tüm_görevliler.TabIndex = 18;
            label_tüm_görevliler.Text = "Tüm görevliler";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_tüm_görevliler);
            Controls.Add(dataGridView1);
            Controls.Add(button_cikis);
            Controls.Add(button_yeni_asi_ekle);
            Controls.Add(label_asi_aciklamasi);
            Controls.Add(textBox_asi_aciklamasi);
            Controls.Add(textBox_asi_adi);
            Controls.Add(label_asi_adi);
            Controls.Add(label_yeni_asi_ekle);
            Controls.Add(label1);
            Controls.Add(button_yeni_görevli_ekle);
            Controls.Add(label_görevli_rol);
            Controls.Add(comboBox_görevli_rol);
            Controls.Add(label_görevli_sifre);
            Controls.Add(textBox_görevli_kullanici_sifre);
            Controls.Add(textBox_görevli_kullanici_adi);
            Controls.Add(label_görevli_kullanici_adi);
            Controls.Add(label_görevli_adi);
            Controls.Add(textBox_görevli_adi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_görevli_adi;
        private Label label_görevli_adi;
        private Label label_görevli_kullanici_adi;
        private TextBox textBox_görevli_kullanici_adi;
        private TextBox textBox_görevli_kullanici_sifre;
        private Label label_görevli_sifre;
        private ComboBox comboBox_görevli_rol;
        private Label label_görevli_rol;
        private Button button_yeni_görevli_ekle;
        private Label label1;
        private Label label_yeni_asi_ekle;
        private Label label_asi_adi;
        private TextBox textBox_asi_adi;
        private TextBox textBox_asi_aciklamasi;
        private Label label_asi_aciklamasi;
        private Button button_yeni_asi_ekle;
        private Button button_cikis;
        private DataGridView dataGridView1;
        private Label label_tüm_görevliler;
    }
}