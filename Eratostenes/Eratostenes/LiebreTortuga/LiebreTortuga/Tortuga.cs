using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    class Tortuga:Corredor
    {
        private int _pasos;
        private int _pos;

        public Tortuga(string name) :base (name)
        {
            name = "Tortuga";
            _pos = 0;
        }

        public int Posicion { get { return _pos; } }

        public int avanzar()
        {
            _pasos = correr();
            if(_pasos > 0 && _pasos < 6)
            {
                return _pos += 3; ;
            }
            else if(_pasos > 5 && _pasos < 8)
            {
                return _pos -= 6; ;
            }
            else
            {
                return _pos++; ;
            }
        }
        /*
        public override string ToString()
        {
            correr();
            if (_pasos > 0 || _pasos < 6)
            {
                _pos += 3;
                return "Tortuga da paso rápido";
            }
            else if (_pasos > 5 || _pasos < 8)
            {
                _pos -= 6;
                return "Tortuga da resbalon";
            }
            else
            {
                _pos++;
                return "Tortuga da paso lento";
            }
        }*/
    }
}
