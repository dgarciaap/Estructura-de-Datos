using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolExpresion
{
    class Arbol
    {
        Nodo inicio;

        public void agregar(Nodo nuevo)
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

        private void agregar(Nodo pos, Nodo nuevo)
        {
            if (pos.Siguiente == null)
            {
                pos.Siguiente = nuevo;
                nuevo.Anterior = pos;
            }
            else
            {
                agregar(pos.Siguiente, nuevo);
            }
        }

        public void generarArbol()
        {
            generarArbolMultiplicacion(inicio);
            generarArbolSuma(inicio);
        }

        private void generarArbolMultiplicacion(Nodo pos)
        {
            /*char[] separador = foo;analizar quien es tu separador
            string[] ramas = s.Split(separador, 2);

            Nodo subRaiz = new Nodo(separador[0]);
            subRaiz.HIzq = 
                raiz.HIzq = metodoRecursibo(ramaIzquierda);
                raiz.Hder = metodoRecursibo(ramaDerecha);
            Nodo temp = inicio;
            while(temp.Dato != "+" && temp.Dato != "-")
            {

            }*/
            //Nodo temp = inicio;
            if(pos.Dato == "/" || pos.Dato == "*")
            {
                pos.HIzq = pos.Anterior;
                eliminar(pos.Anterior);
                pos.HDer = pos.Siguiente;
                eliminar(pos.Siguiente);
                if(pos.Siguiente != null)
                {
                    generarArbolMultiplicacion(pos.Siguiente);
                }
            }
            else
            {
                generarArbolMultiplicacion(pos.Siguiente);
            }
        }

        public void generarArbolSuma(Nodo pos)
        {
            if(pos.Dato == "+" || pos.Dato == "-")
            {
                pos.HIzq = pos.Anterior;
                eliminar(pos.Anterior);
                pos.HDer = pos.Siguiente;
                eliminar(pos.Siguiente);
                if(pos.Siguiente != null)
                {
                    generarArbolSuma(pos.Siguiente);
                }
            }
            else
            {
                generarArbolSuma(pos.Siguiente);
            }
        }

        public void eliminar(Nodo nodo)
        {
            if(inicio == nodo)
            {
                inicio = inicio.Siguiente;
                inicio.Anterior = null;
            }
            else if(nodo.Siguiente == null)
            {
                nodo.Anterior.Siguiente = null;
            }
            else
            {
                nodo.Anterior.Siguiente = nodo.Siguiente;
                nodo.Siguiente.Anterior = nodo.Anterior;
            }
        }

        public string preOrden()
        {
            if(inicio == null)
            {
                return "";
            }
            else
            {
                return preOrden(inicio);
            }
        }

        private string preOrden(Nodo nodo)
        {
            string pre = "";
            pre += nodo.Dato;
            if(nodo.HIzq != null)
            {
                pre += preOrden(nodo.HIzq);
            }
            if(nodo.HDer != null)
            {
                pre += preOrden(nodo.HDer);
            }
            return pre;
        }

        public string postOrden()
        {
            if(inicio == null)
            {
                return "";
            }
            else
            {
                return postOrden(inicio);
            }
        }

        private string postOrden(Nodo nodo)
        {
            string post = "";
            if (nodo.HIzq != null)
            {
                post += postOrden(nodo.HIzq);
            }
            if (nodo.HDer != null)
            {
                post += postOrden(nodo.HDer);
            }
            post += nodo.Dato;
            return post;
        }
    }
}
