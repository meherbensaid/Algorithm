using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class LinkedList
    {
        public Node Head;

        public Node Current;

        private int count;

        public LinkedList(int headValue)
        {
            Head = new Node() { Value=headValue};
            Current = Head;
            count = 1;
        }
        
        public void AddAtLast(int value)
        {
            Node newNode = new Node() { Value = value };
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            Current = newNode;
            count++;
        }
        public void AddAtStart(int value)
        {
            Node newNode = new Node { Value = value };
            newNode.Next = Head;
            Head = newNode;
            count++;
        }

        public void AddAtPosition(int value,int position)
        {
            if (position == 0) AddAtStart(value) ;
            if (position >= count) { AddAtLast(value); return; }
            int i = 0;
            Current = Head;
            while(i!= position - 1)
            {
                Current = Current.Next;
                i++;
            }
            Node newNode = new Node() { Value =value};
            newNode.Next = Current.Next;
            Current.Next = newNode;
            Current = newNode;
            count++;
        }

        public void DeleteAtFirst() {
            if (count == 1)
            {
                Head = null;
                count--;
            }
            else
            {
                Head = Head.Next;
                Current = Head;
                count--;
            }
        }
        public void DeleteAtLast()
        {
            Node tmpNode = Head;
            while (tmpNode.Next.Next != null)
            {
                tmpNode = tmpNode.Next;
            }
            tmpNode.Next = null;
            Current = tmpNode;
            count--;
        }
        
        public void DeleteAtPosition(int position)
        {
            if (position == 0) DeleteAtFirst();
            if (position >= count) {DeleteAtLast(); return; }
            int i = 0;
            Current = Head;
            while (i != position - 1)
            {
                Current = Current.Next;
                i++;
            }
            Current.Next = Current.Next.Next;
            count--;
        }
        public void DisplayNode()
        {
            Node tmpNode = Head;
            while (tmpNode != null)
            {
                Console.WriteLine($"Node : {tmpNode.Value}");
                tmpNode = tmpNode.Next;
            }
            Console.WriteLine(" Fin Node");
        }
        
          


        public static void Main()
        {
            LinkedList L = new LinkedList(1);
            L.AddAtLast(3);
            L.AddAtLast(5);
            L.AddAtStart(0);
            L.AddAtPosition(2, 2);
            L.AddAtLast(6);
            L.AddAtPosition(4, 4);
            L.DeleteAtFirst();
            L.DeleteAtPosition(2);
            L.DeleteAtLast();
           
            L.DisplayNode();
        }
    }
}
