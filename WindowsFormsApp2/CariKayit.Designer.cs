namespace WindowsFormsApp2
{
    partial class CariKayit
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
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdSoayd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblindex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.borc = new System.Windows.Forms.Label();
            this.cariIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariBakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_CarilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.tBL_CarilerTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_CarilerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CarilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(84, 12);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(241, 22);
            this.txtUnvan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ünvan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // txtAdSoayd
            // 
            this.txtAdSoayd.Location = new System.Drawing.Point(84, 51);
            this.txtAdSoayd.Name = "txtAdSoayd";
            this.txtAdSoayd.Size = new System.Drawing.Size(241, 22);
            this.txtAdSoayd.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(84, 90);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(241, 96);
            this.txtAdres.TabIndex = 8;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ (İZMİT)",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA (ADAPAZARI)",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.txtSehir.Location = new System.Drawing.Point(84, 205);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(121, 22);
            this.txtSehir.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(84, 248);
            this.txtTelefon.Mask = "(9999) 000-00-00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(131, 22);
            this.txtTelefon.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(84, 315);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 66);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Salmon;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIptal.Location = new System.Drawing.Point(245, 315);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 66);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Chocolate;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cariIDDataGridViewTextBoxColumn,
            this.cariUnvanDataGridViewTextBoxColumn,
            this.cariAdSoyadDataGridViewTextBoxColumn,
            this.cariSehirDataGridViewTextBoxColumn,
            this.cariTelefonDataGridViewTextBoxColumn,
            this.cariEmailDataGridViewTextBoxColumn,
            this.cariBakiyeDataGridViewTextBoxColumn,
            this.cariAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBL_CarilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(341, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 527);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Location = new System.Drawing.Point(165, 315);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 66);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblindex
            // 
            this.lblindex.AutoSize = true;
            this.lblindex.Location = new System.Drawing.Point(314, 557);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(45, 14);
            this.lblindex.TabIndex = 18;
            this.lblindex.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Borç / Alacak";
            // 
            // borc
            // 
            this.borc.AutoSize = true;
            this.borc.Location = new System.Drawing.Point(204, 525);
            this.borc.Name = "borc";
            this.borc.Size = new System.Drawing.Size(87, 14);
            this.borc.TabIndex = 20;
            this.borc.Text = "Borç / Alacak";
            // 
            // cariIDDataGridViewTextBoxColumn
            // 
            this.cariIDDataGridViewTextBoxColumn.DataPropertyName = "CariID";
            this.cariIDDataGridViewTextBoxColumn.HeaderText = "CariID";
            this.cariIDDataGridViewTextBoxColumn.Name = "cariIDDataGridViewTextBoxColumn";
            this.cariIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cariUnvanDataGridViewTextBoxColumn
            // 
            this.cariUnvanDataGridViewTextBoxColumn.DataPropertyName = "CariUnvan";
            this.cariUnvanDataGridViewTextBoxColumn.HeaderText = "Ünvan";
            this.cariUnvanDataGridViewTextBoxColumn.Name = "cariUnvanDataGridViewTextBoxColumn";
            this.cariUnvanDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariUnvanDataGridViewTextBoxColumn.Width = 130;
            // 
            // cariAdSoyadDataGridViewTextBoxColumn
            // 
            this.cariAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "CariAdSoyad";
            this.cariAdSoyadDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.cariAdSoyadDataGridViewTextBoxColumn.Name = "cariAdSoyadDataGridViewTextBoxColumn";
            this.cariAdSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariAdSoyadDataGridViewTextBoxColumn.Width = 130;
            // 
            // cariSehirDataGridViewTextBoxColumn
            // 
            this.cariSehirDataGridViewTextBoxColumn.DataPropertyName = "CariSehir";
            this.cariSehirDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.cariSehirDataGridViewTextBoxColumn.Name = "cariSehirDataGridViewTextBoxColumn";
            this.cariSehirDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariSehirDataGridViewTextBoxColumn.Width = 120;
            // 
            // cariTelefonDataGridViewTextBoxColumn
            // 
            this.cariTelefonDataGridViewTextBoxColumn.DataPropertyName = "CariTelefon";
            this.cariTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.cariTelefonDataGridViewTextBoxColumn.Name = "cariTelefonDataGridViewTextBoxColumn";
            this.cariTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariTelefonDataGridViewTextBoxColumn.Width = 130;
            // 
            // cariEmailDataGridViewTextBoxColumn
            // 
            this.cariEmailDataGridViewTextBoxColumn.DataPropertyName = "CariEmail";
            this.cariEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cariEmailDataGridViewTextBoxColumn.Name = "cariEmailDataGridViewTextBoxColumn";
            this.cariEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariEmailDataGridViewTextBoxColumn.Width = 130;
            // 
            // cariBakiyeDataGridViewTextBoxColumn
            // 
            this.cariBakiyeDataGridViewTextBoxColumn.DataPropertyName = "CariBakiye";
            this.cariBakiyeDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            this.cariBakiyeDataGridViewTextBoxColumn.Name = "cariBakiyeDataGridViewTextBoxColumn";
            this.cariBakiyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cariAdresDataGridViewTextBoxColumn
            // 
            this.cariAdresDataGridViewTextBoxColumn.DataPropertyName = "CariAdres";
            this.cariAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.cariAdresDataGridViewTextBoxColumn.Name = "cariAdresDataGridViewTextBoxColumn";
            this.cariAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.cariAdresDataGridViewTextBoxColumn.Width = 200;
            // 
            // tBL_CarilerBindingSource
            // 
            this.tBL_CarilerBindingSource.DataMember = "TBL_Cariler";
            this.tBL_CarilerBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_CarilerTableAdapter
            // 
            this.tBL_CarilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = null;
            this.tableAdapterManager.TBL_CarilerTableAdapter = this.tBL_CarilerTableAdapter;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CariKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1360, 551);
            this.Controls.Add(this.borc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblindex);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdSoayd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnvan);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CariKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariKayit";
            this.Load += new System.EventHandler(this.CariKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CarilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoayd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnKaydet;
        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_CarilerBindingSource;
        private DB_CarilerTableAdapters.TBL_CarilerTableAdapter tBL_CarilerTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariBakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblindex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label borc;
    }
}