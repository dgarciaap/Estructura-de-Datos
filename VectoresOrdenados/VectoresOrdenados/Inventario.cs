using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresOrdenados
{
    class Inventario
    {
        public static Producto[] _vec = new Producto[15];
        public int _posActual;

        public Inventario()
        {
            _posActual = 0;
        }

        public void agregar(Producto producto)
        {
            _vec[_posActual] = producto;
            if (_posActual > 0)
            {
                ordenar();
            }
            _posActual++;
        }

        public void ordenar()
        {
            Producto temp;
            for(int i = 0; i < _posActual; i++)
            {
                for(int j = 0; j < _posActual - i; j++)
                {
                    if(_vec[j].codigo > _vec[j + 1].codigo)
                    {
                        temp = _vec[j];
                        _vec[j] = _vec[j + 1];
                        _vec[j + 1] = temp;
                    }
                }
            }
        }

        public void eliminar(int codigo)
        {
            //for (int i = 0; i < _posActual; i++)
            for (int i = 0; i < _posActual; i++)
            {
                if (_vec[i].codigo == codigo)
                {
                    for (int j = i; j < _posActual - 1; j++)
                    {
                        _vec[j] = _vec[j + 1];
                    }
                    _vec[_posActual - 1] = null;
                    _posActual--;
                }
            }
        }

        public string listar()
        {
            string producto = "";
            for (int i = 0; i < _posActual; i++)
            {
                producto += _vec[i].ToString() + Environment.NewLine;
            }
            return producto;
        }

        /* public Producto buscar(int codigo)
         {
             //for
             for (int i = 0; i < _posActual; i++)
             {
                 if (_vec[i].codigo == codigo)
                 {
                     return _vec[i];
                 }
             }
             return null;
         }*/

        public Producto buscar(int codigo)
        {
            int i = 0;
            int j = _posActual -1;
            int k = 0;

            while(i <= j)
            {
                k = i + (j - i) / 2;
                if(_vec[k].codigo == codigo)
                {
                    return _vec[k];
                }
                else if (_vec[k].codigo < codigo)
                {
                    i = k + 1;
                }
                else if (_vec[k].codigo > codigo)
                {
                    j = k - 1;
                }
            } 
            return null;
        }
    }
}

