using CalculatorApp.Console;

namespace CalculatorConsole.Tests
{
    public class MtematicTest
    {
        [Fact]
        public void Matematics_Add_Method_Two_Numbers_is_equals()
        { 
            // Arrange
            double a = 2;
            double b = 3;
            double expectedResult = 5;

            // Act
            var result = Matematics.Add(a, b);

            //Assert
            Assert.Equal(expectedResult, result);

        }
        [Fact]
        public void Divide_Two_Numbers()
        {


        }
    }
}