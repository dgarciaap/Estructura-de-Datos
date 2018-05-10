using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    class Inventario
    {
        Producto inicio;


        public void agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                agregar(inicio, nuevo);
            }

        }

        public void agregar(Producto pos, Producto nuevo)
        {
            if (nuevo.codigo < inicio.codigo)
            {
                Producto temp = inicio;
                inicio = nuevo;
                inicio.siguiente = temp;
                temp.anterior = inicio;
            }
            else if (nuevo.codigo > pos.codigo && pos.siguiente == null)
            {
                pos.siguiente = nuevo;
                nuevo.anterior = pos;
            }
            else if (nuevo.codigo < pos.codigo)
            {
                pos.anterior.siguiente = nuevo;
                nuevo.siguiente = pos;
                pos.anterior = nuevo;
            }
            else
            {
                agregar(pos.siguiente, nuevo);
            }
        }

        public Producto buscar(int cod)
        {
            Producto temp = inicio;
            while (temp.codigo != cod)
            {
                temp = temp.siguiente;
            }
            return temp;
        }

        public void eliminar(int cod)
        {
            Producto temp = buscar(cod);
            temp.anterior.siguiente = temp.siguiente;
            temp.siguiente.anterior = temp.anterior;
        }

        public void eliminarInicio()
        {
            if (inicio.siguiente != null)
            {
                inicio = inicio.siguiente;
            }
            else
            {
                inicio = null;
            }
        }

        public void eliminarUltimo()
        {
            Producto temp = inicio;
            while (temp.siguiente.siguiente != null)
            {
                temp = temp.siguiente;
            }
            temp.siguiente = null;
        }

        public string listar()
        {
            string prod = "";
            Producto temp = inicio;
            while (temp.siguiente != null)
            {
                prod += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }
            prod += temp.ToString();
            return prod;
        }

        public string invertir()
        {
            string prod = "";
            if (inicio != null)
            {
                prod = invertir(inicio);
            }
            return prod;
        }

        public string invertir(Producto prod)
        {
            if (prod.siguiente != null)
            {
                return invertir(prod.siguiente) + prod.ToString();
            }
            else
            {
                return prod.ToString();
            }
        }
    }
}
