using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a contadores y acumuladore");
            Console.WriteLine("digite un numero N:");
            int n = Convert.ToInt32 (Console.ReadLine());
            
            int resta = 1;
        
           for(int i = 4; i>= n; i= 4)

            Console.WriteLine("i:" + (i - resta));

        }
    }
}
