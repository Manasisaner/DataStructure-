using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistuc
{
    internal class Node
    {
        public int data; // i have define two element overther
        public Node next;

        //constructor
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}

