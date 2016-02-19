namespace CarRentalSys
{
    partial class frmCustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAdd));
            this.btn_Home = new System.Windows.Forms.Button();
            this.box_addCustomer = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.picCust = new System.Windows.Forms.PictureBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lbl_Street_No = new System.Windows.Forms.Label();
            this.cbo_County = new System.Windows.Forms.ComboBox();
            this.lbl_County = new System.Windows.Forms.Label();
            this.lbl_Town = new System.Windows.Forms.Label();
            this.lbl_Street = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbl_CustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.btn_AddCustConfirm = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_EnterForeName = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
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
            this.amendCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box_addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCust)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(658, 32);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 14;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // box_addCustomer
            // 
            this.box_addCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box_addCustomer.Controls.Add(this.btn_Reset);
            this.box_addCustomer.Controls.Add(this.picCust);
            this.box_addCustomer.Controls.Add(this.txtNo);
            this.box_addCustomer.Controls.Add(this.lbl_Street_No);
            this.box_addCustomer.Controls.Add(this.cbo_County);
            this.box_addCustomer.Controls.Add(this.lbl_County);
            this.box_addCustomer.Controls.Add(this.lbl_Town);
            this.box_addCustomer.Controls.Add(this.lbl_Street);
            this.box_addCustomer.Controls.Add(this.txtTown);
            this.box_addCustomer.Controls.Add(this.txtStreet);
            this.box_addCustomer.Controls.Add(this.lbl_CustId);
            this.box_addCustomer.Controls.Add(this.txtCustId);
            this.box_addCustomer.Controls.Add(this.btn_AddCustConfirm);
            this.box_addCustomer.Controls.Add(this.txtEmail);
            this.box_addCustomer.Controls.Add(this.lbl_Email);
            this.box_addCustomer.Controls.Add(this.txtPhone);
            this.box_addCustomer.Controls.Add(this.lbl_Phone);
            this.box_addCustomer.Controls.Add(this.txtSurname);
            this.box_addCustomer.Controls.Add(this.lbl_Surname);
            this.box_addCustomer.Controls.Add(this.lbl_EnterForeName);
            this.box_addCustomer.Controls.Add(this.txtForename);
            this.box_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_addCustomer.Location = new System.Drawing.Point(12, 81);
            this.box_addCustomer.Name = "box_addCustomer";
            this.box_addCustomer.Size = new System.Drawing.Size(720, 498);
            this.box_addCustomer.TabIndex = 15;
            this.box_addCustomer.TabStop = false;
            this.box_addCustomer.Text = "Add Customer";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(474, 435);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(102, 35);
            this.btn_Reset.TabIndex = 25;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // picCust
            // 
            this.picCust.Image = ((System.Drawing.Image)(resources.GetObject("picCust.Image")));
            this.picCust.Location = new System.Drawing.Point(356, 36);
            this.picCust.Name = "picCust";
            this.picCust.Size = new System.Drawing.Size(220, 349);
            this.picCust.TabIndex = 24;
            this.picCust.TabStop = false;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(25, 198);
            this.txtNo.MaxLength = 3;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(47, 22);
            this.txtNo.TabIndex = 23;
            // 
            // lbl_Street_No
            // 
            this.lbl_Street_No.AutoSize = true;
            this.lbl_Street_No.Location = new System.Drawing.Point(23, 180);
            this.lbl_Street_No.Name = "lbl_Street_No";
            this.lbl_Street_No.Size = new System.Drawing.Size(26, 16);
            this.lbl_Street_No.TabIndex = 22;
            this.lbl_Street_No.Text = "No";
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
            this.cbo_County.Location = new System.Drawing.Point(25, 293);
            this.cbo_County.Name = "cbo_County";
            this.cbo_County.Size = new System.Drawing.Size(198, 24);
            this.cbo_County.TabIndex = 21;
            // 
            // lbl_County
            // 
            this.lbl_County.AutoSize = true;
            this.lbl_County.Location = new System.Drawing.Point(23, 276);
            this.lbl_County.Name = "lbl_County";
            this.lbl_County.Size = new System.Drawing.Size(49, 16);
            this.lbl_County.TabIndex = 20;
            this.lbl_County.Text = "County";
            // 
            // lbl_Town
            // 
            this.lbl_Town.AutoSize = true;
            this.lbl_Town.Location = new System.Drawing.Point(23, 229);
            this.lbl_Town.Name = "lbl_Town";
            this.lbl_Town.Size = new System.Drawing.Size(41, 16);
            this.lbl_Town.TabIndex = 19;
            this.lbl_Town.Text = "Town";
            // 
            // lbl_Street
            // 
            this.lbl_Street.AutoSize = true;
            this.lbl_Street.Location = new System.Drawing.Point(82, 180);
            this.lbl_Street.Name = "lbl_Street";
            this.lbl_Street.Size = new System.Drawing.Size(43, 16);
            this.lbl_Street.TabIndex = 18;
            this.lbl_Street.Text = "Street";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(25, 247);
            this.txtTown.MaxLength = 15;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(198, 22);
            this.txtTown.TabIndex = 16;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(85, 198);
            this.txtStreet.MaxLength = 21;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(138, 22);
            this.txtStreet.TabIndex = 15;
            // 
            // lbl_CustId
            // 
            this.lbl_CustId.AutoSize = true;
            this.lbl_CustId.Location = new System.Drawing.Point(22, 36);
            this.lbl_CustId.Name = "lbl_CustId";
            this.lbl_CustId.Size = new System.Drawing.Size(48, 16);
            this.lbl_CustId.TabIndex = 14;
            this.lbl_CustId.Text = "Cust Id";
            // 
            // txtCustId
            // 
            this.txtCustId.Enabled = false;
            this.txtCustId.Location = new System.Drawing.Point(23, 53);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(77, 22);
            this.txtCustId.TabIndex = 13;
            // 
            // btn_AddCustConfirm
            // 
            this.btn_AddCustConfirm.Location = new System.Drawing.Point(356, 435);
            this.btn_AddCustConfirm.Name = "btn_AddCustConfirm";
            this.btn_AddCustConfirm.Size = new System.Drawing.Size(102, 35);
            this.btn_AddCustConfirm.TabIndex = 12;
            this.btn_AddCustConfirm.Text = "Confirm";
            this.btn_AddCustConfirm.UseVisualStyleBackColor = true;
            this.btn_AddCustConfirm.Click += new System.EventHandler(this.btn_AddCustConfirm_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 391);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(21, 372);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 16);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(24, 344);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(23, 327);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(68, 16);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "Phone No";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(25, 149);
            this.txtSurname.MaxLength = 25;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(198, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(23, 130);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(62, 16);
            this.lbl_Surname.TabIndex = 2;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_EnterForeName
            // 
            this.lbl_EnterForeName.AutoSize = true;
            this.lbl_EnterForeName.Location = new System.Drawing.Point(24, 82);
            this.lbl_EnterForeName.Name = "lbl_EnterForeName";
            this.lbl_EnterForeName.Size = new System.Drawing.Size(70, 16);
            this.lbl_EnterForeName.TabIndex = 1;
            this.lbl_EnterForeName.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(25, 101);
            this.txtForename.MaxLength = 15;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(198, 22);
            this.txtForename.TabIndex = 0;
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
            this.menuStrip1.TabIndex = 16;
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
            this.amendCustomerToolStripMenuItem,
            this.listCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // amendCustomerToolStripMenuItem
            // 
            this.amendCustomerToolStripMenuItem.Name = "amendCustomerToolStripMenuItem";
            this.amendCustomerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.amendCustomerToolStripMenuItem.Text = "Amend Customer";
            this.amendCustomerToolStripMenuItem.Click += new System.EventHandler(this.amendCustomerToolStripMenuItem_Click);
            // 
            // listCustomersToolStripMenuItem
            // 
            this.listCustomersToolStripMenuItem.Name = "listCustomersToolStripMenuItem";
            this.listCustomersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
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
            // frmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 602);
            this.Controls.Add(this.box_addCustomer);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.box_addCustomer.ResumeLayout(false);
            this.box_addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCust)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.GroupBox box_addCustomer;
        private System.Windows.Forms.Button btn_AddCustConfirm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_EnterForeName;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lbl_CustId;
        private System.Windows.Forms.Label lbl_County;
        private System.Windows.Forms.Label lbl_Town;
        private System.Windows.Forms.Label lbl_Street;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cbo_County;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lbl_Street_No;
        private System.Windows.Forms.PictureBox picCust;
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
        private System.Windows.Forms.ToolStripMenuItem amendCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_Reset;
    }
}