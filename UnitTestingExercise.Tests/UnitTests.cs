using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <------- DONE
        [InlineData(7, 6, 3, 16)]
        [InlineData(0, 1, 4, 5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
                // create a Calculator object - DONE

            var test1 = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = test1.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 8, -1)]//Add test data <------- DONE
        [InlineData(10, 3, 7)]
        [InlineData(22, 22, 0)]


        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var test2 = new Calculator();

            //Act

            var actual = test2.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 20, 400)]//Add test data <-------
        [InlineData(40, 0, 0)]
        [InlineData(2, -3, -6)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var test3 = new Calculator();

            //Act

            var actual = test3.Multiple(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(24, 8, 3)]//Add test data <-------
        [InlineData(10, -5, -2)]
        [InlineData(100, 20, 5)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var test4 = new Calculator();

            //Act
            var actual = test4.Divide(num1, num2);

            ////Assert
            Assert.Equal(expected, actual);

        }

    }
}
