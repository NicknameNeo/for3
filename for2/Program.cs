using System;

namespace for2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            int b = Convert.ToInt32(Console.ReadLine());

            // if (a >= b)
            // {
            //     Console.WriteLine("Число A должно быть меньше числа B.");
            //     return;
            // }
            // int i = 0;
            
            
            // for (int i = a; i <= b; i++)
            // {
            //     Console.WriteLine(i);
            //     // i++;
            // }

            for (int i = b - 1; i > a; i--)
            {
                Console.WriteLine(i);
            }    
            
        }
    }
}