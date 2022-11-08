using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: DONE
        // Add a reference to your UnitTestingExercise project: 

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project DONE
        // and add your reference to the UnitTestingExercise project DONE



        // Step 2: DONE
        // Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        // For Example: 
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // Step 3: DONE
        // Navigate to the UnitTests.cs file and complete the AddTest unit test method


        // Step 4: DONE
        // Create a Subtract method that accepts 2 integers 
        // Keep track of which number is getting passed as minuend and subtrahend 

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }


        // Step 5:DONE
        // Navigate to the UnitTests.cs file and complete the SubtractTest unit test method 


        // Step 6: DONE
        // Create a Multiply method that passes 2 integers DONE

        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }


        // Step 7:DONE
        // Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        //Step 8: DONE
        //Create a Divide method that passes 2 integers 

        public int Divide(int num1, int num2)
        {
                return num1 / num2;
        }


        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}


//public int Divide(int num1, int num2)
//try
//{
//    return num1 / num2;
//}
//catch (Exception e)
//{
//    Console.WriteLine($"{e.Message}");
//}
//finally
//{
//    //Console.WriteLine("Don't worry, this happens a lot");
//}
