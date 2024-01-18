namespace Task2
{
    internal class Program
    {
        static void DisplaySequences(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 2; j <= input.Length; j++)
                {
                    string sequence = input.Substring(i, j - i);
                    if (NoConsecutiveChars(sequence))
                    {
                        Console.WriteLine(sequence);
                    }
                }
            }
        }

        static bool NoConsecutiveChars(string sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Result: ");
            DisplaySequences(input);
        }
    }
}
