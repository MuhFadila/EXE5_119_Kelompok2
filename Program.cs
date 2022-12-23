﻿using System;

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
    class Queue
    {
        public QNode front, rear;
        public Queue() { this.front = this.rear = null; }
        public void enqueue(int key)
        {
            QNode temp = new QNode(key);
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }
    }
}
