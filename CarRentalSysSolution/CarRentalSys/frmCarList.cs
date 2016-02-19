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
    public partial class frmCarList : Form
    {
        //initializing SQL strings
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";
        String strSQL = "Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status, C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R WHERE C.CLASS = R.CLASS ORDER BY CLASS";

        List<String> acura = new List<String> { " ", "TL", "TLX", "ILX", "RLX", "NSX", "NSX-T", "ZDX", "Integra", "Legend", "CL", "RL", "Vigor", "SLX" };
        List<String> alfa = new List<String> { " ", "4C Spider", "Spider", "4C", "8C", "Giulietta", "MiTo", "Sportswagen", "Brera", "GT", "GTV" };
        List<String> aston = new List<String> { " ", "DB9", "Vanquish", "Vantage GT", "Rapide S", "Rapide", "DB7", "V12 Vantage", "Virage", "DB7" };
        List<String> audi = new List<String> { " ", "A3", "A4", "R8", "Q5", "Q3", "A6", "Q7", "A5", "A8", "S3", "S5", "S6" };
        List<String> bentley = new List<String> { " ", "Contiental", "Contiental GT", "Contiental GTC", "Mulsanne", "Amage", "Azure" };
        List<String> bmw = new List<String> { " ", "3 Series", "5 Series", "6 Series", "7 Series", "2 Series", "M3", "M4", "M235", "X1", "X2", "X3", "X4", "X5" };
        List<String> bugatti = new List<String> { " ", "Veyron", "EB110", "EB118" };
        List<String> caddy = new List<String> { " ", "Eldorado", "Escalade", "CTS", "CTS-V", "DTS", "SRX", "STS-V" };
        List<String> chev = new List<String> { " ", "Camaro", "Corvette", "Cruze", "Spark", "Colorado", "Impala", "Sonic", "Malibu" };
        List<String> chrysler = new List<String> { " ", "300", "200", "300c", "Voyager", "Cruiser", "Crossfire", "Pacifica" };
        List<String> citreon = new List<String> { " ", "C1", "DS3", "DS4", "5LS", "C3", "C4 Picasso", "Berlingo", "C5 Sedan", "C5 Estate", "C4 Coupe" };
        List<String> dodge = new List<String> { " ", "Charger", "Viper", "Durango", "Avenger", "Dart", "Nitro", "Dakota" };
        List<String> ferarri = new List<String> { " ", "458 Italia", "FF", "California", "458 Spider", "Enzo", "Modena" };
        List<String> fiat = new List<String> { " ", "500", "500x", "500L", "500c", "Punto", "Coupe" };
        List<String> ford = new List<String> { " ", "Mustang", "F-150", "Focus", "Fiesta", "Explorer", "Edge", "Escape", "F-350", "Fusion" };
        List<String> honda = new List<String> { " ", "Civic", "CR-V", "Fit", "Accord", "CR-Z", "Odyssey", "Hybrid" };
        List<String> hyundai = new List<String> { " ", "Accent", "Elanta", "Santa Fe", "Tucson", "Sonata", "Azera", "Genesis", "GT" };
        List<String> jeep = new List<String> { " ", "Wrangler", "Cherokee", "Renegade", "Commander", "Commanche" };
        List<String> kia = new List<String> { " ", "Sportage", "Rio", "Sedona", "Soul", "Forte" };
        List<String> lamborghini = new List<String> { " ", "Aventador", "Huracan", "Gallardo", "Diablo", "Murcielago" };
        List<String> landrover = new List<String> { " ", "Range Rover", "Range Rover Evoque", "Discovery", "Discovery Sport", "LR2", "LR4", "Freelander" };
        List<String> lexus = new List<String> { " ", "NX", "RX", "RC", "IS", "GX", "GS", "CT" };
        List<String> maserati = new List<String> { " ", "Gran Turismo", "Ghibli", "Coupe", "Quattrporte", "Spyder", "Gransport" };
        List<String> mazda = new List<String> { " ", "CX-5", "MX-5", "M2", "M6", "CX-9", "M5", "RX-8" };
        List<String> mclaren = new List<String> { " ", "650s", "MP4-12c" };
        List<String> merc = new List<String> { " ", "GLA", "CLA", "E", "CLS", "CLK", "C", "CL", "AMG-GT" };
        List<String> mini = new List<String> { " ", "Cooper", "Countryman", "Paceman", "Coupe" };
        List<String> mitsu = new List<String> { " ", "Outlander", "Lancer", "Galant", "Carisma", "Eclipse", "Endevour", "Magma" };
        List<String> nissan = new List<String> { " ", "GT-R", "Altima", "Quest", "Versa", "Almera", "Cedric", "Pathfinder", "QashQai" };
        List<String> opel = new List<String> { " ", "Astra", "Vectra", "Insignia", "Omega", "Signum", "Ascona" };
        List<String> peugot = new List<String> { " ", "206", "1007", "207", "Expert" };
        List<String> porsche = new List<String> { " ", "Maca", "Cayenne", "Panamera", "Spyder", "Carrera", "Carrera GT" };
        List<String> renault = new List<String> { " ", "Clio", "19", "Megane", "Altica", "Argoes", "Laguna", "Zoom" };
        List<String> rover = new List<String> { " ", "75", "Metro", "800", "200", "Streetwise" };
        List<String> saab = new List<String> { " ", "9-3", "9-5", "900", "9000", "9-7", "9-4x" };
        List<String> scion = new List<String> { " ", "tc", "xB", "FR-S", "xD", "iQ", "xA" };
        List<String> seat = new List<String> { " ", "Cordoba", "Leon", "Toleda", "Alhambra", "Salsa", "Altea", "Bolero" };
        List<String> skoda = new List<String> { " ", "Fabia", "Citigo", "Rapid", "Octavia", "Yeti", "Superb", "Roomster" };
        List<String> subaru = new List<String> { " ", "Outback", "Legacy", "BRZ", "WRX", "XV" };
        List<String> suzuki = new List<String> { " ", "Sx4", "Kizashi", "Grand Vitara", "XL7", "Aerio", "Swift", "Equator", "Reno" };
        List<String> tesla = new List<String> { " ", "Model S", "Model X", "SEV" };
        List<String> toyota = new List<String> { " ", "Corolla", "RAV4", "Prius", "Land Cruiser", "Yaris", "Tundra", "Highlander", "Sienna", "Avalon" };
        List<String> vauxhall = new List<String> { " ", "VxR8", "Vx220", "Saturn", "Corsavan" };
        List<String> volkswagen = new List<String> { " ", "Golf", "Polo", "Passat", "Beetle", "Jetta", "Golf GTI", "CC", "Eos", "Rabbit", "Golf R", "Touareg", "GTI" };
        List<String> volvo = new List<String> { " ", "XC90", "XC60", "S60", "S80", "V60", "V40", "S40" };

        public String strReg = "", strMakeAndModel= "", strMake = "", strModel = "", strClass = "";

        public frmCarList()
        {
            InitializeComponent();
        }

        //this is another instance of the form used for the RENT CAR function
        public frmCarList(String parent){
            strSQL = "Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status, C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R WHERE C.CLASS = R.CLASS AND STATUS = 'A' ORDER BY CLASS"; 
           InitializeComponent();
           btn_Search.Enabled = false;
           btn_Search.Visible = false;
           btn_Srch4Rent.Enabled = true;
           btn_Srch4Rent.Visible = true;
           btn_Sel.Visible = true;
           btn_Sel.Enabled = true;
           grp_Status.Enabled = false;
           cbo_Order_By.SelectedIndex = 7;
           btn_HomeFrmListCars.Visible = false;
           menuStrip1.Visible = false;
          
        }

        public void btn_HomeFrmListCars_Click(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        //LOAD
        private void frmListCars_Load_1(object sender, EventArgs e)
        {     
            rad_All_Status.Checked = true;
            rad_All_Fuel.Checked = true;
            cbo_Order_By.SelectedIndex = 7;
            addClasses();
            returnConnection();
        }

        //return connection used for filling grid
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

                grdCar.DataSource = ds.Tables["SS"];
                conn.Close();

                columnWidth();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            cbo_Class.Items.Insert(0, ""); 
            while (dr.Read())
            {       
                cbo_Class.Items.Add(dr["CLASS"]);
                
            }
            conn.Close();
        }

        //button used for search
         private void btn_Search_Click(object sender, EventArgs e)
        {
             if(validateReg())
             {
                 return;
             }
             else
                //must reset to this parameter each time
                 strSQL = "Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status,  C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R";

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

                //set Date
                strSQL = setDateRegistered(strSQL);

                //set Fuel type
                strSQL = setFuelType(strSQL);

                //set status
                strSQL = setStatus(strSQL);

                //set Join
                strSQL = setJoin(strSQL);

                //set order by
                strSQL = setOrder(strSQL);

                returnConnection();

                if (grdCar.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("No Records found!");
                    strSQL = "Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status,  C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R WHERE C.CLASS = R.CLASS ORDER BY CLASS";
                    returnConnection();
                }
            
        }


        //THIS BUTTON IS ONLY ENABLED IN THE OTHER INSTANCE OF THIS FORM - USED FOR RENT CARS

         private void btn_Srch4Rent_Click(object sender, EventArgs e)
         {
             if (validateReg())
             {
                 return;
             }
             else
                 //must reset to this parameter each time
                 strSQL = "Select * from CARS";

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

             //set Date
             strSQL = setDateRegistered(strSQL);

             //set Fuel type
             strSQL = setFuelType(strSQL);

             //set status
             strSQL = setStatusForRent(strSQL);

             //set Join
             strSQL = setJoin(strSQL);

             //set order by
             strSQL = setOrder(strSQL);

             returnConnection();

             if (grdCar.Rows[0].Cells[0].Value == null)
             {
                 MessageBox.Show("No Records found!");
                 strSQL = "Select * from CARS WHERE STATUS = 'A'Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status, C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R WHERE C.CLASS = R.CLASS AND STATUS = 'A' ORDER BY CLASS";
                 returnConnection();
             }
         }

        //method used for adding to sql string a search for reg, following methods do the same depending on name

         private String setReg(String query)         
         {
             String strReg = cboYear.Text + "-" + cboCounty.Text + "-" + txt_Reg.Text;

             if(!txt_Reg.Text.Equals("") || !cboYear.Text.Equals("") || !cboCounty.Text.Equals(""))
             {
                 query = query + " WHERE RegNo = '" + strReg + "'";
             }
             return query;
         }

        private String setYear(String query)
        {
            if (!cbo_Year.Text.Equals(""))
           {
               if (txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals(""))

                    query = query + " WHERE Year_of_Make = '" + cbo_Year.Text.ToUpper() + "'";
               else
                      query = query + " AND Year_of_Make = '" + cbo_Year.Text.ToUpper() + "'";
            }
            return query;
        }

     private String setMake(String query)
        {
            if (!cbo_Make.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals(""))
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
             if (cbo_Year.Text.Equals("") && txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals("") && cbo_Make.Text.Equals(""))
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

            if (!cbo_Colour.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals(""))
                {
                    query = query + " WHERE Colour = '" + cbo_Colour.Text.ToUpper() + "'";
                }
                else
                {
                    query = query + " AND Colour = '" + cbo_Colour.Text.ToUpper() + "'";
                }
            }
            return query;
          }

        private String setClass(String query)
        {

            if (!cbo_Class.Text.Equals(""))
            {
                if (cbo_Year.Text.Equals("") && txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals("") && cbo_Colour.Text.Equals(""))
                {
                    query = query + " WHERE C.Class = '" + cbo_Class.Text + "'";
                }
                else
                {
                    query = query + " AND C.Class = '" + cbo_Class.Text + "'";
                }
            }
            return query;
        }

        private String setDateRegistered(String query)
        {
            if (!dtp_DateReg.Checked == false)
            {
                if (cbo_Year.Text.Equals("") && txt_Reg.Text.Equals("") && cboYear.Text.Equals("") && cboCounty.Text.Equals("") && cbo_Make.Text.Equals("") && cbo_Model.Text.Equals("") && cbo_Colour.Text.Equals("") && cbo_Class.Text.Equals(""))

                    query = query + " WHERE Date_Registered = '" + String.Format("{0:dd-MMM-yy}", dtp_DateReg.Value) + "'";
                else
                    query = query + " AND Date_Registered = '" + String.Format("{0:dd-MMM-yy}", dtp_DateReg.Value) + "'";
            }
            return query;
        }

        private String setFuelType(String query)
        {
            if (rad_All_Fuel.Checked == true)
                return query;

            else
            {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Fuel_Type = '";
                else
                    query = query + " WHERE Fuel_Type = '";

                if (rad_Petrol.Checked == true)
                    query = query + "P'";
                else if (rad_Diesel.Checked == true)
                    query = query + "D'";

                return query;
            }
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
        
                if (rad_Avail.Checked == true)
                    query = query + "A'";
                else if (rad_Del.Checked == true)
                    query = query + "D'";
                else if (rad_Out.Checked == true)
                    query = query + "O'";

                return query;
            }
         }

        //Making sure the status is set to available to rent car instance of this form
        private String setStatusForRent(String query)
        {
                //if there is a WHERE clause already in the query
                if (query.Contains("WHERE"))
                    query = query + " AND Status = 'A'";
                else
                    query = query + " WHERE Status = 'A'";

                return query;
            
        }

        //JOINS THE TABLE
        private String setJoin(String query)
        {
            //if there is a WHERE clause already in the query
            if (query.Contains("WHERE"))
                query = query + " AND C.Class = R.Class";
            else
                query = query + " WHERE C.Class  = R.Class";

            return query;

        }

        //technically not needed since you can just click on the data field in the reader to organise order
        private String setOrder(String query)
        {

            if (!cbo_Order_By.Text.Equals(""))
            {
                query = query + " ORDER BY " + cbo_Order_By.Text.ToUpper() + "";
            }

            return query;
        }


        //reset button that resets parameters
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            strSQL = "Select RegNo, Make, Model, Colour, Year_Of_Make, Fuel_Type, Status, C.Class, Rate_Per_Day, Late_Fee_Rate, Rented, Date_Registered from CARS C, RATES R WHERE C.CLASS = R.CLASS ORDER BY CLASS";
            txt_Reg.Text = "";
            cboYear.SelectedIndex = 0;
            cbo_Year.SelectedIndex = 0;
            cboCounty.SelectedIndex = 0;
            cbo_Make.SelectedIndex = 0;
            cbo_Model.SelectedIndex = -1;
            cbo_Colour.SelectedIndex = 0;
            cbo_Order_By.SelectedIndex = 7;
            rad_All_Status.Checked = true;
            rad_All_Fuel.Checked = true;
            dtp_DateReg.Checked = false;
            cbo_Class.SelectedIndex = -1;
            returnConnection();
        }

        private void btn_Sel_Click(object sender, EventArgs e)
        {
            this.Hide();
            strReg = grdCar.Rows[grdCar.CurrentCell.RowIndex].Cells[0].Value.ToString();
            strClass = grdCar.Rows[grdCar.CurrentCell.RowIndex].Cells[7].Value.ToString();
            strMakeAndModel = strMake = (grdCar.Rows[grdCar.CurrentCell.RowIndex].Cells[1].Value.ToString()) + " " + (strModel = grdCar.Rows[grdCar.CurrentCell.RowIndex].Cells[2].Value.ToString()); 

        }


        //customizes column width on grid
        private void columnWidth()
        {
            grdCar.Columns[0].Width = 85;
            grdCar.Columns[1].Width = 100;
            grdCar.Columns[2].Width = 82;
            grdCar.Columns[3].Width = 60;
            grdCar.Columns[4].Width = 40;
            grdCar.Columns[5].Width = 37;
            grdCar.Columns[6].Width = 53;
            grdCar.Columns[7].Width = 45;
            grdCar.Columns[8].Width = 40;
            grdCar.Columns[9].Width = 62;
            grdCar.Columns[10].Width = 55;
            grdCar.Columns[11].Width = 117;
    
        }



        //validation

        private Boolean validateReg()
        {
            //REGNO
            if ((!cboYear.Text.Equals("") && !cboCounty.Text.Equals("") && !txt_Reg.Text.Equals("")))
            {
                for (int i = 0; i < txt_Reg.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_Reg.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the Registration Serial field");
                        txt_Reg.Text = "";
                        txt_Reg.Focus();
                        return true;
                    }
                }
                return false;
            }
            else if ((cboYear.Text.Equals("") && cboCounty.Text.Equals("") && !txt_Reg.Text.Equals("")) ||
                   (cboYear.Text.Equals("") && !cboCounty.Text.Equals("") && txt_Reg.Text.Equals("")) ||
                   (cboYear.Text.Equals("") && !cboCounty.Text.Equals("") && !txt_Reg.Text.Equals("")) ||
                   (!cboYear.Text.Equals("") && cboCounty.Text.Equals("") && txt_Reg.Text.Equals("")) ||
                   (!cboYear.Text.Equals("") && cboCounty.Text.Equals("") && !txt_Reg.Text.Equals("")) ||
                   (!cboYear.Text.Equals("") && !cboCounty.Text.Equals("") && txt_Reg.Text.Equals("")))
            {

                MessageBox.Show("The Registration fields must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYear.Focus();
                return true;
            }
            else
            {
                return false;
            }
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
           
        ///////////////////////   MENU STRIP   ////////////////////////


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

