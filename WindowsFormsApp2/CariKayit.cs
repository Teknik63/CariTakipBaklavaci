using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class CariKayit : Form
    {
        public int e;
        public CariKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            try
            {
                int n = tBL_CarilerTableAdapter.InsertCariler(txtUnvan.Text, txtAdSoayd.Text, txtAdres.Text, txtSehir.Text, txtTelefon.Text, txtEmail.Text);
                if(n==1)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    this.tBL_CarilerTableAdapter.Fill(this.dB_Cariler.TBL_Cariler);
                    Temizle();
                }
            }
            catch
            {

            }

        }

        private void tBL_CarilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_CarilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void CariKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Cariler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_CarilerTableAdapter.Fill(this.dB_Cariler.TBL_Cariler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dg = dataGridView1.Rows[e.RowIndex];
                lblindex.Text = dg.Cells[0].Value.ToString();
                txtUnvan.Text = dg.Cells[1].Value.ToString();
                txtAdSoayd.Text = dg.Cells[2].Value.ToString();
                txtSehir.Text = dg.Cells[3].Value.ToString();
                txtTelefon.Text = dg.Cells[4].Value.ToString();
                txtEmail.Text = dg.Cells[5].Value.ToString();
                txtAdres.Text = dg.Cells[7].Value.ToString();
                borc.Text = dg.Cells[6].Value.ToString();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            tBL_CarilerTableAdapter.UpdateCariler(txtUnvan.Text, txtAdSoayd.Text, txtAdres.Text, txtSehir.Text, txtTelefon.Text, txtEmail.Text, Convert.ToInt32(lblindex.Text));
            this.tBL_CarilerTableAdapter.Fill(this.dB_Cariler.TBL_Cariler);
            Temizle();
        }

        public void Temizle()
        {
            lblindex.Text = "";
            txtUnvan.Text = "";
            txtAdSoayd.Text = "";
            txtSehir.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
