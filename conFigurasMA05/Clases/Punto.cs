using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05.Clases
{
    public class Punto
    {
        //Atributos
        private int ejeX;
        private int ejeY;

        //Propiedades
        public int EjeX
        { get { return ejeX; } 
          set { ejeX = value; } 
        }

        public int EjeÝ
        {
            get { return ejeY; }
            set { ejeY = value; }
        }

        //Constructor
        public Punto()
        {
            this.ejeX = 0;
            this.ejeY = 0;
        }

        public Punto(int x, int y)
        {
            this.ejeX = x;
            this.ejeY = y;
        }

        public Punto(Punto p)
        {
            this.ejeX = p.ejeX;
            this.ejeY = p.ejeY;
        }

        //Sobreescritura
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("El eje X es: ");
            sb.Append(this.ejeX);
            sb.Append("\n El eje Y es:  ");
            sb.Append(this.ejeY);
            return sb.ToString();
        }



    }
}
