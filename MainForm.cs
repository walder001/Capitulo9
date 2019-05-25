using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capitulo9.Capitulo10.UI.Registro;
using Capitulo9.IU.Registro;
using Capitulo9.IU.Registro.Mascota;


namespace Capitulo9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Evento para presentar el registro de producto

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            rProducto p = new rProducto();
            p.Show();

        }

       
        //Evento para presentar el registro de mascota
        private void Ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMascota mas = new rMascota();

            mas.Show();
        }

        //Envento para presentar el registro de inventario de la empresa
        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInventario inventario = new rInventario();
            inventario.Show();
        }

        //Evento para presentar el registo estudiante
        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.Show();
        }
    }
}
