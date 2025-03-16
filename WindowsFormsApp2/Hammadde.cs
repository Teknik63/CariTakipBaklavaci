using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
    public partial class Hammadde : Form
    {
        public int ID;
        public Hammadde()
        {
            InitializeComponent();
        }

        private void tBL_TedarikHammaddeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBL_TedarikHammaddeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Cariler);

        }

        private void Hammadde_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Cariler.TBL_TedarikHammadde' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_TedarikHammaddeTableAdapter.Fill(this.dB_Cariler.TBL_TedarikHammadde);

        }

        private void btnHamMadde_Click(object sender, EventArgs e)
        {
            tBL_TedarikHammaddeTableAdapter.InsertTedarikHamMadde(txtHamMadde.Text);
            this.tBL_TedarikHammaddeTableAdapter.Fill(this.dB_Cariler.TBL_TedarikHammadde);
        }

        private void tBL_TedarikHammaddeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = tBL_TedarikHammaddeDataGridView.Rows[e.RowIndex];
                txtHamMadde.Text = dg.Cells[1].Value.ToString();
                ID = Convert.ToInt32(dg.Cells[0].Value.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBL_TedarikHammaddeTableAdapter.DeleteTedarikHamMadde(ID);
            this.tBL_TedarikHammaddeTableAdapter.Fill(this.dB_Cariler.TBL_TedarikHammadde);
        }
    }
}
