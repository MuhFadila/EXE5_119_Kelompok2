using System;

namespace EXE5_119_Kelompok2
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Muhammad, Fadila;
        public queue()
        {
            Muhammad = null;
            Fadila = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element : ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (Muhammad == null)
            {
                Muhammad = newnode;
                Fadila = newnode;
            }
        }
        public void delete()
        {
            if (Muhammad == null)
            {
                Console.WriteLine("Queue kosong !");
                return;
            }
        }
    }
}
