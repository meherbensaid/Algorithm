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
    class TriInsertionTest
    {
        private TriInsertion _triInsertion;

        [SetUp]
        public void SetUp()
        {
            _triInsertion = new TriInsertion();
        }

        [Test]
        public void Should_tri_the_Table()
        {
            var table = new int[] { 3, 2, 4, 1 };
            var expected = new int[] { 1, 2, 3, 4 };

            var actual = _triInsertion.DoTri(table);

            Assert.AreEqual(expected, actual);
        }
    }
}
