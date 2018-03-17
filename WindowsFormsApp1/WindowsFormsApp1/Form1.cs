using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dado d1;
        Dado d2;
        public Form1()
        {
            InitializeComponent();
            d1 = new Dado();
            d2 = new Dado();
        }

        private void cmd1Dado_Click(object sender, EventArgs e)
        {
            int[] sumas = new int[6];
            for(int i = 0; i < 100; i++)
            {
                int lanzamiento = d1.tirar();
                sumas[lanzamiento  - 1]++;
            }

            for (int i = 0; i < sumas.Length; i++)
                txtDatos.Text += "La cara " + (i+1) + " cayó: " + sumas[i].ToString() + Environment.NewLine;
        }

        private void cmd2Dado_Click(object sender, EventArgs e)
        {
            int[] sumas = new int[11];
            for(int i = 0; i < 100; i++)
            {
                int x = d1.tirar() + d2.tirar();
                sumas[x - 2]++;
            }

            for(int i = 0; i < sumas.Length; i++)
            {
                txtDatos.Text += "La suma " + (i + 2) + " ocurrió: " + sumas[i].ToString() + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sumas = new int[11];
            for (int i = 0; i < 100; i++)
            {
                int x = d1.tirar() + d1.tirar();
                sumas[x - 2]++;
            }

            for (int i = 0; i < sumas.Length; i++)
            {
                txtDatos.Text += "La suma " + (i + 2) + " ocurrió: " + sumas[i].ToString() + Environment.NewLine;
            }
        }
    }
}
