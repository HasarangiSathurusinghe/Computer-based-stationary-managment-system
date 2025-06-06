
namespace E2046353_SatationaryManagment
{
    partial class frmStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlStationary = new System.Windows.Forms.TabControl();
            this.tabPageOffice = new System.Windows.Forms.TabPage();
            this.dgv_Office_Stationary = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalProfit = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Profit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Ofc_Item_SellingPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Del_Office = new System.Windows.Forms.Button();
            this.btn_Update_Office = new System.Windows.Forms.Button();
            this.txt_Ofc_Item_Qty = new System.Windows.Forms.TextBox();
            this.txt_Ofc_Item_Received_Price = new System.Windows.Forms.TextBox();
            this.txt_Ofc_Item_Name = new System.Windows.Forms.TextBox();
            this.btn_Ofc_Add_Item = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisplayChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeastDemandItem = new System.Windows.Forms.Button();
            this.btnMostDemandItem = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.itemsSet1 = new E2046353_SatationaryManagment.ItemsSet();
            this.itemsTableAdapter1 = new E2046353_SatationaryManagment.ItemsSetTableAdapters.ItemsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stationaryDataSet21 = new E2046353_SatationaryManagment.stationaryDataSet2();
            this.saleTableAdapter = new E2046353_SatationaryManagment.stationaryDataSet2TableAdapters.saleTableAdapter();
            this.stationaryDataSet11 = new E2046353_SatationaryManagment.stationaryDataSet1();
            this.categoryTableAdapter1 = new E2046353_SatationaryManagment.stationaryDataSet1TableAdapters.categoryTableAdapter();
            this.tabControlStationary.SuspendLayout();
            this.tabPageOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Office_Stationary)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStationary
            // 
            this.tabControlStationary.Controls.Add(this.tabPageOffice);
            this.tabControlStationary.Controls.Add(this.tabPageReports);
            this.tabControlStationary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStationary.Location = new System.Drawing.Point(1, 4);
            this.tabControlStationary.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlStationary.Name = "tabControlStationary";
            this.tabControlStationary.SelectedIndex = 0;
            this.tabControlStationary.Size = new System.Drawing.Size(1718, 592);
            this.tabControlStationary.TabIndex = 1;
            // 
            // tabPageOffice
            // 
            this.tabPageOffice.BackColor = System.Drawing.Color.White;
            this.tabPageOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageOffice.Controls.Add(this.dgv_Office_Stationary);
            this.tabPageOffice.Controls.Add(this.groupBox2);
            this.tabPageOffice.Controls.Add(this.btnRefresh);
            this.tabPageOffice.Controls.Add(this.txtItemSearch);
            this.tabPageOffice.Controls.Add(this.btnItemSearch);
            this.tabPageOffice.Controls.Add(this.btnExit);
            this.tabPageOffice.Controls.Add(this.groupBox1);
            this.tabPageOffice.Controls.Add(this.panel1);
            this.tabPageOffice.ImageIndex = 1;
            this.tabPageOffice.Location = new System.Drawing.Point(4, 25);
            this.tabPageOffice.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOffice.Name = "tabPageOffice";
            this.tabPageOffice.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOffice.Size = new System.Drawing.Size(1710, 563);
            this.tabPageOffice.TabIndex = 0;
            this.tabPageOffice.Text = "Item";
            // 
            // dgv_Office_Stationary
            // 
            this.dgv_Office_Stationary.AllowUserToAddRows = false;
            this.dgv_Office_Stationary.AllowUserToDeleteRows = false;
            this.dgv_Office_Stationary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Office_Stationary.Location = new System.Drawing.Point(436, 55);
            this.dgv_Office_Stationary.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Office_Stationary.Name = "dgv_Office_Stationary";
            this.dgv_Office_Stationary.ReadOnly = true;
            this.dgv_Office_Stationary.RowHeadersWidth = 51;
            this.dgv_Office_Stationary.Size = new System.Drawing.Size(1120, 428);
            this.dgv_Office_Stationary.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTotalProfit);
            this.groupBox2.Controls.Add(this.txtTotalCost);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Location = new System.Drawing.Point(436, 482);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(601, 70);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(436, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Total Profit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(209, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total Cost";
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.Location = new System.Drawing.Point(392, 38);
            this.txtTotalProfit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.ReadOnly = true;
            this.txtTotalProfit.Size = new System.Drawing.Size(188, 22);
            this.txtTotalProfit.TabIndex = 40;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(171, 38);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(188, 22);
            this.txtTotalCost.TabIndex = 39;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 14);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 52);
            this.btnCalculate.TabIndex = 39;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(719, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 49);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(577, 4);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemSearch.Multiline = true;
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(132, 48);
            this.txtItemSearch.TabIndex = 15;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSearch.Image")));
            this.btnItemSearch.Location = new System.Drawing.Point(436, 4);
            this.btnItemSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(133, 49);
            this.btnItemSearch.TabIndex = 14;
            this.btnItemSearch.Text = "Search";
            this.btnItemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1400, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 52);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Logout";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmb_Category);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txt_Profit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_Total);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_Ofc_Item_SellingPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_Del_Office);
            this.groupBox1.Controls.Add(this.btn_Update_Office);
            this.groupBox1.Controls.Add(this.txt_Ofc_Item_Qty);
            this.groupBox1.Controls.Add(this.txt_Ofc_Item_Received_Price);
            this.groupBox1.Controls.Add(this.txt_Ofc_Item_Name);
            this.groupBox1.Controls.Add(this.btn_Ofc_Add_Item);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 481);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add, Update or Delete Item";
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(280, 395);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 52);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource2, "Category", true));
            this.cmb_Category.DisplayMember = "Category";
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(155, 193);
            this.cmb_Category.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(257, 24);
            this.cmb_Category.TabIndex = 38;
            this.cmb_Category.ValueMember = "Category";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "category";
            this.bindingSource2.DataSource = this.stationaryDataSet11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(15, 197);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 16);
            this.label23.TabIndex = 37;
            this.label23.Text = "Category";
            // 
            // txt_Profit
            // 
            this.txt_Profit.Location = new System.Drawing.Point(224, 354);
            this.txt_Profit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Profit.Name = "txt_Profit";
            this.txt_Profit.ReadOnly = true;
            this.txt_Profit.Size = new System.Drawing.Size(188, 22);
            this.txt_Profit.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Profit";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(224, 320);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(188, 22);
            this.txt_Total.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 320);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Total";
            // 
            // txt_Ofc_Item_SellingPrice
            // 
            this.txt_Ofc_Item_SellingPrice.Location = new System.Drawing.Point(155, 118);
            this.txt_Ofc_Item_SellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ofc_Item_SellingPrice.Name = "txt_Ofc_Item_SellingPrice";
            this.txt_Ofc_Item_SellingPrice.Size = new System.Drawing.Size(257, 22);
            this.txt_Ofc_Item_SellingPrice.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Selling Price";
            // 
            // btn_Del_Office
            // 
            this.btn_Del_Office.BackColor = System.Drawing.Color.Red;
            this.btn_Del_Office.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del_Office.Image")));
            this.btn_Del_Office.Location = new System.Drawing.Point(284, 244);
            this.btn_Del_Office.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del_Office.Name = "btn_Del_Office";
            this.btn_Del_Office.Size = new System.Drawing.Size(133, 52);
            this.btn_Del_Office.TabIndex = 11;
            this.btn_Del_Office.Text = "Delete ";
            this.btn_Del_Office.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del_Office.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Del_Office.UseVisualStyleBackColor = false;
            this.btn_Del_Office.Click += new System.EventHandler(this.btn_Del_Office_Click);
            // 
            // btn_Update_Office
            // 
            this.btn_Update_Office.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Update_Office.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_Office.Image")));
            this.btn_Update_Office.Location = new System.Drawing.Point(143, 244);
            this.btn_Update_Office.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update_Office.Name = "btn_Update_Office";
            this.btn_Update_Office.Size = new System.Drawing.Size(133, 52);
            this.btn_Update_Office.TabIndex = 9;
            this.btn_Update_Office.Text = "Update";
            this.btn_Update_Office.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update_Office.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update_Office.UseVisualStyleBackColor = false;
            this.btn_Update_Office.Click += new System.EventHandler(this.btn_Update_Office_Click);
            // 
            // txt_Ofc_Item_Qty
            // 
            this.txt_Ofc_Item_Qty.Location = new System.Drawing.Point(155, 156);
            this.txt_Ofc_Item_Qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ofc_Item_Qty.Name = "txt_Ofc_Item_Qty";
            this.txt_Ofc_Item_Qty.Size = new System.Drawing.Size(257, 22);
            this.txt_Ofc_Item_Qty.TabIndex = 8;
            // 
            // txt_Ofc_Item_Received_Price
            // 
            this.txt_Ofc_Item_Received_Price.Location = new System.Drawing.Point(155, 84);
            this.txt_Ofc_Item_Received_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ofc_Item_Received_Price.Name = "txt_Ofc_Item_Received_Price";
            this.txt_Ofc_Item_Received_Price.Size = new System.Drawing.Size(257, 22);
            this.txt_Ofc_Item_Received_Price.TabIndex = 7;
            // 
            // txt_Ofc_Item_Name
            // 
            this.txt_Ofc_Item_Name.Location = new System.Drawing.Point(155, 48);
            this.txt_Ofc_Item_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ofc_Item_Name.Name = "txt_Ofc_Item_Name";
            this.txt_Ofc_Item_Name.Size = new System.Drawing.Size(257, 22);
            this.txt_Ofc_Item_Name.TabIndex = 6;
            // 
            // btn_Ofc_Add_Item
            // 
            this.btn_Ofc_Add_Item.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Ofc_Add_Item.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ofc_Add_Item.Image")));
            this.btn_Ofc_Add_Item.Location = new System.Drawing.Point(1, 244);
            this.btn_Ofc_Add_Item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ofc_Add_Item.Name = "btn_Ofc_Add_Item";
            this.btn_Ofc_Add_Item.Size = new System.Drawing.Size(133, 52);
            this.btn_Ofc_Add_Item.TabIndex = 4;
            this.btn_Ofc_Add_Item.Text = "Save";
            this.btn_Ofc_Add_Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ofc_Add_Item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ofc_Add_Item.UseVisualStyleBackColor = false;
            this.btn_Ofc_Add_Item.Click += new System.EventHandler(this.btn_Ofc_Add_Item_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Received Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 437);
            this.panel1.TabIndex = 16;
            // 
            // tabPageReports
            // 
            this.tabPageReports.BackColor = System.Drawing.Color.White;
            this.tabPageReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageReports.Controls.Add(this.chart1);
            this.tabPageReports.Controls.Add(this.label5);
            this.tabPageReports.Controls.Add(this.btnDisplayChart);
            this.tabPageReports.Controls.Add(this.label1);
            this.tabPageReports.Controls.Add(this.btnLeastDemandItem);
            this.tabPageReports.Controls.Add(this.btnMostDemandItem);
            this.tabPageReports.Controls.Add(this.txtFilter);
            this.tabPageReports.Controls.Add(this.btnSearch);
            this.tabPageReports.Controls.Add(this.dgvReports);
            this.tabPageReports.Controls.Add(this.btnView);
            this.tabPageReports.Controls.Add(this.dtpTo);
            this.tabPageReports.Controls.Add(this.dtpFrom);
            this.tabPageReports.Controls.Add(this.label28);
            this.tabPageReports.Controls.Add(this.label27);
            this.tabPageReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageReports.ImageIndex = 0;
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageReports.Size = new System.Drawing.Size(1710, 563);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Reports";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1081, 144);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(331, 325);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1179, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "In Stock Items";
            // 
            // btnDisplayChart
            // 
            this.btnDisplayChart.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayChart.Image")));
            this.btnDisplayChart.Location = new System.Drawing.Point(1208, 41);
            this.btnDisplayChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayChart.Name = "btnDisplayChart";
            this.btnDisplayChart.Size = new System.Drawing.Size(160, 52);
            this.btnDisplayChart.TabIndex = 13;
            this.btnDisplayChart.Text = "Display Chart";
            this.btnDisplayChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayChart.UseVisualStyleBackColor = true;
            this.btnDisplayChart.Click += new System.EventHandler(this.btnDisplayChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(345, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "(Input Item ID)";
            // 
            // btnLeastDemandItem
            // 
            this.btnLeastDemandItem.Location = new System.Drawing.Point(864, 76);
            this.btnLeastDemandItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeastDemandItem.Name = "btnLeastDemandItem";
            this.btnLeastDemandItem.Size = new System.Drawing.Size(133, 52);
            this.btnLeastDemandItem.TabIndex = 10;
            this.btnLeastDemandItem.Text = "Least Demand Item";
            this.btnLeastDemandItem.UseVisualStyleBackColor = true;
            this.btnLeastDemandItem.Click += new System.EventHandler(this.btnLeastDemandItem_Click);
            // 
            // btnMostDemandItem
            // 
            this.btnMostDemandItem.Location = new System.Drawing.Point(723, 76);
            this.btnMostDemandItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostDemandItem.Name = "btnMostDemandItem";
            this.btnMostDemandItem.Size = new System.Drawing.Size(133, 52);
            this.btnMostDemandItem.TabIndex = 9;
            this.btnMostDemandItem.Text = "Most Demand Item";
            this.btnMostDemandItem.UseVisualStyleBackColor = true;
            this.btnMostDemandItem.Click += new System.EventHandler(this.btnMostDemandItem_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(152, 79);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(184, 47);
            this.txtFilter.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(11, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 52);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(4, 144);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.Size = new System.Drawing.Size(993, 404);
            this.dgvReports.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.Location = new System.Drawing.Point(835, 7);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(163, 52);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Date Filter";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(459, 21);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(333, 22);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpFrom.Location = new System.Drawing.Point(72, 21);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(329, 22);
            this.dtpFrom.TabIndex = 2;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(415, 25);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 16);
            this.label28.TabIndex = 1;
            this.label28.Text = "To ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(5, 25);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "From ";
            // 
            // itemsSet1
            // 
            this.itemsSet1.DataSetName = "ItemsSet";
            this.itemsSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Items";
            this.bindingSource1.DataSource = this.itemsSet1;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "sale";
            this.bindingSource3.DataSource = this.stationaryDataSet21;
            // 
            // stationaryDataSet21
            // 
            this.stationaryDataSet21.DataSetName = "stationaryDataSet2";
            this.stationaryDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // stationaryDataSet11
            // 
            this.stationaryDataSet11.DataSetName = "stationaryDataSet1";
            this.stationaryDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1540, 634);
            this.Controls.Add(this.tabControlStationary);
            this.Name = "frmStore";
            this.Text = "store";
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.tabControlStationary.ResumeLayout(false);
            this.tabPageOffice.ResumeLayout(false);
            this.tabPageOffice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Office_Stationary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStationary;
        private System.Windows.Forms.TabPage tabPageOffice;
        private System.Windows.Forms.DataGridView dgv_Office_Stationary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalProfit;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Profit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Ofc_Item_SellingPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Del_Office;
        private System.Windows.Forms.Button btn_Update_Office;
        private System.Windows.Forms.TextBox txt_Ofc_Item_Qty;
        private System.Windows.Forms.TextBox txt_Ofc_Item_Received_Price;
        private System.Windows.Forms.TextBox txt_Ofc_Item_Name;
        private System.Windows.Forms.Button btn_Ofc_Add_Item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisplayChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeastDemandItem;
        private System.Windows.Forms.Button btnMostDemandItem;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private ItemsSet itemsSet1;
        private ItemsSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private stationaryDataSet2 stationaryDataSet2;
        private stationaryDataSet2TableAdapters.saleTableAdapter saleTableAdapter1;
        private stationaryDataSet2 stationaryDataSet21;
        private stationaryDataSet2TableAdapters.saleTableAdapter saleTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private stationaryDataSet1 stationaryDataSet11;
        private stationaryDataSet1TableAdapters.categoryTableAdapter categoryTableAdapter1;
    }
}