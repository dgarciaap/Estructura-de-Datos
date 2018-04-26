using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficoTortuga
{
    public partial class Form1 : Form
    {
        Tortuga tor = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           txtDatos.Text = tor.imprimir();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            int pasos = Convert.ToInt32(txtAvanzar.Text);
            tor.avanzar(pasos);
        }

        private void btnLevantar_Click(object sender, EventArgs e)
        {
            tor.levantarPluma();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            tor.bajarPluma();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            tor.girarDer();
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            tor.girarIzq();
        }
    }
}
