using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Urunler : Form
    {
        public int ID;
        public Urunler()
        {
            InitializeComponent();
        }

        private void tBL_UrunlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_UrunlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_Urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_UrunlerTableAdapter.Fill(this.dB_Cariler.TBL_Urunler);

        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            tBL_UrunlerTableAdapter.InsertUrunler(txtUrun.Text);
            this.tBL_UrunlerTableAdapter.Fill(this.dB_Cariler.TBL_Urunler);
        }

        private void tBL_UrunlerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_UrunlerDataGridView.Rows[e.RowIndex];
                txtUrun.Text = dg.Cells[1].Value.ToString();
                ID = Convert.ToInt32(dg.Cells[0].Value.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBL_UrunlerTableAdapter.DeleteUrunler(ID);
            this.tBL_UrunlerTableAdapter.Fill(this.dB_Cariler.TBL_Urunler);
        }
    }
}
