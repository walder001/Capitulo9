using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Capitulo10.Entidades
{
    public class InventarioTienda
    {
        
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public float Precio { get; set; }
            public int Cantidad { get; set; }

        public InventarioTienda()
        {
            Codigo = 0;
            Nombre = "";
            Precio = 0.0f;
            Cantidad = 0;
        }
        public InventarioTienda(int codigo, string nombre, float precio, int cantidad)
        {
            Codigo = codigo; 
            Nombre = nombre; 
            Precio = precio; 
            Cantidad = cantidad; 
        }
    }



}
