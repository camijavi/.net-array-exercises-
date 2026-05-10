namespace GeometricPatternsGen;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       Console.WriteLine("=== Geometric Patterns Generator ===\n");

       Console.WriteLine("Please enter 1 or 2 to generate a pattern:\n");

       Console.WriteLine("1. Square");
       Console.WriteLine("2. Triangle");

       int input = int.Parse(Console.ReadLine());
       
       while(true){
        if (input != 1 && input != 2)
        {
            Console.WriteLine("Invalid input. Please enter 1 or 2");
            input = int.Parse(Console.ReadLine());
        }
        else
        {
            break;
        }
       }

       if(input == 1)
       {
           Console.Clear();
           Console.WriteLine("--- Square Pattern ---");
           Console.WriteLine();
           for (int i = 0; i < 5; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   Console.Write(" * ");
               }
               Console.WriteLine();
           }
       }

       if(input == 2)
       {
           Console.Clear();
           Console.WriteLine("--- Triangle Pattern ---");
           Console.WriteLine();

           for (int i = 1; i <= 6; i++)
           {
               for (int j = 1; j <= 6 - i; j++)
               {
                   Console.Write(" ");
               }

               for(int k = 1; k <= (2*i-1); k++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }
       }
    }
}
