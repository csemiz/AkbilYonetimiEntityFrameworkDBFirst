using Microsoft.Data.SqlClient;

namespace AkbilYonetimiUI
{
    public partial class FrmAyarlar : Form
    {
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
                //NOT: Giriş yapmis kullanicinin bilgileriyle select sorgusu yazacagiz.
                //kullanici bilgisi alabilmek icin burada 2 yontem kullanabiliriz
                //static bir class acip icinde GirisYapmisKullaniciEmail propertysi kullanilabilir.
                //2. yöntem olarak Properties settings icine kayitli email bilgisinden yararlanilabilir.
                
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
               
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme BAŞARISIZDIR" + hata.Message); ;
            }
        }
    }
}
