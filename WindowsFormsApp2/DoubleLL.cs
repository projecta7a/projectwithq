using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Node<T>
    {
        T data;
        Node<T> next;
        Node<T> prev;

        public Node<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node(T _data)
        {
            data = _data;

            next = null;
            prev = null;
        }
    }
    class  list<T>
    {
        Node<T> start;
        Node<T> tail;

        public list()
        {
            start = tail = null;
        }

        public void dis()
        {
            if (start == null)
            {
                Console.WriteLine("list empty");
                return;
            }
            Node<T> q = start;

            while (q != null)
            {
                Console.WriteLine(q.Data);
                q = q.Next;
            }

        }
        public void addEnd(T _data)
        {
            Node<T> tmp = new Node<T>(_data);

            if (start == null)
            {
                start = tmp;
                tail = tmp;
            }

            else
            {


                tail.Next = tmp;

                tmp.Prev = tail;

                tail = tmp;


            }


        }

        public void addfirst(T _data)
        {
            Node<T> tmp = new Node<T>(_data);

            if (start == null)
                start = tail = tmp;
            else
            {
                tmp.Next = start;

                start.Prev = tmp;

                start = tmp;
            }


        }

        public void delfirst()
        {
            if (start == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                if (start.Next != null)
                {
                    start.Next.Prev = null;
                }

                start = start.Next;
                if (start == null)
                {
                    tail = null;
                }
            }
        }

        public void delLast()
        {
            if (start == null)
            {
                Console.WriteLine("empty");
            }

            else if (start.Next == null)
            {
                start = null;
            }
            else
            {
                Node<T> q = start;

                while (q.Next != null)
                {
                    q = q.Next;
                }

                q.Prev.Next = null;
            }
        }
        public void printprev(int t)
        {
            if (start == null)
            {
                Console.WriteLine("list empty");
                return;
            }
            Node<T> q = start;

            while (q != null)
            {
                if (q.Data.Equals(t))
                {
                    Console.WriteLine(q.Prev.Data);
                }

                q = q.Next;
            }
        }
        public void del(int d)
        {
            Node<T> previous = null;
            if (start == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if (start.Data.Equals(d))
            {
                if (start.Next != null)
                {
                    start.Next.Prev = null;
                    start = start.Next;
                    return;


                }
                else
                {
                    start = null;
                    Console.WriteLine("list is now empty");
                    return;
                }


            }
            Node<T> current = start;
            while (current.Next != null && !current.Data.Equals(d))
            {
                previous = current;
                current = current.Next;

            }
            if (current.Data.Equals(d))
            {
                previous.Next = previous.Next.Next;
                if (previous.Next != null)
                {
                    previous.Next.Prev = previous;

                }
                else
                {
                    tail = previous;
                }


            }
            else
            {
                Console.WriteLine("not found");

            }
        }

    }
}
