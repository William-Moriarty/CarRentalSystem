using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSys
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text.Equals("Admin") && txt_pass.Text.Equals("Pass"))
            {
                frmAdjustRates adjRates = new frmAdjustRates();
                adjRates.Show();
                this.Close();
            }
            else
                MessageBox.Show("The Username or Password is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void btn_return_Click(object sender, EventArgs e)
        {
            frmMainMenu goBack = new frmMainMenu();
            goBack.Show();
            this.Close();
        }
    }
}
