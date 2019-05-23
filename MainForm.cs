using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capitulo9.IU.Registro;

namespace Capitulo9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            rProducto p = new rProducto();
            p.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
    }
}
