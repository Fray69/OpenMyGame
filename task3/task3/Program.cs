using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Строка: ");
            string s = Console.ReadLine();
            s = s.Replace(" ", "");
            s = s.Replace(",", "");
            s = s.Replace(".", "");
            s = s.Replace("!", "");
            s = s.Replace("?", "");
            s = s.ToLower();

            if (IsPalindrome(s)) Console.WriteLine("Полиндром");
            else Console.WriteLine("Не полиндром");

            Console.ReadKey();
        }

        static bool IsPalindrome(string s)
        {
            char[] b = s.ToCharArray();
            Array.Reverse(b);
            return s == new String(b);
        }
    }
}
