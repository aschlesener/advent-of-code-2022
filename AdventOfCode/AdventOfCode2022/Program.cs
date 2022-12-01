namespace AdventOfCode2022
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Specify a day to run by passing in an argument, e.g. '1'");
                return;
            }

            int day = int.Parse(args[0]);
            switch (day)
            {
                case 1:
                    Day1.Run();
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 and 1.");
                    break;
            }
        }
    }
}
