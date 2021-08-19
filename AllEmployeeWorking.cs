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
    public partial class AllEmployeeWorking : Form
    {
        function fn = new function();
        String query;
        public AllEmployeeWorking()
        {
            InitializeComponent();
        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            //Fetch data from database nd load on form
            query = "select emobile,enamee,fname,email,paddress,idproof,edesignation,working,paid from newEmployee where working = 'Yes'";
            DataSet ds = fn.getData(query);
            //Fire data on datagridview that place on form

            //Data show on datagrid view
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
