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
    public partial class StudentNameNum : Form
    {
        function fn = new function();
        String query;
        public StudentNameNum()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtroomNo.Text != "")
            {

                Int64 roomNo = Int64.Parse(txtroomNo.Text);
                query = "select mobile,namee  from newStudent where roomNo =" + roomNo + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    labelNo.Visible = true;
                    labename.Visible = true;
                    guna2DataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Record With This Room Number Exists:", "Inormation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill all the empty fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentNameNum_Load(object sender, EventArgs e)
        {
            labelNo.Visible = false;
           labename.Visible = false;

        }

        private void labelearn2_Click(object sender, EventArgs e)
        {

        }
    }
}
