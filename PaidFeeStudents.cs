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
    public partial class PaidFeeStudents : Form
    {
        function fn = new function();
        String query;
        public PaidFeeStudents()
        {
            InitializeComponent();
        }

        private void PaidFeeStudents_Load(object sender, EventArgs e)
        {
            query = "select mobile,namee,fname,roomNo,living,paid from newStudent where paid = 'Yes'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
