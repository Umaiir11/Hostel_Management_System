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
    public partial class StudentFees : Form
    {
        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            //code set customize date fordatetimeoicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " MMMM yyyy";


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
                //Searching on the basis of the mobile number
                if (txtmblno.Text != "")
                {
                //fecth data from database and extract on txtboxes
                    query = "select namee,email,roomNo,paid from newStudent where mobile =" + txtmblno.Text + "";
                    //Data of a student is actually save on newStudent Table
                    // In Quuery we write the name of newStudent table
                    //fire Query
                    DataSet ds = fn.getData(query);
                    //If the dataset is empty no record exist with that number
                    //we go to the else part


                    //when data exist now we fetch all the data from data set and fill teh txt boxes

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtname.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtemail.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                        comboBox1.Text= ds.Tables[0].Rows[0][3].ToString();

                    //if student paid previous month rent after pressing the search button data shown on datagridview
                    query = "select * from fees where mobileNo = " + txtmblno.Text + "";
                        DataSet ds2 = fn.getData(query);
                        dataGridView1.DataSource = ds2.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                

            }

        private void btn_pay_Click(object sender, EventArgs e)
        {

            if (txtmblno.Text != "" && txtname.Text != "" && txtemail.Text != "")
            {

                //first we check mobile no is empty nd dues box empty
                if (txtmblno.Text != "" && txtdues.Text != "")
                {
                    //Fetch the data from database
                    query = "select * from fees where mobileNo =" + Int64.Parse(txtmblno.Text) + " and fmonth ='" + dateTimePicker1.Text + "'";
                    DataSet ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        //Fetch the data from database
                        
                        Int64 mobile = Int64.Parse(txtmblno.Text);
                        String month = dateTimePicker1.Text;
                        Int64 amount = Int64.Parse(txtdues.Text);
                        //Insert into fees table
                        query = "insert into fees values(" + mobile + ",'" + month + "'," + amount + ")";
                        
                        //Finally set the data from this method.
                        fn.setData(query, "Fees Paid");
                    }
                    //If fees already paid for that month
                    else
                    {
                        MessageBox.Show("No dues of" + dateTimePicker1.Text + " Left", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                else
                {
                    MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            txtdues.Clear();
            txtRoomNo.Clear();
            txtemail.Clear();
            dataGridView1.DataSource = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //fectch data from textbox
            Int64 mobile = Int64.Parse(txtmblno.Text);
            String livingStatus = comboBox1.Text;
            query = " update newStudent set paid = '" + livingStatus + "' where mobile = " + mobile + " ";
            fn.setData(query, "Fee Status Updated");
        }
    }
}
