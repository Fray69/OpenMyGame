using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0){
                Console.WriteLine("Высокосный");}
            else{
                Console.WriteLine("Не высокосный");}
        }
    }
}
