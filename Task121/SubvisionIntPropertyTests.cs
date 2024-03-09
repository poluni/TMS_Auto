using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    public class SubvisionIntPropertyTests
    {
        private readonly Calculator _sut = new();

        private readonly static object[] _intTestData =
        {
           new object[] { 15, 15, 1 },
           new object[] { 1, 1, 1 },
           new object[] { 0, 5, 0 },
           new object[] { 5, -5, -1 }
        };

        [TestCaseSource(nameof(_intTestData))]
        public void TestProperty_Devision(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int> (x, y), Is.EqualTo(result));
        }
    }
}
