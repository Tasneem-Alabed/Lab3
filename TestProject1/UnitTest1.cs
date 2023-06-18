using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void cha1part1()
        {
            String[] arr = new string[3] {"20","9", "1" };
            var result =Lab3.Program.Firstchaleng(arr);
            Assert.Equal(180, result);
        }
        [Fact]
        public void cha1part2()
        {
            String[] arr = new string[6] { "20", "9", "1", "5485", "2", "55" };
            var result = Lab3.Program.Firstchaleng(arr);
            Assert.Equal(180, result);
        }
        [Fact]
        public void cha1part3()
        {
            String[] arr = new string[2] { "20", "9" };
            var result = Lab3.Program.Firstchaleng(arr);
            Assert.Equal(0, result);
        }
        [Fact]
        public void cha1part4()
        {
            String[] arr = new string[3] { "20", "9", "-1" };
            var result = Lab3.Program.Firstchaleng(arr);
            Assert.Equal(-180, result);
        }
        
    }
}