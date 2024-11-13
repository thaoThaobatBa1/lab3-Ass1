namespace TinhTrungBinhCongTest
{
    public class Tests
    {
        private TrungbinhcongSevice trungbinhcongService;

        [SetUp]
        public void Setup()
        {
            trungbinhcongService = new TrungbinhcongSevice();
        }

        // Ki?m tra tính toán trung bình c?ng v?i danh sách h?p l?
        [Test]
        [TestCase(new double[] { 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(new double[] { -1, 0, 1 }, ExpectedResult = 0)]
        [TestCase(new double[] { 0, 0, 0 }, ExpectedResult = 0)]
        public double TestTinhTrungBinhCong_ValidList(double[] numbers)
        {
            return trungbinhcongService.TinhTrungBinhCong(numbers.ToList());
        }

        // Ki?m tra tr??ng h?p danh sách tr?ng
        [Test]
        public void TestTinhTrungBinhCong_EmptyList_ThrowsArithmeticException()
        {
            var ex = Assert.Throws<ArithmeticException>(() => trungbinhcongService.TinhTrungBinhCong(new List<double>()));
            Assert.That(ex.Message, Is.EqualTo("Danh sách không th? tr?ng."));
        }
    }
}