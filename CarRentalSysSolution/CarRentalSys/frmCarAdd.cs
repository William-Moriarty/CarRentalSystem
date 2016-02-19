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
    public partial class frmCarAdd : Form
    {
        String oradb = "Data Source=Oracle;User Id = t00119587;Password=vy784epg;";
        char chrFuel;

        List<String> acura = new List<String>{"TL","TLX","ILX","RLX","NSX","NSX-T","ZDX","Integra","Legend","CL","RL","Vigor","SLX"};
        List<String> alfa = new List<String>{"4C Spider","Spider","4C","8C","Giulietta","MiTo","Sportswagen","Brera","GT","GTV"};
        List<String> aston = new List<String> { "DB9", "Vanquish", "Vantage GT", "Rapide S", "Rapide", "DB7", "V12 Vantage", "Virage", "DB7" };
        List<String> audi = new List<String> { "A3", "A4", "R8", "Q5", "Q3", "A6", "Q7", "A5", "A8", "S3", "S5", "S6" };
        List<String> bentley = new List<String> { "Contiental", "Contiental GT", "Contiental GTC", "Mulsanne", "Amage", "Azure" };
        List<String> bmw = new List<String> { "3 Series", "5 Series", "6 Series", "7 Series", "2 Series", "M3", "M4", "M235", "X1", "X2", "X3", "X4", "X5" };
        List<String> bugatti = new List<String> { "Veyron", "EB110", "EB118" };
        List<String> caddy = new List<String> { "Eldorado", "Escalade", "CTS", "CTS-V", "DTS", "SRX", "STS-V" };
        List<String> chev = new List<String> { "Camaro", "Corvette", "Cruze", "Spark", "Colorado", "Impala", "Sonic", "Malibu" };
        List<String> chrysler = new List<String> { "300", "200", "300c", "Voyager", "Cruiser", "Crossfire", "Pacifica" };
        List<String> citreon = new List<String> { "C1", "DS3", "DS4", "5LS", "C3", "C4 Picasso", "Berlingo", "C5 Sedan", "C5 Estate", "C4 Coupe" };
        List<String> dodge = new List<String> { "Charger", "Viper", "Durango", "Avenger", "Dart", "Nitro", "Dakota" };
        List<String> ferarri = new List<String> { "458 Italia", "FF", "California", "458 Spider", "Enzo", "Modena" };
        List<String> fiat = new List<String> { "500", "500x", "500L", "500c", "Punto", "Coupe" };
        List<String> ford = new List<String> { "Mustang", "F-150", "Focus", "Fiesta", "Explorer", "Edge", "Escape", "F-350", "Fusion" };
        List<String> honda = new List<String> { "Civic", "CR-V", "Fit", "Accord", "CR-Z", "Odyssey", "Hybrid" };
        List<String> hyundai = new List<String> { "Accent", "Elanta", "Santa Fe", "Tucson", "Sonata", "Azera", "Genesis", "GT" };
        List<String> jeep = new List<String> { "Wrangler", "Cherokee", "Renegade", "Commander", "Commanche" };
        List<String> kia = new List<String> { "Sportage", "Rio", "Sedona", "Soul", "Forte" };
        List<String> lamborghini = new List<String> { "Aventador", "Huracan", "Gallardo", "Diablo", "Murcielago" };
        List<String> landrover = new List<String> { "Range Rover", "Range Rover Evoque", "Discovery", "Discovery Sport", "LR2", "LR4", "Freelander" };
        List<String> lexus = new List<String> { "NX", "RX", "RC", "IS", "GX", "GS", "CT" };
        List<String> maserati = new List<String> { "Gran Turismo", "Ghibli", "Coupe", "Quattrporte", "Spyder", "Gransport" };
        List<String> mazda = new List<String> { "CX-5", "MX-5", "M2", "M6", "CX-9", "M5", "RX-8" };
        List<String> mclaren = new List<String> { "650s", "MP4-12c" };
        List<String> merc = new List<String> { "GLA", "CLA", "E", "CLS", "CLK", "C", "CL", "AMG-GT" };
        List<String> mini = new List<String> { "Cooper", "Countryman", "Paceman", "Coupe" };
        List<String> mitsu = new List<String> { "Outlander", "Lancer", "Galant", "Carisma", "Eclipse", "Endevour", "Magma" };
        List<String> nissan = new List<String> { "GT-R", "Altima", "Quest", "Versa", "Almera", "Cedric", "Pathfinder", "QashQai" };
        List<String> opel = new List<String> { "Astra", "Vectra", "Insignia", "Omega", "Signum", "Ascona" };
        List<String> peugot = new List<String> { "206", "1007", "207", "Expert" };
        List<String> porsche = new List<String> { "Maca", "Cayenne", "Panamera", "Spyder", "Carrera", "Carrera GT" };
        List<String> renault = new List<String> { "Clio", "19", "Megane", "Altica", "Argoes", "Laguna", "Zoom" };
        List<String> rover = new List<String> { "75", "Metro", "800", "200", "Streetwise" };
        List<String> saab = new List<String> { "9-3", "9-5", "900", "9000", "9-7", "9-4x" };
        List<String> scion = new List<String> { "tc", "xB", "FR-S", "xD", "iQ", "xA" };
        List<String> seat = new List<String> { "Cordoba", "Leon", "Toleda", "Alhambra", "Salsa", "Altea", "Bolero" };
        List<String> skoda = new List<String> { "Fabia", "Citigo", "Rapid", "Octavia", "Yeti", "Superb", "Roomster" };
        List<String> subaru = new List<String> { "Outback", "Legacy", "BRZ", "WRX", "XV" };
        List<String> suzuki = new List<String> { "Sx4", "Kizashi", "Grand Vitara", "XL7", "Aerio", "Swift", "Equator", "Reno" };
        List<String> tesla = new List<String> { "Model S", "Model X", "SEV" };
        List<String> toyota = new List<String> { "Corolla", "RAV4", "Prius", "Land Cruiser", "Yaris", "Tundra", "Highlander", "Sienna", "Avalon" };
        List<String> vauxhall = new List<String> { "VxR8", "Vx220", "Saturn", "Corsavan" };
        List<String> volkswagen = new List<String> { "Golf", "Polo", "Passat", "Beetle", "Jetta", "Golf GTI","CC","Eos","Rabbit","Golf R","Touareg","GTI"};
        List<String> volvo = new List<String> { "XC90", "XC60", "S60", "S80", "V60", "V40", "S40" };

        //yup....

            public frmCarAdd()
        {      
            InitializeComponent();         
        }
   
        private void frmCarAdd_Load(object sender, EventArgs e)
        {
            rad_Petrol.Checked = true;
            addClasses();
           
        }

         private void btn_Home_Click_1(object sender, EventArgs e)
        {
            frmMainMenu home = new frmMainMenu();
            home.Show();
            this.Close();
        }

        private void btn_AddCarConfirm_Click(object sender, EventArgs e)
        {
            //validation
            //Must be noted that car models may have numbers in them, so no validating for digits
            if (!validateRegYear() || !validateRegCounty() || !validateRegSerial() || !validateMake() || !validateModel() || !validateColour() || !validateYear())
            {
                return;
            }
            else
            //setting radio buttons
            setRadios();
            if (MessageBox.Show("Are you sure you will add the car?", "Add Car", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                returnConnection();
                MessageBox.Show("Car is Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetUI();
            }
            else
            {

                return;
            }
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetUI();
        }

        //returnConnection is the general name I use for methods for returning SQL connections, this one is for inserting into the cars table
        private void returnConnection()
        {
            try
            {
                String strRegNo = cbo_Reg_Year.Text + "-" + cbo_Reg_County.Text + "-" + txt_RegSerial.Text;

                OracleConnection conn = new OracleConnection(oradb);

                String strSQL = "INSERT INTO CARS (RegNo, Make, Model, Colour,Year_of_Make,Fuel_type, Class, Date_registered) VALUES ('" + strRegNo.ToUpper() + "','" + cboMake.Text.ToUpper() +
                    "','" + cbo_Model.Text.ToUpper() + "','" + cbo_Colour.Text.ToUpper() + "','" + cbo_Year.Text + "','" + chrFuel + "','" + cbo_RateClass.Text + "', '" + DateTime.Today.ToString("dd-MMM-yyyy") + "')";

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
            cbo_RateClass.Items.Insert(0, " "); 
            while (dr.Read())
            {
                cbo_RateClass.Items.Add(dr["CLASS"]);
            }
            conn.Close();
        }

        private void rateChange()
        {
            OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                String strSQL = "SELECT RATE_PER_DAY, DESCRIPTION FROM Cars C, Rates R WHERE '" + cbo_RateClass.Text + "' = R.Class";
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_Rate.Text = dr.GetValue(0).ToString();
                    txt_Desc.Text = dr.GetValue(1).ToString();

                }
                    conn.Close();
                
        }

          private void cbo_RateClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            rateChange();
        }


        ///////// VALIDATION


        //validates reg year to make sure its not empty
        private Boolean validateRegYear()
        {
            //REGNO
            if (!cbo_Reg_Year.Text.Equals(""))
            {          
                return true;
            }
            else
            {
                MessageBox.Show("A Registration Year must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Reg_Year.Focus();
                return false;
            }
        }
        //validates reg county
        private Boolean validateRegCounty()
        {
            //REGNO
            if (!cbo_Reg_County.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("A Registration County must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Reg_County.Focus();
                return false;
            }
        }
        
        private Boolean validateRegSerial()
        {
            //REGNO
            if (!txt_RegSerial.Text.Equals(""))
            {
                for (int i = 0; i < txt_RegSerial.Text.Length; i++)
                {
                    if (!char.IsNumber(txt_RegSerial.Text[i]))
                    {
                        MessageBox.Show("You must enter digits for the REGISTRATION NO field");
                        txt_RegSerial.Text = "";
                        txt_RegSerial.Focus();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("The REGISTRATION field must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_RegSerial.Focus();
                return false;
            }
        }

        private Boolean validateMake()
        {
            //MAKE
            if (!cboMake.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("A Make must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMake.Focus();
                return false;
            }
        }

        private Boolean validateModel()
        {
            //MODEL
            if (!cbo_Model.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("The Model field must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Model.Focus();
                return false;
            }
        }

        private Boolean validateColour()
        {
            //Colour
            if (!cbo_Colour.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("A Colour must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Colour.Focus();
                return false;
            }
        }

        private Boolean validateYear()
        {
            //Year
            if (!cbo_Year.Text.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("A Year must be selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Year.Focus();
                return false;
            }
        }

        private void setRadios()
        {
            //RADIO BUTTONS
            if (rad_Petrol.Checked == true)
            {
                chrFuel = 'P';
            }

            if (rad_Diesel.Checked == true)
            {
                chrFuel = 'D';
            }
        }
        //A method for reseting the UI (Text fields and combo boxes after a car is added
        private void resetUI()
        {
            txt_RegSerial.Text = "";
            cbo_Reg_Year.SelectedIndex = 0;
            cbo_Reg_County.SelectedIndex = 0;
            cboMake.SelectedIndex = 0;
            cbo_Model.SelectedIndex = -1;
            cbo_Colour.SelectedIndex = 0;
            cbo_Year.SelectedIndex = 0;
            cbo_RateClass.SelectedIndex = -1;
            txt_Rate.Text = "";
            txt_Desc.Text = "";
            rad_Petrol.Checked = true;
        }


        /// //////////////////////////CAR MODELS that show when CAR MAKE is selected ///////////////////////////////


        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMake.SelectedIndex == 1)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(acura.ToArray());
            }

            else if (cboMake.SelectedIndex == 2)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(alfa.ToArray());
            }
            else if (cboMake.SelectedIndex == 3)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(aston.ToArray());
            }
            else if (cboMake.SelectedIndex == 4)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(audi.ToArray());
            }
            else if (cboMake.SelectedIndex == 5)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(bentley.ToArray());
            }
            else if (cboMake.SelectedIndex == 6)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(bmw.ToArray());
            }
            else if (cboMake.SelectedIndex == 7)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(bugatti.ToArray());
            }
            else if (cboMake.SelectedIndex == 8)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(caddy.ToArray());
            }
            else if (cboMake.SelectedIndex == 9)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(chev.ToArray());
            }
            else if (cboMake.SelectedIndex == 10)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(chrysler.ToArray());
            }
            else if (cboMake.SelectedIndex == 11)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(citreon.ToArray());
            }
            else if (cboMake.SelectedIndex == 12)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(dodge.ToArray());
            }
            else if (cboMake.SelectedIndex == 13)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(ferarri.ToArray());
            }
            else if (cboMake.SelectedIndex == 14)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(fiat.ToArray());
            }
            else if (cboMake.SelectedIndex == 15)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(ford.ToArray());
            }
            else if (cboMake.SelectedIndex == 16)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(honda.ToArray());
            }
            else if (cboMake.SelectedIndex == 17)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(hyundai.ToArray());
            }
            else if (cboMake.SelectedIndex == 18)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(jeep.ToArray());
            }
            else if (cboMake.SelectedIndex == 19)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(kia.ToArray());
            }
            else if (cboMake.SelectedIndex == 20)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(lamborghini.ToArray());
            }
            else if (cboMake.SelectedIndex == 21)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(landrover.ToArray());
            }
            else if (cboMake.SelectedIndex == 22)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(lexus.ToArray());
            }
            else if (cboMake.SelectedIndex == 23)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(maserati.ToArray());
            }
            else if (cboMake.SelectedIndex == 24)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(mazda.ToArray());
            }
            else if (cboMake.SelectedIndex == 25)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(mclaren.ToArray());
            }
            else if (cboMake.SelectedIndex == 26)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(merc.ToArray());
            }
            else if (cboMake.SelectedIndex == 27)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(mini.ToArray());
            }
            else if (cboMake.SelectedIndex == 28)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(mitsu.ToArray());
            }
            else if (cboMake.SelectedIndex == 29)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(nissan.ToArray());
            }
            else if (cboMake.SelectedIndex == 30)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(opel.ToArray());
            }
            else if (cboMake.SelectedIndex == 31)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(peugot.ToArray());
            }
            else if (cboMake.SelectedIndex == 32)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(porsche.ToArray());
            }
            else if (cboMake.SelectedIndex == 33)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(renault.ToArray());
            }
            else if (cboMake.SelectedIndex == 34)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(rover.ToArray());
            }
            else if (cboMake.SelectedIndex == 35)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(saab.ToArray());
            }
            else if (cboMake.SelectedIndex == 36)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(scion.ToArray());
            }
            else if (cboMake.SelectedIndex == 37)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(seat.ToArray());
            }
            else if (cboMake.SelectedIndex == 38)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(skoda.ToArray());
            }
            else if (cboMake.SelectedIndex == 39)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(subaru.ToArray());
            }
            else if (cboMake.SelectedIndex == 40)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(suzuki.ToArray());
            }
            else if (cboMake.SelectedIndex == 41)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(tesla.ToArray());
            }
            else if (cboMake.SelectedIndex == 42)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(toyota.ToArray());
            }
            else if (cboMake.SelectedIndex == 43)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(vauxhall.ToArray());
            }
            else if (cboMake.SelectedIndex == 44)
            {
                cbo_Model.Items.Clear();
                cbo_Model.Items.AddRange(volkswagen.ToArray());
            }
            else if (cboMake.SelectedIndex == 45)
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


