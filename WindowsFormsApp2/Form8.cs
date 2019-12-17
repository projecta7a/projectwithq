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
    public partial class Form8 : Form
    {
        public Form8()
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
            q.enqueue(label_p.Text + " " + label4.Text);
            Walker.tprice += 15;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_p.Text + "   " + "15");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_7.Text + " " + label3.Text);
            Walker.tprice += 15;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_7.Text + "   " + "15");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_f.Text + " " + label12.Text);
            Walker.tprice += 15;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_f.Text + "   " + "15");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            q.enqueue(label_w.Text + " " + label5.Text);
            Walker.tprice += 10;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_w.Text + "   " + "10");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
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
