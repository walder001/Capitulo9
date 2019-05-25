using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capitulo9.Entidades;
using Capitulo9.BLL;
using Capitulo9.IU.Registro;
using Capitulo9;
using System.Collections;

namespace Capitulo9.IU.Registro
{
    public partial class rProducto : Form
    {
        ArrayList vector = new ArrayList();

        public ProductosTienda[] pro = new ProductosTienda[50];
        public void Inicializar()
        {
            Product n = new Product();
            n.Codigo = txtCodigo.Text;
            n.Nombre = txtNombre.Text;
            n.Precio = txtPrecio.Text;
            n.Cantidad = txtCantidad.Text;
            vector.Add(n);

            dataTable.DataSource = null;
            dataTable.DataSource = vector;

        }
       

        public rProducto()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Mostrar();
            Limpiar();
        }
  
        
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }

        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;

        }
        public void Agregar()
        {
            Product n = new Product();
            n.Codigo = txtCodigo.Text;
            n.Nombre = txtNombre.Text;
            n.Precio = txtPrecio.Text;
            n.Cantidad = txtCantidad.Text;
            vector.Add(n);
            MessageBox.Show("Guardado");

        }

        public void Ag()
        {
            ProductosTienda n = new ProductosTienda();
            n.Codigo = txtCodigo.Text;
            n.Nombre = txtNombre.Text;
            n.Precio = txtPrecio.Text;
            n.Cantidad = txtCantidad.Text;
            vector.Add(n);
            MessageBox.Show("Guardado");

        }

        public void Mostrar()
        {
            dataTable.DataSource = null;
            dataTable.DataSource = vector;
        }


    }
}
