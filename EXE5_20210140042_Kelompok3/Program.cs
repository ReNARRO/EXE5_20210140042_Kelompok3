using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140042_Kelompok3
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        Node endriarto, dewobroto;
        public Queue()
        {
            endriarto = null;
            dewobroto = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element: ");
            nm = Console.ReadLine(); 
            newnode.name = nm;
            newnode.next = null;
            if(endriarto == null)
            {
                endriarto = newnode;
                dewobroto = newnode;
            }
            dewobroto.next = newnode;
            dewobroto = newnode;
        }
        static void Main(string[] args)
        {
        }
    }
}
