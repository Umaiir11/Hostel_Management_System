using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
//this library is for SQL Sever and db functions
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace StudentHousing
{

    //this function class methods we use in our differtnts forms for database features
    class function
    {

       
        protected SqlConnection getConnection()
        {

            //The SqlConnection is opened and set as the Connection for the SqlCommand.
            //Setting up the connection
            //creating the object
            SqlConnection con = new SqlConnection();
            //pass this object a string that is your pc server name and database name
            // So basically,Connection String is a normal String representation which contains Database connection
            // information to establish the connection between Database and the Application
            con.ConnectionString = "data source =DESKTOP-HH5KTCI\\SQLEXPRESS;database= hostel;integrated security=True";
            return con;

        }

        //This method is use to fetch data from teh database , we can extract that data on different txtboxes
        public DataSet getData(String query)
        {
            //	It is used to specifies that access is limited to the containing type or types derived from the containing class.
            // getconnection Method Creates a copy of the existing connection.This class cannot be inherited.
                 SqlConnection con = getConnection();

            //SqlCommand in C# allow the user to query and send the commands to the database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //The CommandText property sets or returns a string that contains a provider command.
            //like a SQL statement, a table name, a relative URL, or a stored procedure call.
            cmd.CommandText = query;

            //It can be used to fill the DataSet and update the data source.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //DataSet is tabular representation of data. Tabular representation means it represents data into row and column format
            DataSet ds = new DataSet();

            // da is the object of sqldata adapter that fils tha dataset 
            da.Fill(ds);
            return ds;
        }

        //this method is use to update ,insert the data of data base from froms
        public void setData(String query,String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            //SqlCommand in C# allow the user to query and send the commands to the database.
            cmd.CommandText = query;

            //We are not using the dataset, with out of dataset with the help of ExecuteNonQuery() method
            //We can change UPDATE, INSERT, or DELETE statements.
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


    }
}
