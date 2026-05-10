namespace FlowControlArrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[8];
        Console.Clear();
        Console.WriteLine("=== Flow Control Practice with Arrays ===");
        Console.WriteLine("");
        Console.WriteLine("Please enter 8 numbers ");

        for (int i = 0; i < 8; i++){ 
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
 

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                continue;
            }

            if (numbers[i] == 0)
            {
                break;
            }

            Console.Write($"{numbers[i]}, ");
        }

    }
}
