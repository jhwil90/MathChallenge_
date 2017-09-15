using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{/*
 Task: Check if each corresponding place in the two numbers(ones, tens, hundreds, …) sums to the same total.
            Input: Your program should read two integer numbers from the user with the same number of digits(example: number1 = 234, number2 = 564).
            Output: Your program should print out: True or False based on the result.
            
            Examples:
            Number1 = 153 , Number2 = 345  => 1 + 3 ≠ 5 + 4 ≠ 3 + 5 Program prints False.
            Number1 = 543 , Number2 = 456  => 5 + 4 = 4 + 5 = 3 + 6 Program prints True.
            
            Things to look for: 
            - Do proper validation on the user’s input.
            - Write the task in a separate method.
            - Provide adequate comments.- Provide adequate user prompts.*/
    using System;
    namespace MathChallenge
    {
        class MainClass
        {
            private static bool CompareDigits()
            {

                Console.WriteLine("Hello and Welcome to the Math Challenge.\nYou will need to enter two intergers with the same numbers of digits!");
                //Declared variables 
                int Num_1;
                int Num_2;

                //Outputs a question to the user and reads in input to initialize variable 1
                Console.WriteLine("Enter the 1st interger: ");
                Num_1 = Convert.ToInt32(Console.ReadLine());
                string lengthOfNum1 = Num_1.ToString();//Converts the int values into strings so the length of the int can be checked for value 1

             
                Console.WriteLine("Enter the 2nd interger: ");
                Num_2 = Convert.ToInt32(Console.ReadLine());
                string lengthOfNum2 = Num_2.ToString();//Converts the int values into strings so the length of the int can be checked for value 1

                //Checks that both strings have the same number of characters and displays the out come to the user
                if (lengthOfNum1.Length != lengthOfNum2.Length)
                {
                    Console.WriteLine("Sorry those intergers do not have the same number of digits. Please use a int with the same number of digits");
                }
                else
                {
                    Console.WriteLine("True\nAwesome! The digits in your numbers({0} and {1}) have the same sum totals. ", Num_1, Num_2);
                }

                int firstTotalPlace = Convert.ToInt32(lengthOfNum1[0] + Convert.ToInt32(lengthOfNum2[0]));
                int secondTotalPlace = Convert.ToInt32(lengthOfNum1[1] + Convert.ToInt32(lengthOfNum2[1]));
                int thirdTotalPlace = Convert.ToInt32(lengthOfNum1[2] + Convert.ToInt32(lengthOfNum2[2]));

                if ((firstTotalPlace == secondTotalPlace) && (secondTotalPlace == thirdTotalPlace) && (firstTotalPlace == thirdTotalPlace))

                {
                    return true;

                }


                else
                {
                    return false;

                }


            }

            public static void Main(string[] args)
            {
                CompareDigits();//Method call

                //Outputs False if the input doesn't match the requirements met in the opening statement
                if (CompareDigits() == false)
                {
                    Console.WriteLine("False!\nThose numbers do not have digits with the same sum totals sorry.");
                }

            }


        }
    }
}

