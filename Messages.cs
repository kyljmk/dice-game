namespace DiceGame
{
    class Messages
    {
        public static void Opening(int i)
        {
            Console.WriteLine($"GAME {i + 1}");
            Thread.Sleep(500);

            Console.WriteLine("Press Enter to roll the dice..");
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void RollResult(int randomNum, string whoRolls)
        {
            Console.WriteLine($"{whoRolls} rolled a {randomNum}!");

            Console.WriteLine(". . . . .");
            Thread.Sleep(1000);
        }
    }
}