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
        private const int FIXED_SIZE = 4;

        public ArrayList()
        {
            data = new object[FIXED_SIZE];
        }

        public ArrayList(object[] elements)
        {
            data = new object[FIXED_SIZE];
            for (int i = 0; i < elements.Length; i++)
            {
                data[i] = elements[i];
            }

            count = elements.Length;
        }


        public object Get(int index)
        {
            if (index < count) return data[index];
            throw new IndexOutOfRangeException("Index should be lower than size of the ArrayList");
          
        }

        public object Add(Object o)
        {
            if(data.Length-count <= data.Length / 2)
            {
                ResizeData();
            }
            data[count++] = o;
            return data[count-1];
        }
        public object Delete(int index)
        {
            if(index < count)
            {
                var obj = data[index];
                var tmp = index;
                data[index] = null;

                while (tmp < count-1)
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
                throw new IndexOutOfRangeException("Index should be lower than size of the ArrayList");
            }
        }

        private void ResizeData()
        {
            Array.Resize(ref  data, data.Length * 2);
        }
    }
}
