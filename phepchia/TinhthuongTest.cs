namespace phepchia
{
    public class Tests
    {
        private TinhthuongSevice tinhthuongService;

        [SetUp]
        public void Setup()
        {
            tinhthuongService = new TinhthuongSevice();
        }

        // Ki?m tra v?i các s? nguyên h?p l?
        [Test]
        [TestCase(10, 2)]
        [TestCase(-10, 2)]
        [TestCase(10, -2)]
        [TestCase(-10, -2)]
        [TestCase(0, 1)]
        public void TestTinhThuong_ValidIntegers(int a, int b)
        {
            var result = tinhthuongService.TinhThuong(a, b);
            Assert.That(result, Is.EqualTo((float)a / b));
        }

        // Ki?m tra chia cho 0
        [Test]
        public void TestTinhThuong_DivideByZero_ThrowsException()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => tinhthuongService.TinhThuong(10, 0));
            Assert.That(ex.Message, Is.EqualTo("Không th? chia cho 0."));
        }

        // Ki?m tra chia v?i s? âm và s? d??ng
        [Test]
        [TestCase(int.MaxValue, 1)]
        [TestCase(int.MinValue, -1)]
        public void TestTinhThuong_BoundaryValues(int a, int b)
        {
            var result = tinhthuongService.TinhThuong(a, b);
            Assert.That(result, Is.EqualTo((float)a / b));
        }

        // Ki?m tra chia cho 1 và -1
        [Test]
        [TestCase(10, 1)]
        [TestCase(-10, -1)]
        [TestCase(10, -1)]
        public void TestTinhThuong_WithOneAndNegativeOne(int a, int b)
        {
            var result = tinhthuongService.TinhThuong(a, b);
            Assert.That(result, Is.EqualTo((float)a / b));
        }
    }
}