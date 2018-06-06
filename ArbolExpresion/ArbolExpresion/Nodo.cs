using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolExpresion
{
    class Nodo
    {
        private string _dato;
        private Nodo _hIzq;
        private Nodo _hDer;
        private Nodo _anterior;
        private Nodo _siguiente;

        public string Dato { get { return _dato; } set { _dato = value ; } }
        public Nodo HIzq { get { return _hIzq; } set { _hIzq = value; } }
        public Nodo HDer { get { return _hDer; } set { _hDer = value; } }
        public Nodo Anterior { get { return _anterior; } set { _anterior = value; } }
        public Nodo Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        public Nodo(string dato)
        {
            _dato = dato;
        }
    }
}
