using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcs
{
    class Class1
    {
        
        static void main()
        {
            DirectoryInfo d = new DirectoryInfo(@"E:\campus france\");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.pdf"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
                Console.WriteLine(str);
            }
        }
    }
}
