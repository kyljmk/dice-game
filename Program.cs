namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandom;
            int computerRandom;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Enter to roll the dice..");

                Console.ReadKey();

                playerRandom = random.Next(0, 7);
                Console.WriteLine($"You have rolled a {playerRandom}");

                Console.WriteLine(". . . . .");
                Thread.Sleep(3000);

                computerRandom = random.Next(0, 7);
                Console.WriteLine($"The computer rolled a {computerRandom}");
            }
        }
    }
}