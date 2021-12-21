using System;
using System.Linq;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String modifiedStr = new String(str.Select(s => Char.IsLetter(s) ? '*' : s).ToArray());
            int punctuationCount = str.Count(s => Char.IsPunctuation(s));

            Console.WriteLine("Измененная строка: " + modifiedStr);
            Console.WriteLine("Количество знаков препинания: " + punctuationCount);
        }
    }
}
