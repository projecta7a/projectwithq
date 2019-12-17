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
    public partial class Form4 : Form
    {
        public Form4()
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
            q.enqueue(label_fc.Text + " " + label8.Text);
            Walker.tprice += 35;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_fc.Text + "   " + "35");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_s.Text + " " + label7.Text);
            Walker.tprice += 30;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_s.Text + "   " + "30");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_k.Text + " " + label6.Text) ;
            Walker.tprice += 33;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_k.Text + "   " + "33");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            q.enqueue(label_f.Text + " " + label5.Text);
            Walker.tprice += 29;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_f.Text + "   " + "29");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            q.enqueue(label_ff.Text + " " + label3.Text);
            Walker.tprice += 25;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_ff.Text + "   " + "25");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            q.enqueue(label_c.Text + " " + label4.Text);
            Walker.tprice += 36;
            label19.Text = Walker.tprice.ToString();

            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_c.Text + "   " + "36");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
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
