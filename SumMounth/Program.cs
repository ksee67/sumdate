using System;
using System.Collections.Generic;

namespace SumMounth
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool dayAdd = true; 
            Dictionary<string, int> months = new Dictionary<string, int>
            {
                { "Январь", 31 },
                { "Февраль", dayAdd ? 29 : 28 }, // 29 в високосный год
                { "Март", 31 },
                { "Апрель", 30 },
                { "Май", 31 },
                { "Июнь", 30 },
                { "Июль", 31 },
                { "Август", 31 },
                { "Сентябрь", 30 },
                { "Октябрь", 31 },
                { "Ноябрь", 30 },
                { "Декабрь", 31 }
            };

            foreach (var month in months)
            {
                Console.WriteLine($"{month.Key}: {month.Value} дней");
            }

            Console.ReadLine();

            //foreach (var month in months)
            //{
            //    for (int i = 1; i <= month.Value; i++)
            //    {
            //        if (i >= 10) // Если число двузначное
            //        {
            //            int digit1 = i / 10; // Получаем первую цифру
            //            int digit2 = i % 10; // Получаем вторую цифру
            //            sum += digit1 + digit2;
            //        }
            //        else
            //        {
            //            sum += i;
            //        }
            //    }

            //}

            //Console.WriteLine(sum);
        }
    }
}
