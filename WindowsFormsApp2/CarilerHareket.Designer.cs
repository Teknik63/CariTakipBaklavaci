namespace WindowsFormsApp2
{
    partial class CarilerHareket
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariAd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hareketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketCariIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketCariUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketUrunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketUrunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketUrunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketTepsiUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketKosebentUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketKargoUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBL_CariHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Cariler = new WindowsFormsApp2.DB_Cariler();
            this.txtUrun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKargoUcreti = new System.Windows.Forms.TextBox();
            this.txtKoseBentUcreti = new System.Windows.Forms.TextBox();
            this.txtTepsiUcreti = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tBL_CariHareketTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_CariHareketTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager();
            this.tBL_CarilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_CarilerTableAdapter = new WindowsFormsApp2.DB_CarilerTableAdapters.TBL_CarilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CariHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CarilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Bakiye
            // 
            this.Bakiye.AutoSize = true;
            this.Bakiye.Location = new System.Drawing.Point(942, 424);
            this.Bakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.Size = new System.Drawing.Size(47, 14);
            this.Bakiye.TabIndex = 1;
            this.Bakiye.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(942, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bakiye";
            // 
            // txtCariAd
            // 
            this.txtCariAd.DisplayMember = "1";
            this.txtCariAd.FormattingEnabled = true;
            this.txtCariAd.Location = new System.Drawing.Point(12, 29);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(246, 22);
            this.txtCariAd.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Müşteri Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hareketIDDataGridViewTextBoxColumn,
            this.hareketCariIDDataGridViewTextBoxColumn,
            this.hareketCariUnvanDataGridViewTextBoxColumn,
            this.hareketUrunDataGridViewTextBoxColumn,
            this.hareketUrunAdetDataGridViewTextBoxColumn,
            this.hareketUrunFiyatDataGridViewTextBoxColumn,
            this.hareketTepsiUcretiDataGridViewTextBoxColumn,
            this.hareketKosebentUcretiDataGridViewTextBoxColumn,
            this.hareketKargoUcretiDataGridViewTextBoxColumn,
            this.hareketTarihDataGridViewTextBoxColumn,
            this.hareketToplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBL_CariHareketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 504);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hareketIDDataGridViewTextBoxColumn
            // 
            this.hareketIDDataGridViewTextBoxColumn.DataPropertyName = "HareketID";
            this.hareketIDDataGridViewTextBoxColumn.HeaderText = "HareketID";
            this.hareketIDDataGridViewTextBoxColumn.Name = "hareketIDDataGridViewTextBoxColumn";
            this.hareketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hareketCariIDDataGridViewTextBoxColumn
            // 
            this.hareketCariIDDataGridViewTextBoxColumn.DataPropertyName = "HareketCariID";
            this.hareketCariIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.hareketCariIDDataGridViewTextBoxColumn.Name = "hareketCariIDDataGridViewTextBoxColumn";
            this.hareketCariIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketCariIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // hareketCariUnvanDataGridViewTextBoxColumn
            // 
            this.hareketCariUnvanDataGridViewTextBoxColumn.DataPropertyName = "HareketCariUnvan";
            this.hareketCariUnvanDataGridViewTextBoxColumn.HeaderText = "Firma Adı";
            this.hareketCariUnvanDataGridViewTextBoxColumn.Name = "hareketCariUnvanDataGridViewTextBoxColumn";
            this.hareketCariUnvanDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketCariUnvanDataGridViewTextBoxColumn.Width = 200;
            // 
            // hareketUrunDataGridViewTextBoxColumn
            // 
            this.hareketUrunDataGridViewTextBoxColumn.DataPropertyName = "HareketUrun";
            this.hareketUrunDataGridViewTextBoxColumn.HeaderText = "Ürün";
            this.hareketUrunDataGridViewTextBoxColumn.Name = "hareketUrunDataGridViewTextBoxColumn";
            this.hareketUrunDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketUrunDataGridViewTextBoxColumn.Width = 200;
            // 
            // hareketUrunAdetDataGridViewTextBoxColumn
            // 
            this.hareketUrunAdetDataGridViewTextBoxColumn.DataPropertyName = "HareketUrunAdet";
            this.hareketUrunAdetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.hareketUrunAdetDataGridViewTextBoxColumn.Name = "hareketUrunAdetDataGridViewTextBoxColumn";
            this.hareketUrunAdetDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketUrunAdetDataGridViewTextBoxColumn.Width = 50;
            // 
            // hareketUrunFiyatDataGridViewTextBoxColumn
            // 
            this.hareketUrunFiyatDataGridViewTextBoxColumn.DataPropertyName = "HareketUrunFiyat";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.hareketUrunFiyatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hareketUrunFiyatDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyatı";
            this.hareketUrunFiyatDataGridViewTextBoxColumn.Name = "hareketUrunFiyatDataGridViewTextBoxColumn";
            this.hareketUrunFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hareketTepsiUcretiDataGridViewTextBoxColumn
            // 
            this.hareketTepsiUcretiDataGridViewTextBoxColumn.DataPropertyName = "HareketTepsiUcreti";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.hareketTepsiUcretiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hareketTepsiUcretiDataGridViewTextBoxColumn.HeaderText = "Tepsi Ücreti";
            this.hareketTepsiUcretiDataGridViewTextBoxColumn.Name = "hareketTepsiUcretiDataGridViewTextBoxColumn";
            this.hareketTepsiUcretiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hareketKosebentUcretiDataGridViewTextBoxColumn
            // 
            this.hareketKosebentUcretiDataGridViewTextBoxColumn.DataPropertyName = "HareketKosebentUcreti";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.hareketKosebentUcretiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hareketKosebentUcretiDataGridViewTextBoxColumn.HeaderText = "Köşebent Ücreti";
            this.hareketKosebentUcretiDataGridViewTextBoxColumn.Name = "hareketKosebentUcretiDataGridViewTextBoxColumn";
            this.hareketKosebentUcretiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hareketKargoUcretiDataGridViewTextBoxColumn
            // 
            this.hareketKargoUcretiDataGridViewTextBoxColumn.DataPropertyName = "HareketKargoUcreti";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.hareketKargoUcretiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.hareketKargoUcretiDataGridViewTextBoxColumn.HeaderText = "Kargo Ücreti";
            this.hareketKargoUcretiDataGridViewTextBoxColumn.Name = "hareketKargoUcretiDataGridViewTextBoxColumn";
            this.hareketKargoUcretiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hareketTarihDataGridViewTextBoxColumn
            // 
            this.hareketTarihDataGridViewTextBoxColumn.DataPropertyName = "HareketTarih";
            this.hareketTarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.hareketTarihDataGridViewTextBoxColumn.Name = "hareketTarihDataGridViewTextBoxColumn";
            this.hareketTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hareketToplamDataGridViewTextBoxColumn
            // 
            this.hareketToplamDataGridViewTextBoxColumn.DataPropertyName = "HareketToplam";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.hareketToplamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.hareketToplamDataGridViewTextBoxColumn.HeaderText = "Toplam Tutar";
            this.hareketToplamDataGridViewTextBoxColumn.Name = "hareketToplamDataGridViewTextBoxColumn";
            this.hareketToplamDataGridViewTextBoxColumn.ReadOnly = true;
            this.hareketToplamDataGridViewTextBoxColumn.Width = 150;
            // 
            // tBL_CariHareketBindingSource
            // 
            this.tBL_CariHareketBindingSource.DataMember = "TBL_CariHareket";
            this.tBL_CariHareketBindingSource.DataSource = this.dB_Cariler;
            // 
            // dB_Cariler
            // 
            this.dB_Cariler.DataSetName = "DB_Cariler";
            this.dB_Cariler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUrun
            // 
            this.txtUrun.DisplayMember = "1";
            this.txtUrun.FormattingEnabled = true;
            this.txtUrun.Location = new System.Drawing.Point(264, 29);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(246, 22);
            this.txtUrun.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ürün Adı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1003, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "Sipariş Geç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(663, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 22);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tepsi Fiyatı";
            // 
            // txtKargoUcreti
            // 
            this.txtKargoUcreti.Location = new System.Drawing.Point(936, 29);
            this.txtKargoUcreti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKargoUcreti.Name = "txtKargoUcreti";
            this.txtKargoUcreti.Size = new System.Drawing.Size(60, 22);
            this.txtKargoUcreti.TabIndex = 47;
            this.txtKargoUcreti.Text = "0";
            // 
            // txtKoseBentUcreti
            // 
            this.txtKoseBentUcreti.Location = new System.Drawing.Point(868, 29);
            this.txtKoseBentUcreti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKoseBentUcreti.Name = "txtKoseBentUcreti";
            this.txtKoseBentUcreti.Size = new System.Drawing.Size(60, 22);
            this.txtKoseBentUcreti.TabIndex = 46;
            this.txtKoseBentUcreti.Text = "0";
            // 
            // txtTepsiUcreti
            // 
            this.txtTepsiUcreti.Location = new System.Drawing.Point(784, 29);
            this.txtTepsiUcreti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTepsiUcreti.Name = "txtTepsiUcreti";
            this.txtTepsiUcreti.Size = new System.Drawing.Size(76, 22);
            this.txtTepsiUcreti.TabIndex = 45;
            this.txtTepsiUcreti.Text = "0";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(582, 29);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(74, 22);
            this.txtFiyat.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(517, 29);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(57, 22);
            this.txtAdet.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tepsi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(865, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 53;
            this.label9.Text = "Köşebent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(933, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 54;
            this.label10.Text = "Kargo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1094, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 55;
            this.button2.Text = "Sipariş Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBL_CariHareketTableAdapter
            // 
            this.tBL_CariHareketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBL_CariHareketTableAdapter = this.tBL_CariHareketTableAdapter;
            this.tableAdapterManager.TBL_CarilerTableAdapter = null;
            this.tableAdapterManager.TBL_GiderTableAdapter = null;
            this.tableAdapterManager.TBL_TahsilatTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikciHareketTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikcilerTableAdapter = null;
            this.tableAdapterManager.TBL_TedarikHammaddeTableAdapter = null;
            this.tableAdapterManager.TBL_UrunlerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DB_CarilerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tBL_CarilerBindingSource
            // 
            this.tBL_CarilerBindingSource.DataMember = "TBL_Cariler";
            this.tBL_CarilerBindingSource.DataSource = this.dB_Cariler;
            // 
            // tBL_CarilerTableAdapter
            // 
            this.tBL_CarilerTableAdapter.ClearBeforeFill = true;
            // 
            // CarilerHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1239, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKargoUcreti);
            this.Controls.Add(this.txtKoseBentUcreti);
            this.Controls.Add(this.txtTepsiUcreti);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCariAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bakiye);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CarilerHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CariHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Cariler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_CarilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Bakiye;
        private System.Windows.Forms.Label label1;
        private DB_Cariler dB_Cariler;
        private System.Windows.Forms.BindingSource tBL_CariHareketBindingSource;
        private DB_CarilerTableAdapters.TBL_CariHareketTableAdapter tBL_CariHareketTableAdapter;
        private DB_CarilerTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox txtCariAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKargoUcreti;
        private System.Windows.Forms.TextBox txtKoseBentUcreti;
        private System.Windows.Forms.TextBox txtTepsiUcreti;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketCariIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketCariUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketUrunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketUrunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketUrunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketTepsiUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketKosebentUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketKargoUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hareketToplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBL_CarilerBindingSource;
        private DB_CarilerTableAdapters.TBL_CarilerTableAdapter tBL_CarilerTableAdapter;
    }
}

