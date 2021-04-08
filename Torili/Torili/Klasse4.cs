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

        String[] liste = new string[2] {"Innensechskant", "Sechskant"};

        public void Array()
        {
            foreach (string i in liste)
            {
                Console.WriteLine(i);
            }
        }

        //public string Liste { get => liste; set => liste = value; }
    }
}
