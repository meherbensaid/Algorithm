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
    class TriSelectionTest
    {
        private TriSelection _triSelection;

        [SetUp]
        public void SetUp()
        {
            _triSelection=new TriSelection();
        }

        [Test]
        public void Should_tri_the_Table()
        {
            var table = new int[] {3, 2, 4, 1};
            var expected = new int[] {1, 2, 3, 4};

            var actual = _triSelection.DoTri(table);

            Assert.AreEqual(expected,actual);
        }
    }
}
