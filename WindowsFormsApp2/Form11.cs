using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           

            FileStream file = new FileStream("Order.txt", FileMode.Open, FileAccess.Read);
            StreamReader readfile = new StreamReader(file);
            string lines = readfile.ReadToEnd();
            readfile.Close();
            file.Close();
            label_show.Text = lines;
            
            label_price.Text = Walker.tprice.ToString();




        }

       
    }
}
