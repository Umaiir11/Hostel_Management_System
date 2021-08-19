using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentHousing
{
    public partial class export : Form
    {
        public export()
        {
            InitializeComponent();
        }

        private void export_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getlist();

        }
        private DataTable getlist()
        {
            DataTable dt = new DataTable();
            String constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from newStudent ",con))
                {
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    dt.Load(r);
                }
            }
            return dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook =  apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            apps.Visible = true;


            worksheet = workbook.Sheets["Sheet1"];

            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported From GridView";

            for (int i = 1;i< dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i+2,j+1]= dataGridView1.Rows[i].Cells[j].Value.ToString();

                }
            }

            workbook.SaveAs("D:\\STUDATA.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            apps.Quit();
        }

    }
}
