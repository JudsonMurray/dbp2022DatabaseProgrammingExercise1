using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// since we are using SQL Server Provider, we need to add a using
// to the System.Data.SqlClient


using System.Data.SqlClient;



namespace DataReaderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a variable to store the connection string
            string connStr = "server=(local);database=Northwind;integrated security=SSPI";

            // create a connection object
            SqlConnection conn = new SqlConnection(connStr);

            // create a command object
            SqlCommand cmd = new SqlCommand();

            // set the command object's connection property
            cmd.Connection = conn;

            // create a variable to store the sql select statement we 
            // want to execute
            string sql = "SELECT * FROM Shippers";

            // set the command object's CommandText property to the variable above
            cmd.CommandText = sql;

            // set the command object's CommandType property
            // the type of command is a T-SQL Statement, so
            // we set it to CommandType.Text (Not necessary to set this for T-SQL Statements)
            cmd.CommandType = CommandType.Text;

            //open the connection
            conn.Open();

            // create a SqlDataReader.  Go get the data by executing the command
            SqlDataReader dr = cmd.ExecuteReader();

            // declare variables to store the 
            // results that will be returned from the database

            int shipperID;
            string companyName;
            string phone;

            // check to make sure the SqlDataReader has returned records
            // if it has, loop through the SqlDataReader, and output each record
            // to a the textbox. If not, show a messagebox

            if (dr.HasRows)
            {
                MessageBox.Show($"We have results - {dr.FieldCount} Records");

                while(dr.Read())
                {
                    shipperID = Convert.ToInt32(dr["ShipperID"]);
                    companyName = dr["CompanyName"].ToString();
                    phone = dr["Phone"].ToString();

                    txtDemo1.Text += $"ShipperID: {shipperID}\tCompanyName: {companyName}\tPhone: {phone}\r\n";
                }


            }
            else
            {
                MessageBox.Show("No results found.");
            }

            // close the reader
            dr.Close();

            // close the connection
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this time, I'm cleaning up the code a bit and making it shorter
            // by using the Constructors and a using
            string connStr = "server=(local);database=Northwind;integrated security=SSPI";
            // create a variable to store the connection string

            // create a variable to store the sql select statement we 
            // want to execute
            string sql = "SELECT * FROM Shippers ORDER BY ShipperID DESC";


            // create a connection object
            SqlConnection conn = new SqlConnection(connStr);
            

            // To ensure that connections are always closed, open 
            // the connection inside a using block. This ensures that the 
            // connection is closed when the code exists the block
            // in a using block, do the following
            // create a command object, and pass the sql statement and connection
            // created above into the Constructor
            // open the connection, Execute the reader, declare the variables to store
            // the data, and then
            // check to make sure the SqlDataReader has returned records
            // if it has, loop through the SqlDataReader, and output each record
            // to a MessageBox
            // close the reader

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();


                int shipperID = -1;
                string companyName;
                string phone;



                if (dr.HasRows)
                {
                    MessageBox.Show($"There are {dr.FieldCount} columns");

                    while (dr.Read())
                    {
                        shipperID =     Convert.ToInt32(dr["shipperID"]);
                        companyName =   dr["CompanyName"].ToString();
                        phone =         dr["Phone"].ToString();

                        txtDemo2.Text += $"ShipperID: {shipperID}\tCompanyName: {companyName}\tPhone: {phone}\r\n";
                    }

                }

            }



            // close the reader

        }
    }
}
