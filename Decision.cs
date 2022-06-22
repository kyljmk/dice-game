namespace DiceGame
{
    class Decision
    {
        public static void RollResultMessage(int playerWinCount, int computerWinCount)
        { 
            Console.WriteLine($"You won {playerWinCount} games, and the computer won {computerWinCount} games.");
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}