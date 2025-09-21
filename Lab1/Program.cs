using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in valfri sträng av bokstäver och siffror:");
            string input = Console.ReadLine(); 
            Console.WriteLine();

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsNumber(input[i]))
                    continue;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (!char.IsNumber(input[j]))
                        break;
                    
                    if (input[i] != input[j])
                        {
                        continue;
                    }
                        // Hämta matchande delsträng
                            string numberMatch = input.Substring(i, j - i + 1);

                        // Skriv hela strängen tecken för tecken
                        for (int k = 0; k < input.Length; k++)
                        {
                            if (k >= i && k <= j)
                            {
                            Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(input[k]);
                            Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(input[k]);
                            }
                        }
                        Console.WriteLine();

                        // Lägg till summan
                        if (long.TryParse(numberMatch, out long result))
                        {
                            sum += result;
                    }
                        break;
                    }
                }
            Console.WriteLine();
            Console.WriteLine($"Summan av delsträngarna är {sum}");
            Console.ReadKey();
        }
    }
}