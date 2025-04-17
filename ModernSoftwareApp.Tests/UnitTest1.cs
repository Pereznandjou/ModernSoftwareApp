using Xunit;


using ModernSoftwareApp;


namespace ModernSoftwareApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
