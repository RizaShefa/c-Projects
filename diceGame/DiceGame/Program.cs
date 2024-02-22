int player1Number;
int player2Number;
int pointsForPalyer1=0;
int pointsForPalyer2=0;
Console.WriteLine("Welcome to Dice With Rei \n Please type your names");

string nameOfPalyer1 =Console.ReadLine();
string nameOfPalyer2 =Console.ReadLine();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("This is a new round...");
    Console.WriteLine("Press any key to threw the dice ");
    Console.ReadLine();
    Random random = new Random();  
    Console.WriteLine("Player 1  turn");
    player1Number = random.Next(1,7);
    Console.WriteLine($"The number in  {nameOfPalyer1} 's  dice was {player1Number} ");
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("Player 2  turn");
    player2Number = random.Next(1, 7);
    Console.WriteLine($"The number in  {nameOfPalyer2} 's  dice was {player2Number} ");

    if (player1Number > player2Number)
    {
        pointsForPalyer1++;
        Console.WriteLine($"{nameOfPalyer1} won this round  and has {pointsForPalyer1} points ");
    }
    else if (player1Number < player2Number)
    {
        pointsForPalyer2++;
        Console.WriteLine($"{nameOfPalyer2} won this round  and has {pointsForPalyer2} points");

    }
    else Console.WriteLine("Draw...");


}
if (pointsForPalyer1 > pointsForPalyer2)
{
    Console.WriteLine($"{nameOfPalyer1.ToUpper()}  has won ");

}
else if (pointsForPalyer1 < pointsForPalyer2)
{
    Console.WriteLine($"{nameOfPalyer2.ToUpper()}  has won ");

}
else Console.WriteLine("draw");



