using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToCharArray();
            int punctuationCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsPunctuation(str[i]))
                {
                    punctuationCount++;
                }
                if (Char.IsLetter(str[i]))
                {
                    str[i] = '*';
                }
            }
            Console.Write("Измененная строка: ");
            Console.WriteLine(str);
            Console.WriteLine("Количество знаков препинания: " + punctuationCount);
        }
    }
}
