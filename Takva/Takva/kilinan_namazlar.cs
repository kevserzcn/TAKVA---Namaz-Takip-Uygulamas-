using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Takva
{
    public partial class kilinan_namazlar : Form
    {
        private string connectionString = "Server=KEVSER;Database=takva;Trusted_Connection=True";
        public kilinan_namazlar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void SaveNamazDurumu()
        {
            DateTime currentDateTime = DateTime.Now;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string[] namazIsimleri = { "Sabah Namazı", "Öğle Namazı", "İkindi Namazı", "Akşam Namazı", "Yatsı Namazı", "Vitr Namazı" };

                    for (int i = 1; i <= 6; i++)
                    {
                        string checkboxName = "checkBox" + i;
                        CheckBox checkBox = this.Controls[checkboxName] as CheckBox;

                        if (checkBox != null)
                        {
                            string namazIsmi = namazIsimleri[i - 1];
                            string sutunAdi = checkBox.Checked ? "kilinan_namaz" : "kilinmayan_namaz";
                            InsertNamazDurumu(connection, sutunAdi, namazIsmi, currentDateTime);
                        }
                    }

                    MessageBox.Show("Namaz durumu başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Namaz durumu kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }

        private void InsertNamazDurumu(SqlConnection connection, string sutunAdi, string namazIsmi, DateTime tarihSaat)
        {
            string query = $"INSERT INTO namaz_durumu ({sutunAdi}, tarih) VALUES (@namazIsmi, @tarihSaat)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@namazIsmi", namazIsmi);
                command.Parameters.AddWithValue("@tarihSaat", tarihSaat);
                command.ExecuteNonQuery();
            }
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Application_Idle(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void kilinan_namazlar_Load(object sender, EventArgs e)
        {

            Application.Idle += new EventHandler(Application_Idle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveNamazDurumu();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
