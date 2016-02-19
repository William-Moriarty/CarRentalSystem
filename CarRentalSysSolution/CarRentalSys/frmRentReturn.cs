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
    public partial class frmRentReturn : Form
    {
        String strSQL = "SELECT Rent_Id, R.Cust_Id, C.Forename, C.Surname, RegNo, Date_From, Date_Due, Cost, Is_Late FROM CUSTOMERS C, RENTALS R WHERE C.Cust_Id= R.Cust_Id AND RETURNED = 'N' ORDER BY Rent_Id";
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";
        String strRentID, strCustID, strName, strCar, strMake, strModel, strDueDate, strDateFrom, strRate, strLateFee,strReg;

        Boolean isLate = false;

        int daysLate, daysOut;

        public frmRentReturn()
        {
            InitializeComponent();
        }

        private void frmReturnCar_Load(object sender, EventArgs e)
        {
           
            txt_RentId.Enabled = false;
            returnConnection();
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        private void returnConnection()
        {
            //Execute query
            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "SS");
         
                grd_Rentals.DataSource = ds.Tables["SS"];
                
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            columnWidth();

        }

        private void btn_AddCarConfirm_Click(object sender, EventArgs e)
        {
            //validate input
            if (!validateCondition() || !validateRentID())
            {
                return;
            }
            else
                if (MessageBox.Show("Are you sure you wish to Return this Car?", "Return Car", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //save car details in car file
                    updateRentals();
                    setRentalOut();

                    //display confirmation message
                    MessageBox.Show("Return is recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset UI
                    txt_RentId.Text = "";
                    txtCondition.Text = "";
                    dtp_Return.Value = System.DateTime.Now;
                    txtCondition.Focus();

                }
            
            
        }

        private double finalCost()
        {

            double finalCost = 0.0;

            double rate = Convert.ToDouble(strRate);
            double lateFee = Convert.ToDouble(strLateFee);
            double supCost = rate * daysOut;

            if (isLate == true)
            {
                finalCost = (supCost) + ((supCost/100) * lateFee);

            }
            else
            {
                finalCost = supCost;

            }
            return finalCost;
        }

        private void updateRentals()
        {
         
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "UPDATE Rentals SET Date_Returned = '" + String.Format("{0:dd-MMM-yy}", dtp_Return.Value) + "', Cost = " + txtCost.Text + ", Condition_On_Return  = '" + txtCondition.Text.ToUpper() + "', Returned = 'Y' WHERE Rent_Id = '" + txt_RentId.Text + "'";

            cmd.CommandText = strSQL;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            returnConnection();
        }

        private void setRentalOut()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "UPDATE CUSTOMERS SET Rental_Out = 'N' WHERE CUST_ID = " + txtCustID2.Text;
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //  conn.Close();
        }

        private void findCarMake()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "SELECT MAKE, MODEL FROM CARS WHERE RegNo = '" + strReg + "'";
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                strCar = strMake + strModel;
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    strMake = dr.GetValue(0).ToString();
                    strModel = dr.GetValue(1).ToString();
                }
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //  conn.Close();
        }

        private String findClass(String strReg)
        {
            String strRegNo = "";

            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "SELECT CLASS FROM CARS WHERE RegNo = '" + strReg + "'";
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
               strRegNo = dr.GetValue(0).ToString();   
                }
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return strRegNo;
        }

        private void findRates(String strClass)
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "SELECT RATE_PER_DAY, LATE_FEE_RATE FROM RATES WHERE Class = '" + strClass + "'";
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    strRate = dr.GetValue(0).ToString();
                    strLateFee = dr.GetValue(1).ToString();
                }
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void grd_Rentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String strClass = findClass(grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[4].Value.ToString());
            findRates(strClass);
            //MessageBox.Show(strRate, strLateFee);

            txt_Start.Text = strRate;
            


            lbl_DateSince.Visible = true;
            lbl_Out.Visible = true;
            lbl_Days.Visible = true;
            lbl_Since.Visible = true;

            lbl_DateSince.Text = grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[5].Value.ToString().Substring(0, 10);

            strReg = grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[4].Value.ToString();
            findCarMake();
            strCar = strReg + " ( " + strMake + " " + strModel + ")";

            strRentID = grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[0].Value.ToString();
            strCustID = grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[1].Value.ToString();

            strDateFrom = String.Format("{0:MM/dd/yy}",grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[5].Value.ToString());
            DateTime frmAsTime = Convert.ToDateTime(strDateFrom);

            strDueDate = String.Format("{0:MM/dd/yy}", grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[6].Value.ToString());
            DateTime dueAsTime = Convert.ToDateTime(strDueDate);
            
            daysLate = (int)(DateTime.Now - dueAsTime).TotalDays;
            daysOut = (int)(DateTime.Now - frmAsTime).TotalDays;

            
            lbl_Days.Text = daysOut.ToString();

            txt_RentId.Text = strRentID;
            txtCustID2.Text = strCustID;

            strName = grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[2].Value.ToString() + " " + grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtName.Text = strName;

            txtCar.Text = strCar;

            if ((grd_Rentals.Rows[grd_Rentals.CurrentCell.RowIndex].Cells[8].Value.ToString()).Equals("Y"))
            {
                isLate = true;
                txtDaysLate.Text = daysLate.ToString();
                txtPen.Text = strLateFee;
                //MessageBox.Show("Yup");
            }
            else
            {
                isLate = false;
                txtDaysLate.Text = "0";
                txtPen.Text = "0";
                //MessageBox.Show("Nope");
            }


            txtCost.Text = string.Format(String.Format("{0:0.00}", finalCost()));
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            if (validateReg())//Validate
            {
                return;
            }
            else

            strSQL = "SELECT Rent_Id, R.Cust_Id, C.Forename, C.Surname, RegNo, Date_From, Date_Due, Cost, Is_Late FROM CUSTOMERS C, RENTALS R";

            //RENT ID
            strSQL = setRentID(strSQL);

            //SET CUST ID
            strSQL = setCustID(strSQL);

            //SET FORENAME
            strSQL = setForename(strSQL);

            //SET SURNAME
            strSQL = setSurname(strSQL);

            //SET REG
            strSQL = setReg(strSQL);

            //CHECK DATE FROM
            strSQL = setDateFrom(strSQL);

            //CHECK DATE DUE
            strSQL = setDateDue(strSQL);

            //Making sure the rentals are NOT returned
            strSQL = setReturned(strSQL);

            //CHECKS JOIN
            strSQL = setJoin(strSQL);

            //SET ORDER
            strSQL = setOrder(strSQL);

            returnConnection();

            if (grd_Rentals.Rows[0].Cells[0].Value == null)
            {
                strSQL = "SELECT Rent_Id, R.Cust_Id, C.Forename, C.Surname, RegNo, Date_From, Date_Due, Cost, Is_Late FROM CUSTOMERS C, RENTALS R WHERE C.Cust_Id= R.Cust_Id AND RETURNED = 'N' ORDER BY Rent_Id";
                MessageBox.Show("No Records found!");
                returnConnection();
            }
        }



        private String setRentID(String query)
        {

            if (!txt_RentIdSrch.Text.Equals(""))
            {
                query = query + " WHERE Rent_Id = " + txt_RentIdSrch.Text + "";
            }
            return query;
        }

        private String setCustID(String query)
        {
            if (!txt_CustID.Text.Equals(""))
            {
                if (txt_RentIdSrch.Text.Equals(""))

                    query = query + " WHERE R.Cust_Id = " + txt_CustID.Text + "";
                else
                    query = query + " AND R.Cust_Id = " + txt_CustID.Text + "";
            }
            return query;
        }

        private String setForename(String query)
        {
            if(!txt_Forename.Text.Equals(""))
            {
                if(txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals(""))

                    query = query + " WHERE C.Forename = '" + txt_Forename.Text.ToUpper() + "'";
                else
                query = query + " AND C.Forename = '" + txt_Forename.Text.ToUpper() + "'";

            }
            return query;
        }

        private String setSurname(String query)
        {
            if (!txt_Surname.Text.Equals(""))
            {
                if (txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals("") && txt_Forename.Text.Equals(""))

                    query = query + " WHERE C.Surname = '" + txt_Surname.Text.ToUpper() + "'";
                else
                    query = query + " AND C.Surname = '" + txt_Surname.Text.ToUpper() + "'";

            }
            return query;
        }

        private String setReg(String query)
        {
            String strRegNo = cbo_RegYear.Text + "-" + cbo_RegCounty.Text + "-" + txt_RegSerial.Text;

            if (!txt_RegSerial.Text.Equals("") && !cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals(""))
            {

                if (txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))

                query = query + " WHERE RegNo = '" + strRegNo + "'";

                else
                    query = query + " AND RegNo = '" + strRegNo + "'";
            }

            return query;
        }

        private String setDateFrom(String query)
        {
            if (!dtp_From.Checked == false)
            {
                if (txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))

                    query = query + " WHERE Date_From = '" + String.Format("{0:dd-MMM-yy}", dtp_From.Value) + "'";
                else
                    query = query + " AND Date_From = '" + String.Format("{0:dd-MMM-yy}", dtp_From.Value) + "'";
            }
            return query;
        }


        private String setDateDue(String query)
        {
            if (!dtp_Due.Checked == false)
            {
                if (txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))

                    query = query + " WHERE Date_Due = '" + String.Format("{0:dd-MMM-yy}", dtp_Due.Value) + "'";
                else
                    query = query + " AND Date_Due = '" + String.Format("{0:dd-MMM-yy}", dtp_Due.Value) + "'";
            }
            return query;
        }

        private String setReturned(String query)
        {
            if (txt_RentIdSrch.Text.Equals("") && txt_CustID.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && dtp_Due.Checked == false && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))
            {
                query = query + " WHERE Returned = 'N'";
            }
            else
                query = query + " AND Returned = 'N'";

            return query;

        }

        //JOINS THE TABLE
        private String setJoin(String query)
        {
            //if there is a WHERE clause already in the query
            if (query.Contains("WHERE"))
                query = query + " AND C.Cust_Id= R.Cust_Id";
            else
                query = query + " WHERE C.Cust_Id= R.Cust_Id";

            return query;

        }

        //SET ORDER
        private String setOrder(String query)
        {
            query = query + " ORDER BY Rent_Id";
            return query;
        }

        private Boolean validateReg()
        {
            //REGNO
            if ((!cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals("") && !txt_RegSerial.Text.Equals("")))
            {
                for (int i = 0; i < txt_RegSerial.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_RegSerial.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the Registration Serial field");
                        txt_RegSerial.Text = "";
                        txt_RegSerial.Focus();
                        return true;
                    }
                }
                return false;
            }
            else if ((cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && !txt_RegSerial.Text.Equals("")) ||
                   (cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals("") && txt_RegSerial.Text.Equals("")) ||
                   (cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals("") && !txt_RegSerial.Text.Equals("")) ||
                   (!cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && txt_RegSerial.Text.Equals("")) ||
                   (!cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && !txt_RegSerial.Text.Equals("")) ||
                   (!cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals("") && txt_RegSerial.Text.Equals("")))
            {

                MessageBox.Show("The Registration fields must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_RegYear.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean validateCondition()
        {

            if (!txtCondition.Text.Equals(""))
            {
                for (int i = 0; i < txtCondition.Text.Length; i++)
                {
                    if (char.IsNumber(txtCondition.Text[i]))
                    {
                        MessageBox.Show("Please enter only text for the Condition field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCondition.Text = "";
                        txtCondition.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        private Boolean validateRentID()
        {

            if (txt_RentId.Text.Equals(""))
            {
                MessageBox.Show("A Rental must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        private void columnWidth()
        {
            grd_Rentals.Columns[0].Width = 60;
            grd_Rentals.Columns[1].Width = 60;
            grd_Rentals.Columns[2].Width = 83;
            grd_Rentals.Columns[3].Width = 95;
            grd_Rentals.Columns[4].Width = 80;
            grd_Rentals.Columns[5].Width = 95;
            grd_Rentals.Columns[6].Width = 95;
            grd_Rentals.Columns[7].Width = 50;
            grd_Rentals.Columns[8].Width = 55;
          
        
        }

        private void btn_ResetSrch_Click(object sender, EventArgs e)
        {
            txt_RentIdSrch.Text = "";
            txt_CustID.Text = "";
            txt_Forename.Text = "";
            txt_Surname.Text = "";
            cbo_RegYear.SelectedIndex = 0;
            cbo_RegCounty.SelectedIndex = 0;
            txt_RegSerial.Text = "";
            dtp_From.Checked = false;
            dtp_Due.Checked = false;

            strSQL = "SELECT Rent_Id, R.Cust_Id, C.Forename, C.Surname, RegNo, Date_From, Date_Due, Cost, Is_Late FROM CUSTOMERS C, RENTALS R WHERE C.Cust_Id= R.Cust_Id AND RETURNED = 'N' ORDER BY Rent_Id";
        returnConnection();
        }

       
        /////////////////////////////MENU
        
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

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentalsList lisRent = new frmRentalsList();
            lisRent.Show();
            this.Close();
        }

        private void rentalAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentalAnalysis rentAnal = new frmRentalAnalysis();
            rentAnal.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software Engineering Project" +
                                         "\nCar Rental System Prototype\nSubmission Date: 20-APR-15\nAuthor: William Moriarty (t00119587)");
        }



       
    }
}
