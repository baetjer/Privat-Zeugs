using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Eingabe bitte:");
            //String eingabe1 = Console.ReadLine();
            //double x = Convert.ToDouble(eingabe1);

            //Klasse1 Klasse1 = new Klasse1();
            //Klasse1.Ye();
            Console.WriteLine("Bitte wählen Sie aus:");

            Klasse4 klasse4 = new Klasse4();
            klasse4.Array();
            
            int input = Convert.ToInt32(Console.ReadLine());


            while ((input != 0) && (input != 1))
            {
                Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                input = Convert.ToInt32(Console.ReadLine());
            }

            string output = klasse4.getElement(input);
            Console.WriteLine("Sie haben sich für {0} entschieden", output);


            Console.WriteLine("Eingabe bitte:");
            String eingabe2 = Console.ReadLine();
            double y = Convert.ToDouble(eingabe2);

            Klasse2 klasse2 = new Klasse2();
            klasse2.Yos(y);

            Console.WriteLine("3 + " + y + " = ");
            Console.WriteLine(klasse2.Ergebnis1);

            Console.WriteLine("Eingabe bitte:");
            String eingabe3 = Console.ReadLine();
            double z = Convert.ToDouble(eingabe3);

            Klasse3 klasse3 = new Klasse3();
            klasse3.Yeet(z);

            Console.WriteLine("3 * " + z + " = "); 
            Console.WriteLine(klasse3.Ergebnis2);

            Console.ReadKey();
        }
    }

    public class Klasse1
    {
        double x = 3;

        //public void Ye(double _x)
        //{ 
        //    x = _x;
        //}

        public double X { get => x; set => x = value; }
    }
     
    public class Klasse2 : Klasse1
    {
        double y;
        double ergebnis1;

        public void Yos(double _y)
        {
            y = _y;
            ergebnis1 = X + y;
        }


        public double Y { get => y; set => y = value; }
        public double Ergebnis1 { get => ergebnis1; set => ergebnis1 = value; }
    }

    public class Klasse3 : Klasse1
    {
        double z;
        double ergebnis2;

        public void Yeet(double _z)
        {
            z = _z;
            ergebnis2 = X * z;
        }

        public double Z1 { get => z; set => z = value; }
        public double Ergebnis2 { get => ergebnis2; set => ergebnis2 = value; }
    }
}
