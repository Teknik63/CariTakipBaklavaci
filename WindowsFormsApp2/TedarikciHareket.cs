using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
    public partial class TedarikciHareket : Form
    {
        public decimal bakiye, cariBakiye;
        public string ID;
        public string toplam;
        public int HarehetID;
        public TedarikciHareket()
        {
            InitializeComponent();
        }

        private void tBL_TedarikciHareketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_TedarikciHareketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Hammadde Alım İşlemi ?", "Ham Madde", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                if (txtFirma.Text != "" || txtMalzeme.Text != "")
                {

                    SqlConnection con = new SqlConnection(tBL_TedarikciHareketTableAdapter.Connection.ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@TedarikUnvan", txtFirma.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ID = dr["TedarikciID"].ToString();
                        cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
                    }
                    con.Close();

                    bakiye = Convert.ToDecimal(txtMiktar.Text) * Convert.ToDecimal(txtFiyat.Text) ;
                    tBL_TedarikciHareketTableAdapter.InsertTedarikciHareket(ID, txtFirma.Text, txtMalzeme.Text, txtMiktar.Text, Convert.ToDecimal(txtFiyat.Text), dtTarih.Value.ToString(), bakiye);
                    cariBakiye += bakiye;

                    TBL_TedarikcilerTableAdapter tBL_Tedarikciler = new TBL_TedarikcilerTableAdapter();
                    tBL_Tedarikciler.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));

                    this.tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);

                }
                else
                {
                    MessageBox.Show("Firma Adı veya Ürün Adı Eksik");
                }

            }
            else
            {
                MessageBox.Show("Ham Madde Alımı İptal Edildi.");
            }


        }

        private void tBL_TedarikciHareketDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_TedarikciHareketDataGridView.Rows[e.RowIndex];
                txtFirma.Text = dg.Cells[2].Value.ToString();
                txtMalzeme.Text = dg.Cells[3].Value.ToString();
                txtMiktar.Text = string.Format("{0:N0}", dg.Cells[4].Value);
                txtFiyat.Text = string.Format("{0:N0}", dg.Cells[5].Value);

                dtTarih.Value = Convert.ToDateTime(dg.Cells[6].Value);
                ID = dg.Cells[1].Value.ToString();
                toplam = dg.Cells[7].Value.ToString();
                HarehetID = Convert.ToInt32(dg.Cells[0].Value.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID == null) { return; }
            else
            {
                SqlConnection con = new SqlConnection(tBL_TedarikciHareketTableAdapter.Connection.ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
                cmd.Parameters.AddWithValue("@TedarikUnvan", txtFirma.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
                }

                cariBakiye -= Convert.ToDecimal(toplam);

                dr.Close();
                cmd.Dispose();

                cmd = new SqlCommand("UPDATE TBL_Tedarikciler SET TedarikBakiye=@TedarikBakiye WHERE TedarikciID=@TedarikciID ", con);
                cmd.Parameters.AddWithValue("@TedarikBakiye", cariBakiye);
                cmd.Parameters.AddWithValue("@TedarikciID", ID);
                dr = cmd.ExecuteReader();

                tBL_TedarikciHareketTableAdapter.DeleteTedarikciHareket(HarehetID);
                this.tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);

                ID = "";
                con.Close();
            }
        }

        private void TedarikciHareket_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_TedarikciHareket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);

            TBL_TedarikcilerTableAdapter tBL_TedarikcilerTableAdapter = new TBL_TedarikcilerTableAdapter();
            TBL_TedarikHammaddeTableAdapter tBL_TedarikHammaddeTableAdapter = new TBL_TedarikHammaddeTableAdapter();

            bakiye = 0;
            label1.Text = bakiye.ToString();
            SqlConnection con = new SqlConnection(tBL_TedarikcilerTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtFirma.Items.Add(dr["TedarikUnvan"]);
            }
            dr.Close();
            cmd.Dispose();


            cmd = new SqlCommand("Select * From TBL_TedarikHammadde", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMalzeme.Items.Add(dr["TedarikHamMaddeAdi"]);
            }
            con.Close();

        }
    }
}
