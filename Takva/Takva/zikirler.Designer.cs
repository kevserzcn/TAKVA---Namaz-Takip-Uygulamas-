namespace Takva
{
    partial class zikirler
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
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(686, 73);
            label1.TabIndex = 1;
            label1.Text = "             Zikirler                    ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sübhânallâhi ve bihamdihi sübhânallâhi'l azîm.", "Lâ havle ve lâ kuvvete illâ billâh.", "Lâ ilâhe illallah.", "Sübhanallahi velhamdülillâhi velâ ilâhe illallâhü vallâhü ekber.", "Sübhanallah.", "Elhamdülillah.", "Allahu ekber.", "Hasbünallahü ve ni'melvekîl.", "Lâ havle ve lâ kuvvete illâ billâh.", "İzâ merartüm bi-riyadı’l-cenneti ferte’û. Kalû ve me riyadu’l cenneti kâle halikûz zikr.", "Men eksera zikrâllâhi ehabbehûl'l teale." });
            comboBox1.Location = new Point(144, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 98);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 5;
            label3.Text = "Lütfen Zikri seçiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightYellow;
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(53, 218);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightYellow;
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(53, 349);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button1.Location = new Point(488, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // zikirler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir1;
            ClientSize = new Size(594, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "zikirler";
            Text = "zikirler";
            Load += zikirler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
    }
}