using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsiUygulamasi
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Server=localhost;Database=AsiUygulamasi;Trusted_Connection=True;TrustServerCertificate=True;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button_yeni_görevli_ekle_Click(object sender, EventArgs e)
        {
            string name = textBox_görevli_adi.Text;
            string username = textBox_görevli_kullanici_adi.Text;
            string password = textBox_görevli_kullanici_sifre.Text;
            string role = comboBox_görevli_rol.SelectedItem?.ToString();  // null kontrolü ekledik
            int createdBy = Form1.currentAdminID;  // Adminin ID'si

            // Alanlar boş mu kontrol edelim
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Eğer bir alan boşsa işlemi sonlandır
            }

            // Yeni görevli ekleme işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL sorgusu ile yeni görevliyi ekliyoruz
                    string query = "INSERT INTO Staff (Name, Username, Password, Role, CreatedBy) " +
                                   "VALUES (@Name, @Username, @Password, @Role, @CreatedBy)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@CreatedBy", createdBy); // Admin ID'si burada

                        command.ExecuteNonQuery();
                        MessageBox.Show("Yeni görevli başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            // ComboBox'a Admin ve Normal Görevli rolünü ekleyelim
            comboBox_görevli_rol.Items.Add("Admin");
            comboBox_görevli_rol.Items.Add("Normal Görevli");
            comboBox_görevli_rol.DropDownStyle = ComboBoxStyle.DropDownList;

            // Varsayılan olarak normal görevli rolü seçili olacak
            comboBox_görevli_rol.SelectedIndex = 1;

            // Tüm görevlileri DataGridView'da göstermek için veri çekme
            ShowStaffMembers();

        }
        private void button_yeni_asi_ekle_Click(object sender, EventArgs e)
        {
            string vaccineName = textBox_asi_adi.Text;
            string description = textBox_asi_aciklamasi.Text;
            int createdBy = Form1.currentAdminID;  // Admin ID'si, şu anda giriş yapan adminin ID'si

            // Aşı adı ve açıklaması boş mu kontrol edelim
            if (string.IsNullOrEmpty(vaccineName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Lütfen aşı adı ve açıklamasını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Eğer bir alan boşsa işlemi sonlandır
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Vaccines (VaccineName, Description, CreatedBy) VALUES (@VaccineName, @Description, @CreatedBy)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VaccineName", vaccineName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@CreatedBy", createdBy);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Yeni aşı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            //ana menüye git
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void ShowStaffMembers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL sorgusu
                    string query = "SELECT StaffID, Username, Name, Role FROM Staff";

                    // DataAdapter ile verileri alıyoruz
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Verileri DataTable'a yükleyelim
                    dataAdapter.Fill(dataTable);

                    // DataGridView'ı güzelleştirelim
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green; // Başlık rengini yeşil yapıyoruz
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Yazı rengini beyaz yapıyoruz
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Yazı tipini ve kalınlığını ayarlıyoruz

                    // DataGridView içindeki tüm kolonları AutoSize yapalım
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                 

                    // DataGridView'a veri kaynaklarını atayalım
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
