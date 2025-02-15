using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wk5Ex1_GradeStorage
{
    internal class Program
    {
        // Method to handle integer input
        static int HandleIntInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a whole number.\n")
        {
            // initialize return value
            int returnValue = Int32.MaxValue;


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToInt32(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value


            while (returnValue == Int32.MaxValue);


            // return returnValue
            return returnValue;
        }


        // A method to ensure double input is valid
        static double HandleDoubleInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a valid number input.\n")
        {
            // initialize return value
            double returnValue = Double.MaxValue;


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToDouble(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == Double.MaxValue);


            // return returnValue
            return returnValue;
        }


        // a method to check if an integer input is between two numbers
        static int CheckIntRange(int input, int min, int max, int evaluationValue = Int32.MinValue, string errorMessage = "Your input was out of range. Input again.\n")
        {
            // initialize return value to the input
            int returnValue = input;

            // processing


            // check if the input is grater than a max value OR less than a min value
            if (input > max || input < min)
            {
                // return an error message
                Console.WriteLine(errorMessage);
                // make evaluation variable reset
                returnValue = evaluationValue;
            }


            // return returnValue
            return returnValue;
        }

        // a method to check if a double input is between two numbers
        static double CheckDoubleRange(double input, double min, double max, double evaluationValue = Double.MinValue, string errorMessage = "Your input was out of range. Input again.\n")
        {
            // initialize return value to the input
            double returnValue = input;


            // processing


            // check if the input is grater than a max value OR less than a min value
            if (input > max || input < min)
            {
                // return an error message
                Console.WriteLine(errorMessage);
                // set return value to the evaluation value
                returnValue = evaluationValue;
            }


            // return returnValue
            return returnValue;
        }


        // Method to add a grade to the list
        static List<double> AddGrade(List<double> gradeList, double newGrade)
        {
            // initialize return value
            List<double> returnValue = gradeList;


            // processing


            // add the new grade to grade list
            gradeList.Add(newGrade);

            // make the trurn value = grade list again?

            // return returnValue
            return returnValue;
        }


        // Method to remove a grade from the list


        // Method to display all grades
        static void DisplayGradeList(List<double> gradeList)
        {
            // processing


            // for each statement to loop through all grades in the list
            foreach (double i in gradeList)
            {
                Console.Write($"| {i} |");
            }

            // skip to the next line
            Console.Write("\n");
        }

        // Method to calculate the average of the grades
        static double AverageGrade(List<double> gradeList)
        {
            // initialize return value to the input
            double returnValue = Double.MinValue;


            // processing


            // declare variables
            double sum = 0;     // declare sum variable and initialize it to 0
            double average = Double.MinValue;       // declare average variable and initialize it to minimum double value


            // for each statement to add together all grades in gradeList
            foreach (double i in gradeList)
            {
                // add gradeList value to the sum
                sum += i;
            }


            // calculate the average of the grade list
            average = sum / gradeList.Count;


            // set return value to the average
            returnValue = average; 


            // return returnValue
            return returnValue;
        }


        // mthod to find the highest and lowest grade
        static void GetMaxAndMinGrades(List<double> gradeList)
        {
            // processing


            // Declare variables
            int max = Int32.MinValue;        // declare int variable to hold the max of all elements in the array
            int min = Int32.MaxValue;        // declare int variable to hold the min of all elements in the array

            // foreach loop to go through the full array
            foreach (int i in gradeList)
            {
                // if the element is greater than the current max
                if (i > max)
                {
                    // replace max with new element number
                    max = i;
                }
            }

            // foreach loop to go through the full array
            foreach (int i in gradeList)
            {
                // if the element is less than the current min
                if (i < min)
                {
                    // replace min with new element number
                    min = i;
                }
            }

            // display max and min values
            Console.WriteLine($"Max Value: {max}\nMinimum Value: {min}\n");
        }

        static void Main(string[] args)
        {
            // Objective: Allow users to manage student grades using a list.
            // Provide options to choose from. Use a switch case with a number correlated to each option.
            // Options: Add a grade, Remove a grade, display all grades, calculate and display average grade,
            // find highest and lowest grade



            // Processing



            // Declare Variables
            // Input Variables
            double newGrade = Double.MinValue;        // declare a variable to change with each grade added. Initialize it to the min double value.
            int userSelection = Int32.MinValue;      // declare a variable to change with each gselection the user makes. Initialize it to the min int value.

            // Output Variables
            List<double> gradeList = new List<double> { };        // Declare empty double list to hold all grades



            // output program title
            Console.WriteLine("Welcome to Grade Management application\n");


            // output the options to the user with their number


            // Output to tell the user they can type 1 to add a grade
            Console.WriteLine("1. Add Grade\n");

            // Output to tell the user they can type 2 to remove a grade
            Console.WriteLine("2. Remove Grade\n");

            // Output to tell the user they can type 3 to see all grades
            Console.WriteLine("3. Display Grades\n");

            // Output to tell the user they can type 4 to calculate the average grade
            Console.WriteLine("4. Calculate Average\n");

            // Output to tell the user they can type 5 to see the highest and lowest grades
            Console.WriteLine("5. Find Highest & Lowest Grade\n");

            // Output to tell the user they can type 6 to exit the application
            Console.WriteLine("6. Exit\n");


            // A do while loop to run the program and allow continuous choice.
            do
            {
                // do while loop to make sure the user selection is within range
                do
                {
                    // ask for and recieve user choice as an integer number
                    userSelection = HandleIntInput("Enter your choice: ");
                    // line break for readability
                    Console.Write("\n");

                    // make sure the integer input is between 1 and 6. If interger is not, reset user selection to Int32 min value
                    userSelection = CheckIntRange(userSelection, 1, 6, Int32.MinValue, "Your input was out of range. Make sure your number is between 1 and 6.\n");
                }
                while (userSelection == Int32.MinValue);


                // check if the user selection is 6, leave the while loop
                if (userSelection == 6)
                {
                    // leave the while loop
                    break;
                }




                // use a switch case to calculate user option
                // use a switch case to perform an operation based on the selection
                switch (userSelection)
                {
                    // Run this case if selection = 1
                    case 1:
                        // do while loop to get grade input and ensure it is valid
                        do
                        {
                            // get the grade from the user make sure it is a valid double number
                            newGrade = HandleDoubleInput("Enter the grade to add: ");
                            // line break for readability
                            Console.Write("\n");

                            // check and make sure the double number is within range 0 and 100, if it is not output an error message and reset newGrade to minimum double value
                            newGrade = CheckDoubleRange(newGrade, 0, 100, Double.MinValue);
                        }
                        // continue while newGrade holds the minimum double value
                        while (newGrade == Double.MinValue);
                       

                        // add the new grade to the list of grades
                        AddGrade(gradeList, newGrade);

                        // let the user know the grade has been added
                        Console.WriteLine("Grade added successfully!\n");


                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 2
                    case 2:
                        // print the sum of all array elements
                        

                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 3
                    case 3:
                        // Display all grades with method
                        DisplayGradeList(gradeList);
                        // line break for readability
                        Console.Write("\n");

                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 4
                    case 4:
                        // Calculate and output the average of the gradeList
                        Console.WriteLine($"Grade Average: {AverageGrade(gradeList)}\n");

                        // Jump out of switch here.
                        break;


                    // Run this case if selection = 5
                    case 5:
                        // Print all array elements in reverse
                        GetMaxAndMinGrades(gradeList);

                        // Jump out of switch here.
                        break;


                    default:
                        // Output a polite message in case of unforseen error.
                        Console.WriteLine("It seems something went wrong on our end. Please close the program and try again.\n");

                        // Jump out of switch here.
                        break;
                }

                // prompt user to continue the loop
                Console.WriteLine("Select what you would like to do next or quit.\n");
                

                // reset user selection
                userSelection = Int32.MinValue;
            }
            while (userSelection == Int32.MinValue);



            // Thank user for using the program
            Console.WriteLine("Thank you for using this program! Come again!");

            // Pause at the end of program for user to read
            Console.Read();
        }
    }
}
