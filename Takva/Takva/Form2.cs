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
    public partial class Sureler : Form
    {
        private string connectionString = "Server=KEVSER;Database=takva;Trusted_Connection=True";
        public Sureler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen_sure = comboBox1.SelectedItem.ToString();
            SureOkunusu(secilen_sure);
        }

        private void SureOkunusu(string sureAdi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT surenin_okunusu FROM namaz_sureleri WHERE sure_adi=@SureAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SureAdi", sureAdi);

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        label2.Text = sqlDataReader["surenin_okunusu"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
