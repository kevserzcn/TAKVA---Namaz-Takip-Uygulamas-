namespace Takva
{
    partial class kilinan_namazlar
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Vladimir Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(-10, 9);
            label1.Name = "label1";
            label1.Size = new Size(627, 73);
            label1.TabIndex = 0;
            label1.Text = "       Kılınan Namazlar        ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.DarkOliveGreen;
            checkBox1.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(12, 150);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(203, 47);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Sabah Namazı";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.DarkOliveGreen;
            checkBox2.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(12, 258);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(186, 47);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Öğle Namazı";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.DarkOliveGreen;
            checkBox3.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(12, 377);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(199, 47);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "İkindi Namazı";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.DarkOliveGreen;
            checkBox4.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(377, 150);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(211, 47);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Akşam Namazı";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.DarkOliveGreen;
            checkBox5.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(377, 258);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(188, 47);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Yatsı Namazı";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.DarkOliveGreen;
            checkBox6.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(377, 377);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(178, 47);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Vitr Namazı";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightYellow;
            label2.Location = new Point(223, 105);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "Tarih";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button1.Location = new Point(486, 459);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button2.Location = new Point(377, 459);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // kilinan_namazlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir1;
            ClientSize = new Size(592, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "kilinan_namazlar";
            Text = "Kılınan Namazlar";
            Load += kilinan_namazlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}