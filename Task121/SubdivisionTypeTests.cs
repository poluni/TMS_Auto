namespace Task121
{
    public class SubdivisionTypeTests
    {
        private readonly Calculator _sut = new();

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("Running tests for Generic method check.");
        }

        #region Sbyte Type Tests
        [TestCase((sbyte)-127, sbyte.MaxValue, (sbyte)-1)]
        public void TestWithVariablesType_SbyteInputSbyteOutput(int x, int y, sbyte result)
        {
            Assert.That(_sut.Div<int, sbyte>(x, y), Is.EqualTo(result));
        }

        [TestCase(sbyte.MaxValue, sbyte.MaxValue, (byte)1)]
        public void TestWithVariablesType_SbyteInputByteOutput(int x, int y, byte result)
        {
            Assert.That(_sut.Div<int, byte>(x, y), Is.EqualTo(result));
        }

        [TestCase(sbyte.MinValue, sbyte.MinValue, (short)1)]
        public void TestWithVariablesType_SbyteInputShortOutput(int x, int y, short result)
        {
            Assert.That(_sut.Div<int, short>(x, y), Is.EqualTo(result));
        }

        [TestCase(sbyte.MaxValue, sbyte.MaxValue, (ushort)1)]
        public void TestWithVariablesType_SbyteInputUshortOutput(int x, int y, ushort result)
        {
            Assert.That(_sut.Div<int, ushort>(x, y), Is.EqualTo(result));
        }

        [TestCase((sbyte)-127, sbyte.MaxValue, -1)]
        public void TestWithVariablesType_SbyteInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase((sbyte)-127, sbyte.MaxValue, -1.0f)]
        public void TestWithVariablesType_SbyteInputFloatOutput(int x, int y, float result)
        {
            Assert.That(_sut.Div<int, float>(x, y), Is.EqualTo(result));
        }

        [TestCase((sbyte)-127, sbyte.MaxValue, -1.0)]
        public void TestWithVariablesType_SbyteInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Byte Type Tests
        [TestCase(byte.MaxValue, byte.MaxValue, (sbyte)1)]
        public void TestWithVariablesType_ByteInputSbyteOutput(int x, int y, sbyte result)
        {
            Assert.That(_sut.Div<int, sbyte>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, (byte)1, byte.MaxValue)]
        public void TestWithVariablesType_ByteInputByteOutput(int x, int y, byte result)
        {
            Assert.That(_sut.Div<int, byte>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, byte.MaxValue, (short)1)]
        public void TestWithVariablesType_ByteInputShortOutput(int x, int y, short result)
        {
            Assert.That(_sut.Div<int, short>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, byte.MaxValue, (ushort)1)]
        public void TestWithVariablesType_ByteInputUshortOutput(int x, int y, ushort result)
        {
            Assert.That(_sut.Div<int, ushort>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, byte.MaxValue, 1)]
        public void TestWithVariablesType_ByteInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, byte.MaxValue, 1.0f)]
        public void TestWithVariablesType_ByteInputFloatOutput(int x, int y, float result)
        {
            Assert.That(_sut.Div<int, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(byte.MaxValue, byte.MaxValue, 1.0)]
        public void TestWithVariablesType_ByteInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Short Type Tests
        [TestCase(short.MaxValue, short.MaxValue, (sbyte)1)]
        public void TestWithVariablesType_ShortInputSbyteOutput(int x, int y, sbyte result)
        {
            Assert.That(_sut.Div<int, sbyte>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MaxValue, short.MaxValue, (byte)1)]
        public void TestWithVariablesType_ShortInputByteOutput(int x, int y, byte result)
        {
            Assert.That(_sut.Div<int, byte>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MinValue, short.MaxValue, (short)-1)]
        public void TestWithVariablesType_ShortInputShortOutput(int x, int y, short result)
        {
            Assert.That(_sut.Div<int, short>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MaxValue, short.MaxValue, (ushort)1)]
        public void TestWithVariablesType_ShortInputUshortOutput(int x, int y, ushort result)
        {
            Assert.That(_sut.Div<int, ushort>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MinValue, short.MaxValue, -1)]
        public void TestWithVariablesType_ShortInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MinValue, short.MaxValue, -1.0f)]
        public void TestWithVariablesType_ShortInputFloatOutput(int x, int y, float result)
        {
            Assert.That(_sut.Div<int, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(short.MinValue, short.MaxValue, -1.0)]
        public void TestWithVariablesType_ShortInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Ushort Type Tests
        [TestCase(ushort.MaxValue, ushort.MaxValue, (sbyte)1)]
        public void TestWithVariablesType_UshortInputSbyteOutput(int x, int y, sbyte result)
        {
            Assert.That(_sut.Div<int, sbyte>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, (byte)1)]
        public void TestWithVariablesType_UshortInputByteOutput(int x, int y, byte result)
        {
            Assert.That(_sut.Div<int, byte>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, (short)1)]
        public void TestWithVariablesType_UshortInputShortOutput(int x, int y, short result)
        {
            Assert.That(_sut.Div<int, short>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, (ushort)1)]
        public void TestWithVariablesType_UshortInputUshortOutput(int x, int y, ushort result)
        {
            Assert.That(_sut.Div<int, ushort>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, 1)]
        public void TestWithVariablesType_UshortInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, 1.0f)]
        public void TestWithVariablesType_UshortInputFloatOutput(int x, int y, float result)
        {
            Assert.That(_sut.Div<int, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(ushort.MaxValue, ushort.MaxValue, 1.0)]
        public void TestWithVariablesType_UsortInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Int Type Tests
        [TestCase(int.MinValue, int.MaxValue, (sbyte)-1)]
        public void TestWithVariablesType_IntInputSbyteOutput(int x, int y, sbyte result)
        {
            Assert.That(_sut.Div<int, sbyte>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MaxValue, int.MaxValue, (byte)1)]
        public void TestWithVariablesType_IntInputByteOutput(int x, int y, byte result)
        {
            Assert.That(_sut.Div<int, byte>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, int.MaxValue, (short)-1)]
        public void TestWithVariablesType_IntInputShortOutput(int x, int y, short result)
        {
            Assert.That(_sut.Div<int, short>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MaxValue, int.MaxValue, (ushort)1)]
        public void TestWithVariablesType_IntInputUshortOutput(int x, int y, ushort result)
        {
            Assert.That(_sut.Div<int, ushort>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, int.MinValue, 1)]
        public void TestWithVariablesType_IntInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, int.MinValue, 1.0f)]
        public void TestWithVariablesType_IntInputFloatOutput(int x, int y, float result)
        {
            Assert.That(_sut.Div<int, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MinValue, int.MinValue, 1.0)]
        public void TestWithVariablesType_IntInputDoubleOutput(int x, int y, double result)
        {
            Assert.That(_sut.Div<int, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Float Type Tests
        [TestCase(float.MinValue, float.MinValue, 1.0f)]
        public void TestWithVariablesType_FloatInputFloatOutput(double x, double y, float result)
        {
            Assert.That(_sut.Div<double, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(float.MinValue, float.MinValue, 1.0)]
        public void TestWithVariablesType_FloatInputDoubleOutput(double x, double y, double result)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Double Type Tests
        [TestCase(double.MinValue, double.MinValue, 1.0f)]
        public void TestWithVariablesType_DoubleInputFloatOutput(double x, double y, float result)
        {
            Assert.That(_sut.Div<double, float>(x, y), Is.EqualTo(result));
        }

        [TestCase(double.MinValue, double.MinValue, 1.0)]
        public void TestWithVariablesType_DoubleInputDoubleOutput(double x, double y, double result)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MaxValue, 1, (ulong)int.MaxValue)]
        public void TestWithVariablesType_IntInputUlongOutput(int x, int y, ulong result)
        {
            Assert.That(_sut.Div<int, ulong>(x, y), Is.EqualTo(result));
        }

        [TestCase(int.MaxValue, 1, (long)int.MaxValue)]
        public void TestWithVariablesType_IntInputLongOutput(int x, int y, long result)
        {
            Assert.That(_sut.Div<int, long>(x, y), Is.EqualTo(result));
        }
        #endregion

        #region Char Type Tests
        [TestCase((int)char.MaxValue, (int)char.MaxValue, 1)]
        public void TestWithVariablesType_CharInputIntOutput(int x, int y, int result)
        {
            Assert.That(_sut.Div<int, int>(x, y), Is.EqualTo(result));
        }

        [TestCase((double)char.MaxValue, (double)char.MaxValue, 1)]
        public void TestWithVariablesType_CharInputDoubleOutput(double x, double y, double result)
        {
            Assert.That(_sut.Div<double, double>(x, y), Is.EqualTo(result));
        }
        #endregion

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("Закончили проверку.");
        }
    }
}