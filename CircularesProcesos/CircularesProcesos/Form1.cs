using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularesProcesos
{
    public partial class Form1 : Form
    {
        Procesador pro = new Procesador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = generar();
        }

        public string generar()
        {
            string datos = "";
            int ciclosVacios = 0;
            int procesosTotales = 0;
            int restar;
            for (int i = 0; i < 300; i++)
            {
                Proceso nuevo = pro.nuevoProceso();
                if (nuevo != null)
                    pro.agregar(nuevo);
                restar = pro.restar();
                if (restar == 0)
                {
                    ciclosVacios++;
                }
                else if (restar == 1)
                {
                    procesosTotales++;
                }
            }
            return datos += "Ciclos vacios: " + ciclosVacios.ToString() + Environment.NewLine
                + "Procesos completados: " + procesosTotales.ToString() + Environment.NewLine
                + "Procesos restantes: " + pro.procesosRestantes().ToString() + Environment.NewLine
                + "Ciclos restantes: " + pro.ciclosRestantes().ToString();
        }
    }
}
