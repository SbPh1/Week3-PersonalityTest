using System;

namespace PersonalityTest
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

            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {UserColor} ükssarvik");
            }
            Console.Read();
        }
    }
}
