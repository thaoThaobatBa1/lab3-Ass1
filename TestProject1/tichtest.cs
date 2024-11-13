namespace TestProject1
{
    public class Tests
    {
        private tich sv;

        [SetUp]
        public void Setup()
        {
            sv = new tich();
        }

        // Ki?m tra v?i các s? nguyên h?p l?
        [Test]
        [TestCase(2, 3, ExpectedResult = 6)]
        [TestCase(-2, 3, ExpectedResult = -6)]
        [TestCase(0, 5, ExpectedResult = 0)]
        [TestCase(5, -5, ExpectedResult = -25)]
        public int TestTinhTich_ValidIntegers(float a, float b)
        {
            return sv.TinhTich(a, b);
        }

        // Ki?m tra v?i các s? không ph?i là s? nguyên
        [Test]
        [TestCase(2.5f, 3)]
        [TestCase(3, 4.7f)]
        [TestCase(2.1f, 3.6f)]
        [TestCase(-1.5f, 2)]
        public void TestTinhTich_NonIntegerInputs_ThrowsException(float a, float b)
        {
            var ex = Assert.Throws<ArgumentException>(() => sv.TinhTich(a, b));
            Assert.That(ex.Message, Is.EqualTo("C? hai s? ph?i là s? nguyên."));
        }

        // Ki?m tra v?i các tr??ng h?p biên
        [Test]
        [TestCase(int.MaxValue, 1, ExpectedResult = int.MaxValue)]
        [TestCase(int.MinValue, 1, ExpectedResult = int.MinValue)]
        [TestCase(1, int.MaxValue, ExpectedResult = int.MaxValue)]
        [TestCase(1, int.MinValue, ExpectedResult = int.MinValue)]
        public int TestTinhTich_BoundaryValues(float a, float b)
        {
            return sv.TinhTich(a, b);
        }
    }
}