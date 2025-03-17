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
    public partial class tahsilat : Form
    {
        public string ID,tahsilatID;
        public decimal cariBakiye;
      
        public tahsilat()
        {
            InitializeComponent();
        }

        private void tBL_TahsilatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_TahsilatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void tahsilat_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Tahsilat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_TahsilatTableAdapter.Fill(this.dB_Cariler.TBL_Tahsilat);


            SqlConnection con = new SqlConnection(tBL_TahsilatTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Cariler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCariAd.Items.Add(dr["CariUnvan"]);
                sorguCmb.Items.Add(dr["CariUnvan"]);
            }

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            pg.Margins = new Margins(2, 1, 2, 1);

            pg.Landscape = false;
            reportViewer1.SetPageSettings(pg);
            reportViewer1.RefreshReport();

        }

        private void tBL_TahsilatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_TahsilatDataGridView.Rows[e.RowIndex];
                txtCariAd.Text = dg.Cells[2].Value.ToString();
                dtTarih.Text = dg.Cells[3].Value.ToString();
                txtBanka.Text = dg.Cells[4].Value.ToString();
                txtIslemNo.Text = dg.Cells[5].Value.ToString();
                txtTutar.Text = dg.Cells[6].Value.ToString();
                tahsilatID = dg.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_TahsilatTableAdapter.Connection.ConnectionString);
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

            cariBakiye -= Convert.ToDecimal(txtTutar.Text);

            tBL_TahsilatTableAdapter.InsertTahsilat(txtCariAd.Text,Convert.ToInt32(ID),dtTarih.Value.ToString(),txtBanka.Text,txtIslemNo.Text, Convert.ToDecimal(txtTutar.Text));

            TBL_CarilerTableAdapter cari = new TBL_CarilerTableAdapter();
            cari.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));

            con.Close();
            this.tBL_TahsilatTableAdapter.Fill(this.dB_Cariler.TBL_Tahsilat);
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
        }

        private void txtCariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_TahsilatTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Cariler WHERE CariUnvan=@CariUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@CariUnvan", txtCariAd.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cariBakiye = Convert.ToDecimal(dr["CariBakiye"].ToString());
            }
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
            con.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBL_TahsilatTableAdapter.Fill(this.dB_Cariler.TBL_Tahsilat);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            reportViewer1.PrintDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tBL_TahsilatTableAdapter.FillbyTarih(dB_Cariler.TBL_Tahsilat, ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"),sorguCmb.Text);
        }

        private void sorguCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sonTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ilkTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_TahsilatTableAdapter.Connection.ConnectionString);
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

            cariBakiye += Convert.ToDecimal(txtTutar.Text);

            tBL_TahsilatTableAdapter.DeleteTahsilat(Convert.ToInt32(tahsilatID));

            TBL_CarilerTableAdapter cari = new TBL_CarilerTableAdapter();
            cari.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));

            con.Close();
            this.tBL_TahsilatTableAdapter.Fill(this.dB_Cariler.TBL_Tahsilat);
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
        }
    }
}
