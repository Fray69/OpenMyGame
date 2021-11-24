using System;
using System.Collections.Generic;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Строка: ");
            string s = Console.ReadLine();

            if (IsValid(s)) Console.WriteLine("Правильная последовательность");
            else Console.WriteLine("Неправильная");

            Console.ReadKey();
        }

 
        static bool IsValid(string input)
        {
            Stack<char> buffer = new Stack<char>();

            bool isValid = true;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        buffer.Push(input[i]);
                        break;

                    case ')':
                        isValid = (buffer.Count > 0 && buffer.Pop() == '(');
                        break;

                    case '}':
                        isValid = (buffer.Count > 0 && buffer.Pop() == '{');
                        break;

                    case ']':
                        isValid = (buffer.Count > 0 && buffer.Pop() == '[');
                        break;

                    default:
                        break;
                }

                if (!isValid) break; 
            }

            return isValid && buffer.Count == 0; 
        }
    }
}
