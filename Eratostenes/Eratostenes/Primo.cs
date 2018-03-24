using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratostenes
{
    class Primo
    {
        private static int _n;
        private bool[] _primo = new bool[1000];

       /* public int N
        {
            get { return _n; }
            set { _n = value; }
        }*/

        public Primo(int n)
        {
            _n = n;
        }

        public void llenar()
        {
            for(int i = 0; i < _n; i++)
            {
                _primo[i] = true;
            }
        }

        public void primos()
        {
            for(int i = 2; i < _n; i++)
            {
                //sacar multiplos
                for(int j = 2; i*j < _n; i++)
                {
                    _primo[i * j] = false;
                }
            }
        }

        public string mostrar()
        {
            string cadena = "";
            for(int i = 2; i < _n; i++)
            {
                if(_primo[i])
                {
                    cadena += i.ToString() + ",";
                }

            }
            return cadena;
        }
    }
}
