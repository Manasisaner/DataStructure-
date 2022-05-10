// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Data Structure Program-------");
            LinkedList list = new LinkedList();//creating object of linkedlist class
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);
            list.Display();
            Console.Read();
          
        }
    }
}