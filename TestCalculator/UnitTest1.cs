using ClassLibrary_Calculator;
using Xunit.Sdk;

namespace TestCalculator
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData(4,7,11)]

        [InlineData(3, 2, 5)]

        [InlineData(14, 7, 21)]

        [InlineData(24, 17, 41)]
        public void TestAdd(int a, int b, int expected)
        {
            //arrage
            Calculator calculator = new Calculator();
            
            //act
            int output = calculator.Add(a, b);
            //assert
            Assert.Equal(expected, output);
        }
    }
}