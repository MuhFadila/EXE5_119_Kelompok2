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
                return;
            }
            Muhammad.next = newnode;
            Fadila.next = newnode;
        }
        public void delete()
        {
            if (Muhammad == null)
            {
                Console.WriteLine("Queue kosong !");
                return;
            }
            Muhammad = Muhammad.next;
            if (Muhammad == null)
                Fadila = null;
        }
        public void display()
        {
            if(Muhammad == null)
            {
                Console.WriteLine("Queue tidak ada !");
                return;
            }
            Node display;
            for (display = Fadila; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
        class program
        {
            static void Main(string[] args)
            {
                queue q = new queue();
                char ch;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Masukan data : ");
                        Console.WriteLine("2. Menghapus data : ");
                        Console.WriteLine("3. Display data : ");
                        Console.WriteLine("4. keluar");
                        Console.Write("\nMasukan pilihannya : ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch (ch)
                        {
                            case '1':
                                q.insert();
                                break;
                            case '2':
                                q.delete();
                                break;
                            case '3':
                                q.display();
                                break;
                            case '4':
                                return;
                            default:
                                Console.WriteLine("Pilihan Salah");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Check the values");
                    }
                }
            }
        }
    }
}
