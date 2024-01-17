namespace Task1
{
    internal class Program
    {
        public static void CellColor(string cell)
        {
            System.Console.WriteLine((cell[0] + cell[1]) % 2 == 0 ? "cell is black" : "cell is white");
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the cell: ");
            var cell = Console.ReadLine();

            CellColor(cell);

        }
    }
}
