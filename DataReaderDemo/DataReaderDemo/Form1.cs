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


            // create a connection object


            // create a command object


            // set the command object's connection property


            // create a variable to store the sql select statement we 
            // want to execute


            // set the command object's CommandText property to the variable above


            // set the command object's CommandType property
            // the type of command is a T-SQL Statement, so
            // we set it to CommandType.Text (Not necessary to set this for T-SQL Statements)


            //open the connection

            // create a SqlDataReader.  Go get the data by executing the command


            // declare variables to store the 
            // results that will be returned from the database


            // check to make sure the SqlDataReader has returned records
            // if it has, loop through the SqlDataReader, and output each record
            // to a the textbox. If not, show a messagebox
            

            // close the reader


            // close the connection

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this time, I'm cleaning up the code a bit and making it shorter
            // by using the Constructors and a using

            // create a variable to store the connection string


            // create a variable to store the sql select statement we 
            // want to execute


            // create a connection object


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
            

                // close the reader

            }

        }
    }
}
