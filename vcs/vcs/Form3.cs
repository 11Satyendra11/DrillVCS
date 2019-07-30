using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vcs
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            this.Text = "DrillVCS";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Add button inserts the user into the database 
        private void add_userbutton_Click(object sender, EventArgs e)
        {
            string conString = "User Id=SYSTEM; password=astro123./;" +
            "Data Source=localhost:1521/xe;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            OracleCommand cmd = con.CreateCommand();
            try
                {
                cmd.CommandText = "INSERT INTO ACCOUNTDRILLVCS(EMAIL,PASSWORD,USER_TYPE)VALUES(:EMAIL,:PASSWORD,'C')";
                cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 90).Value = emailTextBox.Text;
                cmd.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 90).Value = passwordTextBox.Text;

                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Command inserted sucessfully");
                MessageBox.Show("User Added Sucessfully");
            }
            catch (Exception ex1) {
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
