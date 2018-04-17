using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Admin
    {
        public Producto[] _vec = new Producto[15];
        public int _posActual;
        public int _posBusqueda = 2;

        public Admin()
        {
            _posActual = 0;
        }

        public void agregar(Producto producto)
        {
           _vec[_posActual] = producto;
            _posActual++;
        }

        public void eliminar(string codigo)
        {
            for (int i = 0; i < _posActual; i++)
            {
                if (_vec[i].codigo == codigo)
                {
                    for (int j = i; j < _posActual - 1; j++)
                    {
                        _vec[j] = _vec[j + 1];
                    }
                }
            }
            _vec[_posActual - 1] = null;
            _posActual--;
        }

        public void insertar(Producto producto, int posicion)
        {
            for(int i = _posActual; i > posicion - 1; i--)
            {
                _vec[i] = _vec[i - 1];
            }
            _vec[posicion - 1] = producto;
            _posActual++;
        }

        public string listar()
        {
            string producto = "";
            for(int i = 0; i < _posActual; i++)
            {
                producto += _vec[i].ToString() + Environment.NewLine;   
            }
            return producto;
        }

        public Producto buscar(string codigo)
        { 
            for(int i = 0; i < _posActual; i++)
            {
                if(_vec[i].codigo == codigo)
                {
                    return _vec[i];
                }
            }
            return null;
        }
    }
}
