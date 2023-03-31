using AkbilYonetimiIsKatmani;

namespace AkbilYonetimiUI
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAyarlar frmAyar = new FrmAyarlar();
            frmAyar.Show();
        }

        private void btnAkbil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAkbiller frmAkbiller = new FrmAkbiller();
            frmAkbiller.Show();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnTalimat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTalimatlar frmt = new FrmTalimatlar();
            frmt.Show();
        }

        private void FrmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciID = 0;
            this.Hide();
            Form1 giris = new Form1();
            giris.Show();
        }
    }
}
