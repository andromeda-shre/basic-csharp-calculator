using System;

namespace Project1
{
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine("Welcome to The Autumn's one and only... CALCULATOR");
            System.Console.WriteLine("What kind of calculation would you loveeee to perform?");

            System.Console.WriteLine("1) Addition");
            System.Console.WriteLine("2) Subtraction");
            System.Console.WriteLine("3) Multiplication");
            System.Console.WriteLine("4) Division");
            System.Console.WriteLine("5) Quit the application");

            System.Console.Write(": ");
            int userCalcInput = Convert.ToInt32(Console.ReadLine());

            if (userCalcInput == 1)
            {
                addition(userCalcInput);
            }
            else if (userCalcInput == 2)
            {
                subtraction(userCalcInput);
            }
            else if (userCalcInput == 3)
            {
                multiplication(userCalcInput);
            }
            else if (userCalcInput == 4)
            {
                division(userCalcInput);
            }
            else if (userCalcInput == 5)
            {
                quitApplication(userCalcInput);
            }
            else
            {
                System.Console.WriteLine("ERROR: You did an oopsie woopsie!! You may or may not have entered an invalid operator or number that is incorrect.");
                System.Console.WriteLine("Would you like to restart? y/n");
                Console.Write(": ");
                string userConfirmRestart = Console.ReadLine();

                if (userConfirmRestart == "y")
                {
                    Main();
                }
                else if (userConfirmRestart == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    System.Console.WriteLine("Press ENTER to exit.");
                }
            }


            Console.ReadLine();

        }

        static int addition(int op)
        {
            System.Console.WriteLine("Instructions: When prompted, enter your first and second number. The program will calculate it for you.");

            System.Console.Write("Number 1: ");
            double userNum1AddInput = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Number 2: ");
            double userNum2AddInput = Convert.ToDouble(Console.ReadLine());

            double answer = userNum1AddInput + userNum2AddInput;
            System.Console.WriteLine("Your answer is " + answer);
            System.Console.WriteLine("Would you like to perform another operation? y/n");
            System.Console.Write(": ");
            string userRestartAction = Console.ReadLine();

            if (userRestartAction == "y")
            {
                Main();
            }
            else if (userRestartAction == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Press ENTER to exit.");
            }

            return 0;
        }

        static int subtraction(int op)
        {
            System.Console.WriteLine("Instructions: When prompted, enter your first and second number. The program will calculate it for you.");

            System.Console.Write("Number 1: ");
            double userNum1AddInput = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Number 2: ");
            double userNum2AddInput = Convert.ToDouble(Console.ReadLine());

            double answer = userNum1AddInput - userNum2AddInput;
            System.Console.WriteLine("Your answer is " + answer);
            System.Console.WriteLine("Would you like to perform another operation? y/n");
            System.Console.Write(": ");
            string userRestartAction = Console.ReadLine();

            if (userRestartAction == "y")
            {
                Main();
            }
            else if (userRestartAction == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Press ENTER to exit.");
            }

            return 0;
        }

        static int multiplication(int op)
        {
            System.Console.WriteLine("Instructions: When prompted, enter your first and second number. The program will calculate it for you.");

            System.Console.Write("Number 1: ");
            double userNum1AddInput = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Number 2: ");
            double userNum2AddInput = Convert.ToDouble(Console.ReadLine());

            double answer = userNum1AddInput * userNum2AddInput;
            System.Console.WriteLine("Your answer is " + answer);
            System.Console.WriteLine("Would you like to perform another operation? y/n");
            System.Console.Write(": ");
            string userRestartAction = Console.ReadLine();

            if (userRestartAction == "y")
            {
                Main();
            }
            else if (userRestartAction == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Press ENTER to exit.");
            }

            return 0;
        }

        static int division(int op)
        {
            System.Console.WriteLine("Instructions: When prompted, enter your first and second number. The program will calculate it for you.");

            System.Console.Write("Number 1: ");
            double userNum1AddInput = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Number 2: ");
            double userNum2AddInput = Convert.ToDouble(Console.ReadLine());

            double answer = userNum1AddInput / userNum2AddInput;
            System.Console.WriteLine("Your answer is " + answer);
            System.Console.WriteLine("Would you like to perform another operation? y/n");
            System.Console.Write(": ");
            string userRestartAction = Console.ReadLine();

            if (userRestartAction == "y")
            {
                Main();
            }
            else if (userRestartAction == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("Press ENTER to exit.");
            }

            return 0;
        }

        static int quitApplication(int op)
        {
            System.Console.WriteLine("Thank you for using The Official Autumn's Totaly Cool Calculator; proudly presented by HeeTap.");

            Environment.Exit(0);

            return 0;
        }



    }
}
