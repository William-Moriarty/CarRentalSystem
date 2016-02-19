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
    public partial class frmAdjustRates : Form
    {
        string oradb = "Data Source=Oracle;User Id=t00119587;Password=vy784epg;";

        String emRegex = @"^(\$|)([1-9]\d{0,2}(\,\d{3})*|([1-9]\d*))(\.\d{2})?$";
        

        List<String> classes = new List<String> {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"} ;
        
        public frmAdjustRates()
        {
            InitializeComponent();
        }

        private void frmAdjustRates_Load(object sender, EventArgs e)
        {
            
           // MessageBox.Show(getCount().ToString());

            rad_Add.Checked = true;
            btn_Adjust.Visible = false;
            btn_Del.Visible = false;
            cbo_Class.Items.AddRange(classes.ToArray());
            removeClasses();
        
            
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        
        //////////////// ADD RATE
        private void addRate()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "INSERT INTO RATES VALUES ('" + cbo_Class.Text + "','" + txt_Rate.Text + "','" + txt_LateFee.Text + "','" + txt_Desc.Text.ToUpper() + "')";

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!validateClass() || !validateRate() || !validateLate() || !validateDescription())
            {
                return;
            }
            else 
            {
            addRate();
            MessageBox.Show("Rate " + cbo_Class.Text.ToString() + " has been added","Added!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            resetUI();
            cbo_Class.Items.AddRange(classes.ToArray());
            removeClasses();
            }
        }

      
        ////////////////// DELETE RATE

        private void deleteRate()
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "DELETE FROM RATES WHERE CLASS = '" + cbo_Class.Text + "'";

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

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to DELETE this rate?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!ifClassHasRent())
                {
                    return;
                }
                else
                {
                    deleteRate();
                    MessageBox.Show("Rate " + cbo_Class.Text.ToString() + " has been deleted","Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetUI();
                    cbo_Class.Items.Clear();
                    addClasses();
                }
            }
            

        }

        
        //////////////////////// ADJUST RATE

        private void adjustRates()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "UPDATE Rates SET RATE_PER_DAY = " + txt_Rate.Text + ", LATE_FEE_RATE = " + txt_LateFee.Text + ", DESCRIPTION = '" + txt_Desc.Text.ToUpper() + "' WHERE CLASS = '" + cbo_Class.Text + "'";

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

        private void btn_Adjust_Click(object sender, EventArgs e)
        {
            if (!validateClass() || !validateRate() || !validateLate() || !validateDescription())
            {
                return;
            }
            else
            {
                adjustRates();
                MessageBox.Show("Rate " + cbo_Class.Text.ToString() + " has been adjusted", "Adjusted!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetUI();
                cbo_Class.Items.Clear();
                addClasses();
            }
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetUI();
        }



        private void addClasses()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            String strSQL = "SELECT * FROM Rates ORDER BY CLASS";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);         
            OracleDataReader dr = cmd.ExecuteReader();
            cbo_Class.Items.Insert(0, " "); 
            while (dr.Read())
                
            {
                cbo_Class.Items.Add(dr["CLASS"]);          
            }        
            conn.Close();
        }

        /////////This was the most annoying thing ever to figure out

        private void removeClasses()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            String strSQL = "SELECT * FROM Rates ORDER BY CLASS";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {           
                        if (classes.Contains(dr.ItemArray[0].ToString()))
                        {
                            classes.Remove(dr.ItemArray[0].ToString());
                        }                  
                    //MessageBox.Show(dr.ItemArray[0].ToString());
                }
                cbo_Class.Items.Clear();
                cbo_Class.Items.AddRange(classes.ToArray());
            }
        }            

      /*  public int getCount()
        {
            int count = 0;

            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                String strSQL = "SELECT * FROM Rates";

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                count = ds.Tables["ss"].Rows.Count;
                
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return count;

        }*/

    

        private void cbo_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            String strSQL = "SELECT * FROM Rates WHERE CLASS = '" + cbo_Class.Text + "' ORDER BY CLASS";
       
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
           
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                
            {   
            txt_Rate.Text = dr.GetValue(1).ToString();
            txt_LateFee.Text = dr.GetValue(2).ToString();
            txt_Desc.Text = dr.GetValue(3).ToString();
                
            }
            
            conn.Close();       
        }


        private void rad_Add_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Type.Text = "ADD A RATE";

            resetUI();

            btn_Add.Visible = true;
            btn_Adjust.Visible = false;
            btn_Del.Visible = false;

            txt_Rate.Enabled = true;
            txt_Desc.Enabled = true;
            txt_LateFee.Enabled = true;

            cbo_Class.Items.AddRange(classes.ToArray());
            removeClasses();
            
        }

        private void rad_Adj_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Type.Text = "ADJUST A RATE";

            resetUI();

            btn_Adjust.Visible = true;
            btn_Add.Visible = false;
            btn_Del.Visible = false;

            txt_Rate.Enabled = true;
            txt_Desc.Enabled = true;
            txt_LateFee.Enabled = true;

            cbo_Class.Items.Clear();
            addClasses();
        }

        private void rad_Del_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Type.Text = "DELETE A RATE";

       
            txt_Rate.Enabled = false;
            txt_Desc.Enabled = false;
            txt_LateFee.Enabled = false;

            btn_Del.Visible = true;
            btn_Add.Visible = false;
            btn_Adjust.Visible = false;

            cbo_Class.Items.Clear();
            addClasses();
        }

        private void resetUI()
        {
            cbo_Class.SelectedIndex = -1;
            txt_Rate.Text = "";
            txt_Desc.Text = "";
            txt_LateFee.Text = "";
        }

        ///////////////////////VALIDATION

        private Boolean ifClassHasRent()
        {

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            String strSQL = "SELECT COUNT(*) FROM Cars WHERE CLASS = '" + cbo_Class.Text + "' AND Status = 'O'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            decimal classCount = (decimal)cmd.ExecuteScalar();
            conn.Close();

            if (classCount >= 1)
            {
                MessageBox.Show("You cannot delete a rate that is being used by a car in a current rental\nYou must wait until the car is returned before deleting the rate.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Boolean validateClass()
        {
            if (cbo_Class.Text.Equals(""))
            {
                MessageBox.Show("Please Select A Class!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Boolean validateRate()
        {
            if (!txt_Rate.Text.Equals(""))
            {
                Regex rateREGEX = new Regex(emRegex);

                if(!rateREGEX.IsMatch(txt_Rate.Text))
                 {
                MessageBox.Show("Please Input a Valid Rate", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Rate.Focus();
                txt_Rate.Text = "";
                return false;

            
                }
                else
                return true;
            }
            else
            {
                MessageBox.Show("The Rate field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Rate.Focus();
                return false;
            }
        }

        private Boolean validateLate()
        {
                if (!txt_LateFee.Text.Equals(""))
            {
                Regex rateREGEX = new Regex(emRegex);

                if(!rateREGEX.IsMatch(txt_LateFee.Text))
                 {
                MessageBox.Show("Please Input a Valid Late Fee", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LateFee.Focus();
                txt_LateFee.Text = "";
                return false;

            
                }
                else
                return true;
            }
            else
            {
                MessageBox.Show("The Late Fee field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LateFee.Focus();
                return false;
            }
        }

        private Boolean validateDescription()
        {

            if (!txt_Desc.Text.Equals(""))
            {
                for (int i = 0; i < txt_Desc.Text.Length; i++)
                {
                    if (char.IsNumber(txt_Desc.Text[i]))
                    {
                        MessageBox.Show("Please enter only text for the Description field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Desc.Text = "";
                        txt_Desc.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a value for the Description field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

  
        //////////////////////MENU
      
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
