namespace Takva
{
    partial class namaz_vakitleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(-1, 9);
            label1.Name = "label1";
            label1.Size = new Size(599, 73);
            label1.TabIndex = 2;
            label1.Text = "       Namaz Vakitleri        ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "adana", "adıyaman", "afyon", "ağrı", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin", "aydın", "balıkesir", "bartın", "batman", "bayburt", "bilecik", "bingöl", "bitlis", "bolu", "burdur", "bursa", "çanakkale", "çankırı", "çorum", "denizli", "diyarbakır", "düzce", "edirne", "elazığ", "erzincan", "erzurum", "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ığdır", "isparta", "istanbul", "izmir", "kahramanmaraş", "karabük", "karaman", "kars", "kastamonu", "kayseri", "kırıkkale", "kırklareli", "kırşehir", "kilis", "kocaeli", "konya", "kütahya", "malatya", "manisa", "mardin", "mersin", "muğla", "muş", "nevşehir", "niğde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas", "şanlıurfa", "şırnak", "tekirdağ", "tokat", "trabzon", "tunceli", "uşak", "van", "yalova", "yozgat", "zonguldak" });
            comboBox1.Location = new Point(144, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 94);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 6;
            label3.Text = "Lütfen şehri seçiniz.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightYellow;
            textBox1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.OliveDrab;
            textBox1.Location = new Point(175, 197);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 374);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button1.Location = new Point(492, 584);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // namaz_vakitleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir1;
            ClientSize = new Size(598, 625);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "namaz_vakitleri";
            Text = "namaz_vakitleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}