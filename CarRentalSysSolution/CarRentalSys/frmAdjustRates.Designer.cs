namespace CarRentalSys
{
    partial class frmAdjustRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjustRates));
            this.lbl_Class = new System.Windows.Forms.Label();
            this.cbo_Class = new System.Windows.Forms.ComboBox();
            this.lbl_AdjRate = new System.Windows.Forms.Label();
            this.lbl_AdjLate = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txt_LateFee = new System.Windows.Forms.TextBox();
            this.lbl_AdjDesc = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.grpAdj = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Per = new System.Windows.Forms.Label();
            this.lbl_Euro = new System.Windows.Forms.Label();
            this.picCoins = new System.Windows.Forms.PictureBox();
            this.grp_Function = new System.Windows.Forms.GroupBox();
            this.rad_Adj = new System.Windows.Forms.RadioButton();
            this.rad_Add = new System.Windows.Forms.RadioButton();
            this.rad_Del = new System.Windows.Forms.RadioButton();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Adjust = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carSysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).BeginInit();
            this.grp_Function.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(68, 184);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(42, 16);
            this.lbl_Class.TabIndex = 0;
            this.lbl_Class.Text = "Class";
            // 
            // cbo_Class
            // 
            this.cbo_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Class.FormattingEnabled = true;
            this.cbo_Class.Location = new System.Drawing.Point(142, 177);
            this.cbo_Class.Name = "cbo_Class";
            this.cbo_Class.Size = new System.Drawing.Size(52, 23);
            this.cbo_Class.TabIndex = 1;
            this.cbo_Class.SelectedIndexChanged += new System.EventHandler(this.cbo_Class_SelectedIndexChanged);
            // 
            // lbl_AdjRate
            // 
            this.lbl_AdjRate.AutoSize = true;
            this.lbl_AdjRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdjRate.Location = new System.Drawing.Point(25, 247);
            this.lbl_AdjRate.Name = "lbl_AdjRate";
            this.lbl_AdjRate.Size = new System.Drawing.Size(89, 16);
            this.lbl_AdjRate.TabIndex = 2;
            this.lbl_AdjRate.Text = "Rate Per Day";
            // 
            // lbl_AdjLate
            // 
            this.lbl_AdjLate.AutoSize = true;
            this.lbl_AdjLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdjLate.Location = new System.Drawing.Point(49, 310);
            this.lbl_AdjLate.Name = "lbl_AdjLate";
            this.lbl_AdjLate.Size = new System.Drawing.Size(61, 16);
            this.lbl_AdjLate.TabIndex = 4;
            this.lbl_AdjLate.Text = "Late Fee";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(142, 241);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(90, 21);
            this.txt_Rate.TabIndex = 5;
            // 
            // txt_LateFee
            // 
            this.txt_LateFee.Location = new System.Drawing.Point(142, 306);
            this.txt_LateFee.Name = "txt_LateFee";
            this.txt_LateFee.Size = new System.Drawing.Size(90, 21);
            this.txt_LateFee.TabIndex = 6;
            // 
            // lbl_AdjDesc
            // 
            this.lbl_AdjDesc.AutoSize = true;
            this.lbl_AdjDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdjDesc.Location = new System.Drawing.Point(33, 372);
            this.lbl_AdjDesc.Name = "lbl_AdjDesc";
            this.lbl_AdjDesc.Size = new System.Drawing.Size(76, 16);
            this.lbl_AdjDesc.TabIndex = 7;
            this.lbl_AdjDesc.Text = "Description";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(142, 367);
            this.txt_Desc.MaxLength = 50;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(232, 21);
            this.txt_Desc.TabIndex = 8;
            // 
            // grpAdj
            // 
            this.grpAdj.Controls.Add(this.btn_Reset);
            this.grpAdj.Controls.Add(this.lbl_Per);
            this.grpAdj.Controls.Add(this.lbl_Euro);
            this.grpAdj.Controls.Add(this.picCoins);
            this.grpAdj.Controls.Add(this.grp_Function);
            this.grpAdj.Controls.Add(this.lbl_Type);
            this.grpAdj.Controls.Add(this.btn_Add);
            this.grpAdj.Controls.Add(this.btn_Del);
            this.grpAdj.Controls.Add(this.btn_Adjust);
            this.grpAdj.Controls.Add(this.lbl_Class);
            this.grpAdj.Controls.Add(this.txt_Desc);
            this.grpAdj.Controls.Add(this.cbo_Class);
            this.grpAdj.Controls.Add(this.lbl_AdjDesc);
            this.grpAdj.Controls.Add(this.lbl_AdjRate);
            this.grpAdj.Controls.Add(this.lbl_AdjLate);
            this.grpAdj.Controls.Add(this.txt_LateFee);
            this.grpAdj.Controls.Add(this.txt_Rate);
            this.grpAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdj.Location = new System.Drawing.Point(12, 63);
            this.grpAdj.Name = "grpAdj";
            this.grpAdj.Size = new System.Drawing.Size(720, 527);
            this.grpAdj.TabIndex = 9;
            this.grpAdj.TabStop = false;
            this.grpAdj.Text = "Rates";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(272, 418);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(102, 35);
            this.btn_Reset.TabIndex = 20;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Per
            // 
            this.lbl_Per.AutoSize = true;
            this.lbl_Per.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per.Location = new System.Drawing.Point(236, 306);
            this.lbl_Per.Name = "lbl_Per";
            this.lbl_Per.Size = new System.Drawing.Size(24, 20);
            this.lbl_Per.TabIndex = 19;
            this.lbl_Per.Text = "%";
            // 
            // lbl_Euro
            // 
            this.lbl_Euro.AutoSize = true;
            this.lbl_Euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Euro.Location = new System.Drawing.Point(123, 241);
            this.lbl_Euro.Name = "lbl_Euro";
            this.lbl_Euro.Size = new System.Drawing.Size(19, 20);
            this.lbl_Euro.TabIndex = 18;
            this.lbl_Euro.Text = "€";
            // 
            // picCoins
            // 
            this.picCoins.Image = ((System.Drawing.Image)(resources.GetObject("picCoins.Image")));
            this.picCoins.Location = new System.Drawing.Point(460, 92);
            this.picCoins.Name = "picCoins";
            this.picCoins.Size = new System.Drawing.Size(236, 361);
            this.picCoins.TabIndex = 17;
            this.picCoins.TabStop = false;
            // 
            // grp_Function
            // 
            this.grp_Function.Controls.Add(this.rad_Adj);
            this.grp_Function.Controls.Add(this.rad_Add);
            this.grp_Function.Controls.Add(this.rad_Del);
            this.grp_Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Function.Location = new System.Drawing.Point(41, 40);
            this.grp_Function.Name = "grp_Function";
            this.grp_Function.Size = new System.Drawing.Size(333, 51);
            this.grp_Function.TabIndex = 16;
            this.grp_Function.TabStop = false;
            this.grp_Function.Text = "Function";
            // 
            // rad_Adj
            // 
            this.rad_Adj.AutoSize = true;
            this.rad_Adj.Location = new System.Drawing.Point(134, 21);
            this.rad_Adj.Name = "rad_Adj";
            this.rad_Adj.Size = new System.Drawing.Size(72, 24);
            this.rad_Adj.TabIndex = 9;
            this.rad_Adj.TabStop = true;
            this.rad_Adj.Text = "Adjust";
            this.rad_Adj.UseVisualStyleBackColor = true;
            this.rad_Adj.CheckedChanged += new System.EventHandler(this.rad_Adj_CheckedChanged);
            // 
            // rad_Add
            // 
            this.rad_Add.AutoSize = true;
            this.rad_Add.Location = new System.Drawing.Point(49, 21);
            this.rad_Add.Name = "rad_Add";
            this.rad_Add.Size = new System.Drawing.Size(56, 24);
            this.rad_Add.TabIndex = 13;
            this.rad_Add.TabStop = true;
            this.rad_Add.Text = "Add";
            this.rad_Add.UseVisualStyleBackColor = true;
            this.rad_Add.CheckedChanged += new System.EventHandler(this.rad_Add_CheckedChanged);
            // 
            // rad_Del
            // 
            this.rad_Del.AutoSize = true;
            this.rad_Del.Location = new System.Drawing.Point(240, 21);
            this.rad_Del.Name = "rad_Del";
            this.rad_Del.Size = new System.Drawing.Size(74, 24);
            this.rad_Del.TabIndex = 10;
            this.rad_Del.TabStop = true;
            this.rad_Del.Text = "Delete";
            this.rad_Del.UseVisualStyleBackColor = true;
            this.rad_Del.CheckedChanged += new System.EventHandler(this.rad_Del_CheckedChanged);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Type.Location = new System.Drawing.Point(137, 117);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(138, 25);
            this.lbl_Type.TabIndex = 15;
            this.lbl_Type.Text = "ADD A RATE";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(142, 418);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 35);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(142, 418);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(102, 35);
            this.btn_Del.TabIndex = 12;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Adjust
            // 
            this.btn_Adjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adjust.Location = new System.Drawing.Point(142, 418);
            this.btn_Adjust.Name = "btn_Adjust";
            this.btn_Adjust.Size = new System.Drawing.Size(102, 35);
            this.btn_Adjust.TabIndex = 11;
            this.btn_Adjust.Text = "Adjust";
            this.btn_Adjust.UseVisualStyleBackColor = true;
            this.btn_Adjust.Click += new System.EventHandler(this.btn_Adjust_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(658, 32);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 10;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
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
            this.listCarsToolStripMenuItem});
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
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.amendCustomerToolStripMenuItem,
            this.listCustomersToolStripMenuItem});
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
            // frmAdjustRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 602);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.grpAdj);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdjustRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rates";
            this.Load += new System.EventHandler(this.frmAdjustRates_Load);
            this.grpAdj.ResumeLayout(false);
            this.grpAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).EndInit();
            this.grp_Function.ResumeLayout(false);
            this.grp_Function.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.ComboBox cbo_Class;
        private System.Windows.Forms.Label lbl_AdjRate;
        private System.Windows.Forms.Label lbl_AdjLate;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.TextBox txt_LateFee;
        private System.Windows.Forms.Label lbl_AdjDesc;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.GroupBox grpAdj;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Adjust;
        private System.Windows.Forms.RadioButton rad_Del;
        private System.Windows.Forms.RadioButton rad_Adj;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.RadioButton rad_Add;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.GroupBox grp_Function;
        private System.Windows.Forms.PictureBox picCoins;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carSysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Per;
        private System.Windows.Forms.Label lbl_Euro;
    }
}