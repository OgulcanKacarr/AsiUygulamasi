using Microsoft.Data.SqlClient;

namespace AsiUygulamasi
{
    public partial class Form1 : Form
    {
        // Connection string
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AsiUygulamasi"].ConnectionString;

        // Adminin ID'sini ve ad-soyadýný saklayacak global deðiþkenler
        public static int currentAdminID;
        public static string currentAdminRole;
        public static string currentAdminName;


        public Form1()
        {
            InitializeComponent();
        }

        // Giriþ yap butonuna basýnca
        private void button_giris_yap_Click(object sender, EventArgs e)
        {
            // Kullanýcý giriþ bilgilerini al
            string username = textBox_kullanici_adi.Text;
            string password = textBox_sifre.Text;

            // Veritabanýna baðlan
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
                                // Kullanýcýnýn StaffID, Role, Name ve Surname'ini alýyoruz
                                int staffID = reader.GetInt32(0); // StaffID (Adminin ID'si)
                                string role = reader.GetString(1); // Kullanýcýnýn rolü
                                string name = reader.GetString(2); // Kullanýcýnýn adý

                                // Adminin ID'sini, rolünü, adýný ve soyadýný global olarak saklýyoruz
                                currentAdminID = staffID;
                                currentAdminRole = role;
                                currentAdminName = name;


                                if (role == "Admin")
                                {
                                    // Admin olarak giriþ yaptýysa Admin formunu açýyoruz
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Normal görevli olarak giriþ yaptýysa Main Menu formunu açýyoruz
                                    MainMenuForm mainMenu = new MainMenuForm();
                                    mainMenu.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            // Hatalý giriþ
                            lblErrorMessage.Text = "Hatalý kullanýcý adý veya þifre.";
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
            // Þifre alanýný yýldýzlý yap
            textBox_sifre.UseSystemPasswordChar = true;
        }
    }
}
