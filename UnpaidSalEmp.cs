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
    public partial class UnpaidSalEmp : Form
    {
       function fn = new function();
        String query;
        public UnpaidSalEmp()
        {
            InitializeComponent();
        }

        private void UnpaidSalEmp_Load(object sender, EventArgs e)
        {
            query = "select emobile,enamee,fname,edesignation,working,paid from newEmployee  where paid = 'No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
