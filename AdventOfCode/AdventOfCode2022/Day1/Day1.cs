namespace AdventOfCode2022
{
    // https://adventofcode.com/2022/day/1
    internal static class Day1
    {
        internal static void Run()
        {
            int currentSum = 0;
            List<int> largestSums = new List<int>();

            foreach (string line in System.IO.File.ReadLines("day1/input.txt")) {
                if (String.Equals(line, Environment.NewLine) || String.IsNullOrEmpty(line)) {
                    largestSums.Add(currentSum);
                    currentSum = 0;
                }

                try {
                    int value = Int32.Parse(line);
                    currentSum += value;
                } catch {
                    continue;
                }
            }
            largestSums.Add(currentSum);

            largestSums = largestSums.OrderByDescending(s => s).ToList();

            // Part 1
            Console.WriteLine(largestSums[0]);
            // Part 2
            Console.WriteLine(largestSums[0] + largestSums[1] + largestSums[2]);

        }
    }
}
