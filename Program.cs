namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandom;
            int computerRandom;

            int playerWinCount = 0;
            int computerWinCount = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Enter to roll the dice..");
                Console.WriteLine();

                Console.ReadKey();

                playerRandom = random.Next(0, 7);
                Console.WriteLine($"You have rolled a {playerRandom}");

                Console.WriteLine(". . . . .");
                Thread.Sleep(1000);

                computerRandom = random.Next(0, 7);
                Console.WriteLine($"The computer rolled a {computerRandom}");
                Console.WriteLine();
                
                Thread.Sleep(1000);
                if (playerRandom > computerRandom)
                {
                    Console.WriteLine("You won this one!");
                    playerWinCount++;
                }
                else if (playerRandom == computerRandom)
                {
                    Console.WriteLine("This one is a draw!");
                }
                else 
                {
                    Console.WriteLine("You lost this one!");
                    computerWinCount++;
                }

                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}