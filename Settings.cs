using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class Settings : Form
    {

        //public varibale to passs the sext on another form
        public static string passtxt2;
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_earnnigs_Click(object sender, EventArgs e)
        {
            //set text 
            //assign the txt box value that place on settings form to passtxt variable
            passtxt2 = txt_Earn.Text;
            DashBoardd2 ds = new DashBoardd2();
            ds.labl_earn.Visible = true;
            MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);







        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
