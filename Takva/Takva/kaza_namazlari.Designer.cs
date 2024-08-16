namespace Takva
{
    partial class kaza_namazlari
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
            listBox1 = new ListBox();
            button1 = new Button();
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
            label1.Size = new Size(617, 73);
            label1.TabIndex = 1;
            label1.Text = "        Kaza Namazları         ";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightYellow;
            listBox1.ForeColor = Color.DarkOliveGreen;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(132, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 324);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.BackgroundImage = Properties.Resources.Marble_Texture_Phone_Wallpaper_Background;
            button1.Location = new Point(486, 464);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kaza_namazlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.indir1;
            ClientSize = new Size(592, 505);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "kaza_namazlari";
            Text = "kaza_namazlari";
            Load += kaza_namazlari_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}