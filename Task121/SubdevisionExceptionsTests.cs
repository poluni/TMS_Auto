using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    public class SubdevisionExceptionsTests
    {
        private readonly Calculator _sut = new();

        [SetUp]
        public void Setup()
        {
            Console.WriteLine($"Тесты на исключения...");
        }

        [TestCase(int.MinValue, -1)]
        [Author("Jane Doe", "jane.doe@example.com")]
        [Category("Negative")]
        public void TestException_OverflowException(int x, int y)
        {
            Assert.Throws(Is.AssignableTo(typeof(OverflowException)), () => _sut.Div<int, int>(x, y));
        }

        [TestCase(5, 0), Order(1)]
        [Author("Jane Doe", "jane.doe@example.com")]
        [Category("Negative"), Category("zero")]
        public void TestException_DivideByZeroException_IntInput(int x, int y)
        {
            Assert.Throws(Is.AssignableTo(typeof(DivideByZeroException)), () => _sut.Div<int, int>(x, y));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine($"Тесты на исключения выполнены");
        }
    }
}
