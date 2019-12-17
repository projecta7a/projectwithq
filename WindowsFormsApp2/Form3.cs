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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Qlist q = new Qlist();


        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Walker f = new Walker();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            q.enqueue(label_ms.Text + " " + label4.Text);
            WindowsFormsApp2.Walker.tprice += 30;
            Walker.Text = WindowsFormsApp2.Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_ms.Text + "   " + "30");
            writefile.Flush();
            writefile.Close();
            file.Close();


        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_cs.Text + " " + label3.Text) ;
            WindowsFormsApp2.Walker.tprice += 25;
            Walker.Text = WindowsFormsApp2.Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_cs.Text + "   " + "25");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_sf.Text + " " + label12.Text);
            WindowsFormsApp2.Walker.tprice += 20;
            Walker.Text = WindowsFormsApp2.Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_sf.Text + "   " + "20");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

       

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = q.print();
            if (x != " ")
            {
                textBox1.Text = System.Environment.NewLine + x + System.Environment.NewLine;

            }
        }
    }
}
