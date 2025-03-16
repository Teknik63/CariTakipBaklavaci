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
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }

        private void tBL_TedarikcilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_TedarikcilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Tedarikciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_TedarikcilerTableAdapter.Fill(this.dB_Cariler.TBL_Tedarikciler);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tBL_TedarikcilerTableAdapter.InsertTedarikciler(txtUnvan.Text, txtAdSoayd.Text, txtAdres.Text, txtSehir.Text, txtTelefon.Text, txtEmail.Text);
            this.tBL_TedarikcilerTableAdapter.Fill(this.dB_Cariler.TBL_Tedarikciler);
        }

        private void tBL_TedarikcilerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_TedarikcilerDataGridView.Rows[e.RowIndex];
                lblindex.Text = dg.Cells[0].Value.ToString();
                txtUnvan.Text = dg.Cells[1].Value.ToString();
                txtAdSoayd.Text = dg.Cells[2].Value.ToString();
                txtSehir.Text = dg.Cells[4].Value.ToString();
                txtTelefon.Text = dg.Cells[5].Value.ToString();
                txtEmail.Text = dg.Cells[6].Value.ToString();
                txtAdres.Text = dg.Cells[3].Value.ToString();
                borc.Text = dg.Cells[7].Value.ToString();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }
    }
}
