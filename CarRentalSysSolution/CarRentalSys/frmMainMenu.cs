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
    
    public partial class frmMainMenu : Form
    {
        string oradb = "Data Source=Oracle;User Id=t00119587;Password=vy784epg;";

        frmCarAdd addCar = new frmCarAdd();
        frmCarAmend mendCar = new frmCarAmend();
        frmAdminLogin login = new frmAdminLogin();
        frmCarList lisCar = new frmCarList();
        frmCustomerAdd addCus = new frmCustomerAdd();
        frmCustomerAmend mendCus = new frmCustomerAmend();
        frmCustomersList lisCus = new frmCustomersList();
        frmRentCar rentCar = new frmRentCar();
        frmRentalsList lisRent = new frmRentalsList();
        frmRentReturn returnRent = new frmRentReturn();
        frmRentalAnalysis rentAnal = new frmRentalAnalysis();

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

            updateIsLate();  
        }

        //IF A CAR IS LATE THIS AUTOMATICALLY SETS ITS STATUS TO LATE WHEN THE PROGRAM STARTS

        private void updateIsLate()
        {

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            
            String strSQL = "UPDATE Rentals SET Is_Late = 'Y' WHERE Returned = 'N' AND Date_Due < CURRENT_DATE";
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

        private void btn_AddCar_Click(object sender, EventArgs e)
        {         
            addCar.Show();
            this.Hide();
        }

        private void btn_AmendCar_Click(object sender, EventArgs e)
        {          
            mendCar.Show();
            this.Hide();
        }

        private void btn_Adjust_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

       
        private void btn_ListCars_Click_1(object sender, EventArgs e)
        {
            lisCar.Show();
            this.Hide();
        }


        private void btn_AddCust_Click(object sender, EventArgs e)
        {
            addCus.Show();
            this.Hide();
        }

        private void btn_AmendCust_Click(object sender, EventArgs e)
        {
            mendCus.Show();
            this.Hide();
        }

        private void btn_ListCust_Click(object sender, EventArgs e)
        {
            lisCus.Show();
            this.Hide();
        }

        private void btn_RentCar_Click(object sender, EventArgs e)
        {
            rentCar.Show();
            this.Hide();
        }

        private void btn_ListRent_Click(object sender, EventArgs e)
        {
            lisRent.Show();
            this.Hide();
        }


        private void btn_returnCar_Click_1(object sender, EventArgs e)
        {
            returnRent.Show();
            this.Hide();
        }

        private void btn_RentAnal_Click(object sender, EventArgs e)
        {
            rentAnal.Show();
            this.Hide();
        }

        


   
      ///////////////////////   MENU STRIP   ////////////////////////

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //REFERENCE - http://www.homeandlearn.co.uk/csharp/csharp_s4p4.html

            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCar.Show();
            this.Hide();
        }

        private void amendCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mendCar.Show();
            this.Hide();
        }

        private void listCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lisCar.Show();
            this.Hide();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addCus.Show();
            this.Hide();
        }

        private void amendCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mendCus.Show();
            this.Hide();
        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lisCus.Show();
            this.Hide();
        }

        private void rentCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rentCar.Show();
            this.Hide();
        }

        private void returnCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            returnRent.Show();
            this.Hide();
        }

        private void listRentalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lisRent.Show();
            this.Hide();
        }

        private void rentalAnalysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rentAnal.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software Engineering Project" +
                            "\nCar Rental System Prototype\nSubmission Date: 20-APR-15\nAuthor: William Moriarty (t00119587)");
        }

       

    
    }
}
