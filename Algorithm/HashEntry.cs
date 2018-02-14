using System.Collections.Generic;

namespace Algorithm
{
    public class HashEntry<T> where T:IEqualityComparer<T>
    {
        public int Key { get; set; }
        public T Data {get; set; }

        public HashEntry(int key,T data)
        {
            this.Key = key;
            this.Data = data;
        }
    }
}