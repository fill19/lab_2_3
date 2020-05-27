using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_for_Lab_2._3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { -5, 3, 12, -11, 7, -8 };
            int result = Lab_2._3.Program.Multiplication(array);
            Assert.AreEqual(result, 252);

        }
    }
}
