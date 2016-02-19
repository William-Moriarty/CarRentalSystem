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
    public partial class frmCustomersList : Form
    {
        //INTIALIZING SQL STRING
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";
        String strSQL = "Select * from CUSTOMERS";
        
        public String strCustId = "", strCustName = "", strForename = "", strSurname = "";

        public frmCustomersList()
        {
            InitializeComponent();
            
        }

        private void btn_HomeFrmListCusts_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }
        
        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            //grdCust.Columns[1].HeaderText = "Test";
            cbo_Order_By.SelectedIndex = 1;
            rad_All_Status.Checked = true;
            rad_All_Rent.Checked = true;
            returnConnection();
        }

        //THIS IS ANOTHER INSTANCE OF THE CLASS USED TO SEARCH FOR CUSTOMERS FOR THE RENT CAR FUNCTION
        //IT HAS DIFFERENT SETTINGS TO SEARCH FOR CUSTOMERS ONLY THAT DONT HAVE A RENTAL OUT ETC
        //BUTTONS HAVE BEEN DISABLED IN THIS INSTANCE
        public frmCustomersList(String parent)
        {
            strSQL = "Select * FROM CUSTOMERS WHERE status = 'A' AND Rental_Out = 'N'";
            InitializeComponent();
            setCustID(strCustId);

            

            btn_Srch4Rent.Enabled = true;
            btn_Srch4Rent.Visible = true;

            btn_Search.Enabled = false;
            btn_Search.Visible = false;
            btn_Sel.Visible = true;
            menuStrip1.Visible = false;

            grp_Status.Enabled = false;
            grp_Rent_Out.Enabled = false;
           
            btn_HomeFrmListCusts.Enabled = false;
            btn_HomeFrmListCusts.Visible = false;
            
           
        }

        //getting customer id and passing in into a string
        public void grd_ListCusts_Double_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strCustId = grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }


        //FILLS GRID
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

                grdCust.DataSource = ds.Tables["SS"];
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            columnWidth();

        }


        //BUTTON THAT USES METHOS FOR OPTIMIZED QUERIES
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (!validateCustID() || !validateForename() || !validateSurname())
            {

                return;
            }
            else
            //must reset to this parameter each time
            strSQL = "Select * from CUSTOMERS";

            //check cust id
            strSQL = setCustId(strSQL);

            //check forename
            strSQL = setForename(strSQL);

            //check surname
            strSQL = setSurname(strSQL);

            //check street
            strSQL = setStreet(strSQL);

            //check town
            strSQL = setTown(strSQL);

            //check county
            strSQL = setCounty(strSQL);

            //check date registered
            strSQL = setDateRegistered(strSQL);

            //check rental out
            strSQL = setRentalOut(strSQL);

            //check status
            strSQL = setStatus(strSQL);

            //check order by
            strSQL = setOrder(strSQL);

            returnConnection();

            if (grdCust.Rows[0].Cells[0].Value == null)
            {
                strSQL = "Select * from CUSTOMERS";
                MessageBox.Show("No Records found!");
                returnConnection();
            }

        }

        //THIS BUTTON IS DISBALED BUT ENABLED IN ANOTHER INSTANCE OF THE FORM THAT IS USED FOR THE RENT CARS FUNCTION
        //IT IS USED TO ENSURE THAT CUSTOMERS IN THE LIST DO NOT HAVE A RENTAL OUT

        private void btn_Srch4Rent_Click(object sender, EventArgs e)
        {
            if (!validateCustID() || !validateForename() || !validateSurname())
            {

                return;
            }
            else
                //must reset to this parameter each time
                strSQL = "Select * from CUSTOMERS";

            //check cust id
            strSQL = setCustId(strSQL);

            //check forename
            strSQL = setForename(strSQL);

            //check surname
            strSQL = setSurname(strSQL);

            //check street
            strSQL = setStreet(strSQL);

            //check town
            strSQL = setTown(strSQL);

            //check county
            strSQL = setCounty(strSQL);

            //check date registered
            strSQL = setDateRegistered(strSQL);

            //check rental out
            strSQL = setRentalOutForRent(strSQL);

            //check status
            strSQL = setStatusForRent(strSQL);

            //check order by
            strSQL = setOrder(strSQL);

            returnConnection();

            if (grdCust.Rows[0].Cells[0].Value == null)
            {
                strSQL = "Select * from CUSTOMERS WHERE STATUS = 'A' AND Rental_out = 'N'";
                MessageBox.Show("No Records found!");
                returnConnection();
            }
        }

        //FOLLOWING METHODS RETURN SQL STRING FOR OPTIMIZED SEARCHS, THE METHODS RETURN STRING DEPENDING ON THEIR NAMES

        private String setCustId(String query)
        {
            if (!txt_CustId.Text.Equals(""))
            {
                query = query + " WHERE Cust_ID = '" + txt_CustId.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setForename(String query)
        {
            if (!txt_Forename.Text.Equals(""))
            {
                if (txt_CustId.Text.Equals(""))

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
                if (txt_CustId.Text.Equals("") && txt_Forename.Text.Equals(""))

                    query = query + " WHERE Surname = '" + txt_Surname.Text.ToUpper() + "'";
                else
                    query = query + " AND Surname = '" + txt_Surname.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setStreet(String query)
        {
            if (!txt_Street.Text.Equals(""))
            {
                if (txt_CustId.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals(""))

                    query = query + " WHERE Street LIKE '%" + txt_Street.Text.ToUpper() + "%'";
                else
                    query = query + " AND Street = '%" + txt_Street.Text.ToUpper() + "%'";
            }
            return query;
        }

        private String setTown(String query)
        {
            if (!txt_Town.Text.Equals(""))
            {
                if (txt_CustId.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals("") && txt_Street.Text.Equals(""))

                    query = query + " WHERE Town = '" + txt_Town.Text.ToUpper() + "'";
                else
                    query = query + " AND Town = '" + txt_Town.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setCounty(String query)
        {
            if (!cbo_County.Text.Equals(""))
            {
                if (txt_CustId.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals("") && txt_Street.Text.Equals("") && txt_Town.Text.Equals(""))

                    query = query + " WHERE County = '" + cbo_County.Text.ToUpper() + "'";
                else
                    query = query + " AND County = '" + cbo_County.Text.ToUpper() + "'";
            }
            return query;
        }

        private String setDateRegistered(String query)
        {
            if (!dtp_DateReg.Checked == false)
            {
                if (txt_CustId.Text.Equals("") && txt_Forename.Text.Equals("") && txt_Surname.Text.Equals("") && txt_Street.Text.Equals("") && txt_Town.Text.Equals("") && cbo_County.Text.Equals(""))

                    query = query + " WHERE Date_Registered = '" + String.Format("{0:dd-MMM-yy}", dtp_DateReg.Value) + "'";
                else
                    query = query + " AND Date_Registered = '" + String.Format("{0:dd-MMM-yy}", dtp_DateReg.Value) + "'";
            }
            return query;
        }

        private String setRentalOut(String query)
        {
            if (rad_All_Rent.Checked == true)
                return query;

            else
            {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Rental_Out = '";
                else
                    query = query + " WHERE Rental_Out = '";

                if (rad_Yes.Checked == true)
                    query = query + "Y'";
                else if (rad_No.Checked == true)
                    query = query + "N'";

                return query;
            }
        }

        private String setRentalOutForRent(String query)
        {
           
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Rental_Out = 'N'";
                else
                    query = query + " WHERE Rental_Out = 'N'";

                return query;
            
        }
        
        private String setStatus(String query)
        {
            //if all cars required
            if (rad_All_Status.Checked == true)
                return query;
            else
            {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Status = '";
                else
                    query = query + " WHERE Status = '";

                if (rad_Active.Checked == true)
                    query = query + "A'";
                else if (rad_Del.Checked == true)
                    query = query + "D'";

                return query;
            }
        }

        private String setStatusForRent(String query)
        {
           
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Status = 'A'";
                else
                    query = query + " WHERE Status = 'A'";
                return query;       
        }

        private String setOrder(String query)
        {

            if (!cbo_Order_By.Text.Equals(""))
            {
                query = query + " ORDER BY " + cbo_Order_By.Text + "";
            }

            return query;
        }


        //VALDATION

        private Boolean validateCustID()
        {
            //REGNO
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
            if (!txt_Surname.Text.Equals(""))
            {
                for (int i = 0; i < txt_Surname.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Surname.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the FORENAME field");
                        txt_Surname.Text = "";
                        txt_Surname.Focus();
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
                strSQL = "SELECT * FROM CUSTOMERS";
                txt_CustId.Text = "";
                txt_Forename.Text = "";
                txt_Surname.Text = "";
                txt_Street.Text = "";
                txt_Town.Text = "";
                cbo_County.SelectedIndex = 0;
                cbo_Order_By.SelectedIndex = 1;
                rad_All_Status.Checked = true;
                rad_All_Rent.Checked = true;
                dtp_DateReg.Checked = false;
                returnConnection();
       }

        private void columnWidth()
        {
            grdCust.Columns[0].Width = 60;
            grdCust.Columns[1].Width = 75;
            grdCust.Columns[2].Width = 75;
            grdCust.Columns[3].Width = 120;
            grdCust.Columns[4].Width = 95;
            grdCust.Columns[5].Width = 70;
            grdCust.Columns[6].Width = 75;
            grdCust.Columns[7].Width = 100;
            grdCust.Columns[8].Width = 65;
            grdCust.Columns[9].Width = 65;
            grdCust.Columns[10].Width = 65;
            grdCust.Columns[11].Width = 118;
        }

        private void btn_Sel_Click(object sender, EventArgs e)
        {
            this.Hide();      
            strCustId = grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[0].Value.ToString();
            strCustName = strForename = (grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[2].Value.ToString()) + " " + (strSurname = grdCust.Rows[grdCust.CurrentCell.RowIndex].Cells[1].Value.ToString());         
        }

        public void setCustID(String strCustId)
        {
            this.strCustId = strCustId;
        }

        

      

    //////////////////////////////MENU ///////////////////////


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
