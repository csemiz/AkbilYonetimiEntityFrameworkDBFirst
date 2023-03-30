namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalimatlar));
            menuStrip1 = new MenuStrip();
            anaMenuToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            textBoxYukelenecek = new Label();
            textBoxYuklenecekTutar = new TextBox();
            cmbBoxAkbiller = new ComboBox();
            btnTalimatKaydet = new Button();
            labellabel = new Label();
            lblBekleyenTalimat = new Label();
            dataGridViewTalimatlar = new DataGridView();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            checkBoxTumunuGoster = new CheckBox();
            groupBoxYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenuToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            anaMenuToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            anaMenuToolStripMenuItem.Size = new Size(92, 24);
            anaMenuToolStripMenuItem.Text = "Ana Menü";
            anaMenuToolStripMenuItem.Click += anaMenuToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(81, 24);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // textBoxYukelenecek
            // 
            textBoxYukelenecek.AutoSize = true;
            textBoxYukelenecek.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxYukelenecek.Location = new Point(6, 32);
            textBoxYukelenecek.Name = "textBoxYukelenecek";
            textBoxYukelenecek.Size = new Size(137, 20);
            textBoxYukelenecek.TabIndex = 1;
            textBoxYukelenecek.Text = "Yüklenecek Tutar  :";
            // 
            // textBoxYuklenecekTutar
            // 
            textBoxYuklenecekTutar.Location = new Point(194, 32);
            textBoxYuklenecekTutar.Name = "textBoxYuklenecekTutar";
            textBoxYuklenecekTutar.Size = new Size(189, 23);
            textBoxYuklenecekTutar.TabIndex = 2;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(12, 65);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(582, 23);
            cmbBoxAkbiller.TabIndex = 3;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.BackColor = SystemColors.ButtonHighlight;
            btnTalimatKaydet.ForeColor = Color.DarkSlateGray;
            btnTalimatKaydet.Location = new Point(426, 22);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(156, 46);
            btnTalimatKaydet.TabIndex = 4;
            btnTalimatKaydet.Text = "KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = false;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // labellabel
            // 
            labellabel.AutoSize = true;
            labellabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labellabel.ForeColor = Color.Red;
            labellabel.Location = new Point(637, 63);
            labellabel.Name = "labellabel";
            labellabel.Size = new Size(141, 21);
            labellabel.TabIndex = 5;
            labellabel.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.Red;
            lblBekleyenTalimat.Location = new Point(694, 106);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(40, 46);
            lblBekleyenTalimat.TabIndex = 6;
            lblBekleyenTalimat.Text = "0";
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(12, 231);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowTemplate.Height = 25;
            dataGridViewTalimatlar.Size = new Size(783, 150);
            dataGridViewTalimatlar.TabIndex = 7;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            talimatiYukleToolStripMenuItem.Image = (Image)resources.GetObject("talimatiYukleToolStripMenuItem.Image");
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(180, 22);
            talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            talimatiIptalEtToolStripMenuItem.Image = Properties.Resources.carpi;
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(180, 22);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxTumunuGoster.Location = new Point(16, 196);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(132, 24);
            checkBoxTumunuGoster.TabIndex = 9;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(textBoxYukelenecek);
            groupBoxYukleme.Controls.Add(textBoxYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Location = new Point(12, 106);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(602, 75);
            groupBoxYukleme.TabIndex = 10;
            groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 401);
            Controls.Add(groupBoxYukleme);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(labellabel);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private Label textBoxYukelenecek;
        private TextBox textBoxYuklenecekTutar;
        private ComboBox cmbBoxAkbiller;
        private Button btnTalimatKaydet;
        private Label labellabel;
        private Label lblBekleyenTalimat;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox checkBoxTumunuGoster;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}