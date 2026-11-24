using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True");

        public bool emptyFields()
        {

            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("isi terlebih dahulu password dan username ", "information message ", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectacount = "select count (*) from Tbl_Users where Username = @usern And Password = @pass and Status =@status ";
                        using (SqlCommand cmd = new SqlCommand(selectacount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "aktif");
                            int rowcount = (int)cmd.ExecuteScalar();
                            if (rowcount > 0)
                            {
                                string selectrole = "select Role from Tbl_Users where Username = @usern And Password = @pass";
                                using (SqlCommand role = new SqlCommand(selectrole, connect))
                                {
                                    role.Parameters.AddWithValue("@usern", txtusername.Text.Trim());
                                    role.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());
                                    string userrole = role.ExecuteScalar() as string;
                                    MessageBox.Show("Login Berhasil", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (userrole == "Admin")
                                    {

                                    }
                                    else if (userrole == "Kasir")
                                    {
                                        kasir_dasbord kasirDasbord = new kasir_dasbord();
                                        kasirDasbord.Show();
                                        this.Hide();
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("username/password salah atau tidak ada persetujuan admin", "Error mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("connetion failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    finally { connect.Close(); }
                }
            }
        }

      
    }
}
