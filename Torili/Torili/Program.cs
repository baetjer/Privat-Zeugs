using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eingabe bitte:");
            String eingabe1 = Console.ReadLine();
            double x = Convert.ToDouble(eingabe1);

            //Torili torili = new Torili();
            //torili.Ye();

            Console.WriteLine("Eingabe bitte:");
            String eingabe2 = Console.ReadLine();
            double y = Convert.ToDouble(eingabe2);

            Olili olili = new Olili();
            olili.Yos(y);

            Console.WriteLine(olili.Ergebnis1);


            Console.ReadKey();
        }
    }

    public class Torili
    {
        double x;

        //public void Ye(double _x)
        //{ 
        //    x = _x;
        //}

        public double X { get => x; set => x = value; }
    }
     
    public class Olili : Torili
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

    public class Jodyli : Torili
    {
        double z;
        double ergebnis2;

        public void Yeet(double _z)
        {
            Z1 = _z;
            Ergebnis2 = X + z;
        }

        public double Z1 { get => z; set => z = value; }
        public double Ergebnis2 { get => ergebnis2; set => ergebnis2 = value; }
    }
}
