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
    public partial class frmCashier : Form
    {
        //sql connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6QSD8CJ;Initial Catalog=stationary;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int ItemCode, orderNumber = 0;

        public frmCashier()
        {
            InitializeComponent();
            DisplayDataOrder();
            DisplayBill();
        }

        private void frmCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stationaryDataSet6.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.itemsSet1.Items);
            loadCategory();
            DisplayCategoryData();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text == "")
            {
                MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtqty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Convert.ToInt32(txtqty.Text) < 1)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Decimal Total = 0;
            if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {   //insert data to bill table
                cmd = new SqlCommand("insert into bill(date,itemCode,itemName,price,quantity,total) values(@date,@itemCode,@itemName,@price,@quantity,@total)", conn);

                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@itemCode", txtItemCode.Text);
                cmd.Parameters.AddWithValue("@itemName", txtItemName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtqty.Text);

                Total = ((decimal)(Convert.ToInt32(txtqty.Text) * Convert.ToDouble(txtPrice.Text)));
                txtTotalBill.Text = Total.ToString();
                cmd.Parameters.AddWithValue("@total", txtTotalBill.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayBill();

                //insert data to sale table
                cmd = new SqlCommand("insert into sale(date,itemCode,itemName,price,quantity,total) values(@date,@itemCode,@itemName,@price,@quantity,@total)", conn);
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                cmd.Parameters.AddWithValue("@itemCode", txtItemCode.Text);
                cmd.Parameters.AddWithValue("@itemName", txtItemName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtqty.Text);

                Decimal saleTotal = ((decimal)(Convert.ToInt32(txtqty.Text) * Convert.ToDouble(txtPrice.Text)));
                txtTotalBill.Text = saleTotal.ToString();
                cmd.Parameters.AddWithValue("@total", txtTotalBill.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                //update data in items table
                cmd = new SqlCommand("update Items set Quantity=(Quantity-@Quantity) where itemCode=@ItemCode", conn);

                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("@Quantity", txtqty.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                DisplayDataOrder();

                Clear();

                //calculate total and display in grand total text box
                //for (int i = 0; i <= dgvBill.Rows.Count - 1; i++)
                //{
                //    Sum += double.Parse(dgvBill.Rows[i].Cells[6].Value.ToString());
                //}
                //txtGrandTotal.Text = Sum.ToString();


            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //if select datagrid view row then auto fill below textboxes
        private void dgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemCode = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtItemCode.Text = ItemCode.ToString();
            txtItemName.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        // search items
        private void txtItemSearchForOrder_TextChanged(object sender, EventArgs e)
        {
            SqlCommand query2 = new SqlCommand("select itemCode,ItemName,SellingPrice,Quantity,Total,Category from Items Where ItemName like '%" + txtItemSearchForOrder.Text + "'", conn);
            SqlDataAdapter dc = new SqlDataAdapter();
            DataTable da = new DataTable();
            dc.SelectCommand = query2;
            DataTable dt = new DataTable();
            dc.Fill(dt);
            dgvOrder.DataSource = dt;
        }

        //when select category in comboo box then datagrid view filter according to selected category
        private void DisplayCategoryData()
        {

            SqlCommand query2 = new SqlCommand("select ItemCode,ItemName,SellingPrice,Quantity,Total,Category from Items Where Category like '%" + cmbCategory.Text + "'", conn);
            SqlDataAdapter dc = new SqlDataAdapter();
            DataTable da = new DataTable();
            dc.SelectCommand = query2;
            da.Clear();
            dc.Fill(da);
            dgvOrder.DataSource = da;

        }

        //select category from category table
        public void loadCategory()
        {

            String query1 = "select Category from category";
            SqlDataAdapter adapt = new SqlDataAdapter(query1, conn);
            conn.Open();
            DataSet ds = new DataSet();
            adapt.Fill(ds, "Category");
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "Category";
            cmbCategory.DataSource = ds.Tables["Category"];
            conn.Close();

            if (cmbCategory.Items.Count > 1)
            {
                cmbCategory.SelectedIndex = -1;
            }

        }

        //display data in bill table
        private void DisplayBill()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from bill", conn);
            adapt.Fill(dt);
            dgvBill.DataSource = dt;
            conn.Close();
        }

        public void Clear()
        {
            // txtCustomerName.Clear();
            txtItemName.Clear();
            txtItemSearchForOrder.Clear();
            txtPrice.Clear();
            txtqty.Clear();
            txtItemCode.Clear();
            txtTotalBill.Clear();
            ItemCode = 0;
            orderNumber = 0;
            dtpDate.Value = DateTime.Now;
        }

        private void dgvBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderNumber = Convert.ToInt32(dgvBill.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtpDate.Text = dgvBill.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItemCode.Text = dgvBill.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtItemName.Text = dgvBill.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dgvBill.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtqty.Text = dgvBill.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTotalBill.Text = dgvBill.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        


        //display data in items table...
        private void DisplayDataOrder()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select  itemCode, ItemName,ReceivedPrice,Quantity,Total,Category from Items", conn);
            adapt.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
        }


        int pos = 100;

        String itemName;
        int qty, itemCode;
        Double price, Sum;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 800, 900);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //delete selected data in bill table
        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            if (orderNumber != 0)
            {
                cmd = new SqlCommand("delete bill where orderNumber=@orderNumber", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                DialogResult result = MessageBox.Show("Are You sure you want to Delete", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayBill();
                    Clear();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                else
                {
                    conn.Close();
                }
            }
        }

        //delete all data in bill table
        private void btnClearBill_Click(object sender, EventArgs e)
        {
            if (orderNumber != 0)
            {
                cmd = new SqlCommand("delete from bill ", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                DialogResult result = MessageBox.Show("Are You sure you want to Clear All Data", "Clear All Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayBill();
                    Clear();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                else
                {
                    conn.Close();
                }
            }
        }

        private void btnLogoutCashier_Click(object sender, EventArgs e)
        {
            Form1 frmLogin = new Form1();
            DialogResult result = MessageBox.Show("Are You sure you want Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                frmLogin.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtTotalBill.Clear();
            txtCustomerName.Clear();
            txtGrandTotal.Clear();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCategoryData();
        }

        //print data in bill (Document Preview)
        Double total;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            e.Graphics.DrawString("Stationary Management System", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Red, new Point(280));

            e.Graphics.DrawString("Date : " + dtpDate.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(50, 33));
            e.Graphics.DrawString("Customer Name :" + txtCustomerName.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(50, 50));


            e.Graphics.DrawString("ID ", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Red, new Point(185, 80));
            e.Graphics.DrawString("PRODUCT ", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Red, new Point(220, 80));
            e.Graphics.DrawString("UNIT PRICE", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Red, new Point(320, 80));
            e.Graphics.DrawString("QUANTITY", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Red, new Point(430, 80));
            e.Graphics.DrawString("TOTAL", new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Red, new Point(550, 80));

            foreach (DataGridViewRow row in dgvBill.Rows)
            {

                itemCode = Convert.ToInt32(row.Cells["itemCode"].Value);
                itemName = Convert.ToString(row.Cells["itemName"].Value);
                price = Convert.ToDouble(row.Cells["price"].Value);
                qty = Convert.ToInt32(row.Cells["quantity"].Value);
                total = Convert.ToDouble(row.Cells["total"].Value);


                e.Graphics.DrawString("" + itemCode, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Blue, new Point(190, pos));
                e.Graphics.DrawString("" + itemName, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                e.Graphics.DrawString("" + price, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Blue, new Point(350, pos));
                e.Graphics.DrawString("" + qty, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Blue, new Point(450, pos));
                e.Graphics.DrawString("" + total, new Font("Times New Roman", 10, FontStyle.Bold), Brushes.Blue, new Point(550, pos));
                pos = pos + 20;
            }

            e.Graphics.DrawString("Grand Total : Rs " + txtGrandTotal.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("*******************Stationary Management System*******************", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Crimson, new Point(100, pos + 150));
            //dgvBill.Rows.Clear();
            dgvBill.Refresh();
            pos = 50;
            total = 0;


        }
    }
}
