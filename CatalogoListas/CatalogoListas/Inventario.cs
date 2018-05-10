using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoListas
{
    class Inventario
    {
        Producto ultimo, primero, anterior, encontrado, temp;

        public Inventario()
        {
            primero = null;
        }

        public void agregar(Producto nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public void agregarEnInicio(Producto prodEnInicio)
        {
            if (primero == null)
            {
                primero = prodEnInicio;
                ultimo = prodEnInicio;
            }
            else
            {
                prodEnInicio.siguiente = primero;
                primero = prodEnInicio;
            }
        }
        public void insertar(Producto prodAInsertar, int posicion)
        {
            if (posicion == 1)
                agregarEnInicio(prodAInsertar);
            else
            {
                int inv = 2;
                temp = primero;

                while (inv < posicion)
                {
                    temp = temp.siguiente;
                    inv++;
                }

                prodAInsertar.siguiente = temp.siguiente;
                temp.siguiente = prodAInsertar;
            }
        }

        public Producto buscar(int codigo)
        {
            temp = primero;
            encontrado = null;

            while (encontrado == null && temp != null)
                if (temp.codigo == codigo)
                    encontrado = temp;
                else
                {
                    anterior = temp;
                    temp = temp.siguiente;
                }

            return encontrado;
        }

        public bool eliminar(int codigo)
        {
            if (buscar(codigo) != null)
            {
                if (encontrado == primero)
                {
                   if(primero.siguiente != null)
                    {
                        primero = primero.siguiente;
                    } 
                }
                else if (encontrado == ultimo)
                {
                    ultimo = anterior;
                    anterior.siguiente = null;
                } 
                else
                {
                    anterior.siguiente = encontrado.siguiente;
                }

                return true;
            }
            else
                return false;
        }

        public bool eliminarPrimero()
        {
            if (primero != null)
            {
                if (primero.siguiente != null)
                {
                    primero = primero.siguiente;
                }
                return true;
            }
            return false;
        }

        public void eliminarUltimo()
        {
            Producto temp = primero;
            while(temp.siguiente.siguiente != null)
            {
                temp = temp.siguiente;
            }
            temp.siguiente = null;
        }

        public string mostrarInverso()
        {
            string prod = "";
            if(primero != null)
            {
                return prod = mostrarInverso(primero);
            }
            return null;
        }

        public string mostrarInverso(Producto prod)
        {
            if(prod.siguiente != null)
            {
                return mostrarInverso(prod.siguiente) + prod.ToString() + Environment.NewLine;
            }
            else
            {
                return prod.ToString();
            }
        }

        public void invertir()
        {
            Producto temp = primero, tempPrimero = primero;
            primero = ultimo;
            Producto temp1 = primero;
            while (temp.siguiente != ultimo)
            {
                while(temp.siguiente != ultimo)
                {
                    temp = temp.siguiente;
                }
                temp1.siguiente = temp;
                temp.anterior = temp1;
                ultimo = temp;
                temp = tempPrimero;
                temp1 = temp1.siguiente;
            }
            tempPrimero.siguiente = null;
            temp1.siguiente = tempPrimero;
        }

        public string mostrar()
        {
            string reporte = "";
            temp = primero;

            while (temp != null)
            {
                reporte += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }

            return reporte;
        }

        /*private void Agregar(Base nuevo, Base quien)
            if(quien.sig==null)
                quien.sig = nuevo;
            else
                Agregar(nuevo, quien.sig);
                */
    }
}
