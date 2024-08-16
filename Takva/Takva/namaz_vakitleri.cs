using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;

namespace Takva
{
    public partial class namaz_vakitleri : Form
    {
        public namaz_vakitleri()
        {
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            var cities = new List<string>
            {
                "adana", "adıyaman", "afyon", "ağrı", "aksaray", "amasya", "ankara", "antalya",
                "ardahan", "artvin", "aydın", "balıkesir", "bartın", "batman", "bayburt", "bilecik",
                "bingöl", "bitlis", "bolu", "burdur", "bursa", "çanakkale", "çankırı", "çorum",
                "denizli", "diyarbakır", "düzce", "edirne", "elazığ", "erzincan", "erzurum",
                "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ığdır",
                "isparta", "istanbul", "izmir", "kahramanmaraş", "karabük", "karaman", "kars",
                "kastamonu", "kayseri", "kırıkkale", "kırklareli", "kırşehir", "kilis", "kocaeli",
                "konya", "kütahya", "malatya", "manisa", "mardin", "mersin", "muğla", "muş",
                "nevşehir", "niğde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "siirt",
                "sinop", "sivas", "şanlıurfa", "şırnak", "tekirdağ", "tokat", "trabzon", "tunceli",
                "uşak", "van", "yalova", "yozgat", "zonguldak"
            };

            comboBox1.DataSource = cities;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem.ToString();

            var client = new RestClient($"https://api.collectapi.com/pray/all?data.city={selectedCity}");
            var request = new RestRequest();
            request.AddHeader("authorization", "apikey 0qjVnL4emVzh1qODtdisYI:0pa2NvQsVbbG0eeHCUbAwU");
            request.AddHeader("content-type", "application/json");


            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                textBox1.Clear();
                textBox1.Text = $"City: {selectedCity}, Response: {response.Content}";
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


