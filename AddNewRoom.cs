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
    public partial class AddNewRoom : Form
    {
        function fn = new function();
        String query;

        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            //form load and fetch all data from db to gridviewtable
            //this.Location = new Point(350, 170);
            LabelRoomExist.Visible = false;
            LabelRoom.Visible = false;
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
           // AddNewRoom_Load(this,null);
        }

        private void btn_addr_Click(object sender, EventArgs e)
        {
            //Check room is exist or not
            if (txtRoomno1.Text != "")
            {

                //Fetch data from database
                query = "select * from rooms where roomNo=" + txtRoomno1.Text + "";

                //queryfire
                DataSet ds = fn.getData(query);

                //Check dataset actually contain some data or not.

                if (ds.Tables[0].Rows.Count == 0)
                {
                    String status;
                    if (checkbox1.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    LabelRoomExist.Visible = false;
                    query = "insert into rooms (roomNo,roomStatus) values(" + txtRoomno1.Text + ",'" + status + "') ";
                    //query fire
                    fn.setData(query, "Room Added !");
                    AddNewRoom_Load(this, null);
                }
                else
                {
                    LabelRoomExist.Text = "Room ALready Exist";
                    LabelRoomExist.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            
            if (txtRoomno2.Text != "")
            {


                query = "select * from rooms where roomNo=" + txtRoomno2.Text + "";
                DataSet ds = fn.getData(query);
                //while update if no room exist in database
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LabelRoom.Text = "No Room Exist";
                    LabelRoom.Visible = true;
                    checkbox2.Checked = false;

                }
                else
                {
                    LabelRoom.Text = "Room Found.";
                    LabelRoom.Visible = true;
                    //table-- 0th row 1 column fetcheddata
                    // this con automatically checked or un checked the check box agains the room availabilty from db
                    if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                    {
                        checkbox2.Checked = true;

                    }
                    else
                    {
                        checkbox2.Checked = false;
                    }



                }
            }
            else
            {
                 MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            String status;
            if (checkbox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus = '" + status + "' where roomNo=" + txtRoomno2.Text + "";
            //fire query
            fn.setData(query,"Details Updated");
        }
       

        private void btn_del_Click(object sender, EventArgs e)
        {

            
            if (txtRoomno2.Text != "")
            {


                if (LabelRoom.Text == "Room Found.")
                {

                    query = "delete  from rooms where roomNo=" + txtRoomno2.Text + "";
                    fn.setData(query, "Rooms Detail Deleted");
                    AddNewRoom_Load(this, null);
                }

                else
                {
                    MessageBox.Show("Trying to delete which dosen't Exist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_SearchBook_Click(object sender, EventArgs e)
        {

            //while update if no room exist in database
            query = "select * from rooms where roomNo=" + txtRoomno2.Text + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                LabelRoom.Text = "No Room Exist";
                LabelRoom.Visible = true;
               checkBox3.Checked = false;

            }
            else
            {
                LabelRoom.Text = "Room Found.";
                LabelRoom.Visible = true;
                //table-- 0th row 1 column fetcheddata
                // this con automatically checked or un checked the check box agains the room availabilty from db
                if (ds.Tables[0].Rows[0][2].ToString() == "Yes")
                {
                    checkBox3.Checked = true;

                }
                else
                {
                    checkBox3.Checked = false;
                }



            }
        }

        private void btn_Updtbook_Click(object sender, EventArgs e)
        {
            String status;
            if (checkbox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set Booked = '" + status + "' where roomNo=" + txtRoomno2.Text + "";
            //fire query
            fn.setData(query, "Details Updated");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtRoomno2.Text != "")
            {


                //Fetch data from database
                query = "select seats from rooms where roomNo = " + txtRoomno2.Text + "";

                DataSet ds = fn.getData(query);
                LabelRoom.Text = "Room Found.";
                LabelRoom.Visible = true;

                //If data exist, extract extracted data to combobox.
                if (ds.Tables[0].Rows.Count != 0)
                {
                    comboBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    LabelRoom.Text = "No Room Exist";
                    LabelRoom.Visible = true;
                    //MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //extract data from txtboxes to variables

            Int64 roomNo = Int64.Parse(txtRoomno2.Text);
            Int64 seats = Int64.Parse(comboBox1.Text);
            query = " update rooms set seats = " + seats + " where roomNo = " + roomNo + " ";
            fn.setData(query, "Room seats Updated");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

