namespace Cau4
{
    public class Tests
    {
        public int Get(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi của mảng.");
            }
            return arr[index];
        }

        [Test]
        public void GetIndex()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int result = Get(arr, 2);
            Assert.AreEqual(30, result, "Phần tử tại chỉ mục 2 phải là 30.");
        }

        [Test]
        public void GetIndex_NgoaiLe()
        {
            int[] arr = { 10, 20, 30 };
            Assert.Throws<IndexOutOfRangeException>(() => Get(arr, 5), "Chỉ mục nằm ngoài phạm vi phải ném ngoại lệ IndexOutOfRangeException.");
        }

        [Test]
        public void GetIndex_NgoaiLe2()
        {
            int[] arr = { 10, 20, 30 };
            Assert.Throws<IndexOutOfRangeException>(() => Get(arr, -1), "Chỉ mục âm phải ném ngoại lệ IndexOutOfRangeException.");
        }
    }
}