namespace AsiUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_görevli_numarasi = new Label();
            textBox_kullanici_adi = new TextBox();
            textBox_sifre = new TextBox();
            label_kullanici_sifre = new Label();
            button_giris_yap = new Button();
            lblErrorMessage = new Label();
            label_sifre = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label_görevli_numarasi
            // 
            label_görevli_numarasi.AutoSize = true;
            label_görevli_numarasi.Location = new Point(72, 130);
            label_görevli_numarasi.Name = "label_görevli_numarasi";
            label_görevli_numarasi.Size = new Size(47, 15);
            label_görevli_numarasi.TabIndex = 0;
            label_görevli_numarasi.Text = "Görevli:";
            // 
            // textBox_kullanici_adi
            // 
            textBox_kullanici_adi.Location = new Point(122, 127);
            textBox_kullanici_adi.Name = "textBox_kullanici_adi";
            textBox_kullanici_adi.Size = new Size(207, 23);
            textBox_kullanici_adi.TabIndex = 1;
            // 
            // textBox_sifre
            // 
            textBox_sifre.Location = new Point(122, 162);
            textBox_sifre.Name = "textBox_sifre";
            textBox_sifre.Size = new Size(207, 23);
            textBox_sifre.TabIndex = 2;
            // 
            // label_kullanici_sifre
            // 
            label_kullanici_sifre.Location = new Point(0, 0);
            label_kullanici_sifre.Name = "label_kullanici_sifre";
            label_kullanici_sifre.Size = new Size(100, 23);
            label_kullanici_sifre.TabIndex = 5;
            // 
            // button_giris_yap
            // 
            button_giris_yap.Location = new Point(122, 191);
            button_giris_yap.Name = "button_giris_yap";
            button_giris_yap.Size = new Size(207, 23);
            button_giris_yap.TabIndex = 4;
            button_giris_yap.Text = "Giriş yap";
            button_giris_yap.UseVisualStyleBackColor = true;
            button_giris_yap.Click += button_giris_yap_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(143, 228);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(159, 15);
            lblErrorMessage.TabIndex = 6;
            lblErrorMessage.Text = "Hatalı kullanıcı adı veya şifre.";
            lblErrorMessage.Visible = false;
            // 
            // label_sifre
            // 
            label_sifre.AutoSize = true;
            label_sifre.Location = new Point(86, 165);
            label_sifre.Name = "label_sifre";
            label_sifre.Size = new Size(33, 15);
            label_sifre.TabIndex = 7;
            label_sifre.Text = "Şifre:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(174, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 46);
            label1.TabIndex = 8;
            label1.Text = "Giriş";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(label1);
            Controls.Add(label_sifre);
            Controls.Add(lblErrorMessage);
            Controls.Add(button_giris_yap);
            Controls.Add(label_kullanici_sifre);
            Controls.Add(textBox_sifre);
            Controls.Add(textBox_kullanici_adi);
            Controls.Add(label_görevli_numarasi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_görevli_numarasi;
        private TextBox textBox_kullanici_adi;
        private TextBox textBox_sifre;
        private Label label_kullanici_sifre;
        private Button button_giris_yap;
        private Label lblErrorMessage;
        private Label label_sifre;
        private Label label1;
    }
}
