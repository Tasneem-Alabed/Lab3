using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;

namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[4] { 5, 2, 5, 10 };
           var result= Lab3.Program.challenge4(arr);
            Assert.Equal(5, result);
        }
        [Fact]
        public void Test2()
        {
            int[] arr = new int[11] { 4, 4, 3, 2, 3, 4, 5, 6, 5, 4, 3 };
           var result= Lab3.Program.challenge4(arr);
            Assert.Equal(4, result);
        }
        public void Test3()
        {
            int[] arr = new int[4] { 5, 5, 5, 5 };
           var result= Lab3.Program.challenge4(arr);
            Assert.Equal(5, result);
        }
        public void Test4()
        {
            int[] arr = new int[4] { 10, 5, 5, 10 };
           var result= Lab3.Program.challenge4(arr);
            Assert.Equal(10, result);
        }

    }
}