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
using System.Text.RegularExpressions;

namespace CarRentalSys
{
    public partial class frmRentalsList : Form
    {

        //NB - THE COST FIELD IN THE SQL TABLE WAS ORIGINALLY CALLED RATE
        //I DID NOT RENAME TEXT BOXES ETC TO ACCOMADATE THIS (NO TIME)

        //INITIALIZES STRINGS
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";

        String strSQL = "Select Rent_Id, R.Cust_Id, Forename, Surname, Phone_No, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Is_Late, Condition_On_Return from RENTALS R, Customers C WHERE R.Cust_Id = C.Cust_Id ORDER BY Rent_Id";

        string emRegex = @"^(\$|)([1-9]\d{0,2}(\,\d{3})*|([1-9]\d*))(\.\d{2})?$";
        public frmRentalsList()
        {
            InitializeComponent();
        }

        private void btn_HomeFrmListCusts_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        private void frmListRentals_Load(object sender, EventArgs e)
        {
            cbo_Order.SelectedIndex = 1;
            rad_All.Checked = true;
            rad_LateAll.Checked = true;
            dtp_From.Checked = false;
            dtp_Due.Checked = false;
            dtp_Returned.Checked = false;
            returnConnection();
        }

        private void returnConnection()
        {
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
                
                //if value from coloumn due date (formatted) is greater than date due
                //execute method

                 //OracleDataReader dr = cmd.ExecuteReader();
                // if (dr.Read())
                /// {

                     // txt_CustID2.Text = dr.GetValue(0).ToString();




                     //conn.Close();
                // }



                //updateIsLate();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            columnWidth();
        }

        //NOT USED - NO TIME - WANTED TO AUTOMATICALLY SEE IF A RENTAL WAS LATE
        private void updateIsLate()
        {

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "UPDATE Rentals SET Is_Late = 'Y'";

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

        //BUTTON USED FOR OPTIMIZED QUERIES

        private void btn_Search_Click(object sender, EventArgs e)
        {
           if (!validateRentId() || validateReg() || !validateForename() ||!validateSurname() || !validateCustId() || !validateRate())
            {
                return;
            }
            else
            strSQL = "Select Rent_Id, R.Cust_Id, Forename, Surname, Phone_No, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Is_Late, Condition_On_Return from RENTALS R, Customers C";

            //check rent id
            strSQL = setRentId(strSQL);
            //check reg no
            strSQL = setRegNo(strSQL);
            //check rate
            //check cust id
            strSQL = setCustId(strSQL);
            //check date from
            strSQL = setDateFrom(strSQL);
            //check date due
            strSQL = setDateDue(strSQL);
            //check date returned
            strSQL = setDateReturned(strSQL);
            //check forename
            strSQL = setForename(strSQL);
            //check surname
            strSQL = setSurname(strSQL);
            //check cost
            strSQL = setCost(strSQL);
            //check IF returned
            strSQL = setReturn(strSQL);
            //check IF late
            strSQL = setLate(strSQL);
            //setting the join for rentals and customer table
            strSQL = setJoin(strSQL);
            //check order
            strSQL = setOrder(strSQL);

            

            returnConnection();

            if (grd_Rentals.Rows[0].Cells[0].Value == null)
            {
                strSQL = "Select Rent_Id, R.Cust_Id, Forename, Surname, Phone_No, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Is_Late, Condition_On_Return from RENTALS R, Customers C WHERE R.Cust_Id = C.Cust_Id ORDER BY Rent_Id";
                MessageBox.Show("No Records found!");
                returnConnection();
            }
        }

        //METHODS USED FOR SETTING SQL STRINGS FOR QUERIES, NAME OF METHOD IS THE STRING THAT IS BEING SET

        private String setRentId(String query)
        {
            if (!txt_RentId.Text.Equals(""))
            {
                query = query + " WHERE Rent_ID = '" + txt_RentId.Text + "'";
            }
            return query;
        }

        private String setRegNo(String query)
        {
            String strRegNo = cbo_RegYear.Text + "-" + cbo_RegCounty.Text + "-" + txt_RegSerial.Text;

            if (!txt_RegSerial.Text.Equals("") && !cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals(""))
            {
                if (txt_RentId.Text.Equals(""))

                    query = query + " WHERE RegNo = '" + strRegNo + "'";
                else
                    query = query + " AND RegNo = '" + strRegNo + "'";
            }
            return query;
        }

        private String setCustId(String query)
        {
            if (!txt_CustId.Text.Equals(""))
            {
                if (txt_RentId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals(""))

                    query = query + " WHERE Cust_Id = " + txt_CustId.Text + "";
                else
                    query = query + " AND Cust_Id = " + txt_CustId.Text + "";
            }
            return query;
        }

        private String setDateFrom(String query)
        {
            if (!dtp_From.Checked == false)
            {
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals(""))

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
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false)

                    query = query + " WHERE Date_Due = '" + String.Format("{0:dd-MMM-yy}", dtp_Due.Value) + "'";
                else
                    query = query + " AND Date_Due = '" + String.Format("{0:dd-MMM-yy}", dtp_Due.Value) + "'";
            }
            return query;
        }

