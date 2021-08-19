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
    public partial class NewStudent : Form
    {
        function fn = new function();
        String query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus = 'Yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);
            //for adding the available rooms in combobox on that form
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                //ds is dataset.tables zero and from that table we need row, i represnt intially 0th row,we need 0th cloumn means 1st column, roomNo.
                ComboBox1.Items.Add(room);
            }
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
            ComboBox1.SelectedIndex = -1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtmblno.Text != "" && txtname.Text != "" && txtfname.Text != "" && txtemail.Text != "" && txtadrs.Text != "" && txtclg.Text != "" && txtid.Text != "" && ComboBox1.SelectedIndex != -1)
            {
                //fetch data from textboxes
                //assign to variables
                Int64 mobile = Int64.Parse(txtmblno.Text);
                String name = txtname.Text;
                String fname = txtfname.Text;
                String email = txtemail.Text;
                String address = txtadrs.Text;
                String clg = txtclg.Text;
                String id = txtid.Text;
                Int64 roomNo = Int64.Parse(ComboBox1.Text);
                //Insert data to databse from these vriables
                query = " insert into newStudent (mobile,namee,fname,email,paddress,college,idproof,roomNo) values(" + mobile + ",'" + name + "','" + fname + "','" + email + "','" + address + "','" + clg + "','" + id + "'," + roomNo + ") update rooms set Booked='Yes' where roomNo =" + roomNo + "";
                fn.setData(query, "Student Registration Done");

            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       
    }
}
