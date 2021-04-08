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
        string[] liste = new string[2] {"Innensechskant", "Sechskant"};

        //public void Array_Liste(string[] _liste)
        //{
        //    liste = _liste;
        //}

        //public string[] Liste { get => liste; set => liste = value; }

        public void Array()
        {
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

    }
}
