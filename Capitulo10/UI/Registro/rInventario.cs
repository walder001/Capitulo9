using Capitulo9.Capitulo10.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capitulo9.Capitulo10.UI.Registro
{
    public partial class rInventario : Form
    {
        ArrayList array = new ArrayList();
        public rInventario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que limpia las 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text= string.Empty;
            txtDescripcion.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            numPrecio.Value = 0;
             numCantidad.Value = 0;
        }
        /// <summary>
        /// Evento para agregar la clase a un array list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            InventarioTienda inv = new InventarioTienda();
            inv.CodigoProducto = txtCodigo.Text;
            inv.Descripcion = txtDescripcion.Text;
            inv.FechaVencimiento = dtpFecha.Value;
            inv.Precio = Convert.ToSingle(numPrecio.Value);
            inv.Cantidad = Convert.ToInt32(numCantidad.Value);

            array.Add(inv);
            MessageBox.Show("Guardado","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
        }

        private void NumCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
