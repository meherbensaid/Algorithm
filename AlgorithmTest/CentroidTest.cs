using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Centroid;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AlgorithmTest
{
    [TestFixture()]
    public class CentroidTest
    {
        private Centroid _centroid;
        private Point[] _polygone;
        [SetUp]
        public void SetUp()
        {
            _centroid = new Centroid();
            _polygone = new Point[]
            {
                new Point() { X = 5, Y = 3 },
                new Point() { X = 6, Y = 1 },
                new Point() { X = 7, Y = 8 },  
            };
        }

        [Test]
        public void Should_Return_The_Centroid_Of_N_Points()
        {
            var expected = new Point(6, 4);

            var actual = _centroid.CalculateCentroid(_polygone, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
