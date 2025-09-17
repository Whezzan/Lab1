using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mata in valfri sträng av bokstäver och siffror");
            string input = Console.ReadLine(); 
            Console.WriteLine();

            
            long sum = 0;


            for (int i = 0; i < input.Length; i++)
            {
                
                if (char.IsNumber(input[i]) == false)
                {
                    continue;
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    
                    if (char.IsNumber(input[j]) == true)
                    {
                        if (input[i] == input[j])
                        {
                            
                            string numberMatch = input.Substring(i, j - i + 1);
                            string firstMatch = input.Substring(0, input.IndexOf(numberMatch));
                            string secondMatch = input.Substring(i + 1);

                            
                            Console.Write(firstMatch);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(numberMatch);
                            Console.ResetColor();
                            Console.WriteLine(secondMatch);

                            
                            long result;
                            long.TryParse(numberMatch, out result);
                            sum += result;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine($"Summan av delsträngarna är {sum}");


            Console.ReadKey();
        }
    }
}