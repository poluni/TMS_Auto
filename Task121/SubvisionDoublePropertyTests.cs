using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    public class SubvisionDoublePropertyTests
    {
        private readonly Calculator _sut = new();

        private readonly static object[] _doubleTestData =
        {
           new object[] { 15d, 15d, 1d },
           new object[] { 1d, 1d, 1d },
           new object[] { 0d, 5d, 0d },
           new object[] { 5d, -5d, -1d },
        };

        [TestCaseSource(nameof(_doubleTestData))]
        public void TestProperty_Devision(double x, double y, double result)
        {
            Assert.That(_sut.Div<double, double> (x, y), Is.EqualTo(result));
        }
    }
}
