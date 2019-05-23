using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capitulo9.IU.Registro;
using System.Windows;
using System.Windows.Forms;
using System.Collections;

namespace Capitulo9.Entidades
{
        public struct ProductosTienda
        {//Creando la estructura a la que llamaré "ProductosTienda" con los datos de los productos
            public string Codigo;
            public string Nombre;
            public string Precio;
            public string Cantidad;



        //Igualando cada campo de la estructura con su igual en el constructor 
        public ProductosTienda(string codigo, string nombre, string precio, string cantidad)
            {
                //Llevamos a cabo la asignación
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

            public void  Visualizar(TextBox codigo, TextBox nombre, TextBox precio, TextBox cantidad)
            {
                Codigo = Convert.ToString(codigo);
                Nombre = Convert.ToString(nombre);
                Precio = Convert.ToString(precio);
                Cantidad = Convert.ToString(cantidad);

            }


            public void Mostrar(string codigo, string nombre, string precio, string cantidad)
            {
                ProductosTienda[] agregar = new ProductosTienda[5];
                agregar[0].Codigo = codigo;
                agregar[0].Nombre = nombre;
                agregar[0].Precio = precio;
                agregar[0].Cantidad = cantidad;







            }

        }



    





}
