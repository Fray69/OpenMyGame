using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество аргументов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //string[] ams = { "кот", "ток", "кто" };  
            string[] ams = new string[n];
            for (int i = 0; i < n ; i++)
            {
                Console.Write("Аргумент {0}: ", i+1);
                ams[i] = Convert.ToString(Console.ReadLine());
            }

            char[] ch;

            for (int i = 0; i < ams.Length; i++) 
            {
                ch = ams[i].ToArray();        
                Array.Sort(ch);
                ams[i] = new string(ch);

            }
            /*for (int i = 0; i < ams.Length; i++)
                Console.WriteLine(ams[i]);*/

            int check = 1;
            for (int i = 0; i < ams.Length - 1; i++)
                if(ams[i] == ams[i+1])
                    check = 1;
                else
                    check = 0;

            if (check == 1)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadLine();
        }
    }
}