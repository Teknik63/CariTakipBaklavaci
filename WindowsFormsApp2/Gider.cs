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
    public partial class Gider : Form
    {
        public string giderID;
        public Gider()
        {
            InitializeComponent();
        }

        private void tBL_GiderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_GiderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void Gider_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Gider' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_GiderTableAdapter.Fill(this.dB_Cariler.TBL_Gider);

        }

        private void tBL_GiderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_GiderDataGridView.Rows[e.RowIndex];
                txtAciklama.Text = dg.Cells[1].Value.ToString();
                txtTutar.Text = string.Format("{0:N0}", dg.Cells[2].Value);
                dtTarih.Text = dg.Cells[3].Value.ToString();
                giderID = dg.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBL_GiderTableAdapter.InsertGider(txtAciklama.Text, Convert.ToDecimal(txtTutar.Text), dtTarih.Value.ToString());
            this.tBL_GiderTableAdapter.Fill(this.dB_Cariler.TBL_Gider);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBL_GiderTableAdapter.DeleteGider(Convert.ToInt32(giderID));
            this.tBL_GiderTableAdapter.Fill(this.dB_Cariler.TBL_Gider);
        }
    }
}
