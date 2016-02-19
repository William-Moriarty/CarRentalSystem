namespace CarRentalSys
{
    partial class frmCustomersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersList));
            this.btn_Sel = new System.Windows.Forms.Button();
            this.grp_Search_By = new System.Windows.Forms.GroupBox();
            this.lbl_CustId = new System.Windows.Forms.Label();
            this.txt_CustId = new System.Windows.Forms.TextBox();
            this.cbo_County = new System.Windows.Forms.ComboBox();
            this.lbl_County = new System.Windows.Forms.Label();
            this.lbl_Town = new System.Windows.Forms.Label();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Forename = new System.Windows.Forms.Label();
            this.txt_Town = new System.Windows.Forms.TextBox();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Forename = new System.Windows.Forms.TextBox();
            this.btn_Srch4Rent = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grp_Order = new System.Windows.Forms.GroupBox();
            this.cbo_Order_By = new System.Windows.Forms.ComboBox();
            this.grp_Rent_Out = new System.Windows.Forms.GroupBox();
            this.rad_No = new System.Windows.Forms.RadioButton();
            this.rad_Yes = new System.Windows.Forms.RadioButton();
            this.rad_All_Rent = new System.Windows.Forms.RadioButton();
            this.grp_Status = new System.Windows.Forms.GroupBox();
            this.rad_Del = new System.Windows.Forms.RadioButton();
            this.rad_Active = new System.Windows.Forms.RadioButton();
            this.rad_All_Status = new System.Windows.Forms.RadioButton();
            this.grdCust = new System.Windows.Forms.DataGridView();
            this.btn_HomeFrmListCusts = new System.Windows.Forms.Button();
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
            this.amendCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDateReg = new System.Windows.Forms.GroupBox();
            this.dtp_DateReg = new System.Windows.Forms.DateTimePicker();
            this.grp_Search_By.SuspendLayout();
            this.grp_Order.SuspendLayout();
            this.grp_Rent_Out.SuspendLayout();
            this.grp_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpDateReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sel
            // 
            this.btn_Sel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sel.Location = new System.Drawing.Point(12, 275);
            this.btn_Sel.Name = "btn_Sel";
            this.btn_Sel.Size = new System.Drawing.Size(237, 30);
            this.btn_Sel.TabIndex = 8;
            this.btn_Sel.Text = "Select Customer";
            this.btn_Sel.UseVisualStyleBackColor = true;
            this.btn_Sel.Visible = false;
            this.btn_Sel.Click += new System.EventHandler(this.btn_Sel_Click);
            // 
            // grp_Search_By
            // 
            this.grp_Search_By.Controls.Add(this.lbl_CustId);
            this.grp_Search_By.Controls.Add(this.txt_CustId);
            this.grp_Search_By.Controls.Add(this.cbo_County);
            this.grp_Search_By.Controls.Add(this.lbl_County);
            this.grp_Search_By.Controls.Add(this.lbl_Town);
            this.grp_Search_By.Controls.Add(this.lbl_Street);
            this.grp_Search_By.Controls.Add(this.lbl_Surname);
            this.grp_Search_By.Controls.Add(this.lbl_Forename);
            this.grp_Search_By.Controls.Add(this.txt_Town);
            this.grp_Search_By.Controls.Add(this.txt_Street);
            this.grp_Search_By.Controls.Add(this.txt_Surname);
            this.grp_Search_By.Controls.Add(this.txt_Forename);
            this.grp_Search_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Search_By.Location = new System.Drawing.Point(15, 53);
            this.grp_Search_By.Name = "grp_Search_By";
            this.grp_Search_By.Size = new System.Drawing.Size(488, 214);
            this.grp_Search_By.TabIndex = 7;
            this.grp_Search_By.TabStop = false;
            this.grp_Search_By.Text = "Search By";
            // 
            // lbl_CustId
            // 
            this.lbl_CustId.AutoSize = true;
            this.lbl_CustId.Location = new System.Drawing.Point(27, 98);
            this.lbl_CustId.Name = "lbl_CustId";
            this.lbl_CustId.Size = new System.Drawing.Size(46, 15);
            this.lbl_CustId.TabIndex = 12;
            this.lbl_CustId.Text = "Cust ID";
            // 
            // txt_CustId
            // 
            this.txt_CustId.Location = new System.Drawing.Point(79, 94);
            this.txt_CustId.MaxLength = 5;
            this.txt_CustId.Name = "txt_CustId";
            this.txt_CustId.Size = new System.Drawing.Size(45, 21);
            this.txt_CustId.TabIndex = 11;
            // 
            // cbo_County
            // 
            this.cbo_County.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_County.FormattingEnabled = true;
            this.cbo_County.Items.AddRange(new object[] {
            "",
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbo_County.Location = new System.Drawing.Point(237, 165);
            this.cbo_County.Name = "cbo_County";
            this.cbo_County.Size = new System.Drawing.Size(201, 23);
            this.cbo_County.TabIndex = 10;
            // 
            // lbl_County
            // 
            this.lbl_County.AutoSize = true;
            this.lbl_County.Location = new System.Drawing.Point(175, 170);
            this.lbl_County.Name = "lbl_County";
            this.lbl_County.Size = new System.Drawing.Size(44, 15);
            this.lbl_County.TabIndex = 9;
            this.lbl_County.Text = "County";
            // 
            // lbl_Town
            // 
            this.lbl_Town.AutoSize = true;
            this.lbl_Town.Location = new System.Drawing.Point(183, 134);
            this.lbl_Town.Name = "lbl_Town";
            this.lbl_Town.Size = new System.Drawing.Size(37, 15);
            this.lbl_Town.TabIndex = 8;
            this.lbl_Town.Text = "Town";
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Location = new System.Drawing.Point(180, 100);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(39, 15);
            this.lbl_Street.TabIndex = 7;
            this.lbl_Street.Text = "Street";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(164, 65);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(58, 15);
            this.lbl_Surname.TabIndex = 6;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_Forename
            // 
            this.lbl_Forename.AutoSize = true;
            this.lbl_Forename.Location = new System.Drawing.Point(160, 31);
            this.lbl_Forename.Name = "lbl_Forename";
            this.lbl_Forename.Size = new System.Drawing.Size(64, 15);
            this.lbl_Forename.TabIndex = 5;
            this.lbl_Forename.Text = "Forename";
            // 
            // txt_Town
            // 
            this.txt_Town.Location = new System.Drawing.Point(237, 129);
            this.txt_Town.MaxLength = 15;
            this.txt_Town.Name = "txt_Town";
            this.txt_Town.Size = new System.Drawing.Size(201, 21);
            this.txt_Town.TabIndex = 3;
            // 
            // txt_Street
            // 
            this.txt_Street.Location = new System.Drawing.Point(237, 94);
            this.txt_Street.MaxLength = 25;
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(201, 21);
            this.txt_Street.TabIndex = 2;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(237, 60);
            this.txt_Surname.MaxLength = 25;
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(201, 21);
            this.txt_Surname.TabIndex = 1;
            // 
            // txt_Forename
            // 
            this.txt_Forename.Location = new System.Drawing.Point(237, 25);
            this.txt_Forename.MaxLength = 15;
            this.txt_Forename.Name = "txt_Forename";
            this.txt_Forename.Size = new System.Drawing.Size(201, 21);
            this.txt_Forename.TabIndex = 0;
            // 
            // btn_Srch4Rent
            // 
            this.btn_Srch4Rent.Enabled = false;
            this.btn_Srch4Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Srch4Rent.Location = new System.Drawing.Point(696, 275);
            this.btn_Srch4Rent.Name = "btn_Srch4Rent";
            this.btn_Srch4Rent.Size = new System.Drawing.Size(76, 30);
            this.btn_Srch4Rent.TabIndex = 13;
            this.btn_Srch4Rent.Text = "Search";
            this.btn_Srch4Rent.UseVisualStyleBackColor = true;
            this.btn_Srch4Rent.Visible = false;
            this.btn_Srch4Rent.Click += new System.EventHandler(this.btn_Srch4Rent_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(780, 275);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(76, 30);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(696, 274);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(76, 30);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grp_Order
            // 
            this.grp_Order.Controls.Add(this.cbo_Order_By);
            this.grp_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Order.Location = new System.Drawing.Point(542, 219);
            this.grp_Order.Name = "grp_Order";
            this.grp_Order.Size = new System.Drawing.Size(154, 48);
            this.grp_Order.TabIndex = 6;
            this.grp_Order.TabStop = false;
            this.grp_Order.Text = "Order By";
            // 
            // cbo_Order_By
            // 
            this.cbo_Order_By.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Order_By.FormattingEnabled = true;
            this.cbo_Order_By.Items.AddRange(new object[] {
            "",
            "Cust_ID",
            "Forename",
            "Surname",
            "Street",
            "Town",
            "County",
            "Status",
            "Rental_Out",
            "Date_Registered"});
            this.cbo_Order_By.Location = new System.Drawing.Point(6, 21);
            this.cbo_Order_By.Name = "cbo_Order_By";
            this.cbo_Order_By.Size = new System.Drawing.Size(140, 23);
            this.cbo_Order_By.TabIndex = 3;
            // 
            // grp_Rent_Out
            // 
            this.grp_Rent_Out.Controls.Add(this.rad_No);
            this.grp_Rent_Out.Controls.Add(this.rad_Yes);
            this.grp_Rent_Out.Controls.Add(this.rad_All_Rent);
            this.grp_Rent_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Rent_Out.Location = new System.Drawing.Point(542, 111);
            this.grp_Rent_Out.Name = "grp_Rent_Out";
            this.grp_Rent_Out.Size = new System.Drawing.Size(312, 49);
            this.grp_Rent_Out.TabIndex = 2;
            this.grp_Rent_Out.TabStop = false;
            this.grp_Rent_Out.Text = "Rental Out?";
            // 
            // rad_No
            // 
            this.rad_No.AutoSize = true;
            this.rad_No.Location = new System.Drawing.Point(220, 21);
            this.rad_No.Name = "rad_No";
            this.rad_No.Size = new System.Drawing.Size(41, 19);
            this.rad_No.TabIndex = 2;
            this.rad_No.TabStop = true;
            this.rad_No.Text = "No";
            this.rad_No.UseVisualStyleBackColor = true;
            // 
            // rad_Yes
            // 
            this.rad_Yes.AutoSize = true;
            this.rad_Yes.Location = new System.Drawing.Point(122, 21);
            this.rad_Yes.Name = "rad_Yes";
            this.rad_Yes.Size = new System.Drawing.Size(45, 19);
            this.rad_Yes.TabIndex = 1;
            this.rad_Yes.TabStop = true;
            this.rad_Yes.Text = "Yes";
            this.rad_Yes.UseVisualStyleBackColor = true;
            // 
            // rad_All_Rent
            // 
            this.rad_All_Rent.AutoSize = true;
            this.rad_All_Rent.Location = new System.Drawing.Point(22, 21);
            this.rad_All_Rent.Name = "rad_All_Rent";
            this.rad_All_Rent.Size = new System.Drawing.Size(38, 19);
            this.rad_All_Rent.TabIndex = 0;
            this.rad_All_Rent.TabStop = true;
            this.rad_All_Rent.Text = "All";
            this.rad_All_Rent.UseVisualStyleBackColor = true;
            // 
            // grp_Status
            // 
            this.grp_Status.Controls.Add(this.rad_Del);
            this.grp_Status.Controls.Add(this.rad_Active);
            this.grp_Status.Controls.Add(this.rad_All_Status);
            this.grp_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Status.Location = new System.Drawing.Point(542, 54);
            this.grp_Status.Name = "grp_Status";
            this.grp_Status.Size = new System.Drawing.Size(312, 49);
            this.grp_Status.TabIndex = 1;
            this.grp_Status.TabStop = false;
            this.grp_Status.Text = "Status";
            // 
            // rad_Del
            // 
            this.rad_Del.AutoSize = true;
            this.rad_Del.Location = new System.Drawing.Point(219, 20);
            this.rad_Del.Name = "rad_Del";
            this.rad_Del.Size = new System.Drawing.Size(68, 19);
            this.rad_Del.TabIndex = 2;
            this.rad_Del.TabStop = true;
            this.rad_Del.Text = "Deleted";
            this.rad_Del.UseVisualStyleBackColor = true;
            // 
            // rad_Active
            // 
            this.rad_Active.AutoSize = true;
            this.rad_Active.Location = new System.Drawing.Point(120, 20);
            this.rad_Active.Name = "rad_Active";
            this.rad_Active.Size = new System.Drawing.Size(56, 19);
            this.rad_Active.TabIndex = 1;
            this.rad_Active.TabStop = true;
            this.rad_Active.Text = "Active";
            this.rad_Active.UseVisualStyleBackColor = true;
            // 
            // rad_All_Status
            // 
            this.rad_All_Status.AutoSize = true;
            this.rad_All_Status.Location = new System.Drawing.Point(25, 20);
            this.rad_All_Status.Name = "rad_All_Status";
            this.rad_All_Status.Size = new System.Drawing.Size(38, 19);
            this.rad_All_Status.TabIndex = 0;
            this.rad_All_Status.TabStop = true;
            this.rad_All_Status.Text = "All";
            this.rad_All_Status.UseVisualStyleBackColor = true;
            // 
            // grdCust
            // 
            this.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCust.Location = new System.Drawing.Point(12, 310);
            this.grdCust.Name = "grdCust";
            this.grdCust.Size = new System.Drawing.Size(1027, 351);
            this.grdCust.TabIndex = 0;
            this.grdCust.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_ListCusts_Double_CellClick);
            // 
            // btn_HomeFrmListCusts
            // 
            this.btn_HomeFrmListCusts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeFrmListCusts.Location = new System.Drawing.Point(962, 32);
            this.btn_HomeFrmListCusts.Name = "btn_HomeFrmListCusts";
            this.btn_HomeFrmListCusts.Size = new System.Drawing.Size(75, 23);
            this.btn_HomeFrmListCusts.TabIndex = 2;
            this.btn_HomeFrmListCusts.Text = "Home";
            this.btn_HomeFrmListCusts.UseVisualStyleBackColor = true;
            this.btn_HomeFrmListCusts.Click += new System.EventHandler(this.btn_HomeFrmListCusts_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 14;
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
            this.amendCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // amendCustomerToolStripMenuItem
            // 
            this.amendCustomerToolStripMenuItem.Name = "amendCustomerToolStripMenuItem";
            this.amendCustomerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.amendCustomerToolStripMenuItem.Text = "Amend Customer";
            this.amendCustomerToolStripMenuItem.Click += new System.EventHandler(this.amendCustomerToolStripMenuItem_Click);
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
            // grpDateReg
            // 
            this.grpDateReg.Controls.Add(this.dtp_DateReg);
            this.grpDateReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDateReg.Location = new System.Drawing.Point(542, 168);
            this.grpDateReg.Name = "grpDateReg";
            this.grpDateReg.Size = new System.Drawing.Size(312, 45);
            this.grpDateReg.TabIndex = 15;
            this.grpDateReg.TabStop = false;
            this.grpDateReg.Text = "Date Registered";
            // 
            // dtp_DateReg
            // 
            this.dtp_DateReg.Checked = false;
            this.dtp_DateReg.Location = new System.Drawing.Point(7, 17);
            this.dtp_DateReg.Name = "dtp_DateReg";
            this.dtp_DateReg.ShowCheckBox = true;
            this.dtp_DateReg.Size = new System.Drawing.Size(294, 21);
            this.dtp_DateReg.TabIndex = 0;
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 673);
            this.Controls.Add(this.grpDateReg);
            this.Controls.Add(this.btn_Srch4Rent);
            this.Controls.Add(this.btn_Sel);
            this.Controls.Add(this.btn_HomeFrmListCusts);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.grp_Status);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.grp_Rent_Out);
            this.Controls.Add(this.grp_Order);
            this.Controls.Add(this.grp_Search_By);
            this.Controls.Add(this.grdCust);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Customers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.grp_Search_By.ResumeLayout(false);
            this.grp_Search_By.PerformLayout();
            this.grp_Order.ResumeLayout(false);
            this.grp_Rent_Out.ResumeLayout(false);
            this.grp_Rent_Out.PerformLayout();
            this.grp_Status.ResumeLayout(false);
            this.grp_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCust)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDateReg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HomeFrmListCusts;
        private System.Windows.Forms.DataGridView grdCust;
        private System.Windows.Forms.GroupBox grp_Rent_Out;
        private System.Windows.Forms.GroupBox grp_Status;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbo_Order_By;
        private System.Windows.Forms.GroupBox grp_Order;
        private System.Windows.Forms.RadioButton rad_No;
        private System.Windows.Forms.RadioButton rad_Yes;
        private System.Windows.Forms.RadioButton rad_All_Rent;
        private System.Windows.Forms.RadioButton rad_Del;
        private System.Windows.Forms.RadioButton rad_Active;
        private System.Windows.Forms.RadioButton rad_All_Status;
        private System.Windows.Forms.GroupBox grp_Search_By;
        private System.Windows.Forms.TextBox txt_Town;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Forename;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Forename;
        private System.Windows.Forms.Label lbl_County;
        private System.Windows.Forms.Label lbl_Town;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.Label lbl_CustId;
        private System.Windows.Forms.TextBox txt_CustId;
        private System.Windows.Forms.ComboBox cbo_County;
        private System.Windows.Forms.Button btn_Sel;
        private System.Windows.Forms.Button btn_Srch4Rent;
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
        private System.Windows.Forms.ToolStripMenuItem amendCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDateReg;
        private System.Windows.Forms.DateTimePicker dtp_DateReg;
    }
}