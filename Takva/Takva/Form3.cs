using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Takva
{
    public partial class Dualar : Form
    {
        private string connectionString = "Server=KEVSER;Database=takva;Trusted_Connection=True";
        public Dualar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen_dua = comboBox1.SelectedItem.ToString();
            DuaOkunusu(secilen_dua);
        }

        private void DuaOkunusu(string duaAdi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT duanin_okunusu FROM namaz_dualari WHERE dua_adi=@duaAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@duaAdi", duaAdi);

                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        label3.Text = sqlDataReader["duanin_okunusu"].ToString();
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
