using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DB_CarilerTableAdapters;

namespace WindowsFormsApp2
{
    public partial class TedarikHareket : Form
    {
        public string ID, tahsilatID;
        public decimal cariBakiye;
        public TedarikHareket()
        {
            InitializeComponent();
        }

        private void tBL_TedarikciHareketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_TedarikciHareketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void TedarikHareket_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_TedarikciHareket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);



            SqlConnection con = new SqlConnection(tBL_TedarikciHareketTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCariAd.Items.Add(dr["TedarikUnvan"]);
                sorguCmb.Items.Add(dr["TedarikUnvan"]);
            }

            cmd.Dispose();
            dr.Close();

            cmd = new SqlCommand("Select * From TBL_TedarikHammadde", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMalzeme.Items.Add(dr["TedarikHamMaddeAdi"]);
            }
            con.Close();



            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            pg.Margins = new Margins(2, 1, 2, 1);

            pg.Landscape = false;
            reportViewer1.SetPageSettings(pg);
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tBL_TedarikciHareketTableAdapter.FillByTarih(dB_Cariler.TBL_TedarikciHareket, ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"), sorguCmb.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(txtMiktar.Text) * Convert.ToDecimal(txtFiyat.Text);

            tBL_TedarikciHareketTableAdapter.InsertTedarikciHareket(ID, txtCariAd.Text, txtMalzeme.Text, txtMiktar.Text, Convert.ToDecimal(txtFiyat.Text), dtTarih.Value.ToString(), t);
            cariBakiye += t;
            TBL_TedarikcilerTableAdapter td = new TBL_TedarikcilerTableAdapter();
            td.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));
            tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);
        }

        private void txtCariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_TedarikciHareketTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@TedarikUnvan", txtCariAd.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
                ID = dr["TedarikciID"].ToString();
            }
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal t = Convert.ToDecimal(txtMiktar.Text) * Convert.ToDecimal(txtFiyat.Text);
            cariBakiye -= t;
            TBL_TedarikcilerTableAdapter td = new TBL_TedarikcilerTableAdapter();
            td.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));
            tBL_TedarikciHareketTableAdapter.DeleteTedarikciHareket(Convert.ToInt32(tahsilatID));
            tBL_TedarikciHareketTableAdapter.Fill(this.dB_Cariler.TBL_TedarikciHareket);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.PrintDialog();
        }

        private void tBL_TedarikciHareketDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_TedarikciHareketDataGridView.Rows[e.RowIndex];
                txtCariAd.Text = dg.Cells[2].Value.ToString();
                dtTarih.Text = dg.Cells[6].Value.ToString();
                txtMalzeme.Text = dg.Cells[3].Value.ToString();
                txtMiktar.Text = dg.Cells[4].Value.ToString();
                txtFiyat.Text = dg.Cells[5].Value.ToString();
                tahsilatID = dg.Cells[0].Value.ToString();
                ID = dg.Cells[1].Value.ToString();
                tahsilatID = dg.Cells[0].Value.ToString();
            }
        }
    }
}
