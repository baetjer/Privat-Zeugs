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

            Console.WriteLine("Eingabe bitte:");
            String eingabe2 = Console.ReadLine();
            double y = Convert.ToDouble(eingabe2);

            Klasse2 Klasse2 = new Klasse2();
            Klasse2.Yos(y);

            Console.WriteLine("3 + " + y + " = ");
            Console.WriteLine(Klasse2.Ergebnis1);

            Console.WriteLine("Eingabe bitte:");
            String eingabe3 = Console.ReadLine();
            double z = Convert.ToDouble(eingabe3);

            Klasse3 Klasse3 = new Klasse3();
            Klasse3.Yeet(z);

            Console.WriteLine("3 * " + z + " = "); 
            Console.WriteLine(Klasse3.Ergebnis2);

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
