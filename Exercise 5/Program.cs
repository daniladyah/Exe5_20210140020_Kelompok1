using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public class QueueLinkList
    {
        class Node
        {
            public string Value;
            public Node Next;
            public Node(string value)
            {
                Value = value;
            }
        }
        bool Empty()
        {
            if(danila == null)
                return (true);
            else
                return (false);
        }
        Node danila;
        Node anggraini;
        public void Insert(string value)
        {
            var newNode = new Node(value);
            if (anggraini != null)
            {
                anggraini.Next = newNode;
            }
            anggraini = newNode;
            if (danila == null)
            {
                danila = newNode;
            }
        }
        public void Delete()
        {
            if (danila == null)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            var value = danila.Value;
            danila = danila.Next;
            if (danila == null)
            {
                anggraini = null;
            }
        }
    }












    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
