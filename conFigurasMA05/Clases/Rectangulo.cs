using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05.Clases
{
    public class Rectangulo:Figura
    {
        //Attributos
        private decimal ancho;
        private decimal alto;

        //Propiedades
        public decimal Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public decimal Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        //Constructores
        public Rectangulo():base()
        {
            this.ancho = 0;
            this.alto = 0;
        }
        public Rectangulo(int x,int y,decimal ancho,decimal alto) : base(x, y)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public Rectangulo(Punto centro, decimal ancho, decimal alto) : base(centro)
        {
            this.ancho=ancho;
            this.alto=alto;
        }
        public Rectangulo(Rectangulo r) : base(r)
        {
            this.ancho =r.ancho;
            this.alto = r.Alto;
        }

        //Sobreescritura
        public override string ToString()
        {
            return base.ToString() + "\n Ancho: " + this.ancho + "\n Alto: " + this.alto;
        }

        //Metodo
        public decimal CalcularPerimetro()
        {
            return this.ancho *  2 + this.alto * 2;
        }
        public decimal CalcularArea()
        {
            decimal area = this.ancho * this.alto; ;
            Console.WriteLine("El area de un rectangulo es: " + area);
            return area;
        }
    }
}
