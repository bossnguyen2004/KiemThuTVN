namespace BaiNam
{
    public class Tests
    {
        public class ArrayHelper
        {
            public int GetElementAtIndex(int[] array, int index)
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi");
                }
                return array[index];
            }
        }
        [TestFixture]
        public class ArrayHelperTests
        {
            private ArrayHelper arrayHelper;

            [SetUp]
            public void SetUp()
            {
                arrayHelper = new ArrayHelper();
            }


            [Test]
            public void GetElementAtIndex_ValidIndex_ReturnsElement()
            {
                int[] array = { 1, 2, 3, 4, 5 };

                int result = arrayHelper.GetElementAtIndex(array, 2);
                Assert.AreEqual(3, result);
            }


        }
    }
}