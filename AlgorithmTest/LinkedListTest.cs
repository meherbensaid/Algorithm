using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.LinkedList;
using NUnit.Framework;

namespace AlgorithmTest
{
    [TestFixture]
    class LinkedListTest
    {
        private LinkedList _linkedList;
        private LinkedList _emptyLinkedList;
        private LinkedList _linkedListFull;

       [SetUp]
        public void SetUp()
        {
            _linkedList=new LinkedList(1);
            _emptyLinkedList=new LinkedList();

            var tab = new int[] { 1, 2, 3 };
            _linkedListFull = new LinkedList(tab);
        }

        [Test]
        public void Should_Add_Element_At_Last_with_List_that_Have_One_elemnt()
        {
            var value = 12;

            var expected = 12;

            _linkedList.AddAtLast(12);
            var actualValue = _linkedList.Current.Value;
            var nexNode = _linkedList.Current.Next;

            Assert.AreEqual(expected,actualValue);
            Assert.AreEqual(null,nexNode);
        }
        [Test]
        public void Should_Add_Element_At_Last_with_List_that_Have_Many_elemnt()
        {
            var tab = new int[] {1, 2, 3};
            _linkedList=new LinkedList(tab);

            var value = 12;

            var expected = 12;

            _linkedList.AddAtLast(value);
            var actualValue = _linkedList.Current.Value;
            var nexNode = _linkedList.Current.Next;

            Assert.AreEqual(expected, actualValue);
            Assert.AreEqual(null, nexNode);
        }

        [Test]
        public void Should_Add_Element_At_The_First_Position()
        {
            const int value = 14;
            const int expected = 14;

            _linkedList.AddAtStart(value);
            var actual = _linkedList.Head.Value;

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void Should_Return_Element_When_We_Set_the_Element_Value()
        {
           
            var value = 2;
            var expected = 2;

            var actual= _linkedListFull.GetElementByValue(value).Value;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Should_Return_Null_When_The_Element_Does_Not_Exist_In_The_Linked_List()
        {
          
            const int value = 4;

            var actual = _linkedListFull.GetElementByValue(value);

            Assert.IsNull(actual);
        }

        [Test]
        public void Should_Return_Null_When_The_List_Is_Empty_Get_By_Value()
        {
            var actual=_emptyLinkedList.GetElementByValue(12);

            Assert.IsNull(actual);
        }
        [Test]
        public void Should_Return_Null_When_The_List_Is_Empty_Get_By_position()
        {
            var actual = _emptyLinkedList.GetElementAt(12);

            Assert.IsNull(actual);
        }

        [Test]
        public void Should_Return_Element_At_The_index()
        {
            var index = 2;

            var expected = 3;

            var actual = _linkedListFull.GetElementAt(index).Value;

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void Should_Return_Null_When_The_List_Is_Empty_And_We_Set_Element_Index()
        {
            var actual = _emptyLinkedList.GetElementAt(12);

            Assert.IsNull(actual);
        }

        [Test]
        public void Should_Throw_Exception_When_Index_Is_Greater_Than_LinkedList_Size()
        {
            const int index = 120;

            try
            {
                _linkedListFull.GetElementAt(index);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.IsTrue(e.Message.StartsWith("The index should be greater than the size of the linkedList"));
            }
        }
        [Test]
        public void Should_Add_Element_At_Position()
        {
            const int position = 2;
            const int value = 17;
            const int expected = 17;

            _linkedListFull.AddAtPosition(value, position);
            var actual = _linkedListFull.GetElementAt(position).Value;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Should_Add_Element_At_Position_0()
        {
            const int position = 0;
            const int value = 17;
            const int expected = 17;

            _linkedListFull.AddAtPosition(value, position);
            var actual = _linkedListFull.GetElementAt(position).Value;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Should_Add_Element_At_Last_Position()
        {
            const int position = 3;
            const int value = 17;
            const int expected = 17;

            _linkedListFull.AddAtPosition(value, position);
            var actual = _linkedListFull.GetElementAt(position).Value;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Delete_At_First_Postion_In_Linked_List_Which_Contain_One_Element()
        {
            var expected= 0;

            _linkedList.DeleteAtFirst();
            var actual = _linkedList.count;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Delete_At_First_Postion_In_Linked_List_Which_Contain_More_Than_One_Element()
        {
            var expected = _linkedListFull.Head.Next;

            _linkedListFull.DeleteAtFirst();
            var actual = _linkedListFull.Head;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Delete_Last_Element()
        {
            var expected = 2;
            var lastPoistion = _linkedListFull.count - 2;

            _linkedListFull.DeleteAtLast();
            var actual = _linkedListFull.GetElementAt(lastPoistion).Value;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Delete_Element_At_Position()
        {
            const int position = 1;
            var expected = 2;

            var actual = _linkedListFull.DeleteAtPosition(position).Value;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Delete_Element_At_Position_0()
        {
            const int position = 0;
            var expected = 1;

            var actual = _linkedListFull.DeleteAtPosition(position).Value;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Delete_Element_At_Last_Position()
        {
            const int position =2 ;
            var expected = 3;

            var actual = _linkedListFull.DeleteAtPosition(position).Value;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Dislay_LinkedList()
        {
            var expected = "1,2,3";

            var actual = _linkedListFull.DisplayNode();

            Assert.AreEqual(expected,actual);
        }

    }
}
