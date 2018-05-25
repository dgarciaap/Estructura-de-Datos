using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        private int _ciclos;
        private Proceso _siguiente;

        public int Ciclos { get { return _ciclos; } set { _ciclos = value; } }
        public Proceso Siguiente { get { return _siguiente; } set { _siguiente = value; } }
    }
}
