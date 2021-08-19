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
    public partial class NewEmployee : Form
    {
        function fn = new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != ""  && txtname.Text!="" && txtemail.Text!="" && txtid.Text!="" && txtfname.Text!="" &&combox_desg.SelectedIndex!=-1)
            {
                Int64 mobileNo = Int64.Parse(txtmblno.Text);
                String name = txtname.Text;
                String fname = txtfname.Text;
                String email = txtemail.Text;
                String id = txtid.Text;
                String adrs = txtadrs.Text;
                String desig = combox_desg.Text;

                query = "insert into newEmployee (emobile,enamee,fname,email,paddress,idproof,edesignation) values ("+mobileNo+",'"+name+ "','" + fname+ "','" + email + "','" + adrs + "','" + id + "','" + desig + "') ";
                fn.setData(query, "Employee Registration Successfull "); 
                clearAll();



            }
            else
            {
                MessageBox.Show("Fill Empty Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtmblno.Clear(); 
            txtname.Clear();
            txtfname.Clear(); 
            txtemail.Clear();
            txtid.Clear();
            txtadrs.Clear();
            combox_desg.SelectedIndex = -1;
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
