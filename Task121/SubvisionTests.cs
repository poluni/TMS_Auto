using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    public class SubvisionTests
    {
        private readonly Calculator _sut = new();

        [TestCase(0,0), Order(2)]
        [Description("0/0 = NaN")]
        [Category("zero")]
        public void TestWithZeroDevide_DoubleInput(double x, double y)
        {
            Assert.IsNaN(_sut.Div<double, double>(x, y));
        }

        [TestCase(0, Double.NaN), Order(2)]
        [Description("0/NaN = NaN")]
        [Category("zero")]
        public void TestWithNanDevide_DoubleInputNan(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.NaN));
        }

        [TestCase(5, 0), Order(2)]
        [Description("5/0 = + бесконечность")]
        [Category("zero"), Category("Infinity")]
        public void TestWithZeroDevide_DoubleInputPositiveInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.PositiveInfinity));
        }

        [TestCase(-5, 0), Order(2)]
        [Description("-5/0 = - бесконечность")]
        [Category("zero"), Category("Infinity")]
        public void TestWithZeroDevide_DoubleInputNegativeInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.NegativeInfinity));
        }

        [TestCase(Double.NegativeInfinity, Double.MinValue), Order(2)]
        [Description("- бесконечность / мин = + бесконечность")]
        [Category("Infinity")]
        public void TestWithMinDevide_DoubleInputPositiveInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.PositiveInfinity));
        }

        [TestCase(Double.PositiveInfinity, Double.MinValue), Order(2)]
        [Description("+ бесконечность / мин = - бесконечность")]
        [Category("Infinity")]
        public void TestWithMinDevide_DoubleInputNegativeInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.NegativeInfinity));
        }

        [TestCase(Double.PositiveInfinity, Double.MaxValue), Order(2)]
         [Description("+ бесконечность / макс = + бесконечность")]
        [Category("Infinity")]
         public void TestWithMaxDevide_DoubleInputPositiveInfinity(double x, double y)
         {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.PositiveInfinity));
        }

        [TestCase(Double.NegativeInfinity, Double.MaxValue), Order(2)]
        [Description("- бесконечность / макс = - бесконечность")]
        [Category("Infinity")]
        public void TestWithMaxDevide_DoubleInputNegativeInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.NegativeInfinity));
        }        
    }
}
