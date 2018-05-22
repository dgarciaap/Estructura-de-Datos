using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsitasCirculares
{
    class Bus
    {
        public string nombre { get; set; }
        public double tiempo { get; set; }
        public Bus siguiente { get; set; }
        public Bus anterior { get; set; }

        public Bus(string nombre, double tiempo)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
        }

        public override string ToString()
        {
            return nombre + "|" + tiempo.ToString();
        }

    }
}
