using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vcs
{
    public partial class Form1 : Form
    {

        String ownerinfo2;

        String datetimenow;

        //connction for database 

        string conString = "User Id=SYSTEM; password=astro123./;" +
            "Data Source=localhost:1521/xe;";

        //arrayList for file change
        ArrayList arFilemod = new ArrayList();
        //remove duplicate
        ArrayList newList = new ArrayList();

       

       // ArrayList deletedarray = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            this.Text = "DrillVCS";
            
        }

        

        

          
        
        string strFoldername;
        string strFoldernamecopy;
        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("ownerinfo2 : " + ownerinfo2.ToString());

            


            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 strFoldername = folderBrowserDialog.SelectedPath;
                 listFilesDataView(strFoldername);
                


                

                
                    // Create a new FileSystemWatcher and set its properties.
                    FileSystemWatcher watcher = new FileSystemWatcher();
                    watcher.Path = strFoldername;
                    watcher.IncludeSubdirectories = true;
                    /* Watch for changes in LastAccess and LastWrite times, and 
                       the renaming of files or directories. */
                    watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                       | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    // Only watch text files.
                    //watcher.Filter = "*.txt";

                    // Add event handlers.
                    watcher.Changed += new FileSystemEventHandler(OnChanged);
                    watcher.Created += new FileSystemEventHandler(OnChanged);
                    watcher.Deleted += new FileSystemEventHandler(OnChanged);
                    watcher.Renamed += new RenamedEventHandler(OnRenamed);
                    watcher.Error += new ErrorEventHandler(OnError);
                // Begin watching.
                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press \'Enter\' to quit the sample.");
                Console.ReadLine();
                Console.WriteLine("this is entered");
            }
                    
                // Define the event handlers.
                 void OnChanged(object source, FileSystemEventArgs e1)
                    {
                          if(!(e1.ChangeType.ToString().Equals("Deleted")))
                            {
                            arFilemod.Add(e1.FullPath);
                            newList.Add(e1.FullPath);
                                
                            // Specify what is done when a file is changed, created, or deleted.
                            Console.WriteLine("File: " + e1.FullPath + " " + e1.ChangeType);
                            
                            }
                        

                        
                    }

                 void OnRenamed(object source, RenamedEventArgs e1)
                     {
                        
                        arFilemod.Add(e1.FullPath);
                        newList.Add(e1.FullPath);

                         // Specify what is done when a file is renamed.
                        Console.WriteLine("File: {0} renamed to {1}", e1.OldFullPath, e1.FullPath);
                    }


             void OnError(object source, ErrorEventArgs e1)
                {
                //  Show that an error has been detected.
                Console.WriteLine("The FileSystemWatcher has detected an error");
                //  Give more information if the error is due to an internal buffer overflow.
                if (e1.GetException().GetType() == typeof(InternalBufferOverflowException))
                {
                    
                    Console.WriteLine(("The file system watcher experienced an internal buffer overflow: " + e1.GetException().Message));
                }

                

               


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        //Folder Watch button 
        private void folderWatcher_Click(object sender, EventArgs e)
        {
           
            
            
                foreach(string elements in arFilemod)
                {
                    if(!newList.Contains(elements))
                    {
                        newList.Add(elements);
                    }
                }


          
            dataGridView1.DataSource = null;

            DataTable dt = new DataTable();
            for (int i =0; i<newList.Count; i++)
            {
                int rownumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rownumber].Cells["filesName"].Value = newList[i];
                
            }
            
        }


        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(commitMessageBox.Text))
            {
                Console.WriteLine(commitMessageBox.Text);

                if (count == 0)
                {
                    insertintodatabase(strFoldername);
                    count++;
                }

                if(count>0)
                {
                    changedFilestodb(strFoldername);
                    newList.Clear();
                }
            }
        }

        //Check weather the database is connected or not
        public Boolean DatabaseConnect()
        {

            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            OracleCommand cmd = con.CreateCommand();
            
            cmd.CommandText = "select * from VCS_DATABASE";

            OracleDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();

            }
            catch { Exception exp; }


            DataTable dt = new DataTable();
            dt.Load(reader);

            try
            {
                dataGridView1.DataSource = dt.DefaultView;

            }
            catch { Exception ex; }

            
          

            return true;
        }

        // list the files in the datatableview 
        public void listFilesDataView(string strFoldername1)
        {
            DirectoryInfo d = new DirectoryInfo(strFoldername1);//Assuming Test is your Folder
            FileInfo[] Filesinfo = d.GetFiles("*.*", SearchOption.AllDirectories);

            ArrayList al2 = new ArrayList();

            foreach (FileInfo file1 in Filesinfo)
            {
                al2.Add(file1.Name);
            }

           
            
            // foreach (String al3 in al2)
            //DataGridViewRow row1 = new DataGridViewRow();
            for (int i = 0; i < al2.Count; i++)
            {
                int rownumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rownumber].Cells["filesName"].Value = al2[i];
                Console.WriteLine(al2[i]);
              
            }
        }

        // Insert records into the database
        public void insertintodatabase(string strFoldername1)
        {



            DirectoryInfo d = new DirectoryInfo(strFoldername1);//Assuming Test is your Folder
            FileInfo[] Filesinfo = d.GetFiles("*.*", SearchOption.AllDirectories);

            ArrayList al2 = new ArrayList();
            foreach (FileInfo file1 in Filesinfo)
            {
                al2.Add(file1.Name);
            }

            var files = Directory.GetFiles(strFoldername1, "*.* ", SearchOption.AllDirectories);
                        
            ArrayList al = new ArrayList();

            foreach (var file in files)
            {
                al.Add(file);

            }
            Random rand = new Random();

          
            for (int i = 0; i < al2.Count; i++)
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = conString;
                con.Open();

                OracleCommand cmd = con.CreateCommand();
                string randString = rand.Next(1, 100000).ToString();

                String SourceLoc = Convert.ToString(al[i]);

                Console.WriteLine("This is SourceLoc ////////////////////" + SourceLoc);

                FileStream fs = new FileStream(SourceLoc, FileMode.Open, FileAccess.Read,FileShare.Read);
                byte[] ImageData = new byte[fs.Length];

                fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

                fs.Close();
                
                try
                {


                    

                    cmd.CommandText = "INSERT INTO VCS_DATABASE(FILESTORE,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW)VALUES(:blobtodb,:commit,:ver,:fileN,:DirN,:randN,:owner,:datenow)";

                    cmd.Parameters.Add("blobtodb", OracleDbType.Blob, ImageData,ParameterDirection.Input);
                    cmd.Parameters.Add("commit", OracleDbType.Varchar2, 90).Value = commitMessageBox.Text.ToString();
                    cmd.Parameters.Add("ver", OracleDbType.Varchar2, 90).Value = versionBox.Text.ToString();
                    cmd.Parameters.Add("fileN", OracleDbType.Varchar2, 90).Value = al2[i];
                    cmd.Parameters.Add("DirN", OracleDbType.Varchar2, 300).Value = al[i];
                    cmd.Parameters.Add("randN", OracleDbType.Varchar2, 90).Value = randString;
                    cmd.Parameters.Add("owner", OracleDbType.Varchar2, 90).Value = ownerinfo2;
                    datetimenow = DateTime.Now.ToString();
                    cmd.Parameters.Add("datenow", OracleDbType.Varchar2, 90).Value = datetimenow;


                  

                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
                catch(OracleException ex)
                {
                    Console.WriteLine("Record is not inserted into the database table.");
                    Console.WriteLine("Exception Message: " + ex.Message);
                    Console.WriteLine("Exception Source: " + ex.Source);
                }
               


               
               
            }


            dataGridView1.Rows.Clear();

        }

        //commit message
        private void commitMessageBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Changed files added to the database
        private void changedFilestodb(string folderN)
        {

            Random rand = new Random();


            for (int i = 0; i < newList.Count; i++)
            {
                OracleConnection con = new OracleConnection();
               con.ConnectionString = conString;
               con.Open();

                OracleCommand cmd = con.CreateCommand();
                string randString = rand.Next(1, 100000).ToString();

               String SourceLoc = Convert.ToString(newList[i]);

                Console.WriteLine("This is SourceLoc1 ////////////////////" + SourceLoc);

               FileStream fs = new FileStream(SourceLoc, FileMode.Open, FileAccess.Read, FileShare.Read);
               byte[] ImageData = new byte[fs.Length];

               fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

               fs.Close();

               try
                {




                   cmd.CommandText = "INSERT INTO VCS_DATABASE(FILESTORE,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW)VALUES(:blobtodb,:commit,:ver,:fileN,:DirN,:randN,:owner,:datenow)";
    
                   cmd.Parameters.Add("blobtodb", OracleDbType.Blob, ImageData, ParameterDirection.Input);
                   cmd.Parameters.Add("commit", OracleDbType.Varchar2, 90).Value = commitMessageBox.Text.ToString();
                    cmd.Parameters.Add("ver", OracleDbType.Varchar2, 90).Value = versionBox.Text.ToString();
                    cmd.Parameters.Add("fileN", OracleDbType.Varchar2, 90).Value = newList[i];
                   cmd.Parameters.Add("DirN", OracleDbType.Varchar2, 300).Value = newList[i];
                   cmd.Parameters.Add("randN", OracleDbType.Varchar2, 90).Value = randString;
                    cmd.Parameters.Add("owner", OracleDbType.Varchar2, 90).Value = ownerinfo2;
                    datetimenow = DateTime.Now.ToString();
                    cmd.Parameters.Add("datenow", OracleDbType.Varchar2, 90).Value = datetimenow;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
                catch (OracleException ex)
                {
                   Console.WriteLine("Record is not inserted into the database table.");
                    Console.WriteLine("Exception Message: " + ex.Message);
                    Console.WriteLine("Exception Source: " + ex.Source);
                }
                
           }


            dataGridView1.Rows.Clear();


        }

        //owner info 
        public void ownerinfo(String ownerinfo)
        {
            ownerinfo2 = ownerinfo;
        }

        //display all the records in the datatableview when click of a button 
        private void displayall_button_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            OracleCommand cmd = con.CreateCommand();


            cmd.CommandText = "select ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW from VCS_DATABASE WHERE OWNER = :owner";
            cmd.Parameters.Add("owner", OracleDbType.Varchar2, 90).Value = ownerinfo2;

            Console.WriteLine("The value of owner is :" + ownerinfo2);

            OracleDataReader reader = null;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader );
            
            dataGridView1.DataSource = dt.DefaultView;
           

            
            

           


        }

        //Create a branch and copy the files to another directory
        private void branch_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strFoldernamecopy = folderBrowserDialog.SelectedPath;
                //listFilesDataView(strFoldername);
               
                DirectoryCopy(strFoldername, strFoldernamecopy, true);
                MessageBox.Show("Baranch have been copied to a different folder");


            }
        }

        //Copy the files into another directory
        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        //About button window show when about button clicked 
        private void about_button_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog(this);
        }

        

        private void versionBox_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
