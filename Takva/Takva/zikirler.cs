using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takva
{
    public partial class zikirler : Form
    {
        private string connectionString = "Server=KEVSER;Database=takva;Trusted_Connection=True";
        public zikirler()
        {
            InitializeComponent();
        }

        private void ZikirOkunusu(string zikirAdi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT zikir FROM zikirler WHERE zikir=@ZikirAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ZikirAdi", zikirAdi);

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        label2.Text = sqlDataReader["zikir"].ToString();
                    }
                }
            }
        }

        private void MealOkunusu(string zikirAdi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT meal FROM zikirler WHERE zikir=@ZikirAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ZikirAdi", zikirAdi);

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        label4.Text = sqlDataReader["meal"].ToString();
                    }
                }
            }
        }
        private void zikirler_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenzikir = comboBox1.SelectedItem.ToString();
            ZikirOkunusu(secilenzikir);
            MealOkunusu(secilenzikir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
