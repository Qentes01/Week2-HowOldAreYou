using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasjutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsoolis
            //convert string from Readline() to int
            Console.WriteLine("Kui vana sa oled?");
            int Age = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2021 - Age;
            //Console.WriteLine("Olen sündinud aastal " + YearOfBirth);  
            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}.");

            
        }
    }
}
