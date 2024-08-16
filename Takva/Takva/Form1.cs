using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Takva
   
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=KEVSER;Database=takva;Trusted_Connection=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRandomHadis();
        }

        private void LoadRandomHadis()
        {
            string hadis = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 hadis FROM hadisler ORDER BY NEWID()";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        hadis = reader["hadis"].ToString();
                    }
                }
            }
            label6.Text = hadis;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadRandomHadis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sureler sureler = new Sureler();
            sureler.Show();
            this.Hide(); //Form1'i kapatýr.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dualar dualar = new Dualar();
            dualar.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kilinan_namazlar namaz = new kilinan_namazlar();
            namaz.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kaza_namazlari kaza_namazlari = new kaza_namazlari();
            kaza_namazlari.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zikirler zikirler = new zikirler();
            zikirler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            namaz_vakitleri namazVakitleri = new namaz_vakitleri();
            namazVakitleri.Show();
            this.Hide();
        }
    }
}
