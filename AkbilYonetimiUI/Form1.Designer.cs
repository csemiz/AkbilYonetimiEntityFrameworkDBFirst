namespace AkbilYonetimiUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxGiris = new GroupBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            checkBoxHatirla = new CheckBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpBoxGiris.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxGiris
            // 
            grpBoxGiris.BackColor = Color.Transparent;
            grpBoxGiris.Controls.Add(btnGirisYap);
            grpBoxGiris.Controls.Add(btnKayitOl);
            grpBoxGiris.Controls.Add(checkBoxHatirla);
            grpBoxGiris.Controls.Add(txtSifre);
            grpBoxGiris.Controls.Add(txtEmail);
            grpBoxGiris.Controls.Add(label2);
            grpBoxGiris.Controls.Add(label1);
            grpBoxGiris.Location = new Point(12, 12);
            grpBoxGiris.Name = "grpBoxGiris";
            grpBoxGiris.Size = new Size(263, 289);
            grpBoxGiris.TabIndex = 0;
            grpBoxGiris.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Bisque;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(35, 247);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(196, 36);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Bisque;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(35, 191);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(196, 36);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.BackColor = Color.Bisque;
            checkBoxHatirla.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(126, 133);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(105, 21);
            checkBoxHatirla.TabIndex = 4;
            checkBoxHatirla.Text = "Beni Hatırla !";
            checkBoxHatirla.UseVisualStyleBackColor = false;
            checkBoxHatirla.CheckedChanged += checkBoxHatirla_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(108, 85);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(132, 23);
            txtSifre.TabIndex = 3;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(132, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 85);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GalataK;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 364);
            Controls.Add(grpBoxGiris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpBoxGiris.ResumeLayout(false);
            grpBoxGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxGiris;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private CheckBox checkBoxHatirla;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}