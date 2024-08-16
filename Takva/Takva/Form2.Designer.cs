namespace Takva
{
    partial class Sureler
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Vladimir Script", 36.2F);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(-4, 9);
            label1.Name = "label1";
            label1.Size = new Size(700, 74);
            label1.TabIndex = 0;
            label1.Text = "         Namaz Sureleri              ";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fil", "Kureyş", "Maun", "Kevser", "Kafirun", "Nasr", "Tebbet", "İhlas", "Felak", "Nas" });
            comboBox1.Location = new Point(143, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("SimSun", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Location = new Point(486, 517);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(193, 111);
            label3.Name = "label3";
            label3.Size = new Size(194, 27);
            label3.TabIndex = 4;
            label3.Text = "Lütfen Sureyi seçiniz.";
            // 
            // Sureler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir;
            ClientSize = new Size(592, 558);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Sureler";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}