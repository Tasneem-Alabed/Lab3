using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;

namespace TestProject4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[7] { 1, 2, 3 ,0,-11,50,3};
            var result = Lab3.Program.challenge5(arr);
            Assert.Equal(50, result);
        }
        [Fact]
        public void Test2()
        {
            int[] arr = new int[7] { 1, 2, -9, 0, -11, 50, 3 };
            var result = Lab3.Program.challenge5(arr);
            Assert.Equal(50, result);
        }
        [Fact]
        public void Test3()
        {
            int[] arr = new int[7] { 3, 3, 3, 3, 3, 3, 3 };
            var result = Lab3.Program.challenge5(arr);
            Assert.Equal(3, result);
        }
    }
}