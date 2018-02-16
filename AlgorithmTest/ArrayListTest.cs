using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    public class ArrayListTest
    {
        private ArrayList _arrayList;
        private ArrayList _fullArrayList;

        [SetUp]
        public void SetUp()
        {
            _arrayList=new ArrayList();
            _fullArrayList=new ArrayList(new object[]{1,2,3,4});
        }

        [Test]
        public void Should_Add_Element_At_the_Array_List()
        {
            var number = 1;
            var expected = 1;

            var actual = _arrayList.Add(number);

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void Should_Add_Multiple_Element_To_Array_List()
        {
            //var number = 1;
            var expected1 = 1;
            var expected2 = 2;
            var expected3 = 3;
            var expected4 = 4;

            var actual1 = _arrayList.Add(1);
            var actual2 = _arrayList.Add(2);
            var actual3 = _arrayList.Add(3);
            var actual4 = _arrayList.Add(4);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [Test]
        public void Should_Remove_Element_In_The_specific_Index()
        {
            var index = 2;
            var expected = 3;

            var actual = _fullArrayList.Delete(index);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Throw_Exception_If_Index_Is_Out_Of_Range_When_Delete_Element()
        {
            try
            {
                var index = 8;
                var actual = _fullArrayList.Delete(index);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.IsTrue(e.Message.StartsWith("Index should be lower than size of the ArrayList"));
            }
        }

        [Test]
        public void Should_Return_Eleemnt_By_Index()
        {
            var index = 2;
            var expected = 3;

            var actual = _fullArrayList.Get(index);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Throw_Exception_If_Index_Is_Out_Of_Range_When_Get_Element()
        {
            try
            {
                var index = 8;
                var actual = _fullArrayList.Get(index);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.IsTrue(e.Message.StartsWith("Index should be lower than size of the ArrayList"));
            }
        }
    }
}
