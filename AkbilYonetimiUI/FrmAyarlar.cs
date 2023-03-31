using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;
namespace AkbilYonetimiUI
{
    public partial class FrmAyarlar : Form
    {
        AkbiluygulamadbContext context = new AkbiluygulamadbContext();
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {

            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            KullanicininBilgileriniGetir();
        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Id == GenelIslemler.GirisYapanKullaniciID);

                if (kullanici != null)
                {
                    txtAd.Text = kullanici.Ad;
                    txtSoyad.Text = kullanici.Soyad;
                    txtEmail.Text = kullanici.Email;
                    txtEmail.Enabled = false;
                    dtpDogumTarihi.Value = kullanici.DogumTarihi.Value;

                }
                else
                {
                    MessageBox.Show("Kullaıcı bilgileri getirilirken bir sorun oluştu !");
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Id == GenelIslemler.GirisYapanKullaniciID);

                if (kullanici != null)
                {
                    kullanici.Ad = txtAd.Text.Trim();
                    kullanici.Soyad = txtSoyad.Text.Trim();
                    kullanici.DogumTarihi = dtpDogumTarihi.Value;

                    if (!string.IsNullOrEmpty(txtSifre.Text.Trim()) && kullanici.Parola != GenelIslemler.MD5Encryption(txtSifre.Text.Trim()))
                    {
                        kullanici.Parola = GenelIslemler.MD5Encryption(txtSifre.Text.Trim());
                        MessageBox.Show("Yeni şifre girdiniz!");
                    }
                    else
                    {
                        MessageBox.Show("Aynı şifreyi girdiniz !");
                    }
                    
                    context.Kullanicilars.Update(kullanici);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Bilgileriniz güncellendi !");
                        FrmAnasayfa frma = new FrmAnasayfa();
                        this.Hide();
                        frma.Show();
                    }

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme BAŞARISIZDIR" + hata.Message); ;
            }
        }
    }
}
