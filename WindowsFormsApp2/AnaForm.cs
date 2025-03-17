using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DB_CarilerTableAdapters;

namespace WindowsFormsApp2
{
    
    public partial class AnaForm : Form
    {
        public decimal toplamtutar,c,g,t;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariKayit cr = new CariKayit();
            cr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarilerHareket cariler = new CarilerHareket();
            cariler.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tahsilat th = new tahsilat();
            th.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider();
            gider.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
              TBL_CariHareketTableAdapter hareket = new TBL_CariHareketTableAdapter();
              object cariCiro =  hareket.ScalarCariCiroTarihli(ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"));

                if (cariCiro != DBNull.Value && cariCiro != null && cariCiro is decimal) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(cariCiro.ToString(), out decimal ondalikDeger))
                    {
                        c = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        c = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    c = 0; // veya varsayılan başka bir değer
                }
                

                TBL_GiderTableAdapter giderler = new TBL_GiderTableAdapter();
                object giderToplam = giderler.ScalarGiderTarihli(ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"));

                if (giderToplam != DBNull.Value && giderToplam != null && giderToplam is decimal)
                {
                    if (decimal.TryParse(giderToplam.ToString(), out decimal ondalikDeger))
                    {
                        g = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        g = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    g = 0; // veya varsayılan başka bir değer
                }
                

                TBL_TedarikciHareketTableAdapter tedarikHareket = new TBL_TedarikciHareketTableAdapter();
                object tedarikToplam = tedarikHareket.ScalarTedarikciBorcTarihli(ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"));

                if (tedarikToplam != null && tedarikToplam != DBNull.Value)
                {
                    if (decimal.TryParse(tedarikToplam.ToString(), out decimal ondalikDeger))
                    {
                        t = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        t = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    t = 0; // veya varsayılan başka bir değer
                }
                

                decimal f = c - (g + t);
                net.Text = f.ToString("N2");

            }
            else ///
            {
                TBL_CariHareketTableAdapter hareket = new TBL_CariHareketTableAdapter();
                object cariCiro = hareket.ScalarCariCiro();

                if (cariCiro != DBNull.Value && cariCiro != null && cariCiro is decimal) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(cariCiro.ToString(), out decimal ondalikDeger))
                    {
                        c = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        c = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    c = 0; // veya varsayılan başka bir değer
                }

                TBL_GiderTableAdapter giderler = new TBL_GiderTableAdapter();
                object giderToplam = giderler.ScalarGider();

                if (giderToplam != DBNull.Value && giderToplam != null && giderToplam is decimal)
                {
                    if (decimal.TryParse(giderToplam.ToString(), out decimal ondalikDeger))
                    {
                        g = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        g = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    g = 0; // veya varsayılan başka bir değer
                }

                TBL_TedarikciHareketTableAdapter tedarikHareket = new TBL_TedarikciHareketTableAdapter();
                object tedarikToplam = tedarikHareket.ScalarTedarikciBorc();

                if (tedarikToplam != null && tedarikToplam != DBNull.Value)
                {
                    if (decimal.TryParse(tedarikToplam.ToString(), out decimal ondalikDeger))
                    {
                        t = ondalikDeger;
                    }
                    else
                    {
                        // Dönüşüm başarısız ise yapılacak işlemler
                        t = 0; // veya varsayılan başka bir değer
                    }
                }
                else
                {
                    // tedarikToplam null veya DBNull ise yapılacak işlemler
                    t = 0; // veya varsayılan başka bir değer
                }

                decimal f = c - (g + t);
                net.Text = f.ToString("C2");

            }
            ciro.Text = c.ToString("C2");
            gider.Text = g.ToString("C2");
            tedarikci.Text = t.ToString("C2");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tedarikciler tedarik = new Tedarikciler();
            tedarik.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hammadde hammadde = new Hammadde();
            hammadde.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TedarikciHareket tedarikciHareket = new TedarikciHareket();
            tedarikciHareket.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        }
    }
}
