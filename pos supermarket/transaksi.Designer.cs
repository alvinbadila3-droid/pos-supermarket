namespace pos_supermarket
{
    partial class transaksi
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
            this.txtkodeproduct = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtuangbayar = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblkembalian = new System.Windows.Forms.Label();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.btnbayar = new System.Windows.Forms.Button();
            this.dgvkeranjang = new System.Windows.Forms.DataGridView();
            this.numjumlah = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numjumlah)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkodeproduct
            // 
            this.txtkodeproduct.Location = new System.Drawing.Point(22, 42);
            this.txtkodeproduct.Name = "txtkodeproduct";
            this.txtkodeproduct.Size = new System.Drawing.Size(144, 22);
            this.txtkodeproduct.TabIndex = 0;
            this.txtkodeproduct.TextChanged += new System.EventHandler(this.txtkodeproduct_TextChanged);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(32, 34);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtsubtotal.TabIndex = 2;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(150, 34);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 22);
            this.txtdiscount.TabIndex = 3;
            // 
            // txtuangbayar
            // 
            this.txtuangbayar.Location = new System.Drawing.Point(89, 82);
            this.txtuangbayar.Name = "txtuangbayar";
            this.txtuangbayar.Size = new System.Drawing.Size(100, 22);
            this.txtuangbayar.TabIndex = 4;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(281, 34);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(44, 16);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "label1";
            // 
            // lblkembalian
            // 
            this.lblkembalian.AutoSize = true;
            this.lblkembalian.Location = new System.Drawing.Point(220, 85);
            this.lblkembalian.Name = "lblkembalian";
            this.lblkembalian.Size = new System.Drawing.Size(44, 16);
            this.lblkembalian.TabIndex = 6;
            this.lblkembalian.Text = "label2";
            // 
            // btnmasuk
            // 
            this.btnmasuk.Location = new System.Drawing.Point(47, 130);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(96, 43);
            this.btnmasuk.TabIndex = 7;
            this.btnmasuk.Text = "masukan";
            this.btnmasuk.UseVisualStyleBackColor = true;
            this.btnmasuk.Click += new System.EventHandler(this.btnmasuk_Click);
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(614, 352);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(95, 54);
            this.btnbayar.TabIndex = 8;
            this.btnbayar.Text = "bayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            this.btnbayar.Click += new System.EventHandler(this.btnbayar_Click);
            // 
            // dgvkeranjang
            // 
            this.dgvkeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkeranjang.Location = new System.Drawing.Point(212, 29);
            this.dgvkeranjang.Name = "dgvkeranjang";
            this.dgvkeranjang.RowHeadersWidth = 51;
            this.dgvkeranjang.RowTemplate.Height = 24;
            this.dgvkeranjang.Size = new System.Drawing.Size(565, 254);
            this.dgvkeranjang.TabIndex = 9;
            this.dgvkeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numjumlah
            // 
            this.numjumlah.Location = new System.Drawing.Point(22, 92);
            this.numjumlah.Name = "numjumlah";
            this.numjumlah.Size = new System.Drawing.Size(144, 22);
            this.numjumlah.TabIndex = 10;
            this.numjumlah.ValueChanged += new System.EventHandler(this.numjumlah_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numjumlah);
            this.groupBox1.Controls.Add(this.btnmasuk);
            this.groupBox1.Controls.Add(this.txtkodeproduct);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 205);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblkembalian);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.txtuangbayar);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Location = new System.Drawing.Point(191, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "kode product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "uang bayar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "discount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvkeranjang);
            this.Controls.Add(this.btnbayar);
            this.Name = "transaksi";
            this.Text = "transaksi";
            this.Load += new System.EventHandler(this.transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numjumlah)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtkodeproduct;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtuangbayar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblkembalian;
        private System.Windows.Forms.Button btnmasuk;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.DataGridView dgvkeranjang;
        private System.Windows.Forms.NumericUpDown numjumlah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}