namespace CarRentalSys
{
    partial class frmCustomerAmend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAmend));
            this.radDeleteCust = new System.Windows.Forms.RadioButton();
            this.radUpdateCust = new System.Windows.Forms.RadioButton();
            this.btn_HomeFrmAmendCust = new System.Windows.Forms.Button();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txt_CustID2 = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.CustID2 = new System.Windows.Forms.Label();
            this.btn_upd_Res = new System.Windows.Forms.Button();
            this.cbo_County = new System.Windows.Forms.ComboBox();
            this.lbl_County = new System.Windows.Forms.Label();
            this.lbl_Town = new System.Windows.Forms.Label();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.txt_Town = new System.Windows.Forms.TextBox();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.grp_Search_Cust = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.lbl_CustID = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Forename = new System.Windows.Forms.TextBox();
            this.txt_CustID = new System.Windows.Forms.TextBox();
            this.grd_List_Cust = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carSysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCustDetails.SuspendLayout();
            this.grp_Search_Cust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_List_Cust)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radDeleteCust
            // 
            this.radDeleteCust.AutoSize = true;
            this.radDeleteCust.Checked = true;
            this.radDeleteCust.Location = new System.Drawing.Point(328, 24);
            this.radDeleteCust.Name = "radDeleteCust";
            this.radDeleteCust.Size = new System.Drawing.Size(61, 19);
            this.radDeleteCust.TabIndex = 2;
            this.radDeleteCust.TabStop = true;
            this.radDeleteCust.Text = "Delete";
            this.radDeleteCust.UseVisualStyleBackColor = true;
            this.radDeleteCust.Click += new System.EventHandler(this.radDelete_Click);
            // 
            // radUpdateCust
            // 
            this.radUpdateCust.AutoSize = true;
            this.radUpdateCust.Location = new System.Drawing.Point(242, 25);
            this.radUpdateCust.Name = "radUpdateCust";
            this.radUpdateCust.Size = new System.Drawing.Size(65, 19);
            this.radUpdateCust.TabIndex = 3;
            this.radUpdateCust.Text = "Update";
            this.radUpdateCust.UseVisualStyleBackColor = true;
            this.radUpdateCust.Click += new System.EventHandler(this.radUpdate_Click);
            // 
            // btn_HomeFrmAmendCust
            // 
            this.btn_HomeFrmAmendCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeFrmAmendCust.Location = new System.Drawing.Point(658, 32);
            this.btn_HomeFrmAmendCust.Name = "btn_HomeFrmAmendCust";
            this.btn_HomeFrmAmendCust.Size = new System.Drawing.Size(75, 23);
            this.btn_HomeFrmAmendCust.TabIndex = 6;
            this.btn_HomeFrmAmendCust.Text = "Home";
            this.btn_HomeFrmAmendCust.UseVisualStyleBackColor = true;
            this.btn_HomeFrmAmendCust.Click += new System.EventHandler(this.btn_HomeFrmAmendCust_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.txtNo);
            this.grpCustDetails.Controls.Add(this.txt_Name);
            this.grpCustDetails.Controls.Add(this.lblName);
            this.grpCustDetails.Controls.Add(this.txt_CustID2);
            this.grpCustDetails.Controls.Add(this.btnDel);
            this.grpCustDetails.Controls.Add(this.CustID2);
            this.grpCustDetails.Controls.Add(this.btn_upd_Res);
            this.grpCustDetails.Controls.Add(this.cbo_County);
            this.grpCustDetails.Controls.Add(this.radUpdateCust);
            this.grpCustDetails.Controls.Add(this.radDeleteCust);
            this.grpCustDetails.Controls.Add(this.lbl_County);
            this.grpCustDetails.Controls.Add(this.lbl_Town);
            this.grpCustDetails.Controls.Add(this.lbl_Street);
            this.grpCustDetails.Controls.Add(this.txt_Town);
            this.grpCustDetails.Controls.Add(this.txt_Street);
            this.grpCustDetails.Controls.Add(this.txt_Email);
            this.grpCustDetails.Controls.Add(this.lbl_Email);
            this.grpCustDetails.Controls.Add(this.txt_Phone);
            this.grpCustDetails.Controls.Add(this.lbl_phone);
            this.grpCustDetails.Controls.Add(this.btnUpd);
            this.grpCustDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustDetails.Location = new System.Drawing.Point(285, 68);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(447, 232);
            this.grpCustDetails.TabIndex = 8;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Amend Customer Details";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(66, 91);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(31, 21);
            this.txtNo.TabIndex = 23;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(243, 62);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(180, 21);
            this.txt_Name.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(189, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // txt_CustID2
            // 
            this.txt_CustID2.Location = new System.Drawing.Point(66, 62);
            this.txt_CustID2.Name = "txt_CustID2";
            this.txt_CustID2.Size = new System.Drawing.Size(31, 21);
            this.txt_CustID2.TabIndex = 20;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(262, 188);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // CustID2
            // 
            this.CustID2.AutoSize = true;
            this.CustID2.Location = new System.Drawing.Point(11, 67);
            this.CustID2.Name = "CustID2";
            this.CustID2.Size = new System.Drawing.Size(46, 15);
            this.CustID2.TabIndex = 19;
            this.CustID2.Text = "Cust ID";
            // 
            // btn_upd_Res
            // 
            this.btn_upd_Res.Enabled = false;
            this.btn_upd_Res.Location = new System.Drawing.Point(346, 188);
            this.btn_upd_Res.Name = "btn_upd_Res";
            this.btn_upd_Res.Size = new System.Drawing.Size(76, 30);
            this.btn_upd_Res.TabIndex = 17;
            this.btn_upd_Res.Text = "Reset";
            this.btn_upd_Res.UseVisualStyleBackColor = true;
            this.btn_upd_Res.Click += new System.EventHandler(this.btn_upd_Res_Click);
            // 
            // cbo_County
            // 
            this.cbo_County.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_County.Enabled = false;
            this.cbo_County.FormattingEnabled = true;
            this.cbo_County.Items.AddRange(new object[] {
            "",
            "ANTRIM",
            "ARMAGH",
            "CARLOW",
            "CAVAN",
            "CLARE",
            "CORK",
            "DERRY",
            "DONEGAL",
            "DOWN",
            "DUBLIN",
            "FERMANAGH",
            "GALWAT",
            "KERRY",
            "KILDARE",
            "KILKENNY",
            "LAOIS",
            "LEITRIM",
            "LIMERICK",
            "LONGFORD",
            "LOUTH",
            "MAYO",
            "MEATH",
            "MONAGHAN",
            "OFFALY",
            "ROSCOMMON",
            "SLIGO",
            "TIPPERARY",
            "TYRONE",
            "WATERFORD",
            "WESTMEATH",
            "WEXFORD",
            "WICKLOW"});
            this.cbo_County.Location = new System.Drawing.Point(67, 154);
            this.cbo_County.Name = "cbo_County";
            this.cbo_County.Size = new System.Drawing.Size(145, 23);
            this.cbo_County.TabIndex = 16;
            // 
            // lbl_County
            // 
            this.lbl_County.AutoSize = true;
            this.lbl_County.Location = new System.Drawing.Point(11, 159);
            this.lbl_County.Name = "lbl_County";
            this.lbl_County.Size = new System.Drawing.Size(44, 15);
            this.lbl_County.TabIndex = 15;
            this.lbl_County.Text = "County";
            // 
            // lbl_Town
            // 
            this.lbl_Town.AutoSize = true;
            this.lbl_Town.Location = new System.Drawing.Point(18, 128);
            this.lbl_Town.Name = "lbl_Town";
            this.lbl_Town.Size = new System.Drawing.Size(37, 15);
            this.lbl_Town.TabIndex = 14;
            this.lbl_Town.Text = "Town";
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Location = new System.Drawing.Point(16, 97);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(39, 15);
            this.lbl_Street.TabIndex = 13;
            this.lbl_Street.Text = "Street";
            // 
            // txt_Town
            // 
            this.txt_Town.Enabled = false;
            this.txt_Town.Location = new System.Drawing.Point(66, 123);
            this.txt_Town.MaxLength = 15;
            this.txt_Town.Name = "txt_Town";
            this.txt_Town.Size = new System.Drawing.Size(145, 21);
            this.txt_Town.TabIndex = 11;
            // 
            // txt_Street
            // 
            this.txt_Street.Enabled = false;
            this.txt_Street.Location = new System.Drawing.Point(104, 91);
            this.txt_Street.MaxLength = 25;
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(108, 21);
            this.txt_Street.TabIndex = 10;
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(300, 138);
            this.txt_Email.MaxLength = 30;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(122, 21);
            this.txt_Email.TabIndex = 9;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(241, 141);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 15);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Enabled = false;
            this.txt_Phone.Location = new System.Drawing.Point(301, 105);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(121, 21);
            this.txt_Phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(241, 108);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(43, 15);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone";
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(263, 188);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(76, 30);
            this.btnUpd.TabIndex = 2;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Visible = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // grp_Search_Cust
            // 
            this.grp_Search_Cust.Controls.Add(this.Reset);
            this.grp_Search_Cust.Controls.Add(this.btn_Find);
            this.grp_Search_Cust.Controls.Add(this.lbl_Surname);
            this.grp_Search_Cust.Controls.Add(this.lbl_Forename);
            this.grp_Search_Cust.Controls.Add(this.lbl_CustID);
            this.grp_Search_Cust.Controls.Add(this.txt_Surname);
            this.grp_Search_Cust.Controls.Add(this.txt_Forename);
            this.grp_Search_Cust.Controls.Add(this.txt_CustID);
            this.grp_Search_Cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Search_Cust.Location = new System.Drawing.Point(12, 68);
            this.grp_Search_Cust.Name = "grp_Search_Cust";
            this.grp_Search_Cust.Size = new System.Drawing.Size(256, 232);
            this.grp_Search_Cust.TabIndex = 10;
            this.grp_Search_Cust.TabStop = false;
            this.grp_Search_Cust.Text = "Search Customer By";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(151, 188);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(76, 30);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(65, 188);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(76, 30);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(8, 135);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(58, 15);
            this.lbl_Surname.TabIndex = 5;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(5, 98);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(64, 15);
            this.lbl_Forename.TabIndex = 4;
            this.lbl_Forename.Text = "Forename";
            // 
            // lbl_CustID
            // 
            this.lbl_CustID.AutoSize = true;
            this.lbl_CustID.Location = new System.Drawing.Point(17, 70);
            this.lbl_CustID.Name = "lbl_CustID";
            this.lbl_CustID.Size = new System.Drawing.Size(46, 15);
            this.lbl_CustID.TabIndex = 3;
            this.lbl_CustID.Text = "Cust ID";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(70, 130);
            this.txt_Surname.MaxLength = 25;
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(157, 21);
            this.txt_Surname.TabIndex = 2;
            // 
            // txt_Forename
            // 
            this.txt_Forename.Location = new System.Drawing.Point(70, 95);
            this.txt_Forename.MaxLength = 15;
            this.txt_Forename.Name = "txt_Forename";
            this.txt_Forename.Size = new System.Drawing.Size(157, 21);
            this.txt_Forename.TabIndex = 1;
            // 
            // txt_CustID
            // 
            this.txt_CustID.Location = new System.Drawing.Point(70, 65);
            this.txt_CustID.MaxLength = 5;
            this.txt_CustID.Name = "txt_CustID";
            this.txt_CustID.Size = new System.Drawing.Size(35, 21);
            this.txt_CustID.TabIndex = 0;
            // 
            // grd_List_Cust
            // 
            this.grd_List_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_List_Cust.Location = new System.Drawing.Point(12, 310);
            this.grd_List_Cust.Name = "grd_List_Cust";
            this.grd_List_Cust.Size = new System.Drawing.Size(720, 280);
            this.grd_List_Cust.TabIndex = 9;
            this.grd_List_Cust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_List_Cust_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carSysToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carSysToolStripMenuItem
            // 
            this.carSysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.carSysToolStripMenuItem.Name = "carSysToolStripMenuItem";
            this.carSysToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.carSysToolStripMenuItem.Text = "CarSys";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.amendCarToolStripMenuItem,
            this.listCarsToolStripMenuItem,
            this.ratesToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // amendCarToolStripMenuItem
            // 
            this.amendCarToolStripMenuItem.Name = "amendCarToolStripMenuItem";
            this.amendCarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.amendCarToolStripMenuItem.Text = "Amend Car";
            this.amendCarToolStripMenuItem.Click += new System.EventHandler(this.amendCarToolStripMenuItem_Click);
            // 
            // listCarsToolStripMenuItem
            // 
            this.listCarsToolStripMenuItem.Name = "listCarsToolStripMenuItem";
            this.listCarsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listCarsToolStripMenuItem.Text = "List Cars";
            this.listCarsToolStripMenuItem.Click += new System.EventHandler(this.listCarsToolStripMenuItem_Click);
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ratesToolStripMenuItem.Text = "Rates";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.listCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // listCustomersToolStripMenuItem
            // 
            this.listCustomersToolStripMenuItem.Name = "listCustomersToolStripMenuItem";
            this.listCustomersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listCustomersToolStripMenuItem.Text = "List Customers";
            this.listCustomersToolStripMenuItem.Click += new System.EventHandler(this.listCustomersToolStripMenuItem_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCarToolStripMenuItem,
            this.returnCarToolStripMenuItem,
            this.listRentalsToolStripMenuItem,
            this.rentalAnalysisToolStripMenuItem});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // rentCarToolStripMenuItem
            // 
            this.rentCarToolStripMenuItem.Name = "rentCarToolStripMenuItem";
            this.rentCarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rentCarToolStripMenuItem.Text = "Rent Car";
            this.rentCarToolStripMenuItem.Click += new System.EventHandler(this.rentCarToolStripMenuItem_Click);
            // 
            // returnCarToolStripMenuItem
            // 
            this.returnCarToolStripMenuItem.Name = "returnCarToolStripMenuItem";
            this.returnCarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.returnCarToolStripMenuItem.Text = "Return Car";
            this.returnCarToolStripMenuItem.Click += new System.EventHandler(this.returnCarToolStripMenuItem_Click);
            // 
            // listRentalsToolStripMenuItem
            // 
            this.listRentalsToolStripMenuItem.Name = "listRentalsToolStripMenuItem";
            this.listRentalsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listRentalsToolStripMenuItem.Text = "List Rentals";
            this.listRentalsToolStripMenuItem.Click += new System.EventHandler(this.listRentalsToolStripMenuItem_Click);
            // 
            // rentalAnalysisToolStripMenuItem
            // 
            this.rentalAnalysisToolStripMenuItem.Name = "rentalAnalysisToolStripMenuItem";
            this.rentalAnalysisToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rentalAnalysisToolStripMenuItem.Text = "Rental Analysis";
            this.rentalAnalysisToolStripMenuItem.Click += new System.EventHandler(this.rentalAnalysisToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmCustomerAmend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 602);
            this.Controls.Add(this.grd_List_Cust);
            this.Controls.Add(this.grp_Search_Cust);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.btn_HomeFrmAmendCust);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerAmend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amend Customer";
            this.Load += new System.EventHandler(this.frmCustomerAmend_Load);
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.grp_Search_Cust.ResumeLayout(false);
            this.grp_Search_Cust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_List_Cust)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radDeleteCust;
        private System.Windows.Forms.RadioButton radUpdateCust;
        private System.Windows.Forms.Button btn_HomeFrmAmendCust;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.GroupBox grp_Search_Cust;
        private System.Windows.Forms.Label lbl_County;
        private System.Windows.Forms.Label lbl_Town;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.TextBox txt_Town;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_CustID;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Forename;
        private System.Windows.Forms.TextBox txt_CustID;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.ComboBox cbo_County;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button btn_upd_Res;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txt_CustID2;
        private System.Windows.Forms.Label CustID2;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.DataGridView grd_List_Cust;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carSysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}