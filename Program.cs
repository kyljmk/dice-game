
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
                Messages.Opening(i);

                playerRandom = random.Next(0, 7);
                
                Messages.RollResult(playerRandom, "You");

                computerRandom = random.Next(0, 7);
                
                Messages.RollResult(computerRandom, "The computer");

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

            Decision.RollResultMessage(playerWinCount, computerWinCount);

            if (playerWinCount > computerWinCount)
            {
                Console.WriteLine("YOU WIN!!");
            }
            else if (playerWinCount == computerWinCount)
            {
                Console.WriteLine("Well that's a draw.");
            }
            else 
            {
                Console.WriteLine("Better luck next time..");
            }
        }
    }
}