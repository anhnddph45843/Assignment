namespace Cau6
{
    public class Tests
    {
        public int TimPhanTuNhoNhat(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng.");
            }

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        [Test]
        public void TimMin()
        {
            int[] arr = { 5, 3, 8, 1, 4 };
            int result = TimPhanTuNhoNhat(arr);
            Assert.AreEqual(1, result, "Kết quả không đúng, phần tử nhỏ nhất phải là 1.");
        }

        [Test]
        public void TimMin_MangRong()
        {
            int[] emptyArray = { };
            Assert.Throws<ArgumentException>(() => TimPhanTuNhoNhat(emptyArray), "Mảng rỗng phải ném ra ngoại lệ ArgumentException.");
        }

        [Test]
        public void TimMin_Rong()
        {
            int[] arr = { };
            int result = TimPhanTuNhoNhat(arr);
            //Assert.AreEqual(1, result, "Kết quả không đúng, phần tử nhỏ nhất phải là 1.");
        }
    }
}