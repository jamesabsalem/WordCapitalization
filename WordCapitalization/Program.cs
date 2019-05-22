using System;
using System.Linq;
using System.Text;

namespace WordCapitalization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            var stringBuilder = new StringBuilder();
            var firstLetter = Convert.ToChar(input[0].ToString().ToUpper());
            input.RemoveAt(0);
            stringBuilder.Append(firstLetter);
            foreach (var i in input) stringBuilder.Append(i);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}