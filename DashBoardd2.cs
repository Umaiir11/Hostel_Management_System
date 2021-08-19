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
    public partial class DashBoardd2 : Form
    {
       
        public DashBoardd2()
        {
            InitializeComponent();
           
        }

        private void btn_newEmp_Click(object sender, EventArgs e)
        {
            this.PanelD2Load.Controls.Clear();
           NewEmployee ne = new NewEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ne.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(ne);
            ne.Show();
        }

        private void btn_upDel_e_Click(object sender, EventArgs e)
        {
            this.PanelD2Load.Controls.Clear();
           UpdateDeleteEmployee ude = new UpdateDeleteEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ude.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(ude);
            ude.Show();

        }

        private void btn_empPay_Click(object sender, EventArgs e)
        {
            this.PanelD2Load.Controls.Clear();
            EmployeePayment ep = new EmployeePayment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ep.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(ep);
            ep.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.PanelD2Load.Controls.Clear();
           AllEmployeeWorking aew = new AllEmployeeWorking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aew.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(aew);
            aew.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.PanelD2Load.Controls.Clear();
            LeavedEmployees le = new LeavedEmployees (){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            le.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(le);
            le.Show();



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.PanelD2Load.Controls.Clear();
            Settings s = new Settings () { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            s.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(s);
            s.Show();

        }



        private void PanelD2Load_Paint(object sender, PaintEventArgs e)
        {
            // after clicking  the change button the value on settings form txt box pass to the lbl that place on dashboard label
            // labl_earn.Text = "PKR175212"

        


            //labl_earn.Text = Settings.passtxt2;
            String a;
            a = Settings.passtxt2;
            if (labl_earn.Text!=a )
            {
               
                labl_earn.Text = a;
              
            }
            

            else
            {
                
            }




        }

        private void DashBoardd2_Load(object sender, EventArgs e)
        {
           
        }

        private void exportEmp_Click(object sender, EventArgs e)
        {

            this.PanelD2Load.Controls.Clear();
           ExportEmp s = new ExportEmp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            s.FormBorderStyle = FormBorderStyle.None;
            this.PanelD2Load.Controls.Add(s);
            s.Show();

        }
    }
}
