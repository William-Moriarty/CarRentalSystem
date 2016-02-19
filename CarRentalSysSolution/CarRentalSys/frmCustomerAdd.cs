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
    public partial class frmCustomerAdd : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00119587;Password = vy784epg;";

        //STRING for checking if email is valid
        string emRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        OracleConnection conn = new OracleConnection();

        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            getCustId();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();

        }

        private void btn_AddCustConfirm_Click(object sender, EventArgs e)
        {

            //validate input
            if (!validateForename() || !validateSurname() || !validateStreetNo() || !validateStreet() || !validateTown() || !validatePhone() || !validateEmail())
            {
                return;
            }
            else
                if (MessageBox.Show("Are you sure you will add the customer?", "Add Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    addCust();
                    MessageBox.Show("Customer is Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getCustId();
                    resetUI();           
                }
        
               
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetUI();
        }

        //METHOD FOR ADDING A CUSTOMER

        private void addCust()
        {
            try
            {
                String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";

                OracleConnection conn = new OracleConnection(oradb);

                String street = txtNo.Text + " " + txtStreet.Text;

                String strSQL = "INSERT INTO CUSTOMERS (Cust_Id,Forename,Surname,Street, Town, County,Phone_No,Email, Date_Registered) VALUES (" + txtCustId.Text.ToUpper() + ",'" + txtForename.Text.ToUpper() + "','" + txtSurname.Text.ToUpper() +
                    "','" + street.ToUpper() + "', '" + txtTown.Text.ToUpper() + "', '" + cbo_County.Text.ToUpper() + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + DateTime.Today.ToString("dd-MMM-yyyy") + "')";

                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //gets the customers ID automaticall and increments it each time a new custmer is added
        public void getCustId()
        {
            try
            {
                conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand("SELECT NVL(MAX(Cust_Id),0) FROM Customers", conn);
                conn.Open();

                decimal count = (decimal)cmd.ExecuteScalar();
                count += 1;
                txtCustId.Text = count.ToString("0000");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //VALIDATION

        public Boolean validateForename(){


         //FORENAME
         if (!txtForename.Text.Equals(""))
            {
                for (int i = 0; i < txtForename.Text.Length; i++)
                {
                    if (char.IsNumber(txtForename.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the FORENAME field");
                        txtForename.Text = "";
                        txtForename.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The FORENAME field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return false;
            }
        }

        private Boolean validateSurname()
        {
            //SURNAME
            if (!txtSurname.Text.Equals(""))
            {
                for (int i = 0; i < txtSurname.Text.Length; i++)
                {
                    if (char.IsNumber(txtSurname.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the SURNAME field");
                        txtSurname.Text = "";
                        txtSurname.Focus();
                        return false;
                    }                   
                }
                return true;
            }
            else
            {
                MessageBox.Show("The SURNAME field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }
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
            if (!txtStreet.Text.Equals(""))
            {
                for (int i = 0; i < txtStreet.Text.Length; i++)
                {
                    if (char.IsNumber(txtStreet.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the STREET field");
                        txtStreet.Text = "";
                        txtStreet.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The STREET field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return false;
            }
        }

        private Boolean validateTown()
        {
            //TOWN
         if (!txtTown.Text.Equals(""))
         {
             for (int i = 0; i < txtTown.Text.Length; i++)
             {
                 if (char.IsNumber(txtTown.Text[i]))
                 {
                     MessageBox.Show("Please do not enter digits for the TOWN field");
                     txtTown.Text = "";
                     txtTown.Focus();
                     return false;
                 }
             }
             return true;
         }
         else
         {
             MessageBox.Show("The TOWN field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
             txtTown.Focus();
             return false;
         }
        }

       /* private Boolean validateCounty()
        {
            //TOWN
            //if (txtCounty.Text.Equals(""))
            {
                for (int i = 0; i < txtTown.Text.Length; i++)
                {
                    if (char.IsNumber(txtTown.Text[i]))
                    {
                        MessageBox.Show("Please do not enter digits for the TOWN field");
                        txtTown.Text = "";
                        txtTown.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The TOWN field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return false;
            }
        }*/

        private Boolean validatePhone()
        {
            //PHONE
            if (!txtPhone.Text.Equals(""))
            {
                for (int i = 0; i < txtPhone.Text.Length; i++)
                {
                    if (!char.IsNumber(txtPhone.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the PHONE NO field");
                        txtPhone.Text = "";
                        txtPhone.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The PHONE NO field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
        }

        private Boolean validateEmail()
        {
            //EMAIL
            if (!txtEmail.Text.Equals(""))
            {
                Regex emailREGEX = new Regex(emRegex);

                if(!emailREGEX.IsMatch(txtEmail.Text))
                 {
                MessageBox.Show("Please Input Valid Email", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                txtEmail.Text = "";
                return false;

                     //REFERENCE - emRegex - http://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp
                }
                else
                return true;
            }
            else
            {
                MessageBox.Show("The E-MAIL field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
        }

        //METHOD FOR RESETING UI UPON ADDING CUSTOMER

        private void resetUI()
        {
            txtForename.Text = "";
            txtSurname.Text = "";
            txtNo.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            cbo_County.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtForename.Focus();
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
