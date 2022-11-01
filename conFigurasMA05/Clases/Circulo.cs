using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conFigurasMA05.Clases
{
    public class Circulo:Figura
    {
        //Atributos
        private decimal radio;

        //Propiedad
        public decimal Radio { get { return radio; } set { radio = value; } }

        //Constructores
        public Circulo():base()
        {
            this.radio = 0;
        }
        public Circulo(int x, int y, decimal radio) : base(x, y)
        {
            this.radio = radio;
        }
        public Circulo(decimal radio, Punto centro):base(centro)
        {
            this.radio=radio;
        }
        public Circulo(Circulo c):base(c)
        {
            this.radio = c.radio;
        }

        //Sobreescritura
        public override string ToString()
        {
            return "Centro: "+base.centro.ToString()+"Radio: "+radio;
        }

        //Metodos
        public decimal CalcularPerimetro()
        {
            return (radio * 2) * (decimal)Math.PI;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * radio * radio;
        }


    }
}
