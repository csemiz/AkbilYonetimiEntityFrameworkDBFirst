

using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmTalimatlar : Form
    {
        AkbiluygulamadbContext context = new AkbiluygulamadbContext();
        public FrmTalimatlar()
        {
            InitializeComponent();
        }

        private void FrmTalimatlar_Load(object sender, EventArgs e)
        {
            //Comboboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();

            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil seçiniz...";
            // cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBoxYukleme.Enabled = false;

            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TalimatlariDataGrideGetir();
            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;

            checkBoxTumunuGoster.Checked = false;
            BekleyenTalimatSayisiniGetir();
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;


        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
                // burada bekleyen talimatları bulur
                var bekleyen = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID && !x.YuklendiMi);

                if (cmbBoxAkbiller.SelectedIndex >= 0)
                {
                    // burada ise bekleyen talimatlar içinden sadece comboda seçili olanın sayısını alıyoruz
                    lblBekleyenTalimat.Text = bekleyen.Count(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString()).ToString();
                }
                else
                {
                    // bekleyen talimatı yukarıda almıştık. Aldığımız sonucu count ile saydık
                    lblBekleyenTalimat.Text = bekleyen.Count().ToString();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu !" + hata.Message); ;
            }
        }

        private void TalimatlariDataGrideGetir(bool tumunuGoster = false)
        {
            try
            {
                var talimatlar = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID);

                if (!tumunuGoster)
                {
                    talimatlar = talimatlar.Where(x => !x.YuklendiMi);
                }

                if (cmbBoxAkbiller.SelectedIndex >=0)
                {
                    talimatlar = talimatlar.Where(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString());
                }

                dataGridViewTalimatlar.DataSource = talimatlar.ToList();

                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;
                dataGridViewTalimatlar.Columns["Akbil"].Width = 200;
                dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yüklendi mi?";
                dataGridViewTalimatlar.Columns["YuklendiMi"].Width = 150;
                //istediğiniz diger kolonlara da ayarlama yapabilirsiniz.

            }
            catch (Exception hata)
            {
                MessageBox.Show("Taliamtlar getirilirken hata oluştu " + hata.Message);
            }
        }

        private void ComboBoxaKullanicininAkbilleriniGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciID).ToList();
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo";

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu ! " + hata.Message); ;
            }
        }

        private void cmbBoxAkbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)
            {
                textBoxYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = true;
            }
            else
            {
                textBoxYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = false;
            }
            BekleyenTalimatSayisiniGetir();
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden talimat seçilemez ! ");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxYuklenecekTutar.Text))
                {
                    MessageBox.Show("Yükleme için giriş miktarı zorunludur ! ! ");
                    return;
                }
                if (!decimal.TryParse(textBoxYuklenecekTutar.Text.Trim(), out decimal tutar))
                {
                    MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır ! ");
                    return;
                }

                Talimatlar yeniTalimat = new Talimatlar()
                {
                    EklenmeTarihi = DateTime.Now,
                    AkbilId = cmbBoxAkbiller.SelectedValue.ToString(),
                    YuklendiMi = false,
                    Yuklenecektutar = Convert.ToDecimal(textBoxYuklenecekTutar.Text),
                    YuklenmeTarih = null

                };

                context.Talimatlars.Add(yeniTalimat);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Yeni talimat eklendi.");
                    //temizlik
                    textBoxYuklenecekTutar.Clear();
                    cmbBoxAkbiller.SelectedIndex = -1;
                    cmbBoxAkbiller.Text = "Akbil seçiniz";

                    groupBoxYukleme.Enabled = false;
                    BekleyenTalimatSayisiniGetir();
                    TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);

                }
                else
                {
                    MessageBox.Show("Yeni talimat EKLENEMEDİ !!");
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Talimat kaydedilemedi !" + hata.Message); ;
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {//if yazilsa daha iyi olabilirdi.
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle güle çıkış yapıldı... ");
            //GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            //GenelIslemler.GirisYapanKullaniciID = 0;

            Form giris = new Form1();
            foreach (Form item in Application.OpenForms)
            {
                    item.Hide();
            }
            giris.Show();

            Application.OpenForms["Form1"].Show();
        }

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            if (lblBekleyenTalimat.Text != "0")
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 40);
                    lblBekleyenTalimat.ForeColor = Color.Cyan;
                }
                else
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 25);
                    lblBekleyenTalimat.ForeColor = Color.Red;
                }
            }
        }

        private void talimatiIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {

                    //Yuklenmis bir talimat iptal edilemez/silinemez.
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        MessageBox.Show($"DİKKAT {item.Cells["Akbil"].Value} {item.Cells["YuklenecekTutar"].Value} liralık yüklemesi yapılmıştır. YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ! \nİşlemlerinize devam etmek için tamama basınız.");
                        continue;
                    }//if bitti.

                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);


                    if (secilenTalimat != null)
                    {
                        context.Talimatlars.Remove(secilenTalimat);
                        sayac += context.SaveChanges();
                    }
                }//foreach bitti.

                MessageBox.Show($"Seçtiniğiz {sayac} talimat sistemden silinmiştir.");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu ! " + hata.Message); ;
            }
        }

        private void talimatiYukleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    //talimatlar tablosunu guncellemek
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        continue;
                    }

                    //once taliamti yuklendiMi = 1 yapıcaz
                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);

                    if (secilenTalimat != null)
                    {
                        secilenTalimat.YuklendiMi = true;
                        secilenTalimat.YuklenmeTarih = DateTime.Now;
                        context.Talimatlars.Update(secilenTalimat);

                        //Sonra akbilin bakiyesine ekleme yapicaz
                        secilenTalimat.Akbil.Bakiye += Convert.ToDecimal(item.Cells["YuklenecekTutar"].Value);

                        context.Akbillers.Update(secilenTalimat.Akbil);

                        context.SaveChanges();
                        sayac++;

                    }



                }//foreach bitti.
                MessageBox.Show($"{sayac} adet talimat akbile yüklendi ! ");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message); ;
            }
        }
    }
}
