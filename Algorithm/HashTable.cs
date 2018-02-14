using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class HashTable<T> where T:IEqualityComparer<T>
    {
        public HashEntry<T>[] table;
        public const int MAX_SIZE = 10;

        public HashTable()
        {
            table=new HashEntry<T>[MAX_SIZE];
            for (int i = 0; i < MAX_SIZE; i++)
            {
                table[i] = null;
            }
        }

        public void Insert(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }
            int key = (element.GetHashCode(element));
            int positivekey = System.Math.Abs((element.GetHashCode(element)));
            int hash = (positivekey % MAX_SIZE);

            while (table[hash] != null && table[hash].Key != key)
            {
                hash = (hash + 1) % MAX_SIZE;
            }
            table[hash] = new HashEntry<T>(key, element);
        }

        private bool IsFull()
        {
            var isFull = true;
            for (int i = 0; i < MAX_SIZE; i++)
            {
                if (table[i] == null)
                isFull = false;
            }

            return isFull;
        }

        public T Remove(int key)
        {
            var hash = System.Math.Abs((key % MAX_SIZE));
            while (table[hash] != null && table[hash].Key != key)
            {
                hash = hash + 1 % MAX_SIZE;
            }
            if (table[hash] != null)
            {
                var nodeTmp = table[hash];
                table[hash] = null;
                return nodeTmp.Data;
            }
            else
            {
                return default(T);
            }
        }

        public T Retrieve(int key)
        {
            var hash = System.Math.Abs((key % MAX_SIZE));
            while (table[hash] != null && table[hash].Key != key)
            {
                hash = hash + 1 % MAX_SIZE;
            }
            return table[hash] != null ? table[hash].Data : default(T);
        }
        //public T Retrieve(int key)
        //{
        //    var hash = key % MAX_SIZE;
        //    for (int i = 0; i < MAX_SIZE; i++)
        //    {
        //        if (table[i]!=null && key == table[i].Key)
        //        {
        //            return table[i].Data;
        //        }
        //    }
        //    return default(T);
        //}

    }

    public class program
    {

        //public static void Main()
        //{
        //    Person firstName = new Person() { Name = "maher" };
        //    Person firstName2 = new Person() { Name = "mehdi" };
        //    Person firstName3 = new Person() { Name = "marwa" };
        //    Person firstName4 = new Person() { Name = "hajer" };
        //    Person firstName5 = new Person() { Name = "faouzi" };

        //    var hashCode1 = firstName.GetHashCode(firstName);
        //    var hashCode2 = firstName2.GetHashCode(firstName2);
        //    var hashCode3 = firstName3.GetHashCode(firstName3);
        //    var hashCode4 = firstName4.GetHashCode(firstName4);
        //    var hashCode5 = firstName5.GetHashCode(firstName5);


        //    HashTable<Person> table = new HashTable<Person>();
        //    Person person1 = new Person() { Name = "maher" };
        //    Person person2 = new Person() { Name = "mehdi" };
        //    Person person3 = new Person() { Name = "marwa" };
        //    Person person4 = new Person() { Name = "hajer" };
        //    Person person5 = new Person() { Name = "faouzi" };
       
        //    table.Insert(person1);
        //    table.Insert(person2);
        //    table.Insert(person3);
        //    table.Insert(person4);
        //    table.Insert(person5);

        //    var Name=table.Retrieve(hashCode1);
        //    var Name2 = table.Retrieve(hashCode2);
        //    var Name3 = table.Retrieve(hashCode3);
        //    var Name4 = table.Retrieve(hashCode4);
        //    var Name5 = table.Retrieve(hashCode5);

        //    var removedNode = table.Remove(hashCode1);
        //}
    }
}
