namespace CustomMultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       Console.WriteLine("=== Multiplication tables ===\n");

       int num = 0;
       Console.Write("Please enter a whole number: ");

       while (true)
       {
        if(int.TryParse(Console.ReadLine(), out num))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number.");
        }
       }

       Console.WriteLine();
            Console.WriteLine($"--- Table of {num} ---");

            for (int j = 1; j <= 12; j++)
            {
                int result = num * j;
                Console.WriteLine($"{num} x {j} = {result}");
            }

            Console.WriteLine();

    }
}
