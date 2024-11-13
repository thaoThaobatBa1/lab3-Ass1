namespace GetElTest
{
    public class Tests
    {
        private GetElementAtIndex getElementAtIndex;

        [SetUp]
        public void Setup()
        {
            getElementAtIndex = new GetElementAtIndex();
        }

        // Ki?m tra truy xu?t ph?n t? h?p l?
        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3 }, 1, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = 3)]
        public int TestGetElement_ValidIndex(int[] array, int index)
        {
            return getElementAtIndex.GetElement(array, index);
        }

        // Ki?m tra tr??ng h?p ch? m?c âm
        [Test]
        public void TestGetElement_NegativeIndex_ThrowsIndexOutOfRangeException()
        {
            var ex = Assert.Throws<IndexOutOfRangeException>(() => getElementAtIndex.GetElement(new int[] { 1, 2, 3 }, -1));
            Assert.That(ex.Message, Is.EqualTo("Ch? m?c n?m ngoài ph?m vi c?a m?ng."));
        }

        // Ki?m tra tr??ng h?p ch? m?c l?n h?n ?? dài m?ng
        [Test]
        public void TestGetElement_IndexGreaterThanLength_ThrowsIndexOutOfRangeException()
        {
            var ex = Assert.Throws<IndexOutOfRangeException>(() => getElementAtIndex.GetElement(new int[] { 1, 2, 3 }, 3));
            Assert.That(ex.Message, Is.EqualTo("Ch? m?c n?m ngoài ph?m vi c?a m?ng."));
        }
    }
}