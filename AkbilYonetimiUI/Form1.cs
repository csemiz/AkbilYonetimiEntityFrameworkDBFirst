using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class Form1 : Form
    {
        public string Email { get; set; }//kayýt ol formunda kayýt olan kullanýcýnýn emaili buraya gelsin
        AkbiluygulamadbContext context = new AkbiluygulamadbContext();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;
            }
            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;
            txtSifre.PasswordChar = '*';

            //beni hatirlayi Properties.Settings ile yapana kadar burasý böyle kolaylýk saglasin
            txtEmail.Text = "cerensemiz@gmail.com";
            txtSifre.Text = "123";

        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyeceðiz.
            //Kayýt ol formunu açacaðýz.
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                //1)Email ve sifre textboxlarý dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgilerinizi eksiksiz giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //2)Girdiði email ve þifre veritabanýnda mevcut mu?
                var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));

                if (kullanici==null)
                {
                    MessageBox.Show("Email ya da þifrenizi yanlýþ girdiniz ! ");
                    return;
                }
                else
                {
                    MessageBox.Show($"Hoþgeldiniz...{kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";
                    //Beni Hatirlayi settings ile yazalim.

                    //temizlik
                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();

                }
            }
            catch (Exception hata)
            {
                //Dipnot: Exceptionlar asla kullanýcýya gösterilemez.Exceptionlar loglanýr, yazýlýmcýya iletilir.Biz öðrenmek için mbox ýn içine yazdýk.

                MessageBox.Show("Beklenmedik bir sorun oluþtu!" + hata.Message);
            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {
            BeniHatirla();
        }

        private void BeniHatirla()
        {

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))//basilan tus enter ise giris yapilacak
            {
                GirisYap();
            }
        }
    }
}