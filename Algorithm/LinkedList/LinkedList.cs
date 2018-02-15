using System;

namespace Algorithm.LinkedList
{
    public class LinkedList
    {
        public Node Head;

        public Node Current;

        public int count;

        public LinkedList()
        {
            count = 0;
        }
        public LinkedList(int headValue)
        {
            Head = new Node() { Value = headValue };
            Current = Head;
            count = 1;
        }

        public LinkedList(int[] values) : this(values[0])
        {
           
            for (int i = 1; i < values.Length; i++)
            {
                this.AddAtLast(values[i]);
            }

            this.Current = Head;

        }

        public void AddAtLast(int value)
        {
            Node newNode = new Node() { Value = value };
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            Current = newNode;
            count++;
        }
        public void AddAtStart(int value)
        {
            var newNode = new Node
            {
                Value = value,
                Next = Head
            };
            Head = newNode;
            count++;
        }

        public void AddAtPosition(int value, int position)
        {
            if (position == 0)
            {
                AddAtStart(value);
                return;
            }

            if (position >= count) { AddAtLast(value); return; }
            int i = 0;
            Current = Head;
            while (i != position - 1)
            {
                Current = Current.Next;
                i++;
            }

            var newNode = new Node
            {
                Value = value,
                Next = Current.Next
            };
            Current.Next = newNode;
            Current = newNode;
            count++;
        }

        public Node GetElementByValue(int value)
        {
            if (this.count == 0) return null;

            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
                if (Current.Value == value) return Current;
            }

                return null;
        }

        public Node GetElementAt(int index)
        {
            Current = Head;
            var i = 0;
            if (this.count == 0) return null;
            if (index > this.count - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(index),"The index should be greater than the size of the linkedList");
            }
            while (Current.Next != null && i!= index)
            {
                Current = Current.Next;
                i++;
            }

            return Current;
        }

        public Node DeleteAtFirst()
        {
            if (count == 1)
            {
                Head = null;
                count--;
                return null;
            }
            else
            {
                var removedNode = Head;
                Head = Head.Next;
                Current = Head;
                count--;
                return removedNode;
            }
        }
        public Node DeleteAtLast()
        {
            var tmpNode = Head;
            while (tmpNode.Next.Next != null)
            {
                tmpNode = tmpNode.Next;
            }

            var removedNode = tmpNode.Next;
            tmpNode.Next = null;
            Current = tmpNode;
            count--;
            return removedNode;
        }

        public Node DeleteAtPosition(int position)
        {
            if (position == 0) return DeleteAtFirst();
            if (position == count-1) { return DeleteAtLast();  }
            var i = 0;
            Current = Head;
            while (i != position )
            {
                Current = Current.Next;
                i++;
            }

            var removedNode = Current;
            Current = Current.Next;
            count--;
            return removedNode;
        }
        public string DisplayNode()
        {
            var displayNode = "";
            var tmpNode = Head;
            while (tmpNode != null)
            {
                displayNode+=$"{tmpNode.Value},";
                tmpNode = tmpNode.Next;
            }

           return displayNode.Substring(0, displayNode.Length-1);

        }

    }
}
