using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    class Liebre: Corredor
    {
        private int _pasos;
        private int _pos;

        public Liebre(string nombre) : base(nombre)
        {
            nombre = "Liebre";
            _pos = 0;
        }

        public int Posicion { get { return _pos; } }

        public int avanzar()
        {
            _pasos = correr();
            if (_pasos > 0 && _pasos < 3)
            {
                return _pos += 0; 
            }
            else if (_pasos > 2 && _pasos < 5)
            {
                return _pos += 9; 
            }
            else if (_pasos == 5)
            {
                return _pos -= 12; 
            }
            else if (_pasos > 5 && _pasos < 9)
            {
                return _pos++; 
            }
            else
            {
                return _pos -= 2; 
            }
        }
        /*
        public override string ToString()
        {
            correr();
            if (_pasos > 0 || _pasos < 3)
            {
                _pos += 0;
                return "Liebre duerme";
            }
            else if (_pasos > 2 || _pasos < 5)
            {
                _pos += 9;
                return "Liebre da salto grande";
            }
            else if (_pasos == 5)
            {
                _pos -= 12;
                return "Liebre da resbaloón grande";
            }
            else if (_pasos > 5 || _pasos < 9)
            {
                _pos++;
                return "Liebre da salto pequeño";
            }
            else
            {
                _pos -= 2;
                return "Resbalón pequeño";
            }
        }*/
    }
}
