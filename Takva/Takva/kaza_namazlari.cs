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
    public partial class kaza_namazlari : Form
    {
        private string connectionString = " Server= KEVSER;Database=takva;Trusted_Connection=True";
        public kaza_namazlari()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kazaNamazlari()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT kilinmayan_namaz FROM namaz_durumu";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            // Verinin null olup olmadığını kontrol et
                            if (!reader.IsDBNull(reader.GetOrdinal("kilinmayan_namaz")))
                            {
                                listBox1.Items.Add(reader["kilinmayan_namaz"].ToString());
                            }
                        }
                    }
                }
            }
        }
        private void kaza_namazlari_Load(object sender, EventArgs e)
        {
            kazaNamazlari();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
