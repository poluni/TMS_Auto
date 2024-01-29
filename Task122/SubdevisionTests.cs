using NUnitProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task122
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(double))]
    public class SubdevisionTests<K>
    {
        private readonly Calculator _sut = new();

        [TestCase(int.MinValue, int.MinValue, 1), Order(1)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Positive)]
        [Priority(0)]
        public void TestWithVariablesType_IntInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, int.MinValue, 1.0), Order(1)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Positive)]
        [Priority(0)]
        public void TestWithVariablesType_IntInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }

        [TestCase(double.MinValue, double.MinValue, 1.0), Order(1)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Positive)]
        [Priority(0)]
        public void TestWithVariablesType_DoubleInputDoubleOutput(double x, double y, double result)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(result));
        }
        
        [TestCase((int)char.MaxValue, (int)char.MaxValue, 1), Order(1)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Positive)]
        [Priority(0)]
        public void TestWithVariablesType_CharInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, -1), Order(2)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Negative)]
        [Priority(2)]
        public void TestException_OverflowException(int x, int y)
        {
            Assert.Throws(Is.AssignableTo(typeof(OverflowException)), () => _sut.Div<int, int>(x, y));
        }

        [TestCase(5, 0), Order(2)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Negative)]
        [Priority(1)]
        public void TestException_DivideByZeroException_IntInput(int x, int y)
        {
            Assert.Throws(Is.AssignableTo(typeof(DivideByZeroException)), () => _sut.Div<int, int>(x, y));
        }

        [TestCase(0, 0), Order(2)]
        [Severity(SeverityLevel.Critical)]
        [CategoryType(CategoryType.Negative)]
        [Priority(1)]
        public void TestWithZeroDevide_DoubleInput(double x, double y)
        {
            Assert.IsNaN(_sut.Div<double, double>(x, y));
        }

        [TestCase(5, 0), Order(2)]
        [Severity(SeverityLevel.Major)]
        [CategoryType(CategoryType.Negative)]
        [Priority(1)]
        public void TestWithZeroDevide_DoubleInputPositiveInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.PositiveInfinity));
        }

        [TestCase(-5, 0), Order(2)]
        [Severity(SeverityLevel.Major)]
        [CategoryType(CategoryType.Negative)]
        [Priority(1)]
        public void TestWithZeroDevide_DoubleInputNegativeInfinity(double x, double y)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(Double.NegativeInfinity));
        }
    }
}
