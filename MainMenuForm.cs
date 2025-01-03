using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsiUygulamasi
{
    public partial class MainMenuForm : Form
    {
        // Connection string
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AsiUygulamasi"].ConnectionString;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button_yeni_hasta_ekle_Click(object sender, EventArgs e)
        {
            string name = textBox_hasta_adi.Text;
            string surname = textBox_hasta_soyadi.Text;
            DateTime dateOfBirth = dateTimePicker_hasta_dogum_tarihi.Value;
            string gender = comboBox_hasta_cinsiyet.SelectedItem.ToString();
            string phoneNumber = textBox_hasta_telefon.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Patients (Name, Surname, DateOfBirth, Gender, PhoneNumber) VALUES (@Name, @Surname, @DateOfBirth, @Gender, @PhoneNumber)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Surname", surname);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Yeni hasta başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Yeni hasta eklendikten sonra DataGridView'ı güncelle
                        LoadAllPatients();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // ComboBox'a cinsiyet seçeneklerini ekliyoruz
            comboBox_hasta_cinsiyet.Items.Add("Erkek");
            comboBox_hasta_cinsiyet.Items.Add("Kadın");
            comboBox_hasta_cinsiyet.SelectedIndex = 0;  // "Erkek" varsayılan olarak seçili
            comboBox_hasta_cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            // Giriş yapmış kullanıcının adını ve soyadını label'a ekleyelim
            label_giris_yapmis_görevli.Text = $"{Form1.currentAdminName}  ({Form1.currentAdminRole})";

            // Sekme üzerine gelindiğinde filtrelemeyi başlat
            LoadAllPatients(); // İlk başta tüm hastaları listele


            // Sekme üzerine gelindiğinde filtrelemeyi başlat
            LoadAllPatients(); // İlk başta tüm hastaları listele
            LoadVaccines(); // Aşıları yükle


        }

        //aşılar
        private void LoadVaccines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT VaccineID, VaccineName FROM Vaccines";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // ComboBox'a her aşı için Text ve Value ekleniyor
                            comboBox_asi_sec.Items.Add(new { Text = reader["VaccineName"].ToString(), Value = reader["VaccineID"] });
                        }
                    }

                    // ComboBox'ın görünür metin ve değeri belirleniyor
                    comboBox_asi_sec.DisplayMember = "Text";
                    comboBox_asi_sec.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aşılar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // Tüm hastaları DataGridView'a yükle
        private void LoadAllPatients()
        {
            LoadPatients("SELECT PatientID,Name, Surname, DateOfBirth, PhoneNumber, Gender FROM Patients", dataGridView1);
        }

        // 18 yaş altı hastaları DataGridView'a yükle
        private void LoadUnder18Patients()
        {
            LoadPatients("SELECT PatientID,Name, Surname, DateOfBirth, PhoneNumber, Gender FROM Patients WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) < 18", dataGridView2);
        }

        // 5 yaş altı hastaları DataGridView'a yükle
        private void LoadUnder5Patients()
        {
            LoadPatients("SELECT PatientID, Name, Surname, DateOfBirth, PhoneNumber, Gender FROM Patients WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) < 5", dataGridView3);
        }

        // DataGridView'a hastaları yüklemek için ortak metod
        private void LoadPatients(string query, DataGridView targetGridView)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanından hastaları çeken sorgu
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Veritabanındaki hastaları DataTable'a yükle

                        // İlgili DataGridView'a bağla
                        targetGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // TabControl'de sekme değiştiğinde (selected index değiştiğinde)
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hangi sekmenin seçildiğini kontrol et
            int selectedIndex = tabControl1.SelectedIndex;

            // Seçilen sekmeye göre uygun veri yükleme fonksiyonunu çağır
            switch (selectedIndex)
            {
                case 0:
                    // 1. sekme - Tüm hastalar
                    LoadAllPatients();
                    break;
                case 1:
                    // 2. sekme - 18 yaş altı hastalar
                    LoadUnder18Patients();
                    break;
                case 2:
                    // 3. sekme - 5 yaş altı hastalar
                    LoadUnder5Patients();
                    break;
                default:
                    break;
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen hastanın ID'sini al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);  // PatientID'yi doğru kolon adıyla değiştirin

                // Seçilen hasta bilgilerini TextBox'lara aktar
                textBox_hasta_adi.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox_hasta_soyadi.Text = selectedRow.Cells["Surname"].Value.ToString();
                dateTimePicker_hasta_dogum_tarihi.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                comboBox_hasta_cinsiyet.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
                textBox_hasta_telefon.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();

                // Seçilen hasta için randevuları yükle
                LoadAppointmentsForPatient(patientId);
            }
        }


        //seçilen hastanın randevularını getir
        private void LoadAppointmentsForPatient(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT a.AppointmentID, v.VaccineName, a.AppointmentDate, a.Status " +
                                   "FROM Appointments a " +
                                   "JOIN Vaccines v ON a.VaccineID = v.VaccineID " +
                                   "WHERE a.PatientID = @PatientID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Veritabanındaki randevuları DataTable'a yükle

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Bu hasta için hiç randevu bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Randevuları ilgili DataGridView'a yükle
                            dataGridView_secilen_hasta_randevular.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Randevular yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_asi_randevu_ver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen hastanın ID'sini al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);  // PatientID'yi doğru kolon adıyla değiştirin
                int vaccineId = ((dynamic)comboBox_asi_sec.SelectedItem).Value;  // VaccineID'yi ComboBox'dan al
                DateTime vaccineDate = dateTimePicker_asi_randevu_tarihi.Value;
                string status = "Planlandı"; // Başlangıçta randevu statüsü "Planlandı" olacak

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Appointments (PatientID, VaccineID, AppointmentDate, Status) VALUES (@PatientID, @VaccineID, @AppointmentDate, @Status)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PatientID", patientId);
                            command.Parameters.AddWithValue("@VaccineID", vaccineId);
                            command.Parameters.AddWithValue("@AppointmentDate", vaccineDate);
                            command.Parameters.AddWithValue("@Status", status);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Aşı randevusu başarıyla verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
