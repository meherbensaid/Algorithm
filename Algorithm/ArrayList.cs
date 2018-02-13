using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class ArrayList
    {
        private object[] data;
        private int count;
        private const int FIXED_SIZE = 20;

        public ArrayList()
        {
            data = new object[FIXED_SIZE];
        }

        public object Get(int index)
        {
            if (index < count) return data[index];
            throw new IndexOutOfRangeException();
          
        }

        public void Add(Object o)
        {
            if(data.Length-count <= data.Length / 2)
            {
                ResizeData();
            }
            data[count++] = o;
        }
        public object Delete(int index)
        {
            if(index < count)
            {
                var obj = data[index];
                var tmp = index;
                data[index] = null;

                while (tmp < count)
                {
                    data[tmp] = data[tmp + 1];
                    data[tmp + 1] = null;
                    tmp++;
                }
                count--;
                return obj;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void ResizeData()
        {
            Array.Resize(ref  data, data.Length * 2);
        }
    }
}
