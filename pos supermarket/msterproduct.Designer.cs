namespace pos_supermarket
{
    partial class msterproduct
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
            System.Windows.Forms.Label kodeProductLabel;
            System.Windows.Forms.Label namaProductLabel;
            System.Windows.Forms.Label stokProductLabel;
            System.Windows.Forms.Label hargaProductLabel;
            System.Windows.Forms.Label kategoriProductLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msterproduct));
            this.dB_POS_SupermarketDataSet = new pos_supermarket.DB_POS_SupermarketDataSet();
            this.tbl_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProductsTableAdapter = new pos_supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter();
            this.tableAdapterManager = new pos_supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager();
            this.tbl_ProductsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_ProductsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtkodeproduct = new System.Windows.Forms.TextBox();
            this.txtnamaproduk = new System.Windows.Forms.TextBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.numstok = new System.Windows.Forms.NumericUpDown();
            this.numharga = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            kodeProductLabel = new System.Windows.Forms.Label();
            namaProductLabel = new System.Windows.Forms.Label();
            stokProductLabel = new System.Windows.Forms.Label();
            hargaProductLabel = new System.Windows.Forms.Label();
            kategoriProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).BeginInit();
            this.tbl_ProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numharga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kodeProductLabel
            // 
            kodeProductLabel.AutoSize = true;
            kodeProductLabel.Location = new System.Drawing.Point(21, 10);
            kodeProductLabel.Name = "kodeProductLabel";
            kodeProductLabel.Size = new System.Drawing.Size(91, 16);
            kodeProductLabel.TabIndex = 3;
            kodeProductLabel.Text = "Kode Product:";
            // 
            // namaProductLabel
            // 
            namaProductLabel.AutoSize = true;
            namaProductLabel.Location = new System.Drawing.Point(16, 38);
            namaProductLabel.Name = "namaProductLabel";
            namaProductLabel.Size = new System.Drawing.Size(96, 16);
            namaProductLabel.TabIndex = 5;
            namaProductLabel.Text = "Nama Product:";
            // 
            // stokProductLabel
            // 
            stokProductLabel.AutoSize = true;
            stokProductLabel.Location = new System.Drawing.Point(16, 93);
            stokProductLabel.Name = "stokProductLabel";
            stokProductLabel.Size = new System.Drawing.Size(86, 16);
            stokProductLabel.TabIndex = 11;
            stokProductLabel.Text = "Stok Product:";
            // 
            // hargaProductLabel
            // 
            hargaProductLabel.AutoSize = true;
            hargaProductLabel.Location = new System.Drawing.Point(16, 117);
            hargaProductLabel.Name = "hargaProductLabel";
            hargaProductLabel.Size = new System.Drawing.Size(97, 16);
            hargaProductLabel.TabIndex = 13;
            hargaProductLabel.Text = "Harga Product:";
            // 
            // kategoriProductLabel
            // 
            kategoriProductLabel.AutoSize = true;
            kategoriProductLabel.Location = new System.Drawing.Point(4, 63);
            kategoriProductLabel.Name = "kategoriProductLabel";
            kategoriProductLabel.Size = new System.Drawing.Size(109, 16);
            kategoriProductLabel.TabIndex = 9;
            kategoriProductLabel.Text = "Kategori Product:";
            // 
            // dB_POS_SupermarketDataSet
            // 
            this.dB_POS_SupermarketDataSet.DataSetName = "DB_POS_SupermarketDataSet";
            this.dB_POS_SupermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProductsBindingSource
            // 
            this.tbl_ProductsBindingSource.DataMember = "Tbl_Products";
            this.tbl_ProductsBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_ProductsTableAdapter
            // 
            this.tbl_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tbl_DetailTransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_ProductsTableAdapter = this.tbl_ProductsTableAdapter;
            this.tableAdapterManager.Tbl_TransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pos_supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_ProductsBindingNavigator
            // 
            this.tbl_ProductsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_ProductsBindingNavigator.BindingSource = this.tbl_ProductsBindingSource;
            this.tbl_ProductsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_ProductsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_ProductsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_ProductsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_ProductsBindingNavigatorSaveItem});
            this.tbl_ProductsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_ProductsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_ProductsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_ProductsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_ProductsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_ProductsBindingNavigator.Name = "tbl_ProductsBindingNavigator";
            this.tbl_ProductsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_ProductsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tbl_ProductsBindingNavigator.TabIndex = 0;
            this.tbl_ProductsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_ProductsBindingNavigatorSaveItem
            // 
            this.tbl_ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_ProductsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_ProductsBindingNavigatorSaveItem.Image")));
            this.tbl_ProductsBindingNavigatorSaveItem.Name = "tbl_ProductsBindingNavigatorSaveItem";
            this.tbl_ProductsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_ProductsBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_ProductsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_ProductsBindingNavigatorSaveItem_Click);
            // 
            // txtkodeproduct
            // 
            this.txtkodeproduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "KodeProduct", true));
            this.txtkodeproduct.Location = new System.Drawing.Point(131, 4);
            this.txtkodeproduct.Name = "txtkodeproduct";
            this.txtkodeproduct.Size = new System.Drawing.Size(137, 22);
            this.txtkodeproduct.TabIndex = 4;
            // 
            // txtnamaproduk
            // 
            this.txtnamaproduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "NamaProduct", true));
            this.txtnamaproduk.Location = new System.Drawing.Point(131, 32);
            this.txtnamaproduk.Name = "txtnamaproduk";
            this.txtnamaproduk.Size = new System.Drawing.Size(137, 22);
            this.txtnamaproduk.TabIndex = 6;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(131, 57);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(137, 24);
            this.cmbkategori.TabIndex = 15;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(353, 108);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(95, 38);
            this.btnsimpan.TabIndex = 16;
            this.btnsimpan.Text = "simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(502, 108);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(86, 38);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "ubah";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(649, 108);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(96, 38);
            this.btnhapus.TabIndex = 18;
            this.btnhapus.Text = "hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(0, 209);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersWidth = 51;
            this.dgvproduct.RowTemplate.Height = 24;
            this.dgvproduct.Size = new System.Drawing.Size(800, 200);
            this.dgvproduct.TabIndex = 19;
            this.dgvproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellClick);
            this.dgvproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numstok
            // 
            this.numstok.Location = new System.Drawing.Point(131, 87);
            this.numstok.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numstok.Name = "numstok";
            this.numstok.Size = new System.Drawing.Size(137, 22);
            this.numstok.TabIndex = 20;
            // 
            // numharga
            // 
            this.numharga.DecimalPlaces = 2;
            this.numharga.Location = new System.Drawing.Point(131, 115);
            this.numharga.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numharga.Name = "numharga";
            this.numharga.Size = new System.Drawing.Size(137, 22);
            this.numharga.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.numharga);
            this.groupBox1.Controls.Add(this.numstok);
            this.groupBox1.Controls.Add(this.cmbkategori);
            this.groupBox1.Controls.Add(kodeProductLabel);
            this.groupBox1.Controls.Add(this.txtkodeproduct);
            this.groupBox1.Controls.Add(namaProductLabel);
            this.groupBox1.Controls.Add(this.txtnamaproduk);
            this.groupBox1.Controls.Add(kategoriProductLabel);
            this.groupBox1.Controls.Add(stokProductLabel);
            this.groupBox1.Controls.Add(hargaProductLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 170);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msterproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.tbl_ProductsBindingNavigator);
            this.Name = "msterproduct";
            this.Text = "msterproduct";
            this.Load += new System.EventHandler(this.msterproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).EndInit();
            this.tbl_ProductsBindingNavigator.ResumeLayout(false);
            this.tbl_ProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numharga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_POS_SupermarketDataSet dB_POS_SupermarketDataSet;
        private System.Windows.Forms.BindingSource tbl_ProductsBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter tbl_ProductsTableAdapter;
        private DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_ProductsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_ProductsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtkodeproduct;
        private System.Windows.Forms.TextBox txtnamaproduk;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.NumericUpDown numstok;
        private System.Windows.Forms.NumericUpDown numharga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}