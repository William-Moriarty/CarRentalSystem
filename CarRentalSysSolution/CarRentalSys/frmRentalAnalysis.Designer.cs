namespace CarRentalSys
{
    partial class frmRentalAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentalAnalysis));
            this.btn_HomeFrmListCusts = new System.Windows.Forms.Button();
            this.grp_Income = new System.Windows.Forms.GroupBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cbo_MonTo = new System.Windows.Forms.ComboBox();
            this.cbo_MonFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Total_Income_Value = new System.Windows.Forms.Label();
            this.lbl_Avg_Income_Value = new System.Windows.Forms.Label();
            this.lbl_Top_Model_Value = new System.Windows.Forms.Label();
            this.lbl_Top_Make_Value = new System.Windows.Forms.Label();
            this.lblNumRentals = new System.Windows.Forms.Label();
            this.lbl_Total_Income = new System.Windows.Forms.Label();
            this.lbl_Avg_Income = new System.Windows.Forms.Label();
            this.lbl_Top_Model = new System.Windows.Forms.Label();
            this.lbl_Top_Make = new System.Windows.Forms.Label();
            this.lbl_Num_Rentals = new System.Windows.Forms.Label();
            this.btn_AnalyseRentals = new System.Windows.Forms.Button();
            this.lbl_MonTo = new System.Windows.Forms.Label();
            this.lblMonFrm = new System.Windows.Forms.Label();
            this.chrt_Income = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.listCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Income)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HomeFrmListCusts
            // 
            this.btn_HomeFrmListCusts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeFrmListCusts.Location = new System.Drawing.Point(658, 32);
            this.btn_HomeFrmListCusts.Name = "btn_HomeFrmListCusts";
            this.btn_HomeFrmListCusts.Size = new System.Drawing.Size(75, 23);
            this.btn_HomeFrmListCusts.TabIndex = 4;
            this.btn_HomeFrmListCusts.Text = "Home";
            this.btn_HomeFrmListCusts.UseVisualStyleBackColor = true;
            this.btn_HomeFrmListCusts.Click += new System.EventHandler(this.btn_HomeFrmListCusts_Click);
            // 
            // grp_Income
            // 
            this.grp_Income.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grp_Income.Controls.Add(this.cboYears);
            this.grp_Income.Controls.Add(this.cbo_MonTo);
            this.grp_Income.Controls.Add(this.cbo_MonFrom);
            this.grp_Income.Controls.Add(this.label1);
            this.grp_Income.Controls.Add(this.lbl_Total_Income_Value);
            this.grp_Income.Controls.Add(this.lbl_Avg_Income_Value);
            this.grp_Income.Controls.Add(this.lbl_Top_Model_Value);
            this.grp_Income.Controls.Add(this.lbl_Top_Make_Value);
            this.grp_Income.Controls.Add(this.lblNumRentals);
            this.grp_Income.Controls.Add(this.lbl_Total_Income);
            this.grp_Income.Controls.Add(this.lbl_Avg_Income);
            this.grp_Income.Controls.Add(this.lbl_Top_Model);
            this.grp_Income.Controls.Add(this.lbl_Top_Make);
            this.grp_Income.Controls.Add(this.lbl_Num_Rentals);
            this.grp_Income.Controls.Add(this.btn_AnalyseRentals);
            this.grp_Income.Controls.Add(this.lbl_MonTo);
            this.grp_Income.Controls.Add(this.lblMonFrm);
            this.grp_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Income.Location = new System.Drawing.Point(12, 59);
            this.grp_Income.Name = "grp_Income";
            this.grp_Income.Size = new System.Drawing.Size(721, 176);
            this.grp_Income.TabIndex = 5;
            this.grp_Income.TabStop = false;
            this.grp_Income.Text = "Rental Analysis";
            // 
            // cboYears
            // 
            this.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Items.AddRange(new object[] {
            "2015",
            "2014",
            "2013",
            "2012",
            "2011"});
            this.cboYears.Location = new System.Drawing.Point(133, 107);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 23);
            this.cboYears.TabIndex = 25;
            // 
            // cbo_MonTo
            // 
            this.cbo_MonTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MonTo.FormattingEnabled = true;
            this.cbo_MonTo.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cbo_MonTo.Location = new System.Drawing.Point(133, 75);
            this.cbo_MonTo.Name = "cbo_MonTo";
            this.cbo_MonTo.Size = new System.Drawing.Size(121, 23);
            this.cbo_MonTo.TabIndex = 24;
            // 
            // cbo_MonFrom
            // 
            this.cbo_MonFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MonFrom.FormattingEnabled = true;
            this.cbo_MonFrom.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cbo_MonFrom.Location = new System.Drawing.Point(133, 43);
            this.cbo_MonFrom.Name = "cbo_MonFrom";
            this.cbo_MonFrom.Size = new System.Drawing.Size(121, 23);
            this.cbo_MonFrom.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Year";
            // 
            // lbl_Total_Income_Value
            // 
            this.lbl_Total_Income_Value.AutoSize = true;
            this.lbl_Total_Income_Value.Location = new System.Drawing.Point(523, 140);
            this.lbl_Total_Income_Value.Name = "lbl_Total_Income_Value";
            this.lbl_Total_Income_Value.Size = new System.Drawing.Size(30, 15);
            this.lbl_Total_Income_Value.TabIndex = 21;
            this.lbl_Total_Income_Value.Text = "Test";
            // 
            // lbl_Avg_Income_Value
            // 
            this.lbl_Avg_Income_Value.AutoSize = true;
            this.lbl_Avg_Income_Value.Location = new System.Drawing.Point(523, 115);
            this.lbl_Avg_Income_Value.Name = "lbl_Avg_Income_Value";
            this.lbl_Avg_Income_Value.Size = new System.Drawing.Size(30, 15);
            this.lbl_Avg_Income_Value.TabIndex = 20;
            this.lbl_Avg_Income_Value.Text = "Test";
            // 
            // lbl_Top_Model_Value
            // 
            this.lbl_Top_Model_Value.AutoSize = true;
            this.lbl_Top_Model_Value.Location = new System.Drawing.Point(523, 92);
            this.lbl_Top_Model_Value.Name = "lbl_Top_Model_Value";
            this.lbl_Top_Model_Value.Size = new System.Drawing.Size(30, 15);
            this.lbl_Top_Model_Value.TabIndex = 19;
            this.lbl_Top_Model_Value.Text = "Test";
            // 
            // lbl_Top_Make_Value
            // 
            this.lbl_Top_Make_Value.AutoSize = true;
            this.lbl_Top_Make_Value.Location = new System.Drawing.Point(523, 65);
            this.lbl_Top_Make_Value.Name = "lbl_Top_Make_Value";
            this.lbl_Top_Make_Value.Size = new System.Drawing.Size(30, 15);
            this.lbl_Top_Make_Value.TabIndex = 18;
            this.lbl_Top_Make_Value.Text = "Test";
            // 
            // lblNumRentals
            // 
            this.lblNumRentals.AutoSize = true;
            this.lblNumRentals.Location = new System.Drawing.Point(523, 43);
            this.lblNumRentals.Name = "lblNumRentals";
            this.lblNumRentals.Size = new System.Drawing.Size(30, 15);
            this.lblNumRentals.TabIndex = 16;
            this.lblNumRentals.Text = "Test";
            // 
            // lbl_Total_Income
            // 
            this.lbl_Total_Income.AutoSize = true;
            this.lbl_Total_Income.Location = new System.Drawing.Point(400, 140);
            this.lbl_Total_Income.Name = "lbl_Total_Income";
            this.lbl_Total_Income.Size = new System.Drawing.Size(81, 15);
            this.lbl_Total_Income.TabIndex = 15;
            this.lbl_Total_Income.Text = "Total Income:";
            // 
            // lbl_Avg_Income
            // 
            this.lbl_Avg_Income.AutoSize = true;
            this.lbl_Avg_Income.Location = new System.Drawing.Point(384, 115);
            this.lbl_Avg_Income.Name = "lbl_Avg_Income";
            this.lbl_Avg_Income.Size = new System.Drawing.Size(98, 15);
            this.lbl_Avg_Income.TabIndex = 14;
            this.lbl_Avg_Income.Text = "Average Income:";
            // 
            // lbl_Top_Model
            // 
            this.lbl_Top_Model.AutoSize = true;
            this.lbl_Top_Model.Location = new System.Drawing.Point(375, 92);
            this.lbl_Top_Model.Name = "lbl_Top_Model";
            this.lbl_Top_Model.Size = new System.Drawing.Size(108, 15);
            this.lbl_Top_Model.TabIndex = 13;
            this.lbl_Top_Model.Text = "Top Rental Model:";
            // 
            // lbl_Top_Make
            // 
            this.lbl_Top_Make.AutoSize = true;
            this.lbl_Top_Make.Location = new System.Drawing.Point(378, 66);
            this.lbl_Top_Make.Name = "lbl_Top_Make";
            this.lbl_Top_Make.Size = new System.Drawing.Size(106, 15);
            this.lbl_Top_Make.TabIndex = 12;
            this.lbl_Top_Make.Text = "Top Rental Brand:";
            // 
            // lbl_Num_Rentals
            // 
            this.lbl_Num_Rentals.AutoSize = true;
            this.lbl_Num_Rentals.Location = new System.Drawing.Point(372, 43);
            this.lbl_Num_Rentals.Name = "lbl_Num_Rentals";
            this.lbl_Num_Rentals.Size = new System.Drawing.Size(113, 15);
            this.lbl_Num_Rentals.TabIndex = 11;
            this.lbl_Num_Rentals.Text = "Number of Rentals:";
            // 
            // btn_AnalyseRentals
            // 
            this.btn_AnalyseRentals.Location = new System.Drawing.Point(178, 134);
            this.btn_AnalyseRentals.Name = "btn_AnalyseRentals";
            this.btn_AnalyseRentals.Size = new System.Drawing.Size(76, 30);
            this.btn_AnalyseRentals.TabIndex = 9;
            this.btn_AnalyseRentals.Text = "Analyse";
            this.btn_AnalyseRentals.UseVisualStyleBackColor = true;
            this.btn_AnalyseRentals.Click += new System.EventHandler(this.btn_AnalyseRentals_Click);
            // 
            // lbl_MonTo
            // 
            this.lbl_MonTo.AutoSize = true;
            this.lbl_MonTo.Location = new System.Drawing.Point(63, 82);
            this.lbl_MonTo.Name = "lbl_MonTo";
            this.lbl_MonTo.Size = new System.Drawing.Size(59, 15);
            this.lbl_MonTo.TabIndex = 5;
            this.lbl_MonTo.Text = "Month To";
            // 
            // lblMonFrm
            // 
            this.lblMonFrm.AutoSize = true;
            this.lblMonFrm.Location = new System.Drawing.Point(50, 47);
            this.lblMonFrm.Name = "lblMonFrm";
            this.lblMonFrm.Size = new System.Drawing.Size(74, 15);
            this.lblMonFrm.TabIndex = 4;
            this.lblMonFrm.Text = "Month From";
            // 
            // chrt_Income
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_Income.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_Income.Legends.Add(legend1);
            this.chrt_Income.Location = new System.Drawing.Point(13, 252);
            this.chrt_Income.Name = "chrt_Income";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chrt_Income.Series.Add(series1);
            this.chrt_Income.Size = new System.Drawing.Size(720, 338);
            this.chrt_Income.TabIndex = 13;
            this.chrt_Income.Text = "Income";
            title1.Name = "asdasdasd";
            this.chrt_Income.Titles.Add(title1);
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
            this.listRentalsToolStripMenuItem});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // rentCarToolStripMenuItem
            // 
            this.rentCarToolStripMenuItem.Name = "rentCarToolStripMenuItem";
            this.rentCarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rentCarToolStripMenuItem.Text = "Rent Car";
            this.rentCarToolStripMenuItem.Click += new System.EventHandler(this.rentCarToolStripMenuItem_Click);
            // 
            // returnCarToolStripMenuItem
            // 
            this.returnCarToolStripMenuItem.Name = "returnCarToolStripMenuItem";
            this.returnCarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.returnCarToolStripMenuItem.Text = "Return Car";
            this.returnCarToolStripMenuItem.Click += new System.EventHandler(this.returnCarToolStripMenuItem_Click);
            // 
            // listRentalsToolStripMenuItem
            // 
            this.listRentalsToolStripMenuItem.Name = "listRentalsToolStripMenuItem";
            this.listRentalsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.listRentalsToolStripMenuItem.Text = "List Rentals";
            this.listRentalsToolStripMenuItem.Click += new System.EventHandler(this.listRentalsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmRentalAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 602);
            this.Controls.Add(this.chrt_Income);
            this.Controls.Add(this.grp_Income);
            this.Controls.Add(this.btn_HomeFrmListCusts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRentalAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Analysis";
            this.Load += new System.EventHandler(this.frmRentalAnalysis_Load);
            this.grp_Income.ResumeLayout(false);
            this.grp_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_Income)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HomeFrmListCusts;
        private System.Windows.Forms.GroupBox grp_Income;
        private System.Windows.Forms.Label lbl_MonTo;
        private System.Windows.Forms.Label lblMonFrm;
        private System.Windows.Forms.Button btn_AnalyseRentals;
        private System.Windows.Forms.Label lbl_Top_Make;
        private System.Windows.Forms.Label lbl_Num_Rentals;
        private System.Windows.Forms.Label lbl_Total_Income;
        private System.Windows.Forms.Label lbl_Avg_Income;
        private System.Windows.Forms.Label lbl_Top_Model;
        private System.Windows.Forms.Label lblNumRentals;
        private System.Windows.Forms.Label lbl_Top_Make_Value;
        private System.Windows.Forms.Label lbl_Top_Model_Value;
        private System.Windows.Forms.Label lbl_Avg_Income_Value;
        private System.Windows.Forms.Label lbl_Total_Income_Value;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_Income;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.ComboBox cbo_MonTo;
        private System.Windows.Forms.ComboBox cbo_MonFrom;
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
        private System.Windows.Forms.ToolStripMenuItem listCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}