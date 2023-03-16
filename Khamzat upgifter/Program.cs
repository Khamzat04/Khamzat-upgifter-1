using System;

namespace Övning_1_Khamzat
{
    class Program
    {
        static void Main(string[] args)
        {
            Ålder();
        }

        static void Ålder()
        {
            Console.WriteLine("Vad är din ålder?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Du är myndig!");
            }
            else
            {
                Console.WriteLine("Du är inte myndig än.");
            }
        }
    }
}
