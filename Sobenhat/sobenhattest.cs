namespace Sobenhat
{
    public class Tests
    {
        private sobenhatSevice sobenhatService;

        [SetUp]
        public void Setup()
        {
            sobenhatService = new sobenhatSevice();
        }

        // Ki?m tra tìm ph?n t? bé nh?t trong m?ng h?p l?
        [Test]
        [TestCase(new int[] { 3, 5, 1, 4 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -5, -3, 0 }, ExpectedResult = -5)]
        [TestCase(new int[] { 10, 20, 30 }, ExpectedResult = 10)]
        public int TestFindMin_ValidArray_ReturnsMin(int[] array)
        {
            return sobenhatService.FindMin(array);
        }

        // Ki?m tra tr??ng h?p m?ng r?ng
        [Test]
        public void TestFindMin_EmptyArray_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => sobenhatService.FindMin(new int[] { }));
            Assert.That(ex.Message, Is.EqualTo("M?ng không th? r?ng."));
        }

        // Ki?m tra tr??ng h?p m?ng null
        [Test]
        public void TestFindMin_NullArray_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => sobenhatService.FindMin(null));
            Assert.That(ex.Message, Is.EqualTo("M?ng không th? r?ng."));
        }
    }
}