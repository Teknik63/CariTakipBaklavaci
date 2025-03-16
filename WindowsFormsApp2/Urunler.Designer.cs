namespace WindowsFormsApp2
{
    partial class Urunler
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
            this.tBL_UrunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_UrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.btnUrun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tBL_UrunlerTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_UrunlerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_UrunlerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_UrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            this.SuspendLayout();
            // 
            // tBL_UrunlerDataGridView
            // 
            this.tBL_UrunlerDataGridView.AllowUserToAddRows = false;
            this.tBL_UrunlerDataGridView.AllowUserToDeleteRows = false;
            this.tBL_UrunlerDataGridView.AutoGenerateColumns = false;
            this.tBL_UrunlerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBL_UrunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_UrunlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tBL_UrunlerDataGridView.DataSource = this.tBL_UrunlerBindingSource;
            this.tBL_UrunlerDataGridView.Location = new System.Drawing.Point(16, 13);
            this.tBL_UrunlerDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBL_UrunlerDataGridView.Name = "tBL_UrunlerDataGridView";
            this.tBL_UrunlerDataGridView.ReadOnly = true;
            this.tBL_UrunlerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tBL_UrunlerDataGridView.Size = new System.Drawing.Size(357, 527);
            this.tBL_UrunlerDataGridView.TabIndex = 1;
            this.tBL_UrunlerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_UrunlerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UrunID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UrunID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UrunAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ürünler";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // tBL_UrunlerBindingSource
            // 
            this.tBL_UrunlerBindingSource.DataMember = "TBL_Urunler";
            this.tBL_UrunlerBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(16, 546);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(357, 22);
            this.txtUrun.TabIndex = 2;
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.Lime;
            this.btnUrun.FlatAppearance.BorderSize = 0;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.Location = new System.Drawing.Point(16, 574);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(92, 38);
            this.btnUrun.TabIndex = 3;
            this.btnUrun.Text = "Ürün Ekle";
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(114, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBL_UrunlerTableAdapter
            // 
            this.tBL_UrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_OdemeTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = this.tBL_UrunlerTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(388, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.tBL_UrunlerDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_UrunlerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_UrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_UrunlerBindingSource;
        private DB_CarilerTableAdapters.TBL_UrunlerTableAdapter tBL_UrunlerTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tBL_UrunlerDataGridView;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button button1;
    }
}