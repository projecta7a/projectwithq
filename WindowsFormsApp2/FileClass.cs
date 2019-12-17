using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class FileClass
    {
        public FileClass (string  Name)
        {
            FileStream fs = new FileStream("user.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Name);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
