using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ProjectLevelBiginner
{
    internal class GessingNumber
    {
        static public void Main()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*******Welcome to guessing number******");
            Console.WriteLine("***************************************");

            Console.WriteLine(" Please guess a number ");
            Random random = new Random();
            int randomNumber= random.Next(1,100);
            int numberOfGuessing = 0;
            bool numberGessed = true;
            string message;

            while (numberGessed)
            {

                numberOfGuessing++;
                int number = int.Parse(Console.ReadLine());

                numberGessed = GuessNumber(number, randomNumber, numberOfGuessing, numberGessed);


            }

            bool GuessNumber (int number, int randomNumber,int numberOfGessing,bool numberGessed)
            {

                if (number > randomNumber)
                {

                    Console.WriteLine($"The number : {number} is greater ");
                    Console.WriteLine(" Please type the number to guess the random number  ");
                    return numberGessed = true;
                }

                else if (number < randomNumber)
                {
                    Console.WriteLine($"The number : {number} is lower ");
                    Console.WriteLine(" Please type the number to guess the random number  ");
                    return numberGessed = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Coorect , you guessed the number right and the number of gussing is: {numberOfGessing}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("You want to try it again Y/yes N/no");
                    string tryAgain =Console.ReadLine();
                    if (tryAgain.ToUpper()== "Y")
                    {
                        return numberGessed = true;
                        Console.WriteLine(" Please type the number to guess the random number  ");

                    }
                    else { 
                    return numberGessed = false;
                    }

                }
            }






        }


            }

        }
  