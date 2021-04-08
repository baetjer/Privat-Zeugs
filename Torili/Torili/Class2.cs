using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torili
{
    public class Klasse5
    {
        int zahl2;
        string[] entscheidung = new string[2] { "nein", "ja" };

        public void Entscheidung()
        {
            Console.WriteLine("Bitte wählen Sie aus:");

            foreach (string i in entscheidung)
            {
                Console.WriteLine(zahl2 + " " + i);
                zahl2 += 1;
            }
        }

        public string getEntscheidung(int i)
        {
            return entscheidung[i];
        }

        public void Entscheidung_Ausgabe()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            while ((input != 0) && (input != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input = Convert.ToInt32(Console.ReadLine());
            }

            string output = getEntscheidung(input);

            if (input == 0)
            {
                Console.WriteLine("Ihre Auswahl wird gelöscht.");
            }

            else
            {
                Console.WriteLine("Ihre Auswahl wurde zum Warenkorb hinzugefügt.");
            }
        }
    }
}
