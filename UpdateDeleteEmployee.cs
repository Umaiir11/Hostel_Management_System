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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile =" + txtmblno.Text + "";
            DataSet ds = fn.getData(query);
            //Check dataset actually contain some data or not.
            if (ds.Tables[0].Rows.Count != 0)
            {
                txtname.Text = ds.Tables[0].Rows[0][2].ToString();
                txtfname.Text = ds.Tables[0].Rows[0][3].ToString();
                txtemail.Text = ds.Tables[0].Rows[0][4].ToString();
                txtadrs.Text = ds.Tables[0].Rows[0][5].ToString();
                txtid.Text = ds.Tables[0].Rows[0][6].ToString();
                txtdesig.Text= ds.Tables[0].Rows[0][7].ToString();
                comboBox1.Text=ds.Tables[0].Rows[0][8].ToString();


            }
            else
            {
                
                MessageBox.Show("No Record With This Mobile No Exists:", "Inormation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearAll();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Extracted All the values from the textboxes
            Int64 mobile = Int64.Parse(txtmblno.Text);
            String name = txtname.Text;
            String fname = txtfname.Text;
            String email = txtemail.Text;
            String address = txtadrs.Text;
            String id = txtid.Text;
            String desg = txtdesig.Text;
            String WorkingStatus = comboBox1.Text;

            query = " update newEmployee  set enamee = '" + name + "',fname= '" + fname + "',email= '" + email + "',paddress= '" + address + "',idproof= '" + id + "',edesignation= '" + desg + "',working= '" + WorkingStatus + "' where emobile = " + mobile +"";
            fn.setData(query, "Data Updation Successfull");
            clearAll();
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
            txtadrs.Clear();
            txtdesig.Clear();
            txtid.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //Before deletion we need to festch
            if (MessageBox.Show("Confirmation", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)==DialogResult.Yes);
            {
                query = "delete from newEmployee where emobile=" + txtmblno.Text + "";
                fn.setData(query, "Deletion Successfull");
                clearAll();
            }
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
