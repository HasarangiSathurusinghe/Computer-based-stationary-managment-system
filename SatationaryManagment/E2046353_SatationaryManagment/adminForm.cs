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
    public partial class mainForm : Form
    {
        //connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6QSD8CJ;Initial Catalog=stationary;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int UserId, regNo, Category_Id = 0;

        public mainForm()
        {
            InitializeComponent();
            DisplayData();
            DisplayData2();
            DisplayDataCategory();
        }

        //create user ( save user login details)
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                cmd = new SqlCommand("insert into login(UserName,Password,role) values(@userName,@password,@role)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@userName", cmbUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //create user tab ( fill datagrid view data)
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from login", conn);
            adapt.Fill(dt);
            dgvLogin.DataSource = dt;
            conn.Close();
        }

        //create user tab ( autofill textbox when row select in login datagrid view)
        private void dgvLogin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserId = Convert.ToInt32(dgvLogin.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbUserName.Text = dgvLogin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvLogin.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbRole.Text = dgvLogin.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //create user tab
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            DialogResult result = MessageBox.Show("Are You sure you want Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                frmLogin.Show();
            }
        }

        //create user tab_update user
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                cmd = new SqlCommand("update login set UserName=@userName,Password=@password,role=@role where UserId=@UserId", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@userName", cmbUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //create user tab _ delete user
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserId != 0)
            {
                cmd = new SqlCommand("delete login where UserId=@UserId", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@UserId", UserId);
                DialogResult result = MessageBox.Show("Are You sure you want to Delete", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                else
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        //create user ( clear user login details)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        // search with reg no in staff registration
        private void txtSeachStaff_TextChanged(object sender, EventArgs e)
        {
            SqlCommand query2 = new SqlCommand("select regNo,name,address,dateOfBirth,designation,joinedDate,phoneNumber,userName from staff Where regNo like '%" + txtSeachStaff.Text + "'", conn);
            SqlDataAdapter dc = new SqlDataAdapter();
            DataTable da = new DataTable();
            dc.SelectCommand = query2;
            DataTable dt = new DataTable();
            dc.Fill(dt);
            dgvStaff.DataSource = dt;
        }

        private void DisplayData2()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from staff", conn);
            adapt.Fill(dt);
            dgvStaff.DataSource = dt;
            conn.Close();
        }
        // add staff member
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.TextLength == 10)
            {
                txtPhoneNumber.ForeColor = Color.Green;
                cmd = new SqlCommand("insert into staff(name,address,dateOfBirth,designation,joindate,phoneNumber,userName) values(@name,@address,@dateOfBirth,@designation,@joindate,@phoneNumber,@userName)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", txtStaffName.Text);
                cmd.Parameters.AddWithValue("@address", txtStaffAddress.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePickerDob.Value);
                cmd.Parameters.AddWithValue("@designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@joindate", dateTimePickerJoinedDate.Value);
                cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);


                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData2();
                ClearData();

            }

            else
            {
                txtPhoneNumber.ForeColor = Color.Red;
                MessageBox.Show("Please Enter phone number correctly");
                txtPhoneNumber.Text = "";

            }
        }

       // (autofill textbox when row select in login datagrid view)
        private void dgvStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (int.TryParse(dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString(), out int regNoValue))
            {
                regNo = regNoValue;
                
                txtStaffName.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtStaffAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePickerDob.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDesignation.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateTimePickerJoinedDate.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPhoneNumber.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtUserName.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else
            {
                
            }
        }

        //staff registration tab ( update data in database)
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text != "" && txtStaffAddress.Text != "")
            {
                cmd = new SqlCommand("update staff set name=@name,address=@address,dateOfBirth=@dateOfBirth,designation=@designation,joinedDate=@joinedDate,phoneNumber=@phoneNumber,userName=@userName where regNo=@regNo", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@regNo", regNo);
                cmd.Parameters.AddWithValue("@name", txtStaffName.Text);
                cmd.Parameters.AddWithValue("@address", txtStaffAddress.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePickerDob.Value);
                cmd.Parameters.AddWithValue("@designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@joinedDate", dateTimePickerJoinedDate.Value);
                cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@userName", txtUserName.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                conn.Close();
                DisplayData2();
                ClearData();

            }

            else

            {
                MessageBox.Show("Please provide details correctly");
            }
        }

        //staff registration tab ( delete data in database)
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (regNo != 0)
            {
                cmd = new SqlCommand("delete staff where regNo=@regNo", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@regNo", regNo);
                DialogResult result = MessageBox.Show("Are You sure you want to Delete", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayData2();
                    ClearData();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                else
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        //staff registration tab ( clear data in textbox)
        private void btnClearStaff_Click(object sender, EventArgs e)
        {
            txtStaffName.Text = "";
            txtStaffAddress.Text = "";
            txtDesignation.Text = "";
            txtPhoneNumber.Text = "";
            txtUserName.Text = "";
        }

        private void btnExitStaff_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            DialogResult result = MessageBox.Show("Are You sure you want Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                frmLogin.Show();
            }
        }

        private void DisplayDataCategory()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from category", conn);
            adapt.Fill(dt);
            dgv_Category.DataSource = dt;
            conn.Close();
        }

        //Category tab ( add data to database)
        private void btn_Save_Category_Click(object sender, EventArgs e)
        {
            if (txt_Categori_Input.Text != "")
            {
                cmd = new SqlCommand("insert into category(Category) values(@category)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@category", txt_Categori_Input.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayDataCategory();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //clear text in text box
        private void btn_Clear_Category_Click(object sender, EventArgs e)
        {
            txt_Categori_Input.Text = "";
        }
        // ( delete data in database)
        private void btn_Delete_Category_Click(object sender, EventArgs e)
        {
            if (Category_Id != 0)
            {
                cmd = new SqlCommand("delete category where Category_Id=@Category_Id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
                DialogResult result = MessageBox.Show("Are You sure you want to Delete", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayDataCategory();
                    ClearData();
                    MessageBox.Show("Data Deleted Successfully!");
                }

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        //Category tab ( update data in database)
        private void btn_Update_Category_Click(object sender, EventArgs e)
        {
            if (txt_Categori_Input.Text != "")
            {
                cmd = new SqlCommand("update category set Category=@category where Category_Id=@Category_Id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Category_Id", Category_Id);
                cmd.Parameters.AddWithValue("@category", txt_Categori_Input.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayDataCategory();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_Exit_Category_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            DialogResult result = MessageBox.Show("Are You sure you want Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                frmLogin.Show();
            }
        }

        private void dgv_Category_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Category_Id = Convert.ToInt32(dgv_Category.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Categori_Input.Text = dgv_Category.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stationaryDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.stationaryDataSet.staff);
            loadCategory();
        }


        //Clear Data (Staff registration) 
        private void ClearData()
        {

            txtPassword.Text = "";
            cmbRole.Text = "";
            txtStaffName.Text = "";
            txtStaffAddress.Text = "";
            txtDesignation.Text = "";
            txtUserName.Text = "";
            txtPhoneNumber.Text = "";
            Category_Id = 0;
            UserId = 0;
            regNo = 0;
        }

        public void loadCategory() // loading staff details
        {

            String query1 = "select UserName from staff";
            SqlDataAdapter adapt = new SqlDataAdapter(query1, conn);
            conn.Open();
            DataSet ds = new DataSet();
            adapt.Fill(ds, "UserName");
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "UserName";
            cmbUserName.DataSource = ds.Tables["UserName"];
            conn.Close();

            if (cmbUserName.Items.Count > 1)
            {
                cmbUserName.SelectedIndex = -1;
            }
        }
    }
}
