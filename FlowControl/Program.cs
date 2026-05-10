namespace FlowControl;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== Flow Control Practice ===");
        Console.WriteLine("");

        for (int i = 1; i <= 20; i++){

            if (i % 3 == 0){
                continue;
            }

            if (i > 15){
                break;
            }

             Console.Write($"{i}, ");
        }
        
    }
}
