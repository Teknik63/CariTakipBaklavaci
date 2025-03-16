namespace WindowsFormsApp2
{
    partial class Hammadde
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHamMadde = new System.Windows.Forms.Button();
            this.txtHamMadde = new System.Windows.Forms.TextBox();
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.tBL_TedarikHammaddeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_TedarikHammaddeTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_TedarikHammaddeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            this.tBL_TedarikHammaddeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikHammaddeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikHammaddeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(123, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Iptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHamMadde
            // 
            this.btnHamMadde.BackColor = System.Drawing.Color.Lime;
            this.btnHamMadde.FlatAppearance.BorderSize = 0;
            this.btnHamMadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamMadde.Location = new System.Drawing.Point(13, 579);
            this.btnHamMadde.Margin = new System.Windows.Forms.Padding(4);
            this.btnHamMadde.Name = "btnHamMadde";
            this.btnHamMadde.Size = new System.Drawing.Size(102, 32);
            this.btnHamMadde.TabIndex = 7;
            this.btnHamMadde.Text = "Ürün Ekle";
            this.btnHamMadde.UseVisualStyleBackColor = false;
            this.btnHamMadde.Click += new System.EventHandler(this.btnHamMadde_Click);
            // 
            // txtHamMadde
            // 
            this.txtHamMadde.Location = new System.Drawing.Point(13, 549);
            this.txtHamMadde.Margin = new System.Windows.Forms.Padding(4);
            this.txtHamMadde.Name = "txtHamMadde";
            this.txtHamMadde.Size = new System.Drawing.Size(361, 22);
            this.txtHamMadde.TabIndex = 6;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_TedarikHammaddeBindingSource
            // 
            this.tBL_TedarikHammaddeBindingSource.DataMember = "TBL_TedarikHammadde";
            this.tBL_TedarikHammaddeBindingSource.DataSource = this.dB_Cariler;
            // 
            // tBL_TedarikHammaddeTableAdapter
            // 
            this.tBL_TedarikHammaddeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = this.tBL_TedarikHammaddeTableAdapter;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tBL_TedarikHammaddeDataGridView
            // 
            this.tBL_TedarikHammaddeDataGridView.AllowUserToAddRows = false;
            this.tBL_TedarikHammaddeDataGridView.AllowUserToDeleteRows = false;
            this.tBL_TedarikHammaddeDataGridView.AutoGenerateColumns = false;
            this.tBL_TedarikHammaddeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_TedarikHammaddeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tBL_TedarikHammaddeDataGridView.DataSource = this.tBL_TedarikHammaddeBindingSource;
            this.tBL_TedarikHammaddeDataGridView.Location = new System.Drawing.Point(17, 12);
            this.tBL_TedarikHammaddeDataGridView.Name = "tBL_TedarikHammaddeDataGridView";
            this.tBL_TedarikHammaddeDataGridView.ReadOnly = true;
            this.tBL_TedarikHammaddeDataGridView.Size = new System.Drawing.Size(361, 530);
            this.tBL_TedarikHammaddeDataGridView.TabIndex = 9;
            this.tBL_TedarikHammaddeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_TedarikHammaddeDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TedarikUrunID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TedarikUrunID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TedarikHamMaddeAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ham Madde Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Hammadde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(388, 620);
            this.Controls.Add(this.tBL_TedarikHammaddeDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHamMadde);
            this.Controls.Add(this.txtHamMadde);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Hammadde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hammadde";
            this.Load += new System.EventHandler(this.Hammadde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikHammaddeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikHammaddeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHamMadde;
        private System.Windows.Forms.TextBox txtHamMadde;
        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_TedarikHammaddeBindingSource;
        private DB_CarilerTableAdapters.TBL_TedarikHammaddeTableAdapter tBL_TedarikHammaddeTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tBL_TedarikHammaddeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}