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

    public partial class frmCarAmend : Form
    {
        string oradb = "Data Source=Oracle;User Id=t00119587;Password=vy784epg;";

        List<String> acura = new List<String> { " ","TL", "TLX", "ILX", "RLX", "NSX", "NSX-T", "ZDX", "Integra", "Legend", "CL", "RL", "Vigor", "SLX" };
        List<String> alfa = new List<String> { " ","4C Spider", "Spider", "4C", "8C", "Giulietta", "MiTo", "Sportswagen", "Brera", "GT", "GTV" };
        List<String> aston = new List<String> {" ", "DB9", "Vanquish", "Vantage GT", "Rapide S", "Rapide", "DB7", "V12 Vantage", "Virage", "DB7" };
        List<String> audi = new List<String> { " ","A3", "A4", "R8", "Q5", "Q3", "A6", "Q7", "A5", "A8", "S3", "S5", "S6" };
        List<String> bentley = new List<String> {" ", "Contiental", "Contiental GT", "Contiental GTC", "Mulsanne", "Amage", "Azure" };
        List<String> bmw = new List<String> { " ","3 Series", "5 Series", "6 Series", "7 Series", "2 Series", "M3", "M4", "M235", "X1", "X2", "X3", "X4", "X5" };
        List<String> bugatti = new List<String> { " ", "Veyron", "EB110", "EB118" };
        List<String> caddy = new List<String> { " ","Eldorado", "Escalade", "CTS", "CTS-V", "DTS", "SRX", "STS-V" };
        List<String> chev = new List<String> { " ","Camaro", "Corvette", "Cruze", "Spark", "Colorado", "Impala", "Sonic", "Malibu" };
        List<String> chrysler = new List<String> {" ", "300", "200", "300c", "Voyager", "Cruiser", "Crossfire", "Pacifica" };
        List<String> citreon = new List<String> { " ","C1", "DS3", "DS4", "5LS", "C3", "C4 Picasso", "Berlingo", "C5 Sedan", "C5 Estate", "C4 Coupe" };
        List<String> dodge = new List<String> { " ","Charger", "Viper", "Durango", "Avenger", "Dart", "Nitro", "Dakota" };
        List<String> ferarri = new List<String> { " ","458 Italia", "FF", "California", "458 Spider", "Enzo", "Modena" };
        List<String> fiat = new List<String> { " ","500", "500x", "500L", "500c", "Punto", "Coupe" };
        List<String> ford = new List<String> { " ","Mustang", "F-150", "Focus", "Fiesta", "Explorer", "Edge", "Escape", "F-350", "Fusion" };
        List<String> honda = new List<String> { " ","Civic", "CR-V", "Fit", "Accord", "CR-Z", "Odyssey", "Hybrid" };
        List<String> hyundai = new List<String> {" ", "Accent", "Elanta", "Santa Fe", "Tucson", "Sonata", "Azera", "Genesis", "GT" };
        List<String> jeep = new List<String> { " ","Wrangler", "Cherokee", "Renegade", "Commander", "Commanche" };
        List<String> kia = new List<String> { " ","Sportage", "Rio", "Sedona", "Soul", "Forte" };
        List<String> lamborghini = new List<String> { " ","Aventador", "Huracan", "Gallardo", "Diablo", "Murcielago" };
        List<String> landrover = new List<String> { " ","Range Rover", "Range Rover Evoque", "Discovery", "Discovery Sport", "LR2", "LR4", "Freelander" };
        List<String> lexus = new List<String> { " ","NX", "RX", "RC", "IS", "GX", "GS", "CT" };
        List<String> maserati = new List<String> {" ", "Gran Turismo", "Ghibli", "Coupe", "Quattrporte", "Spyder", "Gransport" };
        List<String> mazda = new List<String> {" ", "CX-5", "MX-5", "M2", "M6", "CX-9", "M5", "RX-8" };
        List<String> mclaren = new List<String> {" ", "650s", "MP4-12c" };
        List<String> merc = new List<String> {" ", "GLA", "CLA", "E", "CLS", "CLK", "C", "CL", "AMG-GT" };
        List<String> mini = new List<String> { " ", "Cooper", "Countryman", "Paceman", "Coupe" };
        List<String> mitsu = new List<String> { " ","Outlander", "Lancer", "Galant", "Carisma", "Eclipse", "Endevour", "Magma" };
        List<String> nissan = new List<String> {" ", "GT-R", "Altima", "Quest", "Versa", "Almera", "Cedric", "Pathfinder", "QashQai" };
        List<String> opel = new List<String> { " ","Astra", "Vectra", "Insignia", "Omega", "Signum", "Ascona" };
        List<String> peugot = new List<String> {" ", "206", "1007", "207", "Expert" };
        List<String> porsche = new List<String> {" ", "Maca", "Cayenne", "Panamera", "Spyder", "Carrera", "Carrera GT" };
        List<String> renault = new List<String> { " ","Clio", "19", "Megane", "Altica", "Argoes", "Laguna", "Zoom" };
        List<String> rover = new List<String> { " ","75", "Metro", "800", "200", "Streetwise" };
        List<String> saab = new List<String> { " ","9-3", "9-5", "900", "9000", "9-7", "9-4x" };
        List<String> scion = new List<String> { " ","tc", "xB", "FR-S", "xD", "iQ", "xA" };
        List<String> seat = new List<String> { " ","Cordoba", "Leon", "Toleda", "Alhambra", "Salsa", "Altea", "Bolero" };
        List<String> skoda = new List<String> { " ","Fabia", "Citigo", "Rapid", "Octavia", "Yeti", "Superb", "Roomster" };
        List<String> subaru = new List<String> { " ","Outback", "Legacy", "BRZ", "WRX", "XV" };
        List<String> suzuki = new List<String> { " ","Sx4", "Kizashi", "Grand Vitara", "XL7", "Aerio", "Swift", "Equator", "Reno" };
        List<String> tesla = new List<String> { " ","Model S", "Model X", "SEV" };
        List<String> toyota = new List<String> { " ","Corolla", "RAV4", "Prius", "Land Cruiser", "Yaris", "Tundra", "Highlander", "Sienna", "Avalon" };
        List<String> vauxhall = new List<String> {" ", "VxR8", "Vx220", "Saturn", "Corsavan" };
        List<String> volkswagen = new List<String> { " ","Golf", "Polo", "Passat", "Beetle", "Jetta", "Golf GTI", "CC", "Eos", "Rabbit", "Golf R", "Touareg", "GTI" };
        List<String> volvo = new List<String> {" ", "XC90", "XC60", "S60", "S80", "V60", "V40", "S40" };

        string strRegNo;
        //initialising SQL search string
        String strSQL = "SELECT C.REGNO, MAKE, MODEL, COLOUR, YEAR_OF_MAKE, C.CLASS, RATE_PER_DAY, LATE_FEE_RATE, DATE_REGISTERED FROM CARS C, RATES R WHERE C.Class = R.Class AND C.Status = 'A' ORDER BY MAKE";
        public frmCarAmend()
        {
            InitializeComponent();
        }

        private void frmCarAmend_Load(object sender, EventArgs f)
        {
            //method for returnign connection and filling grid with list of cars
            addClasses();
            returnConnection();       
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
            cbo_srchClass.Items.Insert(0, " "); 
            while (dr.Read())
            {
                cbo_srchClass.Items.Add(dr["CLASS"]);
                cbo_Class.Items.Add(dr["CLASS"]);
            }


            conn.Close();
        }

        //method that updates colour on cars
        private void UpdateCars()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            String strSQL = "UPDATE Cars SET Colour = '" + cbo_Colour.Text.ToUpper() + "', Class = '" + cbo_Class.Text + "' WHERE RegNo = '" + strRegNo +"'";

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

        //the update button which uses the method updat cars, validation and subsequent messages
        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (validateRegYear2())
            {
                return;
            }

            else if (cbo_Colour.Text.Equals(""))
            {
                MessageBox.Show("Please select a Colour!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Colour.Focus();
                return;
            }

            else if (cbo_Class.Text.Equals(""))
            {
                MessageBox.Show("Please select a Class!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Class.Focus();
                return;
            }

            else {
                if (MessageBox.Show("Are you sure you will update the Car details?", "Add Customer", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UpdateCars();
                    ResetUI1();
                    MessageBox.Show("The Car details have been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

               return;
            }

            
        }
        //delete button and method
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this Car?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DeleteCar();

                ResetUI();
            }     
        }
        //method for reset grid list and telling that car is deleted
        private void ResetUI()
        {
            MessageBox.Show("Car is now deleted");
            returnConnection();;
        }

        //method for reset grid list and telling that car is updated
        private void ResetUI1()
        {
            //MessageBox.Show("Car is now updated");
            returnConnection();
        }


        //reset button for reseting parameters for search function
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtRegSerial2.Text = "";
            cboYear2.SelectedIndex = 0;
            cboCounty2.SelectedIndex = 0;
            cbo_RegYear.SelectedIndex = 0;
            cbo_RegCounty.SelectedIndex = 0;
            cbo_Year.SelectedIndex = 0;
            cbo_Make.SelectedIndex = 0;
            cbo_srch_Col.SelectedIndex = 0;
            cbo_srchClass.SelectedIndex = -1;
            cbo_Model.SelectedIndex = -1;
            strSQL = "SELECT C.REGNO, MAKE, MODEL, COLOUR, YEAR_OF_MAKE, C.CLASS, RATE_PER_DAY, LATE_FEE_RATE, DATE_REGISTERED FROM CARS C, RATES R WHERE C.Class = R.Class AND C.Status = 'A' ORDER BY MAKE";
            returnConnection();
        }


        //reset button for reseting the parameters for the update/delete functions
        private void btn_Reset2_Click(object sender, EventArgs e)
        {
            txtRegSerial2.Text = "";
            cboYear2.SelectedIndex = 0;
            cboCounty2.SelectedIndex = 0;
            cbo_Colour.SelectedIndex = 0;
            cbo_Class.SelectedIndex = -1;
        }

        private void btn_Home2_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

     
        //SQL connection method used for filling grid with list
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

                grd_ListCars.DataSource = ds.Tables["SS"];
                conn.Close();

                columnWidth();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Validation for the Car registration fields
        private Boolean validateRegYear()
        {
            //REGNO
            if((!cbo_RegYear.Text.Equals("")  && !cbo_RegCounty.Text.Equals("")  && !txt_RegSerial.Text.Equals("")))
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
            else if((cbo_RegYear.Text.Equals("")  && cbo_RegCounty.Text.Equals("")  && !txt_RegSerial.Text.Equals("")) ||
                   (cbo_RegYear.Text.Equals("")  && !cbo_RegCounty.Text.Equals("") && txt_RegSerial.Text.Equals(""))  ||
                   (cbo_RegYear.Text.Equals("")  && !cbo_RegCounty.Text.Equals("") && !txt_RegSerial.Text.Equals("")) ||
                   (!cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("")  && txt_RegSerial.Text.Equals(""))  ||
                   (!cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("")  && !txt_RegSerial.Text.Equals("")) ||
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

        private Boolean validateRegYear2()
        {
            //REGNO
            if  ((cboYear2.Text.Equals("") && cboCounty2.Text.Equals("") && !txtRegSerial2.Text.Equals("")) ||
                   (cboYear2.Text.Equals("") && !cboCounty2.Text.Equals("") && txtRegSerial2.Text.Equals("")) ||
                   (cboYear2.Text.Equals("") && !cboCounty2.Text.Equals("") && !txtRegSerial2.Text.Equals("")) ||
                   (!cboYear2.Text.Equals("") && cboCounty2.Text.Equals("") && txtRegSerial2.Text.Equals("")) ||
                   (!cboYear2.Text.Equals("") && cboCounty2.Text.Equals("") && !txtRegSerial2.Text.Equals("")) ||
                   (!cboYear2.Text.Equals("") && !cboCounty2.Text.Equals("") && txtRegSerial2.Text.Equals("")) ||
                   (cboYear2.Text.Equals("") && cboCounty2.Text.Equals("") && txtRegSerial2.Text.Equals("")))
            {

                MessageBox.Show("Please select a vehicle!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYear2.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        //button that uses the methods for optimised queries

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (validateRegYear())
            {
               return;
           }
            else
            //must reset to this parameter each time
                strSQL = "SELECT C.REGNO, MAKE, MODEL, COLOUR, YEAR_OF_MAKE, C.CLASS, RATE_PER_DAY, LATE_FEE_RATE, DATE_REGISTERED FROM CARS C, RATES R";

            //check reg no
            strSQL = setReg(strSQL);

            //check year
            strSQL = setYear(strSQL);

            //check Make
            strSQL = setMake(strSQL);

            //check Model
            strSQL = setModel(strSQL);

            //set Colour
            strSQL = setColour(strSQL);

            //set Class
            strSQL = setClass(strSQL);

            //Making sure status is "Available"
            strSQL = setStatus(strSQL);

            //setting join
            strSQL = setJoin(strSQL);

            //sets order
            strSQL = setOrder(strSQL);

            returnConnection();

            if (grd_ListCars.Rows[0].Cells[0].Value == null )
            {
                strSQL = "Select * from CARS WHERE Status = 'A'";
                MessageBox.Show("No Records found!");
                returnConnection();
            }
        }

        
        //sets the sql string to look for reg if reg is input - following methods do the same depending on name (set Year sets year for example)
        private String setReg(String query)
        {
            String strRegNo = cbo_RegYear.Text + "-" + cbo_RegCounty.Text + "-" + txt_RegSerial.Text;

            if (!txt_RegSerial.Text.Equals("") && !cbo_RegYear.Text.Equals("") && !cbo_RegCounty.Text.Equals(""))
            {
                query = query + " WHERE RegNo = '" + strRegNo + "'";
            }

            return query;
        }

        private String setYear(String query)
        {
            if (!cbo_Year.Text.Equals(""))
            {
                if (txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals(""))

                    query = query + " WHERE Year_of_Make = '" + cbo_Year.Text + "'";
                else
                    query = query + " AND Year_of_Make = '" + cbo_Year.Text + "'";
            }
            return query;
        }

        private String setMake(String query)
        {
            if (!cbo_Make.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals(""))
                {
                    query = query + " WHERE Make = '" + cbo_Make.Text.ToUpper() + "'";
                }
                else
                {
                    query = query + " AND  Make = '" + cbo_Make.Text.ToUpper() + "'";
                }
            }
            return query;
        }

        private String setModel(String query)
        {
            if (!cbo_Model.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && cbo_Make.Text.Equals(""))
                {
                    query = query + " WHERE Model = '" + cbo_Model.Text.ToUpper() + "'";
                }
                else
                {
                    query = query + " AND  Model = '" + cbo_Model.Text.ToUpper() + "'";
                }
            }
            return query;
        }

        private String setColour(String query)
        {

            if (!cbo_srch_Col.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals(""))
                {
                    query = query + " WHERE Colour = '" + cbo_srch_Col.Text.ToUpper() + "'";
                }
                else
                {
                    query = query + " AND Colour = '" + cbo_srch_Col.Text.ToUpper() + "'";
                }
            }
            return query;
        }

        private String setClass(String query)
        {

            if (!cbo_srchClass.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals("") && cbo_srch_Col.Text.Equals(""))
                {
                    query = query + " WHERE C.Class = '" + cbo_srchClass.Text.ToUpper() + "'";
                }
                else
                {
                    query = query + " AND C.Class = '" + cbo_srchClass.Text.ToUpper() + "'";
                }
            }
            return query;
        }

        private String setStatus(String query)
        {
            if (cbo_Year.Text.Equals("") && txt_RegSerial.Text.Equals("") && cbo_RegYear.Text.Equals("") && cbo_RegCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals("") && cbo_srch_Col.Text.Equals("") && cbo_srchClass.Text.Equals(""))
            {
                query = query + " WHERE Status = 'A'";
            }  
            else
                query = query + " AND Status = 'A'";
      
                return query;
            
        }

        //JOINS THE TABLE
        private String setJoin(String query)
        {
            //if there is a WHERE clause already in the query
            if (query.Contains("WHERE"))
                query = query + " AND C.Class = R.Class";
            else
                query = query + " WHERE C.Class = R.Class";

            return query;

        }

        private String setOrder(String query)
        {
                query = query + " ORDER BY MAKE";

            return query;
        }

        //this method gets the car reg from the grid and passes them into combo boxes etc, uses substring for putting values in their own combo boxes


        //NB ----- I WAS ORIGINALLY TRYING TO HAVE REGISTRATIONS BE UPDATED BUT THEY WERE A PRIMARY KEY
        //IT IS LEGAL TO CHANGE REGISTRATION IN IRELAND WHICH IS WHY I ORIGINALLY TRIED AND PUT EVERYTHING INTO SUBSTRINGS


        private void getCarsByReg(String carRegNo)
        {
           try{
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                String strSQL = "SELECT * FROM Cars WHERE RegNo = '" + carRegNo + "'";
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    strRegNo = dr.GetValue(0).ToString();
                    cbo_Colour.Text = dr.GetValue(3).ToString();

                    conn.Close();


            //get Get Substrings
 
            String strYear = "";
            String strCounty = "";
            String strSerial = "";
            

            for (int i = 0; i < strRegNo.Length; i++)
            {
                if (strRegNo[3] == '-' && strRegNo[5] == '-')
                {
                    strYear = strRegNo.Substring(0, 3);
                    strCounty = strRegNo.Substring(4, 1);
                    strSerial = strRegNo.Substring(6);
                }
                else if (strRegNo[3] == '-' && strRegNo[6] == '-')
                {
                    strYear = strRegNo.Substring(0, 3);
                    strCounty = strRegNo.Substring(4, 2);
                    strSerial = strRegNo.Substring(7);
                }
                else if (strRegNo[2] == '-' && strRegNo[4] == '-')
                {
                    strYear = strRegNo.Substring(0, 2);
                    strCounty = strRegNo.Substring(3, 1);
                    strSerial = strRegNo.Substring(5);
                }
                else
                {
                    strYear = strRegNo.Substring(0, 2);
                    strCounty = strRegNo.Substring(3, 2);
                    strSerial = strRegNo.Substring(6);
                    
                }
            }
            cboYear2.Text = strYear;
            cboCounty2.Text = strCounty;
            txtRegSerial2.Text = strSerial;
          
             }

                else
                {
                //MessageBox.Show("No Details Found");
                //txt_SearchReg.Focus();
                return;
                }
            }
        catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

   
    //method for deleting car
    public void DeleteCar()
    {
          OracleConnection conn = new OracleConnection(oradb);
          conn.Open();
          OracleCommand cmd = conn.CreateCommand();

          String strWholeReg = cboYear2.Text + "-" + cboCounty2.Text + "-" + txtRegSerial2.Text;

          String strSQL = "UPDATE Cars SET Status = 'D' WHERE RegNo = '" + strWholeReg + "'";

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


    //clicking on the grid to return a value of the car registration number
    private void grd_ListCars_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
        strRegNo = grd_ListCars.Rows[grd_ListCars.CurrentCell.RowIndex].Cells[0].Value.ToString();
        getCarsByReg(strRegNo);
    }

    //radio button update
    private void radUpdate_Click(object sender, EventArgs e)
    {
        //txtRegSerial2.Enabled = true;
        //cboYear2.Enabled = true;
        //cboCounty2.Enabled = true;
        cbo_Colour.Enabled = true;
        btnUpd.Visible = true;
        btnDel.Visible = false;
        btn_Reset2.Enabled = true;
        cbo_Class.Enabled = true;
    }
    //radio button delete
    private void radDelete_Click(object sender, EventArgs e)
    {
        txtRegSerial2.Enabled = false;
        cboCounty2.Enabled = false;
        cboYear2.Enabled = false;
        cbo_Colour.Enabled = false;
        btnUpd.Visible = false;
        btnDel.Visible = true;
        btn_Reset2.Enabled = false;
        cbo_Class.Enabled = false;
    }

    //setting the column width in the grid to customized sizes to make it look neater
    private void columnWidth()
    {
        grd_ListCars.Columns[0].Width = 85;
        grd_ListCars.Columns[1].Width = 100;
        grd_ListCars.Columns[2].Width = 90;
        grd_ListCars.Columns[3].Width = 63;
        grd_ListCars.Columns[4].Width = 40;
        grd_ListCars.Columns[5].Width = 50;
        grd_ListCars.Columns[6].Width = 65;
        grd_ListCars.Columns[7].Width = 63;
        grd_ListCars.Columns[8].Width = 120;
    }


    /// //////////////////////////CAR MODELS that show when CAR MAKE is selected ///////////////////////////////

    private void cbo_Make_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_Make.SelectedIndex == 1)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(acura.ToArray());
        }

        else if (cbo_Make.SelectedIndex == 2)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(alfa.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 3)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(aston.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 4)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(audi.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 5)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(bentley.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 6)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(bmw.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 7)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(bugatti.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 8)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(caddy.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 9)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(chev.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 10)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(chrysler.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 11)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(citreon.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 12)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(dodge.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 13)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(ferarri.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 14)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(fiat.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 15)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(ford.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 16)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(honda.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 17)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(hyundai.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 18)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(jeep.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 19)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(kia.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 20)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(lamborghini.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 21)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(landrover.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 22)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(lexus.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 23)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(maserati.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 24)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(mazda.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 25)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(mclaren.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 26)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(merc.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 27)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(mini.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 28)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(mitsu.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 29)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(nissan.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 30)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(opel.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 31)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(peugot.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 32)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(porsche.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 33)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(renault.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 34)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(rover.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 35)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(saab.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 36)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(scion.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 37)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(seat.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 38)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(skoda.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 39)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(subaru.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 40)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(suzuki.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 41)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(tesla.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 42)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(toyota.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 43)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(vauxhall.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 44)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(volkswagen.ToArray());
        }
        else if (cbo_Make.SelectedIndex == 45)
        {
            cbo_Model.Items.Clear();
            cbo_Model.Items.AddRange(volvo.ToArray());
        }
    }
  
  

    ////////////////////////////////////MENU/////////////////////////////////////////

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


    private void listCarToolStripMenuItem_Click(object sender, EventArgs e)
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

    private void listCustomersToolStripMenuItem1_Click(object sender, EventArgs e)
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

    private void listRentalsToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        frmRentalsList lisRent = new frmRentalsList();
        lisRent.Show();
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
