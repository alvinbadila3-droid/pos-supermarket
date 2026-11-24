using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_supermarket
{
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
        }
        private string connect = "Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transaksi_Load(object sender, EventArgs e)
        {
            hitungrantotal();
            loadautocompletekode();
            setupkeranjang();
        }
        private void loadautocompletekode()
        {
            AutoCompleteStringCollection sumberkode = new AutoCompleteStringCollection();

            string quary = "select DISTINCT KodeProduct from Tbl_Products";
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(quary, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["KodeProduct"] != DBNull.Value)
                                {
                                    sumberkode.Add(reader["KodeProduct"].ToString());
                                }
                            }
                        }
                    }
                }


                txtkodeproduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtkodeproduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtkodeproduct.AutoCompleteCustomSource = sumberkode;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Gagal memuat daftar produk dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private DataTable dgkeranjag = new DataTable();

        private void setupkeranjang()
        {
            dgkeranjag.Columns.Add("kodeproduct", typeof(int));
            dgkeranjag.Columns.Add("namaproduct", typeof(string));
            dgkeranjag.Columns.Add("hargaproduct", typeof(decimal));
            dgkeranjag.Columns.Add("jumlahproduct", typeof(decimal));
            dgkeranjag.Columns.Add("hargasubtotal", typeof(decimal));
            dgkeranjag.Columns.Add("hargafinal", typeof(decimal));
            dgvkeranjang.DataSource = dgkeranjag;
            dgvkeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

       
        private void tambahkeranjang()
        {

            if (string.IsNullOrWhiteSpace(txtkodeproduct.Text))
            {
                MessageBox.Show("Silakan masukkan atau scan Kode Produk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkodeproduct.Focus();
                return;
            }

            if (!int.TryParse(txtkodeproduct.Text, out int kodeProduct))
            {
                MessageBox.Show("Kode Produk harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal qyt = numjumlah.Value;
            string namaProduct = "";
            decimal hargaProduct = 0;
            bool produkDitemukan = false;

            string quarycari = "select NamaProduct,HargaProduct from Tbl_Products where KodeProduct =@kode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(quarycari, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", kodeProduct);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                namaProduct = reader["NamaProduct"].ToString();
                                hargaProduct = Convert.ToDecimal(reader["HargaProduct"]);
                                produkDitemukan = true;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data produk dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!produkDitemukan)
            {

                MessageBox.Show($"Produk dengan Kode [{kodeProduct}] tidak ditemukan di database!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtkodeproduct.SelectAll();
                txtkodeproduct.Focus();
                return;
            }

            bool isExist = false;
            foreach (DataRow row in dgkeranjag.Rows)
            {
                if (Convert.ToInt32(row["kodeproduct"]) == kodeProduct)
                {
                    decimal qtylama = Convert.ToDecimal(row["jumlahproduct"]);
                    decimal qtybaru = qtylama + qyt;


                    row["jumlahproduct"] = qtybaru;
                    row["hargasubtotal"] = qtybaru * hargaProduct;

                    decimal subtotal = Convert.ToDecimal(row["hargasubtotal"]);
                    decimal persendiscount = 0;

                    if (subtotal > 100000)
                    {
                        persendiscount = 0.10m;

                    }
                    else if (subtotal > 200000)
                    {
                        persendiscount = 0.15m;
                    }
                    else if (subtotal > 50000)
                    {
                        persendiscount = 0.05m;

                    }
                    decimal nominaldiscount = subtotal * persendiscount;
                    row["hargafinal"] = subtotal - nominaldiscount;
                    isExist = true;
                    break;

                }
            }
            if (!isExist)
            {
                decimal subtotal = qyt * hargaProduct;
                decimal persendiscount = 0;

                if (subtotal > 100000)
                {
                    persendiscount = 0.10m;

                }
                else if (subtotal > 200000)
                {
                    persendiscount = 0.15m;
                }
                else if (subtotal > 50000)
                {
                    persendiscount = 0.05m;

                }
                decimal nominaldiscount = subtotal * persendiscount;
                decimal hargafinal = subtotal - nominaldiscount;
                isExist = true;


                dgkeranjag.Rows.Add(kodeProduct, namaProduct, hargaProduct, qyt, subtotal, hargafinal);
               
            }
            hitungrantotal();





            txtkodeproduct.Clear();
            numjumlah.Value = 1;
            txtkodeproduct.Focus();

        }
        private void hitungrantotal()
        {
            decimal subtotal = 0;
            decimal persendiscount = 0;
            foreach (DataRow row in dgkeranjag.Rows)
            {
                subtotal += Convert.ToDecimal(row["hargasubtotal"]);

            }
            if (subtotal > 100000)
            {
                persendiscount = 0.10m;

            }
            else if (subtotal > 200000)
            {
                persendiscount = 0.15m;
            }
            else if (subtotal > 50000)
            {
                persendiscount = 0.05m;

            }

            decimal nominaldiscount = subtotal * persendiscount;
            decimal totalbayarfinal = subtotal - nominaldiscount;

            if (decimal.TryParse(txtuangbayar.Text, out decimal uangbayar))
            {
                decimal uangkembalian = uangbayar - totalbayarfinal;

                if (uangkembalian >= 0)
                {
                    lblkembalian.Text = string.Format("Rp {0:N0", uangkembalian);
                    lblkembalian.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblkembalian.Text = string.Format("Rp {0:N0", Math.Abs(uangkembalian));
                    lblkembalian.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblkembalian.Text = "Rp 0";
            }

            txtsubtotal.Text = string.Format("Rp {0:N0}", subtotal);
            txtdiscount.Text = string.Format("{0}% (Rp {1:N0})", persendiscount * 100, nominaldiscount);
            lbltotal.Text = string.Format("Rp {0:N0}", totalbayarfinal);
        }
        private void btnmasuk_Click(object sender, EventArgs e)
        {
            tambahkeranjang();
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            if (dgkeranjag.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = 0;
            decimal persendiscount = 0;
            foreach (DataRow row in dgkeranjag.Rows)
            {
                subtotal += Convert.ToDecimal(row["hargasubtotal"]);

            }
            if (subtotal > 100000)
            {
                persendiscount = 0.10m;

            }
            else if (subtotal > 200000)
            {
                persendiscount = 0.15m;
            }
            else if (subtotal > 50000)
            {
                persendiscount = 0.05m;

            }

            decimal nominaldiscount = subtotal * persendiscount;
            decimal totalbayarfinal = subtotal - nominaldiscount;
            if (decimal.TryParse(txtuangbayar.Text, out decimal uangbayar))
            {
                if (uangbayar < totalbayarfinal)
                {
                    MessageBox.Show($"Uang bayar kurang! Total belanja: Rp {totalbayarfinal:N0}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtuangbayar.Focus();
                    return;
                }

                decimal uangkembalian = uangbayar - totalbayarfinal;
                int invoiceNumber = int.Parse(DateTime.Now.ToString("MMddHHmm"));
                int userid = 1;
                string namaKasir = "alvhin";

                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        foreach (DataRow row in dgkeranjag.Rows)
                        {
                            int kodecheck = Convert.ToInt32(row["kodeproduct"]);
                            decimal qtybeli = Convert.ToDecimal(row["jumlahproduct"]);

                            string quarycekstok = "select StokProduct from Tbl_Products where KodeProduct =@kode";
                            using (SqlCommand cmd = new SqlCommand(quarycekstok, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@kode", kodecheck);
                                object stokDb = cmd.ExecuteScalar();

                                if (stokDb != null && stokDb != DBNull.Value)
                                {
                                    decimal sisaStok = Convert.ToDecimal(stokDb);
                                    if (sisaStok < qtybeli)
                                    {
                                        trans.Rollback();
                                        MessageBox.Show($"Stok produk [{row["namaproduct"]}] tidak mencukupi!\nSisa stok di database: {sisaStok}",
                                                        "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }
                        }
                        string quaryinsert = "insert into Tbl_Transactions (InvoiceNumber,UserID,NamaKasir,KodeProduct,JumlahProduct,HargaProduct,TotalTransaction,Transactiondate)" + "values (@in,@ui,@nk,@kp,@jp,@hp,@tt,@td)";
                        string quaryupdate = "update Tbl_Products set StokProduct = StokProduct - @JumlahProduct where KodeProduct = @kode";

                        foreach (DataRow row in dgkeranjag.Rows)
                        {
                            int kodeProd = Convert.ToInt32(row["kodeproduct"]);
                            decimal qtyProd = Convert.ToDecimal(row["jumlahproduct"]);

                            using (SqlCommand insert = new SqlCommand(quaryinsert, conn, trans))
                            {
                                insert.Parameters.AddWithValue("@in", invoiceNumber);
                                insert.Parameters.AddWithValue("@ui", userid);
                                insert.Parameters.AddWithValue("@nk", namaKasir);
                                insert.Parameters.AddWithValue("@kp", kodeProd);
                                insert.Parameters.AddWithValue("@jp", qtyProd);
                                insert.Parameters.AddWithValue("@hp", Convert.ToDecimal(row["hargaproduct"]));
                                insert.Parameters.AddWithValue("@tt", totalbayarfinal);
                                insert.Parameters.AddWithValue("@td", DateTime.Now);

                                insert.ExecuteNonQuery();

                            }
                            using (SqlCommand updatestok = new SqlCommand(quaryupdate, conn, trans))
                            {
                                updatestok.Parameters.AddWithValue("@JumlahProduct", qtyProd);
                                updatestok.Parameters.AddWithValue("@kode", kodeProd);

                                updatestok.ExecuteNonQuery();
                            }


                        }

                        trans.Commit();
                        DialogResult result = MessageBox.Show($"Transaksi Berhasil Disimpan!\n\nKembalian: Rp {uangkembalian:N0}\n\nApakah ingin cetak Struk PDF?", "Transaksi Sukses", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                       );
                        if (result == DialogResult.Yes)
                        {
                            TampilkanStrukPembayaran(invoiceNumber, namaKasir, subtotal, nominaldiscount, totalbayarfinal, uangbayar, uangkembalian);
                        }
                    }
                    catch (Exception ex)
                    {

                        trans.Rollback();
                        MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void ResetForm()
        {

            if (dgkeranjag != null)
            {
                dgkeranjag.Rows.Clear();
            }


            if (txtsubtotal!= null) txtsubtotal.Text = "Rp 0";
            if (txtdiscount != null) txtdiscount.Text = "0% (Rp 0)";
            if (lbltotal != null) lbltotal.Text = "Rp 0";


            if (txtuangbayar!= null) txtuangbayar.Clear();
            if (lblkembalian!= null)
            {
                lblkembalian.Text = "Rp 0";
                lblkembalian.ForeColor = System.Drawing.Color.Black;
            }


            if (txtkodeproduct != null) txtkodeproduct.Clear();
            numjumlah.Value = 1;


            if (txtkodeproduct != null) txtkodeproduct.Focus();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e, int invoiceNumber, string namaKasir, decimal subtotal, decimal nominaldiscount, decimal totalbayarfinal, decimal uangbayar, decimal uangkembalian)
        {
            Graphics g = e.Graphics;
            Font fontJudul = new Font("Consolas", 14, FontStyle.Bold);
            Font fontSub = new Font("Consolas", 10, FontStyle.Bold);
            Font fontNormal = new Font("Consolas", 10, FontStyle.Regular);

            float x = 60;
            float y = 60;
            string garis = new string('-', 62);
            g.DrawString(" Supermarkert SuperMaju - STRUK PEMBAYARAN", fontJudul, Brushes.Black, x, y); y += 28;
            g.DrawString($"Tanggal Cetak  : {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString(garis, fontNormal, Brushes.Black, x, y); y += 20;

            g.DrawString($"Nomor invoice  : {invoiceNumber}", fontSub, Brushes.Black, x, y); y += 20;
            g.DrawString($"Nama Kasir     : {namaKasir}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString($"subtotal       :Rp {subtotal}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString($"nominaldiscount:RP {nominaldiscount}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString($"totalbayar     :Rp {totalbayarfinal}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString($"uang bayar     :RP {uangbayar}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString($"uang kembalian :Rp {uangkembalian}", fontNormal, Brushes.Black, x, y); y += 20;
            g.DrawString(garis, fontNormal, Brushes.Black, x, y); y += 20;

        }
        private void TampilkanStrukPembayaran(int invoiceNumber, string namaKasir, decimal subtotal, decimal nominaldiscount, decimal totalbayarfinal, decimal uangbayar, decimal uangkembalian)
        {


            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Struk_";
            printDoc.PrintPage += (s, ev) => PrintDoc_PrintPage(s, ev, invoiceNumber, namaKasir, subtotal, nominaldiscount, totalbayarfinal, uangbayar, uangkembalian);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 850,
                Height = 650,
                StartPosition = FormStartPosition.CenterScreen
            };
            previewDialog.ShowDialog();

            // 2. Setelah Print Preview ditutup, tawarkan simpan ke file PDF offline
            DialogResult tanyaPdf = MessageBox.Show(
                "Apakah Anda ingin menyimpan struk pembayaran ini ke file PDF?",
                "Simpan Struk PDF",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tanyaPdf == DialogResult.Yes)
            {
                SimpanStrukKePdfOffline(printDoc);
            }
        }
        private void SimpanStrukKePdfOffline(PrintDocument doc)
        {
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.PrinterSettings.PrintToFile = true;

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "Struk supermaerkut sukamaju" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                doc.PrinterSettings.PrintFileName = saveDialog.FileName;
                doc.Print();
                MessageBox.Show("Struk PDF berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtkodeproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void numjumlah_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasir_dasbord from = new kasir_dasbord();
            from.Show();
            this.Hide();
        }
    }
}
