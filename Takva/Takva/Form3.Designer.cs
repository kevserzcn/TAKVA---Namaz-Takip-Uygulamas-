namespace Takva
{
    partial class Dualar
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
            label1.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, 9);
            label1.Name = "label1";
            label1.Size = new Size(604, 73);
            label1.TabIndex = 0;
            label1.Text = "       Namaz Duâları          ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ettehiyyatü", "Salli", "Barik", "Rabbena", "Kunut 1", "Kunut 2", "Süphaneke" });
            comboBox1.Location = new Point(135, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 117);
            label2.Name = "label2";
            label2.Size = new Size(190, 27);
            label2.TabIndex = 2;
            label2.Text = "Lütfen Duâyı seçiniz.";
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button1.Location = new Point(490, 517);
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
            label3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 235);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // Dualar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir1;
            ClientSize = new Size(596, 558);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            ForeColor = Color.DarkOliveGreen;
            Name = "Dualar";
            Text = "Form3";
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