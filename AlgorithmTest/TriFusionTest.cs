using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AlgorithmTest
{
    [TestFixture( )]
    public class TriFusionTest
    {
        private TriFusion _triFusion;

        [SetUp]
        public void SetUp()
        {
            _triFusion=new TriFusion();
        }

        [Test]
        public void Should_Merge_Table()
        {
            var table = new int[] {0,3, 4, 1,2};
            var expected = new int[] {0,1,2,3, 4};
            var begin = 0;
            var middle = 2;
            var end = 4;

            _triFusion.fusionner(table, begin, middle, end);

            Assert.AreEqual(expected, table);
            
;        }

        [Test]
        public void Should_Merge_Table2()
        {
            var tab = new int[] { 0, 3, 4, 1, 2 ,5};
            var expected = new int[] { 0, 1, 2, 3, 4,5 };
            var begin = 0;
            var middle = 2;
            var end = 5;

            _triFusion.fusionner(tab, begin, middle, end);

            Assert.AreEqual(expected, tab);
        }

        [Test]
        public void Should_Tri_Table()
        {
            var tab = new int[] {4, 3, 2};
            var begin = 0;
            var expected = new int [] {2, 3, 4};
            
            _triFusion.triFusion(tab,begin,tab.Length-1);

            Assert.AreEqual(expected,tab);
        }
    }
}
