using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Capitulo10.Entidades
{
    /// <summary>
    /// Clase de el inventario de la tienda 
    /// </summary>
    public class InventarioTienda
    {
            public string CodigoProducto { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public float Precio { get; set; }
            public int Cantidad { get; set; }
        /// <summary>
        /// Constructor vacio de la clase de el inventario de la tienda
        /// </summary>

        public InventarioTienda()
        {
            this.CodigoProducto = string.Empty;
            this.Descripcion = string.Empty;
            this.FechaVencimiento = DateTime.Now;
            this.Precio = 0.0f;
            this.Cantidad = 0;
        }

        /// <summary>
        /// Constructor con paramentro de la clase de el inventario de la tienda
        /// </summary>

        public InventarioTienda(string codigo, string descripcion, DateTime vencimiento, float precio, int cantidad)
        {
            this.CodigoProducto = codigo;
            this.Descripcion = descripcion;
            this.FechaVencimiento = vencimiento;
            this.Precio = precio;
            this.Cantidad = cantidad; 
        }
    }



}
