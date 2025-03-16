namespace WindowsFormsApp2
{
    partial class Odeme
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBanka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariAd = new System.Windows.Forms.ComboBox();
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.tBL_OdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_OdemeTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_OdemeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            this.tBL_OdemeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCariBakiye = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sorguCmb = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sonTarih = new System.Windows.Forms.DateTimePicker();
            this.ilkTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_OdemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_OdemeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(874, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 79);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ödeme Iptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(775, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 79);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ödeme Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(775, 244);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(123, 22);
            this.txtTutar.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tutar";
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Location = new System.Drawing.Point(775, 192);
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.Size = new System.Drawing.Size(215, 22);
            this.txtIslemNo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "İşlem No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 19;
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
            this.txtBanka.Location = new System.Drawing.Point(775, 141);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(276, 22);
            this.txtBanka.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tarih";
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(775, 88);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 22);
            this.dtTarih.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Müşteri Ünvanı";
            // 
            // txtCariAd
            // 
            this.txtCariAd.FormattingEnabled = true;
            this.txtCariAd.Location = new System.Drawing.Point(775, 41);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(276, 22);
            this.txtCariAd.TabIndex = 14;
            this.txtCariAd.SelectedIndexChanged += new System.EventHandler(this.txtCariAd_SelectedIndexChanged);
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_OdemeBindingSource
            // 
            this.tBL_OdemeBindingSource.DataMember = "TBL_Odeme";
            this.tBL_OdemeBindingSource.DataSource = this.dB_Cariler;
            // 
            // tBL_OdemeTableAdapter
            // 
            this.tBL_OdemeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_OdemeTableAdapter = this.tBL_OdemeTableAdapter;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tBL_OdemeDataGridView
            // 
            this.tBL_OdemeDataGridView.AllowUserToAddRows = false;
            this.tBL_OdemeDataGridView.AllowUserToDeleteRows = false;
            this.tBL_OdemeDataGridView.AutoGenerateColumns = false;
            this.tBL_OdemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tBL_OdemeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tBL_OdemeDataGridView.DataSource = this.tBL_OdemeBindingSource;
            this.tBL_OdemeDataGridView.Location = new System.Drawing.Point(12, 54);
            this.tBL_OdemeDataGridView.Name = "tBL_OdemeDataGridView";
            this.tBL_OdemeDataGridView.ReadOnly = true;
            this.tBL_OdemeDataGridView.Size = new System.Drawing.Size(754, 521);
            this.tBL_OdemeDataGridView.TabIndex = 26;
            this.tBL_OdemeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tBL_OdemeDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OdemeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OdemeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OdemeCariID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OdemeCariUnvan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ünvan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OdemeTarih";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OdemeBanka";
            this.dataGridViewTextBoxColumn5.HeaderText = "Banka";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OdemeIslemNo";
            this.dataGridViewTextBoxColumn6.HeaderText = "İşlem No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OdemeMiktar";
            this.dataGridViewTextBoxColumn7.HeaderText = "Miktar";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // lblCariBakiye
            // 
            this.lblCariBakiye.AutoSize = true;
            this.lblCariBakiye.Location = new System.Drawing.Point(911, 421);
            this.lblCariBakiye.Name = "lblCariBakiye";
            this.lblCariBakiye.Size = new System.Drawing.Size(45, 14);
            this.lblCariBakiye.TabIndex = 27;
            this.lblCariBakiye.Text = "label6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 14);
            this.label9.TabIndex = 34;
            this.label9.Text = "Müşteri Ünvanı";
            // 
            // sorguCmb
            // 
            this.sorguCmb.FormattingEnabled = true;
            this.sorguCmb.Location = new System.Drawing.Point(254, 26);
            this.sorguCmb.Name = "sorguCmb";
            this.sorguCmb.Size = new System.Drawing.Size(184, 22);
            this.sorguCmb.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(444, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 32;
            this.button4.Text = "Getir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Son Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "İlk Tarih";
            // 
            // sonTarih
            // 
            this.sonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sonTarih.Location = new System.Drawing.Point(133, 26);
            this.sonTarih.Name = "sonTarih";
            this.sonTarih.Size = new System.Drawing.Size(115, 22);
            this.sonTarih.TabIndex = 29;
            // 
            // ilkTarih
            // 
            this.ilkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ilkTarih.Location = new System.Drawing.Point(12, 26);
            this.ilkTarih.Name = "ilkTarih";
            this.ilkTarih.Size = new System.Drawing.Size(115, 22);
            this.ilkTarih.TabIndex = 28;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sorguCmb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sonTarih);
            this.Controls.Add(this.ilkTarih);
            this.Controls.Add(this.lblCariBakiye);
            this.Controls.Add(this.tBL_OdemeDataGridView);
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
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_OdemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_OdemeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBanka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCariAd;
        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_OdemeBindingSource;
        private DB_CarilerTableAdapters.TBL_OdemeTableAdapter tBL_OdemeTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tBL_OdemeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblCariBakiye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sorguCmb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker sonTarih;
        private System.Windows.Forms.DateTimePicker ilkTarih;
    }
}