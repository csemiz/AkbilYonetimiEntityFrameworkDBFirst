namespace AkbilYonetimiUI
{
    partial class FrmKayitOl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxIsim = new TextBox();
            textBoxSoyisim = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSifre = new TextBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 1;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 180);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 222);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "D. Tarihi:";
            // 
            // textBoxIsim
            // 
            textBoxIsim.Location = new Point(106, 46);
            textBoxIsim.Name = "textBoxIsim";
            textBoxIsim.Size = new Size(217, 23);
            textBoxIsim.TabIndex = 5;
            // 
            // textBoxSoyisim
            // 
            textBoxSoyisim.Location = new Point(106, 94);
            textBoxSoyisim.Name = "textBoxSoyisim";
            textBoxSoyisim.Size = new Size(217, 23);
            textBoxSoyisim.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(106, 139);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(217, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(106, 178);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(217, 23);
            textBoxSifre.TabIndex = 8;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.ForeColor = SystemColors.Highlight;
            btnKayitOl.Location = new Point(27, 268);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(296, 35);
            btnKayitOl.TabIndex = 10;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = SystemColors.Highlight;
            btnGirisYap.Location = new Point(27, 321);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(296, 38);
            btnGirisYap.TabIndex = 11;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = Properties.Resources.doga;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(369, 371);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSoyisim);
            Controls.Add(textBoxIsim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKayitOl";
            Text = "FrmKayitOl";
            FormClosed += FrmKayitOl_FormClosed;
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxIsim;
        private TextBox textBoxSoyisim;
        private TextBox textBoxEmail;
        private TextBox textBoxSifre;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private DateTimePicker dateTimePicker1;
    }
}