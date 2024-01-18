namespace Task1
{
    internal class Program
    {
        public static void CellColor(string cell)
        {
            System.Console.WriteLine((cell[0] + cell[1]) % 2 == 0 ? "cell is black" : "cell is white");
        }

        public static void CheckCell(string cell)
        {
            if (cell.Length == 2)
            {
                if ((cell[0] >= 'a' && cell[0] <= 'h' || cell[0] >= 'A' && cell[0] <= 'H') && cell[1] >= '1' && cell[1] <= '8')
                {
                    CellColor(cell);
                }
                else
                {
                    System.Console.WriteLine("Not defined");
                }   
            }
        }   

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the cell: ");
            var cell = Console.ReadLine();

            CheckCell(cell);
        }
    }
}
