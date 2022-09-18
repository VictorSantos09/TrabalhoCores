namespace TrabalhoCores
{
    public static class IsNullOrEmpty
    {
        public static string EmptyST(string input)
        {
            while (input == string.Empty)
            {
                Console.WriteLine("Tente Novamente");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}