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
    public partial class UpdateDeleteStudents : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudents()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtclg.Clear();
            txtid.Clear();
            txtRoomNo1.Clear();
            comboBox1.SelectedIndex =-1;
        }

        private void UpdateDeleteStudents_Load(object sender, EventArgs e)
        {
           
            //Fetch data from database 
            query = "select roomNo from rooms where roomStatus = 'Yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);
            //for adding the available rooms in combobox on that form

            //Extract data from database to combobox
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                //ds is dataset.tables zero and from that table we need row, i represnt intially 0th row,we need 0th cloumn means 1st column, roomNo.
               txtRoomNo.Items.Add(room);
            }



        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Fetching data from db
            if (txtmblno.Text != "" )
               
            {

                //Fetch data from databse and extract on textboxes which are place on this from
                query = "select * from newStudent where mobile =" + txtmblno.Text + "";
                DataSet ds = fn.getData(query);
                //Check dataset actually contain some data or not.
                //not equall to means that it contains some data.
                if (ds.Tables[0].Rows.Count != 0)
                {
                    //Extracting on textboxes
                    txtname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtfname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtadrs.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtclg.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtid.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtRoomNo1.Text = ds.Tables[0].Rows[0][8].ToString();
                    comboBox1.Text = ds.Tables[0].Rows[0][9].ToString();

                }
                else
                {
                    clearAll();
                    MessageBox.Show("No Record With This Mobile No Exists:", "Inormation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != "" )
            {

                //Extracted All the values from the textboxes and assign  to variables
                Int64 mobile = Int64.Parse(txtmblno.Text);
                String name = txtname.Text;
                String fname = txtfname.Text;
                String email = txtemail.Text;
                String address = txtadrs.Text;
                String clg = txtclg.Text;
                String id = txtid.Text;
                Int64  roomNo = Int64.Parse(txtRoomNo1.Text);
                String livingStatus = comboBox1.Text;

                //Every data in the database newStudent table updated with data.
                //we add two quries ,working of other query is actually change the status of room avialbility
                query = " update newStudent set namee = '" + name + "',fname= '" + fname + "',email= '" + email + "',paddress= '" + address + "',college= '" + clg + "',idproof= '" + id + "',roomNo= " + roomNo + ",living= '" + livingStatus + "' where mobile = " + mobile + " update rooms set Booked ='" + livingStatus + "'where roomNo=" + roomNo + "";
                fn.setData(query, "Information Updated");

            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != "")
            {



                if (MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) ;
                query = " delete from newStudent where mobile =" + txtmblno.Text + "";
                fn.setData(query, "Data Deleted");
                clearAll();
            }
            else {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
