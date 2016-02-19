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
    public partial class frmCustomerAmend : Form
    {
        //INITALIZING SQL STRINGS 
        string oradb = "Data Source=Oracle;User Id=t00119587;Password=vy784epg;";
        string strCustId = "";
        //since you can only amend customers that are avaliable and dont have a rental this is used to initialize the SQL grid
        String strSQL = "Select Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email from CUSTOMERS WHERE Status = 'A' AND RENTAL_OUT = 'N'";
        String strStreet="", strStreetNo="", strAllStreet = "";
 
        string emRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";


        public frmCustomerAmend()
        {
            InitializeComponent();
        }
        //LOAD FORM
        private void frmCustomerAmend_Load(object sender, EventArgs e)
        {
            //getSubStrings();
            
            radDeleteCust.Checked = true;
            btnUpd.Visible = true;
            txt_CustID2.Enabled = false;
            txt_Name.Enabled = false;
            returnConnection();
        }

        private void btn_HomeFrmAmendCust_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        //GETS SUBSTRING FOR STREET NUMBERS AND STREET NAMES
        private void getSubStrings()
        {
            //strAllStreet = "2313b EVERGREEN WOODEN STREET 5";
            int spaceCount = 0;

            for (int i = 0; i < strAllStreet.Length; i++)
            {
                if (char.IsNumber(strAllStreet[i]) || strAllStreet[i] == ' ')
                {
                    if (strAllStreet[i] == ' ')
                    {
                        spaceCount++;
                        if (spaceCount  == 1)
                        {
                        strStreetNo = strAllStreet.Substring(0, i);
                        strStreet = strAllStreet.Substring(i + 1);
                        }
                    }
                }
            }

           //MessageBox.Show(strStreetNo);
            //MessageBox.Show(strStreet);
        }


        //FILLS GRID
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

                grd_List_Cust.DataSource = ds.Tables["SS"];
                conn.Close();

                columnWidth();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //UPDATE BUTTON WHICH USES VALDATION METHODS AND UPDATE CUSTOMER MTHODE, including messages 
        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (!validateCustId2() || !validateStreetNo() || !validateStreet() || !validateTown() || !validatePhone() || !validateEmail() || !validateCounty())
            {
                return;
            }
            else
                if (MessageBox.Show("Are you sure you will update the customer?", "Add Car", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UpdateCustomers();
                    MessageBox.Show("Customer is updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();    
                }
                    
        }

        //BUTTON FOR DELETING USES A VALADTION METHOD AND DELETE CUSTOMER / RESET UI METHOD

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (validateCustId2()) //validates
            {
                if (MessageBox.Show("Are you sure you wish to delete this Customer?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteCustomers();//deletes customer
                    ResetUI();//resets UI
                }

            }
            else
            {
                return;
            }
        }

      


        //button used for reseting parameters for the update/del fields
        private void btn_upd_Res_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        //resets  UI

        private void ResetUI()
        {
            txt_CustID2.Text = "";
            txt_Name.Text = "";
            txt_Street.Text = "";
            txt_Town.Text = "";
            cbo_County.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            txtNo.Text = "";
            returnConnection();
        }

       //button used for the optimised SQL search

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (!validateForename() || !validateSurname() || !validateCustId())
            {
                return;
            }

            else
            {
                //must reset to this parameter each time
                strSQL = "Select Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email from CUSTOMERS";

                //check reg no
                strSQL = setCustId(strSQL);

                //check year
                strSQL = setForename(strSQL);

                //check Make
                strSQL = setSurname(strSQL);

                //Making sure status is "Available"
                strSQL = setStatus(strSQL);

                //Making sure rental_out is set to 'N'
                strSQL = setRentalOutForRent(strSQL);

                returnConnection();

                if (grd_List_Cust.Rows[0].Cells[0].Value == null)
                {
                    strSQL = "Select Cust_Id, Forename, Surname, Street, Town, County, Phone_No, Email from CUSTOMERS WHERE Status = 'A' AND RENTAL_OUT = 'N'";
                    MessageBox.Show("No Records found!");
                    returnConnection();
                }
            }
        }

        //gets customer ID and passes its details into text fields

        private void grd_List_Cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strCustId = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txt_CustID2.Text = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[1].Value.ToString() + grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[2].Value.ToString();
            strAllStreet = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[3].Value.ToString();
            getSubStrings();
            txtNo.Text = strStreetNo;
            txt_Street.Text = strStreet;
            txt_Town.Text = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[4].Value.ToString();
            cbo_County.SelectedText.Equals(grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[5].Value.ToString());
            txt_Email.Text = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txt_Phone.Text = grd_List_Cust.Rows[grd_List_Cust.CurrentCell.RowIndex].Cells[6].Value.ToString();
        }

      
        //UPDATE CUSTOMER METHOD
        private void UpdateCustomers()
        {
                String strWholeStreet = txtNo.Text + " " + txt_Street.Text;

                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                String strSQL = "UPDATE Customers SET Street = '" + strWholeStreet.ToUpper() + "', Town = '" + txt_Town.Text.ToUpper() + "', County = '" + cbo_County.Text.ToUpper() + "', Phone_No = '" + txt_Phone.Text + "', Email = '" + txt_Email.Text + "' WHERE Cust_ID = " + txt_CustID2.Text + "";

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

        //METHODS FOR USING OPTIMSED SEARCHES AND SETTING SQL STRINGS - THE NAME OF THE METHOD SETS THE PARAMETER

        private String setCustId(String query)
        {
            if (!txt_CustID.Text.Equals(""))
            {
                query = query + " WHERE Cust_Id = '" + txt_CustID.Text + "'";
            }
            return query;
        }

        private String setForename(String query)
        {
            if (!txt_Forename.Text.Equals(""))
            {
                if (txt_CustID.Text.Equals(""))

                    query = query + " WHERE Forename = '" + txt_Forename.Text.ToUpper() + "'";
                else
                    query = query + " AND Surname = '" + txt_Forename.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setSurname(String query)
        {
            if (!txt_Surname.Text.Equals(""))
            {
                if (txt_CustID.Text.Equals("") && txt_Forename.Text.Equals(""))
                {
                    query = query + " WHERE Surname = '" + txt_Surname.Text.ToUpper() + "'";
                }
                else               
                    query = query + " AND Surname = '" + txt_Surname.Text.ToUpper() + "'";
                
            }
            return query;
        }

        private String setStatus(String query)
        {
            if (txt_CustID.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))
            {
                query = query + " WHERE Status = 'A'";
            }
            else
                query = query + " AND Status = 'A'";

            return query;

        }

        //METHOD FOR DELETING CUSTOMERS

        private void DeleteCustomers()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "UPDATE Customers SET Status = 'D' WHERE CUST_ID = '" + txt_CustID2.Text + "'";

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
        }

        //makes sure the customer selected can only be when they DONT have a rental out
        private String setRentalOutForRent(String query)
        {

            //if there is a WHERE clause already in the query
            if (query.Contains("WHERE"))
                query = query + " AND Rental_Out = 'N'";
            else
                query = query + " WHERE Rental_Out = 'N'";

            return query;

        }

        //VALADATION

        private Boolean validateCustId2()
        {
            if (txt_CustID2.Text.Equals(""))
                 {
               
                        MessageBox.Show("A Customer MUST be selected!");
                        txt_CustID.Text = "";
                        txt_CustID.Focus();
                        return false;
                    
                }
            return true;
          
        }
        
         private Boolean validateCustId()
        {
            //CUSTID 1
            if (!txt_CustID.Text.Equals(""))
            {
                for (int i = 0; i < txt_CustID.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_CustID.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the CUST ID field");
                        txt_CustID.Text = "";
                        txt_CustID.Focus();
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

        private Boolean validateStreetNo()
        {
            //STREET NO
            if (!txtNo.Text.Equals(""))
            {
                for (int i = 0; i < txtNo.Text.Length; i++)
                {
                    if (!char.IsNumber(txtNo.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the STREET NO field");
                        txtNo.Text = "";
                        txtNo.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
            //Street No CAN be empty
        }

        private Boolean validateStreet()
        {
            //STREET
            if (!txt_Street.Text.Equals(""))
            {
                for (int i = 0; i < txt_Street.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Street.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the STREET field");
                        txt_Street.Text = "";
                        txt_Street.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The STREET field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Street.Focus();
                return false;
            }
        }

        private Boolean validateTown()
        {
            //TOWN
            if (!txt_Town.Text.Equals(""))
            {
                for (int i = 0; i < txt_Town.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Town.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the TOWN field");
                        txt_Town.Text = "";
                        txt_Town.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The TOWN field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Town.Focus();
                return false;
            }
        }

        private Boolean validateCounty()
        {
            //COUNTY
            if (!cbo_County.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("A County must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Town.Focus();
                return false;
            }
        }

        private Boolean validatePhone()
        {
            //PHONE
            if (!txt_Phone.Text.Equals(""))
            {
                for (int i = 0; i < txt_Phone.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_Phone.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the PHONE NO field");
                        txt_Phone.Text = "";
                        txt_Phone.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The PHONE NO field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Phone.Focus();
                return false;
            }
        }

        private Boolean validateEmail()
        {
            //EMAIL
            if (!txt_Email.Text.Equals(""))
            {
                Regex emailREGEX = new Regex(emRegex);

                if (!emailREGEX.IsMatch(txt_Email.Text))
                {
                    MessageBox.Show("Please Input Valid Email", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Email.Focus();
                    txt_Email.Text = "";
                    return false;

                    //REFERENCE - emRegex - http://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp
                }
                else
                    return true;
            }
            else
            {
                MessageBox.Show("The E-MAIL field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return false;
            }
        }


        //RAD BUTTON SETTING PARAMETERS ENABLED/DISABLED
        private void radUpdate_Click(object sender, EventArgs e)
        {
            txtNo.Enabled = true;
            txt_Street.Enabled = true;
            txt_Town.Enabled = true;
            cbo_County.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Email.Enabled = true;
            btnUpd.Visible = true;
            btnDel.Visible = false;
            btn_upd_Res.Enabled = true;
            txt_Street.Enabled = true;
            btn_upd_Res.Enabled = true;
        }

        private void radDelete_Click(object sender, EventArgs e)
        {
            txtNo.Enabled = false;
            txt_Street.Enabled = false;
            txt_Town.Enabled = false;
            cbo_County.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            btnUpd.Visible = false;
            btnDel.Visible = true;
            btn_upd_Res.Enabled = false;
        }

        //SETTING CUSTOMIZED COLUMNWIDTHS
        private void columnWidth()
        {

            grd_List_Cust.Columns[0].Width = 60;
            grd_List_Cust.Columns[1].Width = 75;
            grd_List_Cust.Columns[2].Width = 75;
            grd_List_Cust.Columns[3].Width = 120;
            grd_List_Cust.Columns[4].Width = 102;
            grd_List_Cust.Columns[5].Width = 70;
            grd_List_Cust.Columns[6].Width = 75;
            grd_List_Cust.Columns[7].Width = 100;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txt_CustID.Text = "";
            txt_Forename.Text = "";
            txt_Surname.Text = "";
            strSQL = "Select * from CUSTOMERS WHERE Status = 'A'";
            returnConnection();
        }

        

        ///////////////////////   MENU STRIP   ////////////////////////

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
