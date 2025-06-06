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

namespace E2046353_SatationaryManagment
{
    public partial class Form1 : Form
    {
        int attempts = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isvalid()
        {
            if (txtUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid Username ", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid Password ", "Error");
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6QSD8CJ;Initial Catalog=stationary;Integrated Security=True"))
                {
                    string query = "SELECT * FROM login WHERE UserName = '" + txtUserName.Text.Trim() +
                        "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1 && cmbLogin.Text == "Admin")
                    {
                        mainForm mainForm = new mainForm();
                        this.Hide();
                        mainForm.Show();
                    }

                    else if (dta.Rows.Count == 1 && cmbLogin.Text == "Cashier")
                    {
                        frmCashier frmCashier = new frmCashier();
                        this.Hide();
                        frmCashier.Show();
                    }

                    else if (dta.Rows.Count == 1 && cmbLogin.Text == "StoreKeeper")
                    {
                        frmStore frmStore = new frmStore();
                        this.Hide();
                        frmStore.Show();
                    }


                    else

                    {
                        MessageBox.Show("User Name or Password is Incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        attempts = attempts + 1;
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                    }

                    if (attempts >= 3)
                    {
                        MessageBox.Show("User Terminated", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        attempts = attempts + 1;
                        txtPassword.ReadOnly = true;
                        txtUserName.ReadOnly = true;
                    }


                }

            }
            else
                MessageBox.Show("Enter valid Username or Password ", "Error");
        }
    }
}
