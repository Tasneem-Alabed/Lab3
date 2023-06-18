using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int [] arr = new int[4] { 5, 2, 3 , 10};
           var result = Lab3.Program.Challenge2(4,arr);
            Assert.Equal(5,result);
        }
        [Fact]
        public void Test2()
        {
            int[] arr = new int[2] { 3, 10 };
            var result = Lab3.Program.Challenge2(2, arr);
            Assert.Equal(0, result);
        }
        [Fact]
        public void Test3()
        {
            int[] arr = new int[] { 0, 0, 0, 0 };
            var result = Lab3.Program.Challenge2(4, arr);
            Assert.Equal(0, result);
        }
    }
}