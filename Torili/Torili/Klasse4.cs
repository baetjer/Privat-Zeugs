using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torili
{
    public class Klasse4
    {
        int input = 0;
        int zahl1;
        private string[] liste = new string[2] {"Innensechskant", "Sechskant"};

        public void Array()
        {
            Console.WriteLine("Bitte wählen Sie aus:");

            foreach (string i in liste)
            {
                Console.WriteLine(zahl1 + " " + i);
                zahl1 += 1;
            }
        }

        public string getElement(int i)
        {
            return liste[i];
        }

        public void Array_Ausgabe()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            while ((input != 0) && (input != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input = Convert.ToInt32(Console.ReadLine());
            }

            string output = getElement(input);
            Console.WriteLine("Sie haben sich für {0} entschieden", output);
        }

        public void Array_Warenkorb()
        {
            string output = getElement(input);
            Console.WriteLine(output);
        }
    }
}
