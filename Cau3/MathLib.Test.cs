namespace Cau3
{
    public class Tests
    {
        public double TinhTrungBinh(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArithmeticException("Không thể tính trung bình cộng của danh sách trống.");
            }

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
        [Test]
        public void TinhTrungBinh()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double result = TinhTrungBinh(numbers);
            Assert.AreEqual(3.0, result, 0.0001, "Kết quả trung bình cộng không đúng.");
        }

        [Test]
        public void TinhTrungBinh_MangNull()
        {
            int[] nullArray = null;
            Assert.Throws<ArithmeticException>(() => TinhTrungBinh(nullArray), "Danh sách null phải ném ra ngoại lệ ArithmeticException.");
        }
    }
}