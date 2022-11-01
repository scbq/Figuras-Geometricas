using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05.Clases
{
    public class Figura
    {
        //Atributos
        protected Punto centro;

        //Constructores
        public Figura()
        {
            this.centro = new Punto();
        }

        public Figura(int x, int y)
        {
            this.centro = new Punto(x, y);
        }

        public Figura(Punto centro)
        {
            this.centro = new Punto (centro);
        }

        public Figura(Figura f)
        {
            this.centro = f.centro;
        }

        //Sobreescritura
        public override string ToString()
        {
            return centro.ToString();
        }
    }
}
