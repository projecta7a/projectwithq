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
    public partial class Form7 : Form
    {
        public Form7()
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
            q.enqueue(label_ic.Text + " " + label4.Text);
            Walker.tprice += 15;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_ic.Text + "   " + "15");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_mc.Text + " " + label3.Text);
            Walker.tprice += 35;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_mc.Text + "   " + "35");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_cc.Text + " " + label12.Text);
            Walker.tprice += 40;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_cc.Text + "   " + "45");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
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
