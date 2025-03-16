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
        public decimal toplamtutar;
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
                TariheGore(ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"));
                decimal t = Convert.ToDecimal(ciro.Text) - (Convert.ToDecimal(gider.Text) + Convert.ToDecimal(tedarikci.Text));
                net.Text = t.ToString();
            }
            else
            {
                GenelSorgu();
                decimal t = Convert.ToDecimal(ciro.Text) - (Convert.ToDecimal(gider.Text) + Convert.ToDecimal(tedarikci.Text));
                net.Text = t.ToString();
            }

 

        }

        public void TariheGore(string ilkTarih,string sonTarih)
        {
            TBL_CariHareketTableAdapter hareket = new TBL_CariHareketTableAdapter();
            SqlConnection con = new SqlConnection(hareket.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(HareketToplam) FROM TBL_CariHareket WHERE HareketTarih >= @BaslangicTarihi AND HareketTarih <= @BitisTarihi", con);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", ilkTarih);
            cmd.Parameters.AddWithValue("@BitisTarihi", sonTarih);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        ciro.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }
            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("SELECT SUM(GiderTutar) FROM TBL_Gider WHERE GiderTarih >= @BaslangicTarihi AND GiderTarih <= @BitisTarihi", con);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", ilkTarih);
            cmd.Parameters.AddWithValue("@BitisTarihi", sonTarih);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        gider.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("SELECT SUM(HareketToplam) FROM TBL_TedarikciHareket WHERE HareketTarih >= @BaslangicTarihi AND HareketTarih <= @BitisTarihi", con);
            cmd.Parameters.AddWithValue("@BaslangicTarihi", ilkTarih);
            cmd.Parameters.AddWithValue("@BitisTarihi", sonTarih);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        tedarikci.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }



            con.Close();

        }


        public void GenelSorgu()
        {
            TBL_CariHareketTableAdapter hareket = new TBL_CariHareketTableAdapter();
            SqlConnection con = new SqlConnection(hareket.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(HareketToplam) FROM TBL_CariHareket", con);

            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        ciro.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }
            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("SELECT SUM(GiderTutar) FROM TBL_Gider ", con);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        gider.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }
            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("SELECT SUM(HareketToplam) FROM TBL_TedarikciHareket", con);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value && dr[0] != null) // DBNull ve null kontrolü
                {
                    if (decimal.TryParse(dr[0].ToString(), out decimal tutar)) // decimal dönüşüm kontrolü
                    {
                        toplamtutar = tutar;
                        tedarikci.Text = tutar.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanından dönen değer decimal'e dönüştürülemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanından dönen değer null veya DBNull.");
                }

            }




            con.Close();
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
