using conFigurasMA05.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto p1=new Punto(10,10);
            Console.WriteLine(p1.ToString());

            Figura f1 = new Figura(10,20);
            Console.WriteLine(f1.ToString());

            Circulo c1 = new Circulo(15,10,20);
            Console.WriteLine(c1.CalcularPerimetro());
            Circulo c2 = new Circulo(15, 10, 20);
            Console.WriteLine(c2.CalcularArea());

            Rectangulo r1 = new Rectangulo(20,10,30,15);
            Console.WriteLine(r1.CalcularPerimetro());
            Rectangulo r2 = new Rectangulo(r1);
            Console.WriteLine(r2.CalcularArea());
        }
    }
}
