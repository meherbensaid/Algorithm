using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class HashTableTest
    {
        private HashTable<Person> _hashTable;

        [SetUp]
        public void SetUp()
        {
            _hashTable=new HashTable<Person>();
        }

        [Test]
        public void Should_Insert_element_At_Hashtable()
        {
            var person= new Person() { Name = "maher" };
            var expected = new Person() { Name = "maher" };

            var actual = _hashTable.Insert(person).Data;

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void Should_Return_Specific_Element_By_Key()
        {
            var person1 = new Person() { Name = "a0" };
            var person2 = new Person() { Name = "a5" };
            var person3 = new Person() { Name = "xw" };
            var person4 = new Person() { Name = "qsd" };
            var person5 = new Person() { Name = "dqsdqs" };
            var person6 = new Person() { Name = "dfgd" };
            var person7 = new Person() { Name = "jh" };
            var person8 = new Person() { Name = "sdygsd" };
            var person9 = new Person() { Name = "fqsf" };
            var person10 = new Person() { Name = "fqsefdf" };
           

            var expected = new Person() { Name = "a5" };
            var key = person2.Name.GetHashCode();

            _hashTable.Insert(person1);
            _hashTable.Insert(person2);
            _hashTable.Insert(person3);
            _hashTable.Insert(person4);
            _hashTable.Insert(person5);
            _hashTable.Insert(person6);
            _hashTable.Insert(person7);
            _hashTable.Insert(person8);
            _hashTable.Insert(person9);
            _hashTable.Insert(person10);
           

            var actual = _hashTable.Get(key);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Return_False_When_HAshtable_Is_Full()
        {
            var person1 = new Person() { Name = "a0" };
            var person2 = new Person() { Name = "a5" };
            var person3 = new Person() { Name = "xw" };
            var person4 = new Person() { Name = "qsaed" };
            var person5 = new Person() { Name = "dqsdqs" };
            var person6 = new Person() { Name = "dfgd" };
            var person7 = new Person() { Name = "jh" };
            var person8 = new Person() { Name = "sdygsd" };
            var person9 = new Person() { Name = "fqsf" };
            var person10 = new Person() { Name = "fazeazeqsf" };
            var person11 = new Person() { Name = "qfsfqsf" };

            var expected = true;

            _hashTable.Insert(person1);
            _hashTable.Insert(person2);
            _hashTable.Insert(person3);
            _hashTable.Insert(person4);
            _hashTable.Insert(person5);
            _hashTable.Insert(person6);
            _hashTable.Insert(person7);
            _hashTable.Insert(person8);
            _hashTable.Insert(person9);
            _hashTable.Insert(person10);
            _hashTable.Insert(person11);

            var actual = _hashTable.IsFull();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Remove_Element_From_Hashtable()
        {
            var person1 = new Person() { Name = "a5" };
            var person2 = new Person() { Name = "a0" };
            var expected= new Person() { Name = "a0" };
            var key = person2.GetHashCode(person2);
            _hashTable.Insert(person1);
            _hashTable.Insert(person2);


            var actual = _hashTable.Remove(key);
            
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void Should_Return_null_When_Remove_Eelement_Does_Not_Exist_In_HashTAble()
        {
           
            var actual = _hashTable.Remove(78);

            Assert.AreEqual(null, actual);
        }

    }
}
