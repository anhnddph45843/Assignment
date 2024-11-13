namespace Cau2
{
    public class Tests
    {
        public int Chia(int soBiChia, int soChia)
        {
            if (soChia == 0) throw new DivideByZeroException("Không thể chia cho 0.");
            return (soBiChia / soChia);
        }
        [TestCase(10, 2, 5)]     
        [TestCase(-10, 2, -5)]   
        [TestCase(0, 5, 0)]      
        [TestCase(10, -2, -5)]   
        [TestCase(-10, -2, 5)]   
        // Test các giá trị biên
        [TestCase(int.MaxValue, 1, int.MaxValue)] 
        [TestCase(int.MinValue, 1, int.MinValue)] 
        [TestCase(1, int.MaxValue, 0)]            
        [TestCase(100, 1, 100)]  
        [TestCase(100, -1, -100)]
        [TestCase(100, 0, -100)]
        public void PhepChia(int soBiChia, int soChia, double kq)
        {
            int result = Chia(soBiChia, soChia);
            Assert.AreEqual(kq, result);
        }
        [Test]
        public void PhepChia_NgoaiLe()
        {
            Assert.Throws<DivideByZeroException>(() => Chia(10, 0), "Không thể chia cho 0 phải ném ra ngoại lệ DivideByZeroException");
        }
    }
}