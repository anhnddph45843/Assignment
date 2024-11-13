namespace MathLibTest
{
    [TestFixture]
    public class Tests
    {
        public bool IsInteger(double number) => number % 1 == 0;
        public int Tich(double x, double y)
        {
            if(!IsInteger(x)||!IsInteger(y)) throw new InvalidOperationException("Số thứ nhất và số thứ 2 phải là số nguyên");
            return (int)(x * y);
        }
        [TestCase(10, 5, 50)]           
        [TestCase(-10, 5, -50)]      
        [TestCase(0, 5, 0)]          
        [TestCase(1000, 0, 0)]      
        [TestCase(-7, -3, 21)]        
        [TestCase(int.MaxValue, 1, int.MaxValue)] 
        [TestCase(int.MinValue, 1, int.MinValue)] 
        [TestCase(1, 1, 1)]
        [TestCase(5.5, 3,10)]
        [TestCase(4, 2.5,10)]
        [TestCase(5.5, 2.5,10)]
        public void TinhTich(double a, double b, double expected)
        {
            int result = Tich(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(5.5, 3)]   
        [TestCase(4, 2.5)]  
        [TestCase(5.5, 2.5)]
        public void TinhTich_NgoaiLe(double a, double b)
        {
            Assert.Throws<InvalidOperationException>(() => Tich(a, b), "Số thứ nhất và số thứ 2 ko phải là số nguyên phải ném ra ngoại lệ InvalidOperationException");
        }
    }
}