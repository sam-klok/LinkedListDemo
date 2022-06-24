using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public LLNode Head { get; set; }

        public LinkedList() { }

        public LLNode this[int index]
        {
            get
            {
                var n = Head;

                for (int i = 0; i < index; i++)
                {
                    n = n.Next;
                }

                return n;
            }
            set => this[index].Data = value.Data;
        }

        public void Delete(int index)
        {
            if (index > 0)
            {
                var current = this[index];
                var previous = this[index - 1];
                previous.Next = current.Next;
            }
        }

        public void DeleteAll()
        {
            Head = null;
        }

        public LLNode Last
        {
            get
            {
                if (Head == null)
                    return null;

                var x = Head;
                while (x.Next != null)
                {
                    x = x.Next;
                }
                return x;
            }
        }

        public void Add(LLNode node)
        {
            if (Head == null)
                Head = node;
            else
                Last.Next = node;
        }

        public void AddFirst(LLNode node)
        {
            node.Next = Head;
            Head = node;
        }

        public void AddFirst(int data)
        {
            var node = new LLNode(data);
            AddFirst(node);
        }

        public LinkedList(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                var n = new LLNode(a[i]);
                Add(n);
            }
        }


        public void Print()
        {
            var n = Head;
            while (n != null)
            {
                Console.Write($"{n.Data} ");
                n = n.Next;
            }

            Console.WriteLine();
        }
    }

}
