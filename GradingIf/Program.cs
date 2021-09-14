using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib mis hinde kasutaja sai
            //Kui kasutaja sai "5", kuvab konsool "Suurepärane"
            //"4" = "Vaga hea"
            //"3" = "Hea"
            //"2" = "Rahuldav"
            //"1" = "Puudulik"
            //Muul juhul "Puudulik

            Console.WriteLine("Sisestage oma hinne");
            int UserGrade = Convert.ToInt32(Console.ReadLine());

            if (UserGrade == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (UserGrade == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (UserGrade == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (UserGrade == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else if (UserGrade == 1)
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }
            Console.WriteLine("Kena päeva!");

            
        }
    }
}
