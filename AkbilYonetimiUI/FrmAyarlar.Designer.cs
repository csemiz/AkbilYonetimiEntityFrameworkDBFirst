namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
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
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSifre = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 51);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 1;
            label2.Text = "İsim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 153);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "Soyisim :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(285, 51);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 3;
            label4.Text = "D. Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(278, 134);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 4;
            label5.Text = "Yeni Şifre :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.IndianRed;
            btnGuncelle.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(27, 226);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(540, 50);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "BilGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GradientInactiveCaption;
            txtEmail.Location = new Point(101, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.GradientInactiveCaption;
            txtAd.Location = new Point(101, 100);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(152, 23);
            txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.GradientInactiveCaption;
            txtSoyad.Location = new Point(101, 153);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(152, 23);
            txtSoyad.TabIndex = 8;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.GradientInactiveCaption;
            txtSifre.Location = new Point(367, 136);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 23);
            txtSifre.TabIndex = 9;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(367, 51);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(200, 23);
            dtpDogumTarihi.TabIndex = 10;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImage = Properties.Resources.doga2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 323);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtSifre);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtEmail);
            Controls.Add(btnGuncelle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAyarlar";
            Text = "FrmAyarlar";
            Load += FrmAyarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSifre;
        private DateTimePicker dtpDogumTarihi;
    }
}