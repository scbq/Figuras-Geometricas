using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05.Clases
{
    public class Triangulo:Figura
    {
        //Atributos
        private decimal ladoA;
        private decimal ladoB;
        private decimal ladoC;

        //Propiedades
        public decimal LadoA { get { return ladoA; } set { ladoA = value; } }
        public decimal LadoB { get { return ladoB; } set {ladoB = value; } }
        public decimal LadoC { get { return ladoC; } set {ladoC = value; } }

        //Constructores
        public Triangulo() : base()
        {

        }
    }
}
