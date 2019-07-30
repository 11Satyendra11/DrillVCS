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
    public partial class Form2 : Form
    {
        public string ownerinfo1;
        public Form2()
        {
            InitializeComponent();
            this.Text = "DrillVCS";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Login in button logs you in. 
        private void login_button_Click(object sender, EventArgs e)
        {
            

            string conString = "User Id=SYSTEM; password=astro123./;" +
            "Data Source=localhost:1521/xe;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText = "select * from ACCOUNTDRILLVCS WHERE EMAIL = :EMAIL";
            cmd.Parameters.Add("email", OracleDbType.Varchar2, 90).Value = emailTextBox.Text;



            OracleDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(reader.GetString(2).ToString().Equals("A"))
                        {
                            if(reader.GetString(1).ToString().Equals(passwordTextBox.Text.ToString()))
                            {
                                MessageBox.Show("You have sucessfully Logged In");

                                Form3 form3 = new Form3();
                                form3.Show();
                            }else
                            {
                                MessageBox.Show("Please Enter the right Email and Password!");
                            }

                            
                        }
                        else
                        {
                            if (reader.GetString(1).ToString().Equals(passwordTextBox.Text.ToString()))
                            {
                                ownerinfo1 = reader.GetString(0).ToString();

                                MessageBox.Show("You have sucessfully Logged In");
                                Form1 form1 = new Form1();
                                form1.ownerinfo(ownerinfo1);
                                form1.Show();
                            }else
                            {
                                MessageBox.Show("Please Enter the right Email and Password!");
                            }
                        }
                        Console.WriteLine("Reader read line " + reader.GetString(2).ToString());
                    }

                   

                }
                else
                {
                    MessageBox.Show("Incorrect Email or password!");
                }
               
            }
            catch(Exception ex1)
            {

            }
           
           
           
            con.Close();
            
            
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
