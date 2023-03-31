using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        AkbiluygulamadbContext context = new AkbiluygulamadbContext();
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
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;

                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanlari doldurunuz.");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }
                }//foreache bitti.

                //Bu emailden sistemde var mi?
                if (context.Kullanicilars.FirstOrDefault(x => x.Email == textBoxEmail.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu email sistemde mevcuttur !");
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    return;
                }

                Kullanicilar yeniKullanici = new Kullanicilar()
                {
                    EklenmeTarihi = DateTime.Now,
                    Ad = textBoxIsim.Text.Trim(),
                    Soyad = textBoxSoyisim.Text.Trim(),
                    DogumTarihi = dateTimePicker1.Value,
                    Email = textBoxEmail.Text.Trim(),
                    Parola = GenelIslemler.MD5Encryption(textBoxSifre.Text.Trim())

                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Kullanıcı eklendi.");
                    //temizlik
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;
                        }
                    }//foreach bitti

                    var cevap = MessageBox.Show("Giriş sayfasına gitmek ister misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes) //((int)cevap==6)
                    {
                        Form1 frmg = new Form1();
                        frmg.Email = textBoxEmail.Text.Trim();
                        this.Hide();
                        frmg.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı ekleme başarısız oldu ! !");
                }

                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;

            }
            catch (Exception ex)
            {
                //ex log.txt'ye yazılacak (loglama) 
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !" +
                     ex.Message); ;
                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;
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






