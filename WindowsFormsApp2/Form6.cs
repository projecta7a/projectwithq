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
    public partial class Form6 : Form
    {
        public Form6()
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
            q.enqueue(label_mb.Text + " " + label8.Text);
            Walker.tprice += 50;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_mb.Text + "   " + "50");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_ap.Text + " " + label7.Text);
            Walker.tprice += 65;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_ap.Text + "   " + "65");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_bp.Text + " " + label6.Text);
            Walker.tprice += 48;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_bp.Text + "   " + "48");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            q.enqueue(label_ml.Text + " " + label5.Text);
            Walker.tprice += 50;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_ml.Text + "   " + "50");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            q.enqueue(label_sp.Text + " " + label1.Text);
            Walker.tprice += 85;
            label19.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_sp.Text + "   " + "48");
            writefile.Flush();
            writefile.Close();
            file.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
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
