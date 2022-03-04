using System;

namespace laboratory_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            float n1, n2;
            Console.WriteLine("Введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n1 > n2)
            {
                Console.WriteLine(Math.Pow(n1, n2));
            }
            else if(n1 < n2)
            {
                if(n2 % n1 ==0)
                {
                    Console.WriteLine($"Второе число делится на первое без остатка!");
                }else
                    Console.WriteLine($"Второе число делится на первое с остатком!");
            } else if(n2 == n1)
            {
                for(int i = 0; i < 5; i++)
                Console.WriteLine("Первое число равен второму");                    
            }
            // Доделать 3 условие, если отрицание!
           Console.ReadKey();  


        }
    }
}
