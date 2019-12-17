using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Node
    {
        string data;
        Node next;

        public string Data
        {
            set { data = value; }
            get { return data; }
        }

        public Node Next
        {
            set { next = value; }
            get { return next; }
        }

        public Node(string data)
        {
            this.data = data;
            next = null;
        }


    }
    class LiskClass
    {
        Node start;
        Node tail;

        public LiskClass() { start = null; tail = null; }

        public void add(String data)
        {
            Node tmp = new Node(data);

            if (start == null) { start = tmp; tail = tmp; } else { tail.Next = tmp; tail = tmp; }
        }

        //display


        public void display()
        {
            if (start==null)
            {
                Console.WriteLine( "list empty");

            }
            Node q = start;
            while (q != null)
            {
                Console.WriteLine(q.Data);
                q = q.Next;
              

            }

        }
           

    }

}
