using Microsoft.Data.SqlClient;

namespace AsiUygulamasi
{
    public partial class Form1 : Form
    {
        // Connection string
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AsiUygulamasi"].ConnectionString;

        // Adminin ID'sini ve ad-soyad�n� saklayacak global de�i�kenler
        public static int currentAdminID;
        public static string currentAdminRole;
        public static string currentAdminName;


        public Form1()
        {
            InitializeComponent();
        }

        // Giri� yap butonuna bas�nca
        private void button_giris_yap_Click(object sender, EventArgs e)
        {
            // Kullan�c� giri� bilgilerini al
            string username = textBox_kullanici_adi.Text;
            string password = textBox_sifre.Text;

            // Veritaban�na ba�lan
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL sorgusu
                    string query = "SELECT StaffID, Role, Name FROM Staff WHERE Username = @username AND Password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreler
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Kullan�c�n�n StaffID, Role, Name ve Surname'ini al�yoruz
                                int staffID = reader.GetInt32(0); // StaffID (Adminin ID'si)
                                string role = reader.GetString(1); // Kullan�c�n�n rol�
                                string name = reader.GetString(2); // Kullan�c�n�n ad�

                                // Adminin ID'sini, rol�n�, ad�n� ve soyad�n� global olarak sakl�yoruz
                                currentAdminID = staffID;
                                currentAdminRole = role;
                                currentAdminName = name;


                                if (role == "Admin")
                                {
                                    // Admin olarak giri� yapt�ysa Admin formunu a��yoruz
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Normal g�revli olarak giri� yapt�ysa Main Menu formunu a��yoruz
                                    MainMenuForm mainMenu = new MainMenuForm();
                                    mainMenu.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            // Hatal� giri�
                            lblErrorMessage.Text = "Hatal� kullan�c� ad� veya �ifre.";
                            lblErrorMessage.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �ifre alan�n� y�ld�zl� yap
            textBox_sifre.UseSystemPasswordChar = true;
        }
    }
}
