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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            LeavedStudents ls = new LeavedStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();
        }

        private void btn_livingS_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
           AllStudentsLiving ls = new AllStudentsLiving () { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            StudentNameNum ls = new StudentNameNum() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            PaidFeeStudents ls = new PaidFeeStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
           AllEmployeeWorking ls = new AllEmployeeWorking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
           LeavedEmployees ls = new LeavedEmployees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            UnpaidFeeStudents ls = new UnpaidFeeStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            PaidEmpSal ls  = new PaidEmpSal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form load on reports button form's panel
            this.PanelRepLoad.Controls.Clear();
            UnpaidSalEmp ls = new UnpaidSalEmp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ls.FormBorderStyle = FormBorderStyle.None;
            this.PanelRepLoad.Controls.Add(ls);
            ls.Show();

        }
    }
}
