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
        /// <summary>
        /// Declaracion de un array list global 
        /// </summary>
        /// 
        ArrayList vector; 

        //Constructor de la clase producto
        public rProducto()
        {
            InitializeComponent();
            vector =new ArrayList();
        }
        
        //Evento para limpiar el formulario
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        
        }

        //Evento que guardar que agrega en el array list
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }

        //Metodo que limpia el formulatio
        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;

        }

        //Metodo para agregar a el array list
        public void Agregar()
        {
            Product n = new Product();
            n.Codigo = txtCodigo.Text;
            n.Nombre = txtNombre.Text;
            n.Precio = txtPrecio.Text;
            n.Cantidad = txtCantidad.Text;
            vector.Add(n);
            MessageBox.Show("Guardado","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        //Metodo para mostrar en el dataGriewView
        public void Mostrar()
        {
            dataTable.DataSource = null;
            dataTable.DataSource = vector;
        }


    }
}
