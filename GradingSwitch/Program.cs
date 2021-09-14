using System;

namespace GradingSwitch
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

            switch (UserGrade)
            {
                case 5:
                    Console.WriteLine("Suurepärane");
                    break;
                case 4:
                    Console.WriteLine("Väga hea");
                    break;
                case 3:
                    Console.WriteLine("Hea");
                    break;
                case 2:
                    Console.WriteLine("Rahuldav");
                    break;
                case 1:
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Puudulik");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
