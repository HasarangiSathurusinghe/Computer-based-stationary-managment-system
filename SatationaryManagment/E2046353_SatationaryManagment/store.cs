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
    public partial class frmStore : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6QSD8CJ;Initial Catalog=stationary;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ItemCode = 0;

        public frmStore()
        {
            InitializeComponent();
        }

        //Items table - add Item
        private void btn_Ofc_Add_Item_Click(object sender, EventArgs e)
        {
            if (txt_Ofc_Item_Name.Text != "" && txt_Ofc_Item_Received_Price.Text != "" && txt_Ofc_Item_SellingPrice.Text != "" && txt_Ofc_Item_Qty.Text != "")
            {
                cmd = new SqlCommand("insert into Items(ItemName,ReceivedPrice,SellingPrice,Quantity,Total,Profit,Category) " +
                    "values(@ItemName,@ReceivedPrice,@SellingPrice,@Quantity,@Total,@Profit,@Category)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ItemName", txt_Ofc_Item_Name.Text);
                cmd.Parameters.AddWithValue("@ReceivedPrice", txt_Ofc_Item_Received_Price.Text);
                cmd.Parameters.AddWithValue("@SellingPrice", txt_Ofc_Item_SellingPrice.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Ofc_Item_Qty.Text);

                double num1, num2, num3, dif, total, profit = 0;

                num1 = Convert.ToDouble(txt_Ofc_Item_Qty.Text);
                num2 = Convert.ToDouble(txt_Ofc_Item_Received_Price.Text);
                num3 = Convert.ToDouble(txt_Ofc_Item_SellingPrice.Text);
                total = num1 * num2;
                dif = num1 * num3;
                profit = dif - total;

                txt_Total.Text = total.ToString();
                txt_Profit.Text = profit.ToString();

                cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
                cmd.Parameters.AddWithValue("@Profit", txt_Profit.Text);
                cmd.Parameters.AddWithValue("@Category", cmb_Category.Text);

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

        // load data in items table
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Items", conn);
            adapt.Fill(dt);
            dgv_Office_Stationary.DataSource = dt;
            conn.Close();
        }
        // 
        private void ClearData()
        {
            txt_Ofc_Item_Received_Price.Text = "";
            txt_Ofc_Item_Name.Text = "";
            txt_Ofc_Item_Qty.Text = "";
            txt_Ofc_Item_SellingPrice.Text = "";
            txt_Profit.Text = "";
            txt_Total.Text = "";
            ItemCode = 0;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'stationaryDataSet2.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.stationaryDataSet21.sale);
            // TODO: This line of code loads data into the 'itemsSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.itemsSet1.Items);
            // TODO: This line of code loads data into the 'stationaryDataSet11.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.stationaryDataSet11.category);
        }
        // tab items
        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sale Where itemName In( Select itemName from sale Where itemCode=@itemCode Group By itemName Having Count(itemName) >1) and itemCode=@itemCode Order by itemName ", conn);
            cmd.Parameters.AddWithValue("itemCode", txtFilter.Text);
            SqlDataAdapter Sda = new SqlDataAdapter();
            Sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            Sda.Fill(dt);
            dgvReports.DataSource = dt;
            conn.Close();
        }

        // item tab seacrh
        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Items WHERE ItemName = '" + txtItemSearch.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            dgv_Office_Stationary.DataSource = dta;
            conn.Close();
        }

        // tab items
        private void btn_Update_Office_Click(object sender, EventArgs e)
        {
            if (txt_Ofc_Item_Name.Text != "")
            {
                cmd = new SqlCommand("update Items set ItemName=@ItemName,ReceivedPrice=@ReceivedPrice,Quantity=@Quantity,SellingPrice=@SellingPrice,Total=@Total,Profit=@Profit,Category=@Category where ItemCode=@ItemCode", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("@ItemName", txt_Ofc_Item_Name.Text);
                cmd.Parameters.AddWithValue("@ReceivedPrice", txt_Ofc_Item_Received_Price.Text);
                cmd.Parameters.AddWithValue("@SellingPrice", txt_Ofc_Item_SellingPrice.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Ofc_Item_Qty.Text);

                double num1, num2, num3, dif, total, profit = 0;

                num1 = Convert.ToDouble(txt_Ofc_Item_Qty.Text);
                num2 = Convert.ToDouble(txt_Ofc_Item_Received_Price.Text);
                num3 = Convert.ToDouble(txt_Ofc_Item_SellingPrice.Text);
                total = num1 * num2;
                dif = num1 * num3;
                profit = dif - total;

                txt_Total.Text = total.ToString();
                txt_Profit.Text = profit.ToString();

                cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
                cmd.Parameters.AddWithValue("@Profit", txt_Profit.Text);
                cmd.Parameters.AddWithValue("@Category", cmb_Category.Text);

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

        private void btn_Del_Office_Click(object sender, EventArgs e)
        {
            if (ItemCode != 0)
            {
                cmd = new SqlCommand("delete Items where ItemCode=@ItemCode", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
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

        Double total, TotalProfit;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Items", conn);
            adapt.Fill(dt);
            dgv_Office_Stationary.DataSource = dt;
            conn.Close();
        }

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

        // tab reports
        //Between two days filter

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Sda = new SqlDataAdapter("Select * From sale Where Date Between '" + dtpFrom.Value.ToString() + "' And '" + dtpTo.Value.ToString() + "'", conn);
            DataTable Sd = new DataTable();
            Sda.Fill(Sd);
            dgvReports.DataSource = Sd;
        }

        // most deamanding item
        private void btnMostDemandItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sale Where itemName In( Select itemName from sale Group By itemName Having (Count(*) >10)) ", conn);
            SqlDataAdapter Sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            Sda.SelectCommand = cmd;
            dt.Clear();
            Sda.Fill(dt);
            dgvReports.DataSource = dt;
            conn.Close();
        }

        // least demand item
        private void btnLeastDemandItem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sale Where itemName In( Select itemName from sale Group By itemName Having (Count(*) < 10)) ", conn);
            SqlDataAdapter Sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            Sda.SelectCommand = cmd;
            dt.Clear();
            Sda.Fill(dt);
            dgvReports.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from sale Where itemName In( Select itemName from sale Where itemCode=@itemCode Group By itemName Having Count(itemName) >1) and itemCode=@itemCode Order by itemName ", conn);
            cmd.Parameters.AddWithValue("itemCode", txtFilter.Text);
            SqlDataAdapter Sda = new SqlDataAdapter();
            Sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            Sda.Fill(dt);
            dgvReports.DataSource = dt;
            conn.Close();
        }

        private void btnDisplayChart_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "itemName";
            chart1.Series[0].YValueMembers = "quantity";
            chart1.DataSource = itemsSet1.Items;
            chart1.DataBind();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_Ofc_Item_Received_Price.Text = "";
            txt_Ofc_Item_Name.Text = "";
            txt_Ofc_Item_Qty.Text = "";
            txt_Ofc_Item_SellingPrice.Text = "";
            txt_Profit.Text = "";
            txt_Total.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter1.Fill(this.stationaryDataSet11.category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // tab item calculate
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgv_Office_Stationary.Rows.Count - 1; i++)
            {
                total += double.Parse(dgv_Office_Stationary.Rows[i].Cells[5].Value.ToString());
                TotalProfit += double.Parse(dgv_Office_Stationary.Rows[i].Cells[6].Value.ToString());
            }
            txtTotalCost.Text = total.ToString();
            txtTotalProfit.Text = TotalProfit.ToString();
        }
    }
}
