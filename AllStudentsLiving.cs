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
    public partial class AllStudentsLiving : Form
    {
        function fn = new function();
        String query;
        public AllStudentsLiving()
        {
            InitializeComponent();
        }

        private void AllStudentsLiving_Load(object sender, EventArgs e)
        {
            query = "select mobile,namee,fname,email,paddress,college,idproof,roomNo,living from newStudent where living = 'Yes'";
            DataSet ds = fn.getData(query);
            //Fire data on datagridview that place on form
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
