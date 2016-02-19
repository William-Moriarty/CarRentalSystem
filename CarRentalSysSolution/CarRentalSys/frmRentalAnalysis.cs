using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace CarRentalSys
{
    public partial class frmRentalAnalysis : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";
        String strMonthName = "";
        int monthNum = 0;

        public frmRentalAnalysis()
        {
            InitializeComponent();
        }

        //LOAD
        private void frmRentalAnalysis_Load(object sender, EventArgs e)
        {
            monthNum = cbo_MonFrom.SelectedIndex = 0;
            cbo_MonFrom.SelectedIndex = 0;
            cbo_MonTo.SelectedIndex = 11;
            cboYears.SelectedIndex = 0;
            setLabelsFalse();
            line_chart_load();
        }

        private void btn_HomeFrmListCusts_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        //METHODS USED WHEN THE ANALYSE BUTTON IS CLICKED
        private void btn_AnalyseRentals_Click(object sender, EventArgs e)
        {
            if (!validateAnal())
            {
                return;
            }
            else
            setNumRentals();
            setMake();
            setModel();
            setAvgIncome();
            setTotalIncome();
            setLabelsTrue();

            line_chart_load();
        }

        //finds the number of rentals used between dates and sets them to a label to be viewed
        private void setNumRentals()
        {
            try
            {
                String strSQL = "SELECT COUNT(Rent_Id) AS Num_Rentals FROM Rentals WHERE Date_FROM BETWEEN '" + getStartMonth() + "' AND '" + getEndMonth() + "'";
                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                conn.Open();
                //decimal totalRents = (decimal)cmd.ExecuteScalar();
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                lblNumRentals.Text = dr.GetValue(0).ToString();
                lblNumRentals.Visible = true;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();
        }

        //finds the make that has been rented the most between two dates and sets them to a label to be viewed
        private void setMake()
        {
            try
            {
                String strSQL = "SELECT Make FROM CARS C,RENTALS R WHERE Rented = (SELECT MAX(Rented) FROM CARS) AND R.Date_FROM >= '" + getStartMonth() + "' AND R.Date_FROM <= '" + getEndMonth() + "'";

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();
                String topMake = (String)cmd.ExecuteScalar();
                lbl_Top_Make_Value.Text = topMake;
                lbl_Top_Make_Value.Visible = true;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();
        }

        //finds the model that has been rented the most between two dates and sets it to a label to be viewed
        private void setModel()
        {
            try
            {
                String strSQL = "SELECT Model FROM CARS C,RENTALS R WHERE Rented = (SELECT MAX(Rented) FROM CARS) AND R.Date_FROM >= '" + getStartMonth() + "' AND R.Date_FROM <= '" + getEndMonth() + "'";

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                String topModel = (String)cmd.ExecuteScalar();
                lbl_Top_Model_Value.Text = topModel;
                lbl_Top_Model_Value.Visible = true;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();
        }

        //finds the average income between two dates and sets them to a label to be viewed
        private void setAvgIncome()
        {
            try
            {
                String strSQL = "SELECT CAST(NVL(AVG(Cost),0) AS decimal(6,2)) FROM Rentals WHERE Date_FROM >= '" + getStartMonth() + "' AND Date_FROM <= '" + getEndMonth() + "'";

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                //must format the decimal to accept 2 decimal points
                //crahing if points are zero
                decimal avgRents = (decimal)cmd.ExecuteScalar();
                lbl_Avg_Income_Value.Text = avgRents.ToString();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();
        }

        //finds the total income between two dates and sets them to a label

        private void setTotalIncome()
        {
            try
            {

                String strSQL = "SELECT CAST(NVL(SUM(Cost),0) AS decimal(6,2)) AS Avg_Income FROM Rentals WHERE Date_FROM >= '" + getStartMonth() + "' AND Date_FROM <= '" + getEndMonth() + "'";

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();


                //must format the decimal to accept 2 decimal points
                decimal totRents = (decimal)cmd.ExecuteScalar();
                lbl_Total_Income_Value.Text = totRents.ToString();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();
        }
        //sets the labels to false
        void setLabelsFalse()
        {

            lblNumRentals.Visible = false;
            lbl_Top_Make_Value.Visible = false;
            lbl_Top_Model_Value.Visible = false;
            lbl_Avg_Income_Value.Visible = false;
            lbl_Total_Income_Value.Visible = false;
        }
        //sets the labels to true (used when analysed button is used
        void setLabelsTrue()
        {
            lblNumRentals.Visible = true;
            lbl_Top_Make_Value.Visible = true;
            lbl_Top_Model_Value.Visible = true;
            lbl_Avg_Income_Value.Visible = true;
            lbl_Total_Income_Value.Visible = true;
        }


        //GETS THE VALUES OF A MONTH
        public double getMonthVal(int month, String year)
        {
            double monthVal = 0.0;

            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "SELECT CAST(NVL(SUM(Cost),0) AS decimal(6,2)) FROM Rentals WHERE Date_FROM LIKE '%" + getMonthName(month) + "-" + year + "'";

                conn.Open();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                return monthVal = (Convert.ToDouble(dr.GetValue(0)));
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return monthVal;
        }


        //METHOD USED FOR LOADING A LINE CHART
        //ALSO BROKE MY HEART
        
        private void line_chart_load()
        {
            //REFRESHES LINE CHART EVERYTIME METHOD IS CALLED
            chrt_Income.Series[0].Points.Clear();

            //OBJECT USED TO FIND MONTH NAME
            System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();


            //REFERENCE - http://stackoverflow.com/questions/3184121/get-month-name-from-month-number

            for (int i = getMonthNo(getStartMonth().Substring(3, 3)); i <= getMonthNo(getEndMonth().Substring(3, 3)); i++)
            {

                strMonthName = mfi.GetAbbreviatedMonthName(i).ToString();

                chrt_Income.Series["Income"].Points.AddXY(strMonthName, getMonthVal(i, cboYears.Text.Substring(2, 2)));
            }
        }

        //GETS THE PREFIX TO A MONTH
        private String getStartMonth()
        {
            String startMonth = "01-" + cbo_MonFrom.Text + "-" + cboYears.Text.Substring(2, 2);
            return startMonth;
        }

        //GETS THE LAST DATE OF A MONTH DEPENDING ON NAME
        private String getEndMonth()
        {
            String days = "31-";

            switch (cbo_MonTo.Text)
            {
                case "SEP":
                case "APR":
                case "JUN":
                case "NOV":
                    days = "30-";
                    break;
                case "FEB":
                    days = "28-";
                    break;
                default:
                    break;
            }

            return days + cbo_MonTo.Text + "-" + cboYears.Text.Substring(2, 2);
        }

        //GETS THE INDEX OF A MONTH NAME
        private int getMonthNo(String month)
        {
            int mm = 0;

            switch (month)
            {
                case "JAN":
                    mm = 1;
                    break;
                case "FEB":
                    mm = 2;
                    break;
                case "MAR":
                    mm = 3;
                    break;
                case "APR":
                    mm = 4;
                    break;
                case "MAY":
                    mm = 5;
                    break;
                case "JUN":
                    mm = 6;
                    break;
                case "JUL":
                    mm = 7;
                    break;
                case "AUG":
                    mm = 8;
                    break;
                case "SEP":
                    mm = 9;
                    break;
                case "OCT":
                    mm = 10;
                    break;
                case "NOV":
                    mm = 11;
                    break;
                case "DEC":
                    mm = 12;
                    break;
                default:
                    break;
            }

            return mm;

        }

        private String getMonthName(int mm)
        {
            String month;

            switch (mm)
            {
                case 1:
                    month = "JAN";
                    break;
                case 2:
                    month = "FEB";
                    break;
                case 3:
                    month = "MAR";
                    break;
                case 4:
                    month = "APR";
                    break;
                case 5:
                    month = "MAY";
                    break;
                case 6:
                    month = "JUN";
                    break;
                case 7:
                    month = "JUL";
                    break;
                case 8:
                    month = "AUG";
                    break;
                case 9:
                    month = "SEP";
                    break;
                case 10:
                    month = "OCT";
                    break;
                case 11:
                    month = "NOV";
                    break;
                case 12:
                    month = "DEC";
                    break;
                default:
                    month = "DEC";
                    break;

            }
            return month;
        }


        private Boolean validateAnal()
        {
            if (cbo_MonFrom.SelectedIndex >= cbo_MonTo.SelectedIndex)
            {
            MessageBox.Show("Please select a month BEFORE " + cbo_MonTo.Text.ToString() + " in the Month From ComboBox","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
            }
            return true;
        }
      
        /////////////MENU 
       


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarAdd addCar = new frmCarAdd();
            addCar.Show();
            this.Close();
        }

        private void amendCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarAmend mendCar = new frmCarAmend();
            mendCar.Show();
            this.Close();
        }

        private void listCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarList lisCars = new frmCarList();
            lisCars.Show();
            this.Close();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminLogin login = new frmAdminLogin();
            login.Show();
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerAdd addCus = new frmCustomerAdd();
            addCus.Show();
            this.Close();
        }

        private void amendCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerAmend mendCus = new frmCustomerAmend();
            mendCus.Show();
            this.Close();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersList lisCus = new frmCustomersList();
            lisCus.Show();
            this.Close();
        }

        private void rentCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentCar rentCar = new frmRentCar();
            rentCar.Show();
            this.Close();
        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentReturn returnCar = new frmRentReturn();
            returnCar.Show();
            this.Close();
        }

        private void listRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentalsList lisRent = new frmRentalsList();
            lisRent.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software Engineering Project" +
                             "\nCar Rental System Prototype\nSubmission Date: 20-APR-15\nAuthor: William Moriarty (t00119587)");
        }

       


    }

}  

