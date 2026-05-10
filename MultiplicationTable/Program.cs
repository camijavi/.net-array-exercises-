namespace MultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Multiplication tables from 1 to 5 ===\n");

        // Ciclo externo: controla la tabla actual (del 1 al 5)
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"--- Table of {i} ---");

            // Ciclo interno: realiza las multiplicaciones del 1 al 10
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                Console.WriteLine($"{i} x {j} = {result}");
            }

            // Espacio entre tablas para mayor orden
            Console.WriteLine();
        }
 
    }
}
