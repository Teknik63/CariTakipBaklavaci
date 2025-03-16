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

    public partial class CarilerHareket : Form
    {
        public decimal bakiye, cariBakiye;
        public float tepsi = 0;
        public float kosebent = 0;
        public float nakliye = 0;
        public string ID;
        public string toplam;
        public int HarehetID;
        public CarilerHareket()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtTepsiUcreti.Text = "";
            txtKoseBentUcreti.Text = "";
            txtKargoUcreti.Text = "";
            tepsi = 0;
            kosebent = 0;
            nakliye = 0;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Sipariş Hazırlamak İstiyormusunuz ?", "Sipariş Hazırla", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                if (txtCariAd.Text != "" || txtUrun.Text != "")
                {

                    SqlConnection con = new SqlConnection(tBL_CariHareketTableAdapter.Connection.ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From TBL_Cariler WHERE CariUnvan=@CariUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@CariUnvan", txtCariAd.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ID = dr["CariID"].ToString();
                        cariBakiye = Convert.ToDecimal(dr["CariBakiye"].ToString());
                    }
                    con.Close();
                    float tepsiUcreti = Convert.ToInt32(txtAdet.Text) * Convert.ToInt32(txtFiyat.Text);
                    tepsi = Convert.ToInt32(txtAdet.Text) * Convert.ToInt32(txtTepsiUcreti.Text); // Tepsi Adedi ile Tepsi ücreti çarpılıyor.
                    kosebent = Convert.ToInt32(txtAdet.Text) * (Convert.ToInt32(txtKoseBentUcreti.Text) * 4); /// Tepsi Sayısı ile Köşebent ücreti çarpılıyor.
                    nakliye = Convert.ToInt32(txtKargoUcreti.Text); // Nalliye Ücreti
                    bakiye = Convert.ToDecimal(tepsiUcreti) + Convert.ToDecimal(tepsi) + Convert.ToDecimal(kosebent) + Convert.ToDecimal(nakliye);
                    tBL_CariHareketTableAdapter.InsertHareket
                        (
                        ID,
                        txtCariAd.Text,
                        txtUrun.Text,
                        txtAdet.Text,
                        Convert.ToDecimal(txtFiyat.Text),
                        Convert.ToDecimal(tepsi),
                        Convert.ToDecimal(kosebent),
                        Convert.ToDecimal(nakliye),
                        dateTimePicker1.Value.ToString(),
                        bakiye
                        );
                    cariBakiye += bakiye;
                    TBL_CarilerTableAdapter cari = new TBL_CarilerTableAdapter();
                    cari.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));
                    this.tBL_CariHareketTableAdapter.Fill(this.dB_Cariler.TBL_CariHareket);

                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri Adı veya Ürün Adı Eksik");
                }

            }
            else
            {
                MessageBox.Show("Sipariş İşlemi İptal Edildi.");
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Cariler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_CarilerTableAdapter.Fill(this.dB_Cariler.TBL_Cariler);
            this.tBL_CariHareketTableAdapter.Fill(this.dB_Cariler.TBL_CariHareket);
            bakiye = 0;
            Bakiye.Text = bakiye.ToString();
            SqlConnection con = new SqlConnection(tBL_CariHareketTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Cariler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCariAd.Items.Add(dr["CariUnvan"]);
            }
            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("Select * From TBL_Urunler", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtUrun.Items.Add(dr["UrunAdi"]);
            }
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID == null) { return; }
            else
            {
                SqlConnection con = new SqlConnection(tBL_CariHareketTableAdapter.Connection.ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From TBL_Cariler WHERE CariID=@CariID", con);
                cmd.Parameters.AddWithValue("@CariID", ID.ToString());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cariBakiye = Convert.ToDecimal(dr["CariBakiye"].ToString());
                }

                cariBakiye -= Convert.ToDecimal(toplam);

                dr.Close();
                cmd.Dispose();

                cmd = new SqlCommand("UPDATE TBL_Cariler SET Caribakiye=@Caribakiye WHERE CariID=@CariID ", con);
                cmd.Parameters.AddWithValue("@Caribakiye", cariBakiye);
                cmd.Parameters.AddWithValue("@CariID", ID);
                dr = cmd.ExecuteReader();

                tBL_CariHareketTableAdapter.DeleteHareket(HarehetID);
                this.tBL_CariHareketTableAdapter.Fill(this.dB_Cariler.TBL_CariHareket);
                Temizle();
                ID = "";
                con.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = dataGridView1.Rows[e.RowIndex];
                txtCariAd.Text = dg.Cells[2].Value.ToString();
                txtUrun.Text = dg.Cells[3].Value.ToString();
                txtAdet.Text = string.Format("{0:N0}", dg.Cells[4].Value);
                txtFiyat.Text = string.Format("{0:N0}", dg.Cells[5].Value);
                decimal tepsilerinUcreti = Convert.ToDecimal(string.Format("{0:N0}", dg.Cells[6].Value)) / Convert.ToDecimal(txtAdet.Text);

                txtTepsiUcreti.Text = string.Format("{0:N0}", tepsilerinUcreti);
                decimal kosebentAdetFiyati = (Convert.ToDecimal(string.Format("{0:N0}", dg.Cells[7].Value)) / Convert.ToDecimal(txtAdet.Text)) / 4;

                txtKoseBentUcreti.Text = string.Format("{0:N0}",kosebentAdetFiyati);
                txtKargoUcreti.Text = string.Format("{0:N0}", dg.Cells[8].Value);
                dateTimePicker1.Value = Convert.ToDateTime(dg.Cells[9].Value);
                ID = dg.Cells[1].Value.ToString();
                toplam = dg.Cells[10].Value.ToString();
                HarehetID = Convert.ToInt32(dg.Cells[0].Value.ToString());

            }
        }

        private void tBL_CariHareketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_CariHareketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }
    }
}
