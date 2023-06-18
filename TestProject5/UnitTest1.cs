using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;

namespace TestProject5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string word = "Hello challenge";
            string[,] arr = { { "Hello", "5" }, { "challenge", "9" } };
           var result = Lab3.Program.challenge9(word); 
           
            Assert.Equal(arr, result);
        }
        [Fact]
        public void Test2()
        {
            string word = ".net course lab";
            string[,] arr = { { ".net", "4" } , { "course", "6" },{ "lab", "3" } };
            var result = Lab3.Program.challenge9(word);

            Assert.Equal(arr, result);
        }
    }
}