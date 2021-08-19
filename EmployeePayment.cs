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
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        String query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != "")
            {
                query = "select enamee,email,edesignation,paid from newEmployee where emobile =" + txtmblno.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtdesig.Text = ds.Tables[0].Rows[0][2].ToString();
                    comboBox1.Text=ds.Tables[0].Rows[0][3].ToString();


                    //if student paid previous month rent after pressing the search button data shown on datagridview
                    query = "select * from employeeSalary where mobileNo = " + txtmblno.Text + "";
                    DataSet ds2 = fn.getData(query);
                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Enter Some Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            //code set customize date fordatetimeoicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " MMMM yyyy";
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != "" && txtdues.Text != "")
            {
                //Fetch the data from database
                query = "select * from employeeSalary where mobileNo =" + Int64.Parse(txtmblno.Text) + " and fmonth ='" + dateTimePicker1.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //Fetch the data from database
                    Int64 mobile = Int64.Parse(txtmblno.Text);
                    String month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtdues.Text);
                    //Insert into fees table
                    query = "insert into employeeSalary values(" + mobile + ",'" + month + "'," + amount + ")";
                    //Finally set the data from this method.
                    fn.setData(query, "Payment Paid");
                }
                //If fees already paid for that month
                else
                {
                    MessageBox.Show("No dues of" + dateTimePicker1.Text + " Left", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txtmblno.Clear();
            txtname.Clear();
            txtdues.Clear();
            txtdesig.Clear();
            txtemail.Clear();
            dataGridView1.DataSource = 0;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtmblno.Text);
            String livingStatus = comboBox1.Text;
            query = " update newEmployee set paid = '" + livingStatus + "' where emobile = " + mobile + " ";
            fn.setData(query, "Fee Status Updated");
        }
    }
}
