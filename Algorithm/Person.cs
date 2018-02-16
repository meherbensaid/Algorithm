using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Person: IEqualityComparer<Person>,IEquatable<Person> {

        public string Name { get; set; }

        public bool Equals(Person x, Person y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode();
        }

        public bool Equals(Person other)
        {
            return other != null && this.Name.Equals(other.Name);
        }
    }
}
