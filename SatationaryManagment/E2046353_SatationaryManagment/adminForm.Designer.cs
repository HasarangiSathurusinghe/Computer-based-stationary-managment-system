
namespace E2046353_SatationaryManagment
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Category = new System.Windows.Forms.DataGridView();
            this.btn_Clear_Category = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Exit_Category = new System.Windows.Forms.Button();
            this.btn_Save_Category = new System.Windows.Forms.Button();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.btn_Update_Category = new System.Windows.Forms.Button();
            this.txt_Categori_Input = new System.Windows.Forms.TextBox();
            this.btn_Delete_Category = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSeachStaff = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnExitStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.dateTimePickerJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPageCreateUser = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.stationaryDataSet = new E2046353_SatationaryManagment.stationaryDataSet();
            this.staffTableAdapter1 = new E2046353_SatationaryManagment.stationaryDataSetTableAdapters.staffTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            this.tabPageCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Create Category";
            // 
            // dgv_Category
            // 
            this.dgv_Category.AllowUserToAddRows = false;
            this.dgv_Category.AllowUserToDeleteRows = false;
            this.dgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Category.Location = new System.Drawing.Point(439, 68);
            this.dgv_Category.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            this.dgv_Category.RowHeadersWidth = 51;
            this.dgv_Category.Size = new System.Drawing.Size(964, 393);
            this.dgv_Category.TabIndex = 21;
            this.dgv_Category.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Category_RowHeaderMouseClick);
            // 
            // btn_Clear_Category
            // 
            this.btn_Clear_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear_Category.Image")));
            this.btn_Clear_Category.Location = new System.Drawing.Point(297, 180);
            this.btn_Clear_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear_Category.Name = "btn_Clear_Category";
            this.btn_Clear_Category.Size = new System.Drawing.Size(133, 54);
            this.btn_Clear_Category.TabIndex = 23;
            this.btn_Clear_Category.Text = "Clear";
            this.btn_Clear_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clear_Category.UseVisualStyleBackColor = true;
            this.btn_Clear_Category.Click += new System.EventHandler(this.btn_Clear_Category_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Category";
            // 
            // btn_Exit_Category
            // 
            this.btn_Exit_Category.BackColor = System.Drawing.Color.Red;
            this.btn_Exit_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit_Category.Image")));
            this.btn_Exit_Category.Location = new System.Drawing.Point(1269, 7);
            this.btn_Exit_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Category.Name = "btn_Exit_Category";
            this.btn_Exit_Category.Size = new System.Drawing.Size(133, 54);
            this.btn_Exit_Category.TabIndex = 22;
            this.btn_Exit_Category.Text = "Logout";
            this.btn_Exit_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit_Category.UseVisualStyleBackColor = false;
            this.btn_Exit_Category.Click += new System.EventHandler(this.btn_Exit_Category_Click);
            // 
            // btn_Save_Category
            // 
            this.btn_Save_Category.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Save_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_Category.Image")));
            this.btn_Save_Category.Location = new System.Drawing.Point(15, 118);
            this.btn_Save_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save_Category.Name = "btn_Save_Category";
            this.btn_Save_Category.Size = new System.Drawing.Size(133, 54);
            this.btn_Save_Category.TabIndex = 16;
            this.btn_Save_Category.Text = "Save";
            this.btn_Save_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save_Category.UseVisualStyleBackColor = false;
            this.btn_Save_Category.Click += new System.EventHandler(this.btn_Save_Category_Click);
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCategory.Controls.Add(this.label6);
            this.tabPageCategory.Controls.Add(this.dgv_Category);
            this.tabPageCategory.Controls.Add(this.btn_Clear_Category);
            this.tabPageCategory.Controls.Add(this.label7);
            this.tabPageCategory.Controls.Add(this.btn_Exit_Category);
            this.tabPageCategory.Controls.Add(this.btn_Save_Category);
            this.tabPageCategory.Controls.Add(this.btn_Update_Category);
            this.tabPageCategory.Controls.Add(this.txt_Categori_Input);
            this.tabPageCategory.Controls.Add(this.btn_Delete_Category);
            this.tabPageCategory.ImageIndex = 2;
            this.tabPageCategory.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCategory.Size = new System.Drawing.Size(1424, 529);
            this.tabPageCategory.TabIndex = 2;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Category
            // 
            this.btn_Update_Category.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Update_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update_Category.Image")));
            this.btn_Update_Category.Location = new System.Drawing.Point(156, 118);
            this.btn_Update_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update_Category.Name = "btn_Update_Category";
            this.btn_Update_Category.Size = new System.Drawing.Size(133, 54);
            this.btn_Update_Category.TabIndex = 17;
            this.btn_Update_Category.Text = "Update";
            this.btn_Update_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update_Category.UseVisualStyleBackColor = false;
            this.btn_Update_Category.Click += new System.EventHandler(this.btn_Update_Category_Click);
            // 
            // txt_Categori_Input
            // 
            this.txt_Categori_Input.Location = new System.Drawing.Point(123, 71);
            this.txt_Categori_Input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Categori_Input.Name = "txt_Categori_Input";
            this.txt_Categori_Input.Size = new System.Drawing.Size(307, 22);
            this.txt_Categori_Input.TabIndex = 19;
            // 
            // btn_Delete_Category
            // 
            this.btn_Delete_Category.BackColor = System.Drawing.Color.Red;
            this.btn_Delete_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Category.Image")));
            this.btn_Delete_Category.Location = new System.Drawing.Point(297, 118);
            this.btn_Delete_Category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_Category.Name = "btn_Delete_Category";
            this.btn_Delete_Category.Size = new System.Drawing.Size(133, 54);
            this.btn_Delete_Category.TabIndex = 18;
            this.btn_Delete_Category.Text = "Delete";
            this.btn_Delete_Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete_Category.UseVisualStyleBackColor = false;
            this.btn_Delete_Category.Click += new System.EventHandler(this.btn_Delete_Category_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 335);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 22);
            this.txtUserName.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "User Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 293);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
            this.txtPhoneNumber.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Phone Number";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(673, 30);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(200, 16);
            this.label29.TabIndex = 37;
            this.label29.Text = "(Enter Registration Number)";
            // 
            // txtSeachStaff
            // 
            this.txtSeachStaff.Location = new System.Drawing.Point(443, 26);
            this.txtSeachStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachStaff.Multiline = true;
            this.txtSeachStaff.Name = "txtSeachStaff";
            this.txtSeachStaff.Size = new System.Drawing.Size(204, 27);
            this.txtSeachStaff.TabIndex = 36;
            this.txtSeachStaff.TextChanged += new System.EventHandler(this.txtSeachStaff_TextChanged);
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(441, 70);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.Size = new System.Drawing.Size(961, 457);
            this.dgvStaff.TabIndex = 34;
            this.dgvStaff.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_RowHeaderMouseClick);
            // 
            // btnExitStaff
            // 
            this.btnExitStaff.BackColor = System.Drawing.Color.Red;
            this.btnExitStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnExitStaff.Image")));
            this.btnExitStaff.Location = new System.Drawing.Point(1271, 7);
            this.btnExitStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitStaff.Name = "btnExitStaff";
            this.btnExitStaff.Size = new System.Drawing.Size(133, 54);
            this.btnExitStaff.TabIndex = 33;
            this.btnExitStaff.Text = "Logout";
            this.btnExitStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitStaff.UseVisualStyleBackColor = false;
            this.btnExitStaff.Click += new System.EventHandler(this.btnExitStaff_Click);
            // 
            // btnClearStaff
            // 
            this.btnClearStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnClearStaff.Image")));
            this.btnClearStaff.Location = new System.Drawing.Point(300, 443);
            this.btnClearStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(133, 54);
            this.btnClearStaff.TabIndex = 32;
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearStaff.UseVisualStyleBackColor = true;
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStaff.Image")));
            this.btnDeleteStaff.Location = new System.Drawing.Point(300, 382);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(133, 54);
            this.btnDeleteStaff.TabIndex = 31;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStaff.Image")));
            this.btnUpdateStaff.Location = new System.Drawing.Point(159, 382);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(133, 54);
            this.btnUpdateStaff.TabIndex = 30;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.Location = new System.Drawing.Point(17, 382);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(133, 54);
            this.btnAddStaff.TabIndex = 29;
            this.btnAddStaff.Text = "Save";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dateTimePickerJoinedDate
            // 
            this.dateTimePickerJoinedDate.Location = new System.Drawing.Point(152, 252);
            this.dateTimePickerJoinedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerJoinedDate.Name = "dateTimePickerJoinedDate";
            this.dateTimePickerJoinedDate.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerJoinedDate.TabIndex = 28;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(152, 214);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(280, 22);
            this.txtDesignation.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 217);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 16);
            this.label25.TabIndex = 25;
            this.label25.Text = "Designation";
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Location = new System.Drawing.Point(152, 178);
            this.dateTimePickerDob.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerDob.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 258);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 16);
            this.label26.TabIndex = 27;
            this.label26.Text = "Joined Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 183);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 16);
            this.label24.TabIndex = 23;
            this.label24.Text = "Date Of Birth";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStaff);
            this.tabControl1.Controls.Add(this.tabPageCreateUser);
            this.tabControl1.Controls.Add(this.tabPageCategory);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList2;
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 558);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageStaff.Controls.Add(this.txtUserName);
            this.tabPageStaff.Controls.Add(this.label8);
            this.tabPageStaff.Controls.Add(this.txtPhoneNumber);
            this.tabPageStaff.Controls.Add(this.label5);
            this.tabPageStaff.Controls.Add(this.label29);
            this.tabPageStaff.Controls.Add(this.txtSeachStaff);
            this.tabPageStaff.Controls.Add(this.dgvStaff);
            this.tabPageStaff.Controls.Add(this.btnExitStaff);
            this.tabPageStaff.Controls.Add(this.btnClearStaff);
            this.tabPageStaff.Controls.Add(this.btnDeleteStaff);
            this.tabPageStaff.Controls.Add(this.btnUpdateStaff);
            this.tabPageStaff.Controls.Add(this.btnAddStaff);
            this.tabPageStaff.Controls.Add(this.dateTimePickerJoinedDate);
            this.tabPageStaff.Controls.Add(this.label26);
            this.tabPageStaff.Controls.Add(this.txtDesignation);
            this.tabPageStaff.Controls.Add(this.label25);
            this.tabPageStaff.Controls.Add(this.dateTimePickerDob);
            this.tabPageStaff.Controls.Add(this.label24);
            this.tabPageStaff.Controls.Add(this.txtStaffAddress);
            this.tabPageStaff.Controls.Add(this.label23);
            this.tabPageStaff.Controls.Add(this.txtStaffName);
            this.tabPageStaff.Controls.Add(this.label22);
            this.tabPageStaff.ImageIndex = 1;
            this.tabPageStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageStaff.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStaff.Size = new System.Drawing.Size(1424, 529);
            this.tabPageStaff.TabIndex = 1;
            this.tabPageStaff.Text = "Staff Registration";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(152, 53);
            this.txtStaffAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffAddress.Multiline = true;
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(280, 114);
            this.txtStaffAddress.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 53);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 16);
            this.label23.TabIndex = 21;
            this.label23.Text = "Address";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(152, 14);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(280, 22);
            this.txtStaffName.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 17);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 16);
            this.label22.TabIndex = 19;
            this.label22.Text = "Name";
            // 
            // tabPageCreateUser
            // 
            this.tabPageCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCreateUser.Controls.Add(this.btnClear);
            this.tabPageCreateUser.Controls.Add(this.cmbUserName);
            this.tabPageCreateUser.Controls.Add(this.cmbRole);
            this.tabPageCreateUser.Controls.Add(this.label4);
            this.tabPageCreateUser.Controls.Add(this.label1);
            this.tabPageCreateUser.Controls.Add(this.dgvLogin);
            this.tabPageCreateUser.Controls.Add(this.label2);
            this.tabPageCreateUser.Controls.Add(this.btnExit);
            this.tabPageCreateUser.Controls.Add(this.label3);
            this.tabPageCreateUser.Controls.Add(this.btnSave);
            this.tabPageCreateUser.Controls.Add(this.txtPassword);
            this.tabPageCreateUser.Controls.Add(this.btnUpdate);
            this.tabPageCreateUser.Controls.Add(this.btnDelete);
            this.tabPageCreateUser.ImageIndex = 0;
            this.tabPageCreateUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCreateUser.Name = "tabPageCreateUser";
            this.tabPageCreateUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCreateUser.Size = new System.Drawing.Size(1424, 529);
            this.tabPageCreateUser.TabIndex = 0;
            this.tabPageCreateUser.Text = "Create User";
            this.tabPageCreateUser.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(289, 250);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 54);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(132, 63);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(289, 24);
            this.cmbUserName.TabIndex = 13;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "StoreKeeper"});
            this.cmbRole.Location = new System.Drawing.Point(132, 148);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(289, 24);
            this.cmbRole.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User";
            // 
            // dgvLogin
            // 
            this.dgvLogin.AllowUserToAddRows = false;
            this.dgvLogin.AllowUserToDeleteRows = false;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Location = new System.Drawing.Point(431, 63);
            this.dgvLogin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.ReadOnly = true;
            this.dgvLogin.RowHeadersWidth = 51;
            this.dgvLogin.Size = new System.Drawing.Size(972, 411);
            this.dgvLogin.TabIndex = 8;
            this.dgvLogin.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLogin_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1269, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 54);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Logout";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(8, 188);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 54);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(132, 105);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(148, 188);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 54);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(289, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 54);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "admin_person_user_man_2839.png");
            this.imageList2.Images.SetKeyName(1, "business_application_addmale_useradd_insert_add_user_client_2312 (1).png");
            this.imageList2.Images.SetKeyName(2, "category_icon_184131.png");
            // 
            // stationaryDataSet
            // 
            this.stationaryDataSet.DataSetName = "stationaryDataSet";
            this.stationaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "staff";
            this.bindingSource1.DataSource = this.stationaryDataSet;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageStaff.ResumeLayout(false);
            this.tabPageStaff.PerformLayout();
            this.tabPageCreateUser.ResumeLayout(false);
            this.tabPageCreateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Category;
        private System.Windows.Forms.Button btn_Clear_Category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Exit_Category;
        private System.Windows.Forms.Button btn_Save_Category;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.Button btn_Update_Category;
        private System.Windows.Forms.TextBox txt_Categori_Input;
        private System.Windows.Forms.Button btn_Delete_Category;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtSeachStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnExitStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoinedDate;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPageCreateUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList2;
        private stationaryDataSet stationaryDataSet;
        private stationaryDataSetTableAdapters.staffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}