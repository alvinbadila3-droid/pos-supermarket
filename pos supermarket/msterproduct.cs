using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace pos_supermarket
{
    public partial class msterproduct : Form
    {
        public msterproduct()
        {
            InitializeComponent();
        }
        private int selectedporductid = 0;
        private void tbl_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_POS_SupermarketDataSet);

        }
        private string connect = "Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True";


        private void msterproduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Products' table. You can move, or remove it, as needed.
            this.tbl_ProductsTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Products);
            loaddata();
            loadcombobox();

        }
        private void loadcombobox()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string quary = "select NamaCategory,CategoryID from Tbl_Categories";
                SqlDataAdapter da = new SqlDataAdapter(quary, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbkategori.DisplayMember = "NamaCategory";
                cmbkategori.ValueMember = "CategoryID";
                cmbkategori.DataSource = dt;

            }
        }
        private void loaddata()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string quary = "select ProductID,KodeProduct as [Kode product],NamaProduct as [Nama],categoryID as [kategoriID],KategoriProduct as [kategoriproduct],StokProduct as [stok],HargaProduct as [harga] from Tbl_Products ";
                SqlDataAdapter da = new SqlDataAdapter(quary, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvproduct.DataSource = dt;
                if (dgvproduct.Columns["ProductID"] != null) dgvproduct.Columns["ProductID"].Visible = false;

            }

        }
        private void resetform()
        {
            txtkodeproduct.Clear();
            numstok.Value = 0;
            txtnamaproduk.Clear();
            numharga.Value = 0;
            selectedporductid = 0;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproduct.Rows[e.RowIndex];
                selectedporductid = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtkodeproduct.Text = row.Cells["Kode product"].Value.ToString();
                txtnamaproduk.Text = row.Cells["Nama"].Value.ToString();
                numstok.Value = Convert.ToDecimal(row.Cells["stok"].Value);
                numharga.Value = Convert.ToDecimal(row.Cells["harga"].Value);
                cmbkategori.SelectedValue = Convert.ToInt32(row.Cells["kategoriID"].Value);
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkodeproduct.Text) || string.IsNullOrWhiteSpace(txtnamaproduk.Text) || numstok.Value <= 0 || numharga.Value <= 0 || cmbkategori.SelectedValue == null)
            {
                MessageBox.Show("Lengkapi seluruh data ", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            string namakategoriproduct = cmbkategori.Text.Trim().ToLower();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                try
                {
                    string quary = "insert into Tbl_Products ( KodeProduct,NamaProduct,categoryID,KategoriProduct,StokProduct,HargaProduct) " + "values (@kode,@namaproduct,@categoriid,@namakategori,@stok,@harga)";
                    using (SqlCommand cmd = new SqlCommand(quary, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", txtkodeproduct.Text.Trim());
                        cmd.Parameters.AddWithValue("@namaproduct", txtnamaproduk.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoriid", cmbkategori.SelectedValue);
                        cmd.Parameters.AddWithValue("@namakategori", namakategoriproduct);
                        cmd.Parameters.AddWithValue("@stok", numstok.Value);
                        cmd.Parameters.AddWithValue("@harga", numharga.Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("data nerhasil di masukan ke dalam data base", "informasin massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    resetform();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Gagal memuat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedporductid == 0)
            {
                MessageBox.Show("pilih terlebih dahulu bagian yang mau kamu ubah", "warning message", MessageBoxButtons.OK);

            }
            string namakategoriproduct = cmbkategori.Text.Trim().ToLower();
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string quary = "update Tbl_Products set  KodeProduct =@kode ,NamaProduct =@namaproduct ,categoryID =@categoriid,KategoriProduct =@namakategori,StokProduct =@stok,HargaProduct =@harga where ProductID =@id";
                    using (SqlCommand cmd = new SqlCommand(quary, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", txtkodeproduct.Text.Trim());
                        cmd.Parameters.AddWithValue("@namaproduct", txtnamaproduk.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoriid", cmbkategori.SelectedValue);
                        cmd.Parameters.AddWithValue("@namakategori", namakategoriproduct);
                        cmd.Parameters.AddWithValue("@stok", numstok.Value);
                        cmd.Parameters.AddWithValue("@harga", numharga.Value);
                        cmd.Parameters.AddWithValue("@id", selectedporductid);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("data paket berhasil di perbarui", "infomation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    resetform();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("gagal memuat : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (selectedporductid == 0)
            {
                MessageBox.Show("pilih terlebih dahulu bagian yang mau kamu ubah", "warning message", MessageBoxButtons.OK);

            }
            if (MessageBox.Show("Yakin ingin menghapus data Kurir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("delete from Tbl_Products where ProductID =@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedporductid);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("data paket berhasio di hapus", "infomation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    resetform();
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasir_dasbord from = new kasir_dasbord();
            from.Show();
            this.Hide();
        }
    }
}
