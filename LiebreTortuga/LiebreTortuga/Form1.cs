using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiebreTortuga
{
    public partial class Form1 : Form
    {
        Liebre l;
        Tortuga t;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l = new Liebre("Liebre");
            t = new Tortuga("Tortuga");

            while(l.Posicion < 80 && t.Posicion < 80)
            {
                txtR.Text += "Liebre avanza " + l.avanzar().ToString() + Environment.NewLine;
                txtR.Text += "Tortuga avanza " + t.avanzar().ToString() + Environment.NewLine;
            }

            if(l.Posicion > t.Posicion)
            {
                txtR.Text += "La liebre ha ganado";
            }
            else if(l.Posicion < t.Posicion)
            {
                txtR.Text += "La tortuga ha ganado";
            }
            else if(l.Posicion == t.Posicion)
            {
                txtR.Text += "Empate";
            }
        }
    }
}
