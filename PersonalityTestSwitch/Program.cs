using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //-//- "sinine", konsool kuvab "oled töökas"
            //-//- "roheline", -//- "oled looduse sõber"
            //-// midagi muud, -//- "oled ükssarvik"

            Console.WriteLine("Sisestage oma lemmik värv");
            String UserColor = Console.ReadLine().ToLower();

           switch (UserColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor} ükssarvik");
                    break;


            }

            Console.WriteLine("Kena päeva");

        }
    }
}
