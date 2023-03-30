
using Microsoft.Identity.Client;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
       
        public FrmKayitOl()
        {
            InitializeComponent();//Formu İnşa etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            
            #region Ayarlar
            textBoxSifre.PasswordChar = '*';
            dateTimePicker1.MaxDate = new DateTime(2016, 1, 1);//Girilecek tarihi ayarladık
            dateTimePicker1.Value = new DateTime(2016, 1, 1);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanlari doldurunuz.");
                        return;
                    }
                }
                
            }
            catch (Exception ex)
            {
                //ex log.txt'ye yazılacak (loglama) 
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !" +
                     ex.Message); ;
            }
        }

        private void GirisFomunaGit()
        {
            Form1 frmG = new Form1();
            frmG.Email = textBoxEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFomunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFomunaGit();
        }
    }
}






