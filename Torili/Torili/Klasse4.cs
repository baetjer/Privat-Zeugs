using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Klasse4
    {
        //String[] liste = new String[2];
        int zahl1;
        private string[] liste = new string[2] {"Innensechskant", "Sechskant"};

        //public void Array_Liste(string[] _liste)
        //{
        //    liste = _liste;
        //}

        //public string[] Liste { get => liste; set => liste = value; }

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

    }
}
