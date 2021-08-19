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
    public partial class UnpaidFeeStudents : Form
    {
        function fn = new function();
        String query;
        public UnpaidFeeStudents()
        {
            InitializeComponent();
        }

        private void UnpaidFeeStudents_Load(object sender, EventArgs e)
        {
            query = "select mobile,namee,fname,roomNo,living,paid from newStudent where paid = 'No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
