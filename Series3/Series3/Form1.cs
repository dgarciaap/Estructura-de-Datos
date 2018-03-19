using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double sen(double x, int n)
        {
            double suma = x;
            int po;
            for(int i = 2; i <= n; i++)
            {
                po = (i * 2) - 1;
                if(i % 2 == 0)
                {
                    suma -= Math.Pow(x, po) / factorial(po);
                }
                else
                {
                    suma += Math.Pow(x, po) / factorial(po);
                }
            }
            return suma;
        }

        private void cmdSen_Click(object sender, EventArgs e)
        {
            txtR.Text = sen(Convert.ToDouble(txtX.Text), Convert.ToInt32(txtN.Text)).ToString();
        }

        public double cos(double x, int n)
        {
            double suma = 1;
            int po;
            for (int i = 1; i <= n; i++)
            {
                po = i * 2;
                if (i % 2 == 0)
                {
                    suma += Math.Pow(x,po)/factorial(po);
                }
                else
                {
                    suma -= Math.Pow(x, po) / factorial(po);
                }
            }
            return suma;
        }

        public double factorial(int n)
        {
            double resultado = 1f;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            txtR.Text = cos(Convert.ToDouble(txtX.Text), Convert.ToInt32(txtN.Text)).ToString();
        }

        public double ln(double x, int n)
        {
            double suma = ((x-1)/x); 
            for(double i=2; i < n+1; i++)
            {
                suma += ((1 / i) * Math.Pow(((x - 1) / x),i));
                txtComprobar.Text += suma.ToString() + Environment.NewLine;
            }
            return suma;
        } 

        private void cmdLn_Click(object sender, EventArgs e)
        {
            txtR.Text = ln(Convert.ToDouble(txtX.Text), Convert.ToInt32(txtN.Text)).ToString();
        }
    }
}
