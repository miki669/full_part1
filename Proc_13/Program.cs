using System;
namespace Proc_15 // Это задание я не понял чутька...
{
    internal class Program
    {

        static void swap(float x, float y)
        {
            x=x+y;
            y=x-y;
            x=x-y;
        }
        static void shiftleft3(float a, float b, float c)
        {
            swap(a, b);
            swap(c, b);
        }
        static void Main(string[] args)
        {
            float a, b, c;
            for (int i = 1; i <=2; ++i)
            {
                Console.WriteLine("Введите А: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите C: ");
                c = Convert.ToInt32(Console.ReadLine());
                shiftleft3(a, b, c);
                Console.WriteLine($"A равен = {a} \nB равен = {b} \nC равен = {c}");
            }
            Console.ReadKey();
        }
    }
}
