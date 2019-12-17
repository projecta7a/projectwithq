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
    public partial class Form2 : Form
    {





        

        public Form2()
        {
            InitializeComponent();

        }

        Qlist q = new Qlist();


        private void button9_Click(object sender, EventArgs e)
        {
            q.enqueue(lable_fc.Text +" "+ label12.Text);
            Walker.tprice += 45;
            label_price.Text = Walker.tprice.ToString();
            
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(lable_fc.Text +"   "+ "45");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        public void button17_Click(object sender, EventArgs e)
        {
            q.enqueue(label_wb.Text + " " + label9.Text);
            Walker.tprice += 65;
            label_price.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_wb.Text + "   " + "65");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            q.enqueue(label_cp.Text + " " + label8.Text);
            Walker.tprice += 45;
            label_price.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_cp.Text + "   " + "45");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {

            q.enqueue(label_cb.Text + " " + label7.Text);
            Walker.tprice += 55;
            label_price.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_cb.Text + "   " + "55");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            q.enqueue(label_gc.Text + " " + label6.Text);
            Walker.tprice += 50;
            label_price.Text = Walker.tprice.ToString();
            FileStream file = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writefile = new StreamWriter(file);
            writefile.WriteLine(label_gc.Text + "   " + "50");
            writefile.Flush();
            writefile.Close();
            file.Close();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Walker f = new Walker();
            f.Show();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
           
        }

        private void Form2_Load(object sender, EventArgs e)
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
