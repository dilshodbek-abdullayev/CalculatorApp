using CalculatorApp.Console;

namespace CalculatorConsole.Tests
{
    public class MatematicTest
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
        public void Multiply_Two_Numbers()
        {
            double a = 4;
            double b = 2;
            double expectedResult = 8;

            var res = Matematics.Multiply(a, b);

            Assert.Equal(expectedResult, res);

        }
        [Fact]
        public void Subtrak_TwoNumbers()
        {
            double a = 4;
            double b = 2;
            double expectedResult = 2;

            Assert.Equal(expectedResult, Matematics.Subtrak(a, b));
        }

        [Theory]
        [InlineData(2,true)]
        [InlineData(-2,false)]
        [InlineData(1,true)]
        [InlineData(0,true)]

        public void IsValid_Numbers_than_zero(int x, bool expectedResult)
        {
            // Act
            var result = Matematics.IsValid(x);
             
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Test_Divide_Method_exception()
        {
            // Arrange
            double x = 3;
            double y = 0;

            //double exceptResult = 1.5;

            Action result = () => Matematics.Divide(x, y);

            //Assert

            Assert.Throws<DivideByZeroException>(result);

          //  Assert.Throws<ArgumentNullException>(() => result); 

        }
    }
}