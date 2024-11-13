namespace XuatTen
{
    public class Tests
    {
        private XuatTenService xuatTenService;

        [SetUp]
        public void Setup()
        {
            xuatTenService = new XuatTenService();
        }

        // Ki?m tra truy xu?t tên ng??i dùng h?p l?
        [Test]
        public void TestGetName_ValidProfile_ReturnsName()
        {
            var profile = new UserProfile { Name = "John Doe" };
            var result = xuatTenService.GetName(profile);
            Assert.That(result, Is.EqualTo("John Doe"));
        }

        // Ki?m tra tr??ng h?p ??i t??ng h? s? là null
        [Test]
        public void TestGetName_NullProfile_ThrowsNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => xuatTenService.GetName(null));
            Assert.That(ex.Message, Is.EqualTo("??i t??ng h? s? không th? là null."));
        }
    }
}