        private String setDateReturned(String query)
        {
            if (!dtp_Returned.Checked == false)
            {
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && dtp_Due.Checked == false)

                    query = query + " WHERE Date_Returned = '" + String.Format("{0:dd-MMM-yy}", dtp_Returned.Value) + "'";
                else
                    query = query + " AND Date_Returned = '" + String.Format("{0:dd-MMM-yy}", dtp_Returned.Value) + "'";
            }
            return query;
        }

        private String setForename(String query)
        {
            if (!txt_Forename.Text.Equals(""))
            {
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && dtp_Due.Checked == false && dtp_Returned.Checked == false)

                    query = query + " WHERE Forename = '" + txt_Forename.Text.ToUpper() + "'";
                else
                    query = query + " AND Forename = '" + txt_Forename.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setSurname(String query)
        {
            if (!txt_Surname.Text.Equals(""))
            {
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && dtp_Due.Checked == false && dtp_Returned.Checked == false && txt_Forename.Text.Equals(""))

                    query = query + " WHERE Surname = '" + txt_Surname.Text.ToUpper() + "'";
                else
                    query = query + " AND Surname = '" + txt_Surname.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setCost(String query)
        {
            if (!txt_Rate.Text.Equals(""))
            {
                if (txt_RentId.Text.Equals("") && txt_CustId.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && dtp_From.Checked == false && dtp_Due.Checked == false && dtp_Returned.Checked == false && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))

                    query = query + " WHERE Cost LIKE '%" + txt_Rate.Text + "%'";
                else
                    query = query + " AND Cost LIKE '%" + txt_Rate.Text + "%'";
            }
            return query;
        }

        private String setReturn(String query)
        {
            //if all cars required
            if (rad_All.Checked == true)
                return query;
            else
            {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Returned = '";
                else
                    query = query + " WHERE Returned = '";

                if (rad_No.Checked == true)
                    query = query + "N'";

                if (rad_Yes.Checked == true)
                    query = query + "Y'";


                return query;
            }
        }

        private String setLate(String query)
        {
            //if cars are late
            if (rad_LateAll.Checked == true)
                return query;
            else
            {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Is_Late = '";
                else
                    query = query + " WHERE Is_Late = '";

                if (rad_LateNo.Checked == true)
                    query = query + "N'";

                if (rad_LateYes.Checked == true)
                    query = query + "Y'";


                return query;
            }
        }


        private String setJoin(String query)
        {
            //if there is a WHERE clause already in the query
            if (query.Contains("WHERE"))
                query = query + " AND R.Cust_Id = C.Cust_Id";
            else
                query = query + " WHERE R.Cust_Id = C.Cust_Id";

            return query;

        }

        private String setOrder(String query)
        {

            if (!cbo_Order.Text.Equals(""))
            {
                query = query + " ORDER BY " + cbo_Order.Text + "";
            }

            return query;
        }



        
         ////////////////////////////

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

        private Boolean validateRentId()
        {
            //CUSTID 1
            if (!txt_RentId.Text.Equals(""))
            {
                for (int i = 0; i < txt_RentId.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_RentId.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the RENT ID field");
                        txt_RentId.Text = "";
                        txt_RentId.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }


        private Boolean validateCustId()
        {
            //CUSTID 1
            if (!txt_CustId.Text.Equals(""))
            {
                for (int i = 0; i < txt_CustId.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_CustId.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the CUST ID field");
                        txt_CustId.Text = "";
                        txt_CustId.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        //FORENAME
        private Boolean validateForename()
        {

            if (!txt_Forename.Text.Equals(""))
            {
                for (int i = 0; i < txt_Forename.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Forename.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the FORENAME field");
                        txt_Forename.Text = "";
                        txt_Forename.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }


        private Boolean validateSurname()
        {
            //SURNAME
            if (!txt_Surname.Text.Equals(""))
            {
                for (int i = 0; i < txt_Surname.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Surname.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the SURNAME field");
                        txt_Surname.Text = "";
                        txt_Surname.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        private Boolean validateRate()
        {
            Regex rateREGEX = new Regex(emRegex);
            if (!txt_Rate.Text.Equals(""))
            {
                if (!rateREGEX.IsMatch(txt_Rate.Text))
                {
                    MessageBox.Show("Please Input Valid Rate", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Rate.Focus();
                    txt_Rate.Text = "";
                    return false;

                    //REFERENCE - emRegex - http://regexlib.com/DisplayPatterns.aspx?cattabindex=2&categoryId=3&AspxAutoDetectCookieSupport=1
                }
                else
                    return true;
            }
            return true;
        }

        private void columnWidth()
        {
            grd_Rentals.Columns[0].Width = 60;
            grd_Rentals.Columns[1].Width = 60;
            grd_Rentals.Columns[2].Width = 73;
            grd_Rentals.Columns[3].Width = 80;
            grd_Rentals.Columns[4].Width = 85;
            grd_Rentals.Columns[5].Width = 80;
            grd_Rentals.Columns[6].Width = 75;
            grd_Rentals.Columns[7].Width = 70;
            grd_Rentals.Columns[8].Width = 105;
            grd_Rentals.Columns[9].Width = 60;
            grd_Rentals.Columns[10].Width = 70;
            grd_Rentals.Columns[11].Width = 60;
            grd_Rentals.Columns[12].Width = 150;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            strSQL = "Select Rent_Id, R.Cust_Id, Forename, Surname, Phone_No, RegNo, Date_From, Date_Due, Date_Returned, Cost, Returned, Is_Late, Condition_On_Return from RENTALS R, Customers C WHERE R.Cust_Id = C.Cust_Id ORDER BY Rent_Id";
            cbo_RegYear.SelectedIndex = 0;
            cbo_RegCounty.SelectedIndex = 0;
            txt_CustId.Text = "";
            txt_Forename.Text = "";
            txt_Rate.Text = "";
            txt_RegSerial.Text = "";
            txt_Surname.Text = "";
            txt_RentId.Text = "";
            cbo_Order.SelectedIndex = 1;
            rad_All.Checked = true;
            rad_LateAll.Checked = true;
            dtp_Due.Checked = false;
            dtp_From.Checked = false;
            dtp_Returned.Checked = false;
            returnConnection();
        }

       
       /////////////////////////////// MENU
    

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void amendCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCarAmend mendCar = new frmCarAmend();
            mendCar.Show();
            this.Close();
        }

        private void listCarsToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomerAdd addCus = new frmCustomerAdd();
            addCus.Show();
            this.Close();
        }

        private void amendCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void rentCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRentCar rentCar = new frmRentCar();
            rentCar.Show();
            this.Close();
        }

        private void returnCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRentReturn returnCar = new frmRentReturn();
            returnCar.Show();
            this.Close();
        }

        private void rentalAnalysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRentalAnalysis rentAnal = new frmRentalAnalysis();
            rentAnal.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software Engineering Project" +
                                         "\nCar Rental System Prototype\nSubmission Date: 20-APR-15\nAuthor: William Moriarty (t00119587)");
        }
    }
}