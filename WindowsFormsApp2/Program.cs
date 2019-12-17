using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form12());
        }
    }
    public class node
    {
        public string Data;
        public node Next;
        public node(string Data)
        {
            this.Data = Data;
        }
        public string data { get { return Data; } set { Data = value; } }
        public node next { get { return Next; } set { Next = value; } }
    }
    public class Qlist
    {



        public node First, Last, Mynode;
        public Qlist()
        {
            first = last = null;
        }

        #region  properties

        public node first { get { return First; } set { First = value; } }
        public node last { get { return Last; } set { Last = value; } }
        public node mynode { get { return Mynode; } set { Mynode = value; } }

        #endregion

        public void enqueue(string data)
        {
            mynode = new node(data);
            if (first == null)
                first = last = mynode;
            else
            {
                last.next = mynode;
                last = mynode;
            }
        }
        public string dequeue()
        {
            if (first == null)
                return " ";
            else
            {
                string v = first.data;
                first = first.next;
                return v;
            }
        }
        public string peek()
        {
            if (first == null)
            {
                return " ";
            }
            else
            {
                string v = first.data;
                return v;
            }
        }
        public string print()
        {
            node p = first;
            string x;
            if (first == null)
            {
                return " ";
            }
            else
            {
                x = " ";
                while (p != null)
                {
                    x += p.data;
                    p = p.next;
                }
                return x;
            }

        }
        public void clear()
        {
            first = last = null;


        }

    }
}
