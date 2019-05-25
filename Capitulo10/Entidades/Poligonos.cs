using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Capitulo10.Entidades
{
    public class Poligono
    {
        public float Lado { get; set; }
        public float Largo { get; set; }
        public float Ancho { get; set; }
        public float Radio { get; set; }

        public float Alto { get; set; }


        //Sobrecargando constructor
        public Poligono(float ancho, float largo)
        {
            Ancho = ancho;
            this.Largo = largo;
        }

        //Sobrecargando constructor
        public Poligono(float ancho, float largo, float alto)
        {
            this.Ancho = ancho;
            this.Largo = largo;
            this.Alto = alto;
        }

        //Sobrecargando constructor
        public Poligono(float radio)
        {
            this.Radio = radio;
        }

        

        //Programando el metodo ToString() para usarse en esta clase: "Pilogono"
       



    }
}
