namespace Cau5
{
    public class User
    {
        public string Name { get; set; }
    }
    public class Tests
    {
        public string GetName(User profile)
        {
            if (profile == null)
            {
                throw new NullReferenceException("Đối tượng hồ sơ không được rỗng.");
            }

            return profile.Name;
        }

        [Test]
        public void GetName()
        {
            User profile = new User { Name = "Alice" };
            string result = GetName(profile);
            Assert.AreEqual("Alice", result, "Kết quả phải trả về tên 'Alice'.");
        }
        [Test]
        public void GetName_NgoaiLe()
        {
            User profile = null;
            Assert.Throws<NullReferenceException>(() => GetName(profile), "Khi hồ sơ là null, phải ném ngoại lệ NullReferenceException.");
        }
    }
}