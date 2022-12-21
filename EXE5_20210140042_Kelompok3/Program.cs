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
                return;
            }
            dewobroto.next = newnode;
            dewobroto = newnode;
        }
        public void delete()
        {
            if(endriarto == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            endriarto = endriarto.next;
            if (endriarto == null)
                dewobroto = null ;
        }
        public void display()
        {
            if (endriarto == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node tampil;
            for  (tampil = endriarto; tampil != null; tampil = tampil.next)
                Console.WriteLine(tampil.name);
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                                break;
                            }
                        case '2':
                            {
                                q.delete();
                                break;
                            }
                        case '3':
                            {
                                q.display();
                                break;
                            }
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
