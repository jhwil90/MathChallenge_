using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    using System;
    namespace MathChallenge
    {
        class MainClass
        {
            private static bool CompareDigits()
            {

                Console.WriteLine("Hello world! Thank you for attending the Math Challenge!\nThe rules are very simple. " +
                    "You will need to enter two intergers with the same numbers of digits. Let's give it a go!");
                
                //Declared variables 
                int Num_1;
                int Num_2;

                //variable 1 begins
                Console.WriteLine("Select your 1st interger:");

                //Converting whole number into Char object
                Num_1 = Convert.ToInt32(Console.ReadLine());
                string lengthOfNum1 = Num_1.ToString();
               
                //variable 2 begins
                Console.WriteLine("Select your 2nd interger:");

                Console.WriteLine("Select your 2nd interger:");

                //Converting whole number into Char object
                Num_2 = Convert.ToInt32(Console.ReadLine());
                string lengthOfNum2 = Num_2.ToString();

                //Informs user if int amounts are equal
                if (lengthOfNum1.Length != lengthOfNum2.Length)
                {
                    Console.WriteLine("The intergers you chose do not have the same number of digits. Stay Positive. Try again!!");
                }
                else
                {
                    Console.WriteLine("True\nGreat Job! The digits in your integers have an equal amount! ", Num_1, Num_2);
                }

                int firstTotalPlace = Convert.ToInt32(lengthOfNum1[0] + Convert.ToInt32(lengthOfNum2[0]));
                int secondTotalPlace = Convert.ToInt32(lengthOfNum1[1] + Convert.ToInt32(lengthOfNum2[1]));
                if ((firstTotalPlace == secondTotalPlace) && (secondTotalPlace == firstTotalPlace)) 

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
                //Calling the Method
                CompareDigits();

                //Answer false if the two intergers do not have the same numbers of digits
                if (CompareDigits() == false)
                {
                    Console.WriteLine("False!\nThose are not the same number of digits! Keep trying!.");
                }

            }


        }
    }
}

