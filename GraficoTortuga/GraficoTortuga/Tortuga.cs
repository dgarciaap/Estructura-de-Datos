using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficoTortuga
{
    class Tortuga
    {
        private int[,] matriz = new int[20, 20];
        private int[] _pos = new int[2];
        private int _pluma;
        private int _direccion;

        public Tortuga()
        {
            llenar();
            _pos[0] = 0;
            _pos[1] = 0;
            _pluma = 0;
            _direccion = 6;
        }

        private void llenar()
        {
            int ren = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < col; r++)
                {
                    matriz[r, c] = 0;
                }
            }
        }

        public void levantarPluma()
        {
            _pluma = 0;
        }

        public void bajarPluma()
        {
            _pluma = 1;
            matriz[_pos[1], _pos[0]] = _pluma;
        }

        public void avanzar(int pasos)
        {
            int[] ultpos = new int[2] { _pos[0], _pos[1] };
            for (int i = 0; i < pasos; i++)
            {
                if (_direccion == 8)
                {
                    _pos[1]--;
                }
                else if (_direccion == 2)
                {
                    _pos[1]++;
                }
                else if (_direccion == 6)
                {
                    _pos[0]++;
                }
                else if (_direccion == 4)
                {
                    _pos[0]--;
                }
                if (_pos[0] < matriz.GetLength(1) && _pos[1] < matriz.GetLength(0))
                {
                    if (_pluma == 1)
                    {
                        matriz[_pos[1], _pos[0]] = _pluma;
                    }
                }
                else
                {
                    _pos[0] = ultpos[0];
                    _pos[1] = ultpos[1];
                }
            }
        }

        public void girarDer()
        {
            if(_direccion == 8)
            {
                _direccion = 6;
            }
            else if(_direccion == 6)
            {
                _direccion = 2;
            }
            else if(_direccion == 2)
            {
                _direccion = 4;
            }
            else if(_direccion == 4)
            {
                _direccion = 8;
            }
        }

        public void girarIzq()
        {
            if(_direccion == 8)
            {
                _direccion = 4;
            }
            else if(_direccion == 4)
            {
                _direccion = 2;
            }
            else if(_direccion == 2)
            {
                _direccion = 6;
            }
            else if(_direccion == 6)
            {
                _direccion = 8;
            }
        }

        public string imprimir()
        {
            string mat = "";
            int ren = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < col; r++)
                {
                    mat += matriz[r, c].ToString() + " ";
                }
                mat += Environment.NewLine;
            }
            return mat;
        }
    }
}
