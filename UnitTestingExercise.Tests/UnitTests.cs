using System;
using Xunit;
using UnitTestingExercise;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, -1, -1, 1)]
        [InlineData(4, 2, 3, 9)]
        [InlineData(-5, 11555, -5, 11545)]
        [InlineData(-2, -22, 5, -19)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var adder = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = adder.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(2, 3, -1)]
        [InlineData(3, -1, 4)]
        [InlineData(4, -2, 6)]
        [InlineData(-5, 11555, -11560)]
        [InlineData(-2, -22, 20)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var subtr = new Calculator();
            //Act
            var actual = subtr.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 3, 9)]
        [InlineData(-1, 3, -3)]
        [InlineData(3, 33, 99)]
        [InlineData(-22, -1, 22)]
        [InlineData(0, -332, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multr = new Calculator();
            //Act
            var actual = multr.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(7, 7, 1)]
        [InlineData(21, 3, 7)]
        [InlineData(99, 9, 11)]
        [InlineData(2, 2, 1)]
        [InlineData(15, 5, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divr = new Calculator();
            //Act
            var actual = divr.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
