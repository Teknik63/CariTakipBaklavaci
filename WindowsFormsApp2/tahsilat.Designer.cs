namespace WindowsFormsApp2
{
    partial class tahsilat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tBL_TahsilatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.tBL_TahsilatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TahsilatCariID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCariAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBanka = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCariBakiye = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button3 = new System.Windows.Forms.Button();
            this.ilkTarih = new System.Windows.Forms.DateTimePicker();
            this.sonTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sorguCmb = new System.Windows.Forms.ComboBox();
            this.tBL_TahsilatTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_TahsilatTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TahsilatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TahsilatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tBL_TahsilatBindingSource
            // 
            this.tBL_TahsilatBindingSource.AllowNew = true;
            this.tBL_TahsilatBindingSource.DataMember = "TBL_Tahsilat";
            this.tBL_TahsilatBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_TahsilatDataGridView
            // 
            this.tBL_TahsilatDataGridView.AllowUserToAddRows = false;
            this.tBL_TahsilatDataGridView.AllowUserToDeleteRows = false;
            this.tBL_TahsilatDataGridView.AutoGenerateColumns = false;
            this.tBL_TahsilatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_TahsilatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TahsilatCariID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tBL_TahsilatDataGridView.DataSource = this.tBL_TahsilatBindingSource;
            this.tBL_TahsilatDataGridView.Location = new System.Drawing.Point(12, 56);
            this.tBL_TahsilatDataGridView.Name = "tBL_TahsilatDataGridView";
            this.tBL_TahsilatDataGridView.ReadOnly = true;
            this.tBL_TahsilatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tBL_TahsilatDataGridView.Size = new System.Drawing.Size(807, 569);
            this.tBL_TahsilatDataGridView.TabIndex = 1;
            this.tBL_TahsilatDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_TahsilatDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TahsilatID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TahsilatID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // TahsilatCariID
            // 
            this.TahsilatCariID.DataPropertyName = "TahsilatCariID";
            this.TahsilatCariID.HeaderText = "ID";
            this.TahsilatCariID.Name = "TahsilatCariID";
            this.TahsilatCariID.ReadOnly = true;
            this.TahsilatCariID.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TahsilatCariUnvan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Müşteri Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TahsilatTarih";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TahsilatBanka";
            this.dataGridViewTextBoxColumn4.HeaderText = "Banka";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TahsilatIslemNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "İşlem No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TahsilatMiktar";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // txtCariAd
            // 
            this.txtCariAd.FormattingEnabled = true;
            this.txtCariAd.Location = new System.Drawing.Point(840, 42);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(276, 22);
            this.txtCariAd.TabIndex = 2;
            this.txtCariAd.SelectedIndexChanged += new System.EventHandler(this.txtCariAd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(837, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Ünvanı";
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(840, 89);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 22);
            this.dtTarih.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Banka";
            // 
            // txtBanka
            // 
            this.txtBanka.FormattingEnabled = true;
            this.txtBanka.Items.AddRange(new object[] {
            "AKBANK",
            "ALBARAKA TÜRK KATILIM BANKASI",
            "CITIBANK",
            "DENİZBANK",
            "ENPARA",
            "FİBABANKA",
            "GARANTİ BANKASI",
            "HALK BANKASI",
            "HAYAT FİNANS KATILIM BANKASI",
            "HSBC BANK",
            "ING BANK",
            "İŞ BANKASI",
            "KUVEYT TÜRK KATILIM BANKASI",
            "ODEA BANK",
            "QNB BANK",
            "ŞEKERBANK",
            "T.O.M. KATILIM BANKASI",
            "TÜRKİYE EMLAK KATILIM BANKASI",
            "TÜRKİYE FİNANS KATILIM BANKASI",
            "VAKIF KATILIM BANKASI",
            "VAKIFLAR BANKASI",
            "YAPI VE KREDİ BANKASI",
            "ZİRAAT KATILIM BANKASI"});
            this.txtBanka.Location = new System.Drawing.Point(840, 142);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(276, 22);
            this.txtBanka.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(837, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşlem No";
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Location = new System.Drawing.Point(840, 193);
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.Size = new System.Drawing.Size(215, 22);
            this.txtIslemNo.TabIndex = 9;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(840, 245);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(123, 22);
            this.txtTutar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tutar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(840, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 79);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ödeme Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(939, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 79);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ödeme Iptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(908, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Müşteri Mevcut Borç";
            // 
            // lblCariBakiye
            // 
            this.lblCariBakiye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariBakiye.Location = new System.Drawing.Point(883, 542);
            this.lblCariBakiye.Name = "lblCariBakiye";
            this.lblCariBakiye.Size = new System.Drawing.Size(192, 104);
            this.lblCariBakiye.TabIndex = 17;
            this.lblCariBakiye.Text = "0000000000";
            this.lblCariBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tBL_TahsilatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Tahsilat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1155, 311);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(515, 246);
            this.reportViewer1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1038, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 79);
            this.button3.TabIndex = 19;
            this.button3.Text = "Yazdır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ilkTarih
            // 
            this.ilkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ilkTarih.Location = new System.Drawing.Point(12, 25);
            this.ilkTarih.Name = "ilkTarih";
            this.ilkTarih.Size = new System.Drawing.Size(115, 22);
            this.ilkTarih.TabIndex = 20;
            this.ilkTarih.ValueChanged += new System.EventHandler(this.ilkTarih_ValueChanged);
            // 
            // sonTarih
            // 
            this.sonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sonTarih.Location = new System.Drawing.Point(133, 25);
            this.sonTarih.Name = "sonTarih";
            this.sonTarih.Size = new System.Drawing.Size(115, 22);
            this.sonTarih.TabIndex = 21;
            this.sonTarih.ValueChanged += new System.EventHandler(this.sonTarih_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "İlk Tarih";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "Son Tarih";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(444, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 24;
            this.button4.Text = "Getir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "Müşteri Ünvanı";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // sorguCmb
            // 
            this.sorguCmb.FormattingEnabled = true;
            this.sorguCmb.Location = new System.Drawing.Point(254, 25);
            this.sorguCmb.Name = "sorguCmb";
            this.sorguCmb.Size = new System.Drawing.Size(184, 22);
            this.sorguCmb.TabIndex = 25;
            this.sorguCmb.SelectedIndexChanged += new System.EventHandler(this.sorguCmb_SelectedIndexChanged);
            // 
            // tBL_TahsilatTableAdapter
            // 
            this.tBL_TahsilatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_OdemeTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = this.tBL_TahsilatTableAdapter;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1135, 629);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sorguCmb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sonTarih);
            this.Controls.Add(this.ilkTarih);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblCariBakiye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIslemNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBanka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.tBL_TahsilatDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "tahsilat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Tahsilat";
            this.Load += new System.EventHandler(this.tahsilat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TahsilatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TahsilatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.DataGridView tBL_TahsilatDataGridView;
        private System.Windows.Forms.ComboBox txtCariAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBanka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCariBakiye;
        private System.Windows.Forms.BindingSource tBL_TahsilatBindingSource;
        private DB_CarilerTableAdapters.TBL_TahsilatTableAdapter tBL_TahsilatTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TahsilatCariID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker ilkTarih;
        private System.Windows.Forms.DateTimePicker sonTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sorguCmb;
    }
}