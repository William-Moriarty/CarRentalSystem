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
    public partial class frmRentCar : Form
    {
      
       // OracleConnection conn = new OracleConnection();

        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";

        string emRegex = @"^(\$|)([1-9]\d{0,2}(\,\d{3})*|([1-9]\d*))(\.\d{2})?$";
        frmCustomersList lc1 = new frmCustomersList("L");
        frmCarList cl1 = new frmCarList("C");
          
        public frmRentCar()
        {
            InitializeComponent();
        }

        private void frmRentCar_Load(object sender, EventArgs e)
        {       
            getRentId();  //GETS RENT ID         
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        //BUTTON USED FOR RENTING A CAR -USES VALIDATION METHODS AND RENT CAR METHOD AND SETS THE CUSTOMERS STATUS TO RENTAL OOUT

        private void btn_RentConfirm_Click(object sender, EventArgs e)
        {
            checkDates();

            if (!validateCustID() || !checkDates() || !validateRentals())
            {
                return;
            }
            else
            //save car details in car file
                if (MessageBox.Show("Are you sure you make this rental?", "Rent Car", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    rental(); //rents car
                    updateCustRental();//increments amount of rentals for a customer
                    setRentalOut();//sets customers status for "RENTAL_OUT" to 'Y'

                    //display confirmation message
                    MessageBox.Show("Rental details recorded, Payment will be made upon return of rented car", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset UI
                    getRentId();
                    resetUI();
                }
              
        }

        private void btn_Reser_Click(object sender, EventArgs e)
        {
            resetUI();
        }

        //METHOD USED FOR RENTAL//INSERTING DETAISL INTO RENTALS TABLE

        public void rental()
        {
            try {
            //String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";

            OracleConnection conn = new OracleConnection(oradb);

            String strSQL = "INSERT INTO RENTALS (Rent_Id,Cust_Id, RegNo, Date_From, Date_Due) VALUES ('" + txt_RentId.Text + "','" + txtCust.Text + "','" + txtCar.Text +
                "','" + String.Format("{0:dd-MMM-yy}", dtp_From.Value) + "','" + String.Format("{0:dd-MMM-yy}", dtp_Due.Value) + "')";

            // DateTime.Today.ToString("dd/MM/yyyy");
            //String.Format("{0:dd-MM-yyyy}", Today.to);

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
            //conn.Close();
        }

       
        //increments the amount of rentals for a customer in the custome table
        public void updateCustRental()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "UPDATE CUSTOMERS SET NUM_RENTALS = (NUM_RENTALS + 1) WHERE CUST_ID = " + txtCust.Text;
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
        //sets the rental out value to 'Y'
        private void setRentalOut()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "UPDATE CUSTOMERS SET Rental_Out = 'Y' WHERE CUST_ID = " + txtCust.Text;
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
        //gets new rent id for form load and after a rental is made
        public void getRentId()
        {
            try
            {
                //String oradb = "Data Source=Oracle;User Id = t00119587;Password = vy784epg;";

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand("SELECT NVL(MAX(Rent_Id),0) FROM Rentals", conn);
                conn.Open();

                decimal count = (decimal)cmd.ExecuteScalar();
                count += 1;
                txt_RentId.Text = count.ToString("0000");

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conn.Close();

        }

        private void rateChange()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "SELECT R.Class, RATE_PER_DAY, DESCRIPTION, LATE_FEE_RATE FROM Cars C, Rates R WHERE R.Class = '" + cl1.strClass + "'";
            cmd.CommandText = strSQL;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Class.Text = dr.GetValue(0).ToString();
                txt_RatePerDay.Text = dr.GetValue(1).ToString();
                txt_Desc.Text = dr.GetValue(2).ToString();
                txt_Late.Text = dr.GetValue(3).ToString();

            }
            conn.Close();

        }

        private void resetUI()
        {      
            txtCust.Text = "";
            txtCar.Text = "";
            txtCust.Focus();
            txtCarMake.Text = "";
            txtCustName.Text = "";
            txt_Class.Text = "";
            txt_Desc.Text = "";
            txt_RatePerDay.Text = "";
            txt_Late.Text = "";
        }

        //FOLLOWING BUTTONS OPENS AN INSTANCE OF LIST CUSTOMERS /CARS TO VIEW A LIST OF CUSTOMERS
        //CLICKING ON A CUSTOMER PASSES A VALUE TO A STRING WHICH IS USED BY THE REFRESH BUTTON

        private void btn_FindCust_Click(object sender, EventArgs e)
        {
            lc1.Show();
        }

        private void btn_FindCar_Click(object sender, EventArgs e)
        {
            cl1.Show();
        }

        //VALIDATION


        public Boolean checkDates()
        {

            if (dtp_From.Value > dtp_Due.Value)
            {
                MessageBox.Show("Please select a Due Date that is LATER than Date From", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private Boolean validateCustID()
        {
            //CUST ID
            if (!txtCust.Text.Equals(""))
            {
                for (int i = 0; i < txtCust.Text.Length; i++)
                {
                    if (!char.IsNumber(txtCust.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the Cust ID field","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCust.Text = "";
                        txtCust.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The Cust ID field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCust.Focus();
                return false;
            }
        }

        private Boolean validateRentals()
        {
            if (txt_Class.Text.Equals("") || txt_RatePerDay.Text.Equals("") || txt_Late.Text.Equals("") || txt_Desc.Text.Equals(""))
            {
                MessageBox.Show("The Vehicle must have a Class before it can be rented!\nPlease go to the Amend Cars Function and add a Rate to the vehicle", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
            return true;
            }
        }


        private void btn_Refresh1_Click(object sender, EventArgs e)
        {
            txtCust.Text = lc1.strCustId;
            txtCustName.Text = lc1.strCustName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cl1.strClass);
            txtCar.Text = cl1.strReg;
            txtCarMake.Text = cl1.strMakeAndModel;
           // txt_Class.Text = cl1.strClass;
            rateChange();
        }


        ////////////////////////////////////// MENU /////////////////////////////////////////



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

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentReturn returnCar = new frmRentReturn();
            returnCar.Show();
            this.Close();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
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

