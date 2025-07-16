using System;

namespace roman_to_integer
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int total = 0;
            int prevValue = 0;
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            foreach (char c in s)
            {
                int currentValue = romanMap[c];
                if (currentValue > prevValue)
                {
                    total += currentValue - 2 * prevValue;
                }
                else
                {
                    total += currentValue;
                }
                prevValue = currentValue;
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
        }
    }
}