using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmTest
{
    [TestFixture]
    public class TriRapideTest
    {
        private TriRapide _triRapide;

        [SetUp]
        public void SetUp()
        {
            _triRapide=new TriRapide();           
        }

        [Test]
        public void Should_Return_The_Indice_Of_Pivot()
        {
            var tab = new int[] {1, 3, 2, 0, 9};
            var expected =1;

            var actual=_triRapide.ChoosePivot(tab,0,tab.Length-1);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Should_Tri_Table()
        {
            var tab = new int[] { 1, 3, 2, 0, 9 };
            var expected = new int[] { 0, 1, 2, 3, 9 };

            _triRapide.DoTri(tab);

            Assert.AreEqual(expected, tab);
        }
    }
}
