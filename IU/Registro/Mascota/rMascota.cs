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
using Capitulo9.Entidades;

namespace Capitulo9.IU.Registro.Mascota
{
    public partial class rMascota : Form
    {
        ArrayList dato = new ArrayList();
        public rMascota()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Listar();

        }

        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            nudEdad.Value = 0;
            txtGenero.Text = string.Empty;

            txtNombreMascota.Text = string.Empty;
            nudEdadMascota.Value = 0;
            txtGeneroMascota.Text = string.Empty;
        }

        public void Agregar()
        {
            Entidades.Persona p = new Entidades.Persona();

            p.Nombre = txtNombre.Text;
            p.edad = Convert.ToInt32(nudEdad.Value);
            p.genero = txtGenero.Text;

            p.NombreMascota = txtNombreMascota.Text;
            p.EdadMascota = Convert.ToInt32(nudEdadMascota.Value);
            p.GeneroMascota = txtGeneroMascota.Text;

            dato.Add(p);

        }

        public void Listar()
        {
            dgvInformacion.DataSource = null;
            dgvInformacion.DataSource = dato;
        }


    }
}
