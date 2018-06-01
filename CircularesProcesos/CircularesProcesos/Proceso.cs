using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularesProcesos
{
    class Proceso
    {
        public int _ciclos;
        public Proceso _siguiente;
        public Proceso _anterior;
        
        public int Ciclos { get { return _ciclos; } set { _ciclos = value; } }
        public Proceso Siguiente { get { return _siguiente; } set { _siguiente = value; } }
        public Proceso Anterior { get { return _anterior; } set { _anterior = value; } }
    }
}
