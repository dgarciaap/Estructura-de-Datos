using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolExpresion
{
    public partial class Form1 : Form
    {
        string exp;
        Arbol arbol = new Arbol();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            exp = txtExpresion.Text;
            for(int i = 0; i < exp.Length; i++)
            {
                Nodo nuevo = new Nodo(exp[i].ToString());
                arbol.agregar(nuevo);
            }
            arbol.generarArbol();
            txtResultados.Text = arbol.preOrden() + Environment.NewLine + arbol.postOrden();
        }
    }
}
