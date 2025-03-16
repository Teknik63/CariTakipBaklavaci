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
    public partial class Odeme : Form
    {
        public decimal cariBakiye;
        public string ID;
        public int OdemeID;
        public Odeme()
        {
            InitializeComponent();
        }

        private void tBL_OdemeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_OdemeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void Odeme_Load(object sender, EventArgs e)
        {



            // TODO: Bu kod satırı 'dB_Cariler.TBL_Odeme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_OdemeTableAdapter.Fill(this.dB_Cariler.TBL_Odeme);
            SqlConnection con = new SqlConnection(tBL_OdemeTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtCariAd.Items.Add(dr["TedarikUnvan"]);
                sorguCmb.Items.Add(dr["TedarikUnvan"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_OdemeTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@TedarikUnvan", txtCariAd.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr["TedarikciID"].ToString();
                cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
            }

            cariBakiye -= Convert.ToDecimal(txtTutar.Text);

            tBL_OdemeTableAdapter.InsertOdeme(Convert.ToInt32(ID), txtCariAd.Text, dtTarih.Value.ToString(), txtBanka.Text, txtIslemNo.Text, Convert.ToDecimal(txtTutar.Text));

            TBL_TedarikcilerTableAdapter tedarik = new TBL_TedarikcilerTableAdapter();
            tedarik.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));

            con.Close();
            this.tBL_OdemeTableAdapter.Fill(this.dB_Cariler.TBL_Odeme);
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
        }

        private void txtCariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_OdemeTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@TedarikUnvan", txtCariAd.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
            }
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
            con.Close();
        }

        private void tBL_OdemeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_OdemeDataGridView.Rows[e.RowIndex];
                txtCariAd.Text = dg.Cells[2].Value.ToString();
                dtTarih.Text = dg.Cells[3].Value.ToString();
                txtBanka.Text = dg.Cells[4].Value.ToString();
                txtIslemNo.Text = dg.Cells[5].Value.ToString();
                txtTutar.Text = dg.Cells[6].Value.ToString();
                OdemeID = Convert.ToInt32(dg.Cells[0].Value.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(tBL_OdemeTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBL_Tedarikciler WHERE TedarikUnvan=@TedarikUnvan", con); //VeriGuncelle.Parameters.AddWithValue("@adsoyad", adsoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@TedarikUnvan", txtCariAd.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr["TedarikciID"].ToString();
                cariBakiye = Convert.ToDecimal(dr["TedarikBakiye"].ToString());
            }

            cariBakiye += Convert.ToDecimal(txtTutar.Text);

            tBL_OdemeTableAdapter.DeleteOdeme(Convert.ToInt32(OdemeID));

            TBL_TedarikcilerTableAdapter cari = new TBL_TedarikcilerTableAdapter();
            cari.UpdateHareketBakiye(cariBakiye, Convert.ToInt32(ID));

            con.Close();
            this.tBL_OdemeTableAdapter.Fill(this.dB_Cariler.TBL_Odeme);
            lblCariBakiye.Text = Convert.ToString(cariBakiye);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tBL_OdemeTableAdapter.FillByOdeme(dB_Cariler.TBL_Odeme, ilkTarih.Value.ToString("yyyy.MM.dd"), sonTarih.Value.ToString("yyyy.MM.dd"), sorguCmb.Text);
        }
    }
}
