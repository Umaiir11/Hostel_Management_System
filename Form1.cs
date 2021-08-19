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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtuser.Text=="umair"&& txtpass.Text=="pass")
            {
                this.Hide();
               // Dashboard ds = new Dashboard();
               // ds.Show();
               Dashboardd dd = new Dashboardd();
                dd.Show();
            }
            else
            {
                txtuser.Clear();
                txtpass.Clear();
                MessageBox.Show("Please Enter Valid Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
