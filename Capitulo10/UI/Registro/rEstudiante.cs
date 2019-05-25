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
    public partial class rEstudiante : Form
    {
        ArrayList array = new ArrayList();
        public rEstudiante()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            txtGrado.Text = string.Empty;
            txtNombrePadre.Text = string.Empty;
            txtTelefonoPadre.Text = string.Empty;
            txtNombreMadre.Text = string.Empty;
            txtTelefonoMadre.Text = string.Empty;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            InformacionEstudiante info = new InformacionEstudiante();

            info.Nombres = txtNombre.Text;
            info.Direccion = txtDireccion.Text;
            info.FechaNaciminete =  dtpFecha.Value;
            info.Grado = txtGrado.Text;
            info.NombrePadre = txtNombrePadre.Text;
            info.TelefonoPadre = txtTelefonoPadre.Text;
            info.NombreMadre = txtNombreMadre.Text;
            info.TelefonoMadre = txtTelefonoMadre.Text;
            array.Add(info);
            MessageBox.Show("Guardado","",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
