namespace WindowsFormsApp2
{
    partial class TedarikHareket
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedarikHareket));
            this.tBL_TedarikciHareketDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.sorguCmb = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sonTarih = new System.Windows.Forms.DateTimePicker();
            this.ilkTarih = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.Mik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzeme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariAd = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCariBakiye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tBL_TedarikciHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_TedarikciHareketTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_TedarikciHareketTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikciHareketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikciHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            this.SuspendLayout();
            // 
            // tBL_TedarikciHareketDataGridView
            // 
            this.tBL_TedarikciHareketDataGridView.AllowUserToAddRows = false;
            this.tBL_TedarikciHareketDataGridView.AllowUserToDeleteRows = false;
            this.tBL_TedarikciHareketDataGridView.AutoGenerateColumns = false;
            this.tBL_TedarikciHareketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_TedarikciHareketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tBL_TedarikciHareketDataGridView.DataSource = this.tBL_TedarikciHareketBindingSource;
            this.tBL_TedarikciHareketDataGridView.Location = new System.Drawing.Point(13, 12);
            this.tBL_TedarikciHareketDataGridView.Name = "tBL_TedarikciHareketDataGridView";
            this.tBL_TedarikciHareketDataGridView.ReadOnly = true;
            this.tBL_TedarikciHareketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tBL_TedarikciHareketDataGridView.Size = new System.Drawing.Size(1043, 471);
            this.tBL_TedarikciHareketDataGridView.TabIndex = 1;
            this.tBL_TedarikciHareketDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_TedarikciHareketDataGridView_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Müşteri Ünvanı";
            // 
            // sorguCmb
            // 
            this.sorguCmb.FormattingEnabled = true;
            this.sorguCmb.Location = new System.Drawing.Point(255, 519);
            this.sorguCmb.Name = "sorguCmb";
            this.sorguCmb.Size = new System.Drawing.Size(184, 24);
            this.sorguCmb.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(561, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 31;
            this.button4.Text = "Getir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Son Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "İlk Tarih";
            // 
            // sonTarih
            // 
            this.sonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sonTarih.Location = new System.Drawing.Point(134, 519);
            this.sonTarih.Name = "sonTarih";
            this.sonTarih.Size = new System.Drawing.Size(115, 23);
            this.sonTarih.TabIndex = 28;
            // 
            // ilkTarih
            // 
            this.ilkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ilkTarih.Location = new System.Drawing.Point(13, 519);
            this.ilkTarih.Name = "ilkTarih";
            this.ilkTarih.Size = new System.Drawing.Size(115, 23);
            this.ilkTarih.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1260, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 79);
            this.button3.TabIndex = 46;
            this.button3.Text = "Yazdır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1161, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 79);
            this.button2.TabIndex = 45;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1062, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 79);
            this.button1.TabIndex = 44;
            this.button1.Text = "Malzeme Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(1065, 232);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(123, 23);
            this.txtFiyat.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1062, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fiyat";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(1065, 180);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(215, 23);
            this.txtMiktar.TabIndex = 41;
            // 
            // Mik
            // 
            this.Mik.AutoSize = true;
            this.Mik.Location = new System.Drawing.Point(1062, 163);
            this.Mik.Name = "Mik";
            this.Mik.Size = new System.Drawing.Size(47, 16);
            this.Mik.TabIndex = 40;
            this.Mik.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1062, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Malzeme";
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.FormattingEnabled = true;
            this.txtMalzeme.Location = new System.Drawing.Point(1065, 129);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(276, 24);
            this.txtMalzeme.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1062, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(1065, 76);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 23);
            this.dtTarih.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1062, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Müşteri Ünvanı";
            // 
            // txtCariAd
            // 
            this.txtCariAd.FormattingEnabled = true;
            this.txtCariAd.Location = new System.Drawing.Point(1065, 29);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(276, 24);
            this.txtCariAd.TabIndex = 34;
            this.txtCariAd.SelectedIndexChanged += new System.EventHandler(this.txtCariAd_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tBL_TedarikciHareketBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.TedarikHareket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(577, 565);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 155);
            this.reportViewer1.TabIndex = 47;
            // 
            // lblCariBakiye
            // 
            this.lblCariBakiye.AutoSize = true;
            this.lblCariBakiye.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariBakiye.Location = new System.Drawing.Point(1154, 320);
            this.lblCariBakiye.Name = "lblCariBakiye";
            this.lblCariBakiye.Size = new System.Drawing.Size(48, 16);
            this.lblCariBakiye.TabIndex = 48;
            this.lblCariBakiye.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1073, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Bakiye :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 523);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 20);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "Ünvana Göre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tBL_TedarikciHareketBindingSource
            // 
            this.tBL_TedarikciHareketBindingSource.DataMember = "TBL_TedarikciHareket";
            this.tBL_TedarikciHareketBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HareketID";
            this.dataGridViewTextBoxColumn1.HeaderText = "HareketID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HareketTedarikciID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HareketTedarikciUnvan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Firma Adı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HareketTedarikciHamMadde";
            this.dataGridViewTextBoxColumn4.HeaderText = "Malzeme";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HareketTedarikciHamMaddemiktar";
            this.dataGridViewTextBoxColumn5.HeaderText = "Miktar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HareketTedarikciHamMaddeFiyat";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HareketTarih";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HareketToplam";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tBL_TedarikciHareketTableAdapter
            // 
            this.tBL_TedarikciHareketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_OdemeTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = this.tBL_TedarikciHareketTableAdapter;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TedarikHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1359, 552);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCariBakiye);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.Mik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sorguCmb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sonTarih);
            this.Controls.Add(this.ilkTarih);
            this.Controls.Add(this.tBL_TedarikciHareketDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TedarikHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TedarikHareket";
            this.Load += new System.EventHandler(this.TedarikHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikciHareketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_TedarikciHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_TedarikciHareketBindingSource;
        private DB_CarilerTableAdapters.TBL_TedarikciHareketTableAdapter tBL_TedarikciHareketTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tBL_TedarikciHareketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sorguCmb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker sonTarih;
        private System.Windows.Forms.DateTimePicker ilkTarih;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label Mik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMalzeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCariAd;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblCariBakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}