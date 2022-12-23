using System;

namespace EXE5_119_Kelompok2
{
    class QNode
    {
        public int key;
        public QNode next;
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
