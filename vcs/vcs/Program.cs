using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace vcs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());

            //string conString = "Provider=ODP.NET, Managed Driver; DATA SOURCE=localhost:1521/orcl;USER ID=SYS;Password=astro123./;";
            //OleDbConnection con = new OleDbConnection();
            //con.ConnectionString = conString;
            //con.Open();
            //Console.Write("connected to the database");

            //System.Windows.Forms.DataGridView dataGridView1;
            //void button1(object sender, EventArgs e)
            //{

            //    //OleDbDataAdapter oda = new OleDbDataAdapter("select * from vcs", con);
            //    //DataTable dt = new DataTable();
            //    //dataGridView1.DataSource = dt;


            //}

        }
    }
}
