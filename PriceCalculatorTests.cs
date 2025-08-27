using ProductApp.Services;
using Xunit;
using System;

namespace ProductApp.Tests.Services
{
    public class PriceCalculatorTests
    {
        [Theory]
        [InlineData(0, 0.07, 0)]
        [InlineData(100, 0.07, 107)]
        [InlineData(9.99, 0.07, 10.69)]
        public void AddTax_ReturnsExpectedTotal(decimal price, double rate, decimal expected)
        {
            // Arrange
            var calc = new PriceCalculator();

            // Act
            var result = calc.AddTax(price, (decimal)rate);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AddTax_ThrowsIfNegativePrice()
        {
            var calc = new PriceCalculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.AddTax(-5, 0.07m));
        }
    }
}

