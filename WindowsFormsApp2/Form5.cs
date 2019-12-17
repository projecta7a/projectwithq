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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Qlist q = new Qlist();
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Walker f = new Walker();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            q.enqueue(label_m.Text + " " + label8.Text);
            Walker.tprice += 45;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_m.Text + "   " + "45");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_v.Text + " " + label7.Text);
            Walker.tprice += 50;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_v.Text + "   " + "50");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_s.Text + " " + label6.Text);
            Walker.tprice += 55;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_s.Text + "   " + "55");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            q.enqueue(label_p.Text + " " + label10.Text);
            Walker.tprice += 52;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_p.Text + "   " + "52");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            q.enqueue(label_mc.Text + " " + label4.Text);
            Walker.tprice += 60;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_mc.Text + "   " + "60");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            q.enqueue(label_mm.Text + " " + label9.Text);
            Walker.tprice += 48;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_mm.Text + "   " + "48");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
