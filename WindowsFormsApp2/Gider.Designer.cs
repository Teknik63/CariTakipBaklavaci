namespace WindowsFormsApp2
{
    partial class Gider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tBL_GiderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_GiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tBL_GiderTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_GiderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            this.txtAciklama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_GiderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_GiderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            this.SuspendLayout();
            // 
            // tBL_GiderDataGridView
            // 
            this.tBL_GiderDataGridView.AllowUserToAddRows = false;
            this.tBL_GiderDataGridView.AllowUserToDeleteRows = false;
            this.tBL_GiderDataGridView.AutoGenerateColumns = false;
            this.tBL_GiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_GiderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tBL_GiderDataGridView.DataSource = this.tBL_GiderBindingSource;
            this.tBL_GiderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tBL_GiderDataGridView.Name = "tBL_GiderDataGridView";
            this.tBL_GiderDataGridView.ReadOnly = true;
            this.tBL_GiderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tBL_GiderDataGridView.Size = new System.Drawing.Size(473, 558);
            this.tBL_GiderDataGridView.TabIndex = 1;
            this.tBL_GiderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_GiderDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GiderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "GiderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GiderKalemi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiderTutar";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiderTarih";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tBL_GiderBindingSource
            // 
            this.tBL_GiderBindingSource.DataMember = "TBL_Gider";
            this.tBL_GiderBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(491, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(620, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(491, 85);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(123, 23);
            this.txtTutar.TabIndex = 7;
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(491, 139);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(120, 23);
            this.dtTarih.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih";
            // 
            // tBL_GiderTableAdapter
            // 
            this.tBL_GiderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = this.tBL_GiderTableAdapter;
            this.tableAdapterManager.TBL_OdemeTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtAciklama
            // 
            this.txtAciklama.FormattingEnabled = true;
            this.txtAciklama.Items.AddRange(new object[] {
            "İşçi Giderleri",
            "Temizlik Giderleri",
            "Tamirat Giderleri",
            "Genel Giderler",
            "Yemek Giderleri"});
            this.txtAciklama.Location = new System.Drawing.Point(494, 31);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(249, 24);
            this.txtAciklama.TabIndex = 10;
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(754, 582);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBL_GiderDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Gider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genel ve İşçi Giderleri";
            this.Load += new System.EventHandler(this.Gider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_GiderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_GiderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_GiderBindingSource;
        private DB_CarilerTableAdapters.TBL_GiderTableAdapter tBL_GiderTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tBL_GiderDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox txtAciklama;
    }
}