using System;

namespace ProjectLevelBiginner
{
    internal class DiceGame
    {
        static public void rei()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************");
            Console.WriteLine("Welcome to Dice game");
            Console.WriteLine("************************");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************************************************************************");
            Console.WriteLine("There is one rule: The one who goes first to 5 points wins the game");
            Console.WriteLine("************************************************************************");

            Console.ForegroundColor = ConsoleColor.White;

            int pointNumber1 = 0;
            int pointNumber2 = 0;
            int setesPlayer1 = 0;
            int setesPlayer2 = 0;
            bool playAgain = true;
            string computer = "Computer";

            
                Console.WriteLine("Please type your name");
                string player1 = Console.ReadLine();

            while (playAgain)
            {
              
                PlayRound(  player1, computer,ref pointNumber1, ref pointNumber2, ref setesPlayer1, ref setesPlayer2);

                Console.ForegroundColor = ConsoleColor.White;

                if (pointNumber1== 2 || pointNumber2==2)
                {
                Console.WriteLine("Do you want to play again? (Y/yes, N/no)");
                        pointNumber1 = 0;
                        pointNumber2 = 0;

                    string response = Console.ReadLine().ToUpper();
                    if (response == "N")
                    {
                        DisplayFinalResults(player1,computer, setesPlayer1, setesPlayer2);
                        playAgain = false;
                    }
                }

            }
        }

        static void PlayRound(string player1, string computer, ref int pointNumber1, ref int pointNumber2, ref int setesPlayer1, ref int setesPlayer2)
        {
            Random random = new Random();
            int number1 = random.Next(1, 7);

            Console.WriteLine("Press enter to roll the dice");
            
            Console.ReadLine();
            Console.WriteLine($"You rolled number: {number1}");

            System.Threading.Thread.Sleep(1000);

            int number2 = random.Next(1, 7);
            Console.WriteLine($"Computer rolled number: {number2}");

            string message = DetermineWinner(player1, computer, number1, number2, ref pointNumber1, ref pointNumber2);

            Console.WriteLine(message);

            if (pointNumber1 == 2)
            {
                DisplayRoundResults(player1, computer, setesPlayer1, setesPlayer2, ref pointNumber1, ref pointNumber2, "green");
                Console.WriteLine($"\n{player1} has won the game \n {player1} Sets: {setesPlayer1 += 1}  Computer Sets: {setesPlayer2} \n");

            }
            else if (pointNumber2 == 2)
            {
                DisplayRoundResults(player1, computer, setesPlayer1, setesPlayer2, ref pointNumber1, ref pointNumber2, "red");
                Console.WriteLine($"\n{computer} has won the game \n {player1} Sets: {setesPlayer1}  {computer} Sets: {setesPlayer2 +=1} \n");

            }
        }

        static string DetermineWinner(string player1, string computer , int number1, int number2, ref int pointNumber1, ref int pointNumber2)
        {
            string message;

            if (number2 == number1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                message = $"******Draw****** \n {player1} {pointNumber1}\t {computer}: {pointNumber2}";
            }
            else if (number2 < number1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                message = $"******{player1} Won****** \n {player1} {pointNumber1 += 1}\t Computer: {pointNumber2}";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                message = $"****** {computer} Lose****** \n {player1} {pointNumber1}\t Computer: {pointNumber2 += 1}";
            }

            return message;
        }

        static void DisplayRoundResults(string player1, string computer ,int setesPlayer1, int setesPlayer2, ref int pointNumber1, ref int pointNumber2, string color)
        {
            Console.ForegroundColor = color == "green" ? ConsoleColor.Green  : ConsoleColor.Red;
           

        }

        static void DisplayFinalResults(string player1,string computer, int setesPlayer1, int setesPlayer2)
        {
            if (setesPlayer2 > setesPlayer1)
            {
                Console.WriteLine($"{computer} has won {setesPlayer2} - {setesPlayer1} ");
            }
            else
            {
                Console.WriteLine($"{player1} has won {setesPlayer1} - {setesPlayer2} ");
            }
        }
    }
}
