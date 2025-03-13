using static System.Console;

namespace RollingDice
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ch23 Dice Rolls by Kyle Evenson");
            WriteLine("Welcome to the Dice gam")
            DoWork();



            
            WriteLine("Does this wait to print after the DoWork method is called?");

            WriteLine("\nPress any key to continue");
            ReadKey();

        }
        public static void DoWork()
        {
            Write("\nHow many rolls? ");
            int amount = int.Parse(Console.ReadLine());
            Task rolling = Task.Run(() => RollDice(amount));
            Task rolling10 = Task.Run(()=> RollDice(amount * 10));
            Task rolling100 = Task.Run(() => RollDice(amount * 100));
            WriteLine("Inside DoWork, does it wait for the tasks to complete?");
        }
        public static void RollDice(int amount)
        {
            int[] possibleRolls = new int[11];
            Random roll1 = new Random();
            Random roll2 = new Random();
            for (int i = 0; i < amount; i++)
            {
                int result = roll1.Next(6) + roll2.Next(6);
                possibleRolls[result]++;
            }
           
            for (int i = 0;i < possibleRolls.Length; i++)
            {
                WriteLine($"Value {i + 2} rolled {possibleRolls[i]} times");
            }
            WriteLine($"Total number of rolls: {amount:N}\n");
        }
    }
}