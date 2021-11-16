using System;

namespace guess_game
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Random random = new Random();
           int nahodneCislo;
           bool neuhodl = true;
           int hadaneCislo;
           nahodneCislo = random.Next(1, 100);


            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("guess game");
            Console.WriteLine("myslím si číslo od 1 do 100");
            
            while(neuhodl)
            {
                Console.WriteLine("tipni si číslo");
                hadaneCislo = int.Parse(Console.ReadLine());
                if (hadaneCislo < nahodneCislo)
                {
                    Console.WriteLine("číslo je větší");
                }
                else if (hadaneCislo > nahodneCislo) 
                {
                    Console.WriteLine("číslo je menší");
                }
                else
                {
                    Console.WriteLine("výborně, uhádl jsi");
                    neuhodl = false;
                }
            }

            


               

            




        }
    }
}
