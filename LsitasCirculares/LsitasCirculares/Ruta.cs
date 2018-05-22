using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsitasCirculares
{
    class Ruta
    {
        Bus raiz, ultimo;

        public void agregarUltimo(Bus nuevo)
        {
            if(raiz == null)
            {
                raiz = nuevo;
                nuevo.siguiente = nuevo;
                nuevo.anterior = nuevo;
            }
            else
            {
                ultimo = raiz.anterior;
                nuevo.siguiente = raiz;
                nuevo.anterior = ultimo;
                raiz.anterior = nuevo;
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public Bus buscar(string nombre)
        {
            Bus temp = raiz;
            while(temp.nombre != nombre)
            {
                temp = temp.siguiente;
            }
            return temp;
        }

        public Bus eliminarUltimo()
        {
            ultimo.anterior.siguiente = raiz;
            raiz.anterior = ultimo.anterior;
            ultimo = ultimo.anterior;
            return ultimo;
        }

        public Bus eliminarInicio()
        {
            if(raiz.siguiente == raiz)
            {
                raiz = null;
            }
            else
            {
                raiz = raiz.siguiente;
                ultimo.siguiente = raiz;
            }
            return raiz;
        }

        public Bus eliminar(string nombre)
        {
            Bus bus = buscar(nombre);
            bus.siguiente.anterior = bus.anterior;
            bus.anterior.siguiente = bus.siguiente;
            return bus;
        }

        public string listar()
        {
            string buses = "";
            Bus temp = raiz;
            do
            {
                buses += temp.ToString() + " | " + Environment.NewLine;
                temp = temp.siguiente;
            } while (temp != raiz);
            return buses;
        }

        private int cantidad()
        {
            int cant = 0;
            Bus temp = raiz;
            do
            {
                cant++;
                temp = temp.siguiente;
            } while (temp != raiz);
            return cant;
        }

        public void insertar(Bus nuevo, int pos)
        {
            if(pos <= cantidad())
            {
                if(pos == 1)
                {
                    if(cantidad() == 1)
                    {
                        Bus temp = raiz;
                        raiz = nuevo;
                        raiz.siguiente = temp;
                        temp.anterior = raiz;
                    }
                    else
                    {
                        Bus temp = raiz;
                        raiz = nuevo;
                        raiz.siguiente = temp;
                        raiz.anterior = ultimo;
                        ultimo.siguiente = raiz;
                        temp.anterior = raiz;
                    }
                }
                else if(pos == cantidad())
                {
                    Bus temp = ultimo;
                    ultimo.anterior.siguiente = nuevo;
                    nuevo.siguiente = ultimo;
                    ultimo.anterior = nuevo;
                }
                else
                {
                    Bus temp = raiz;
                    for(int i = 1; i <= pos -1; i++)
                    {
                        temp = temp.siguiente;
                    }
                    temp.anterior.siguiente = nuevo;
                    nuevo.siguiente = temp;
                    temp.anterior = nuevo;
                }
            }
        }

        public string ruta(string nombre, double horaIn, double horaFin)
        {
            string cadena = "";
            Bus bus = buscar(nombre);
            double suma = horaIn;
            for(int i = 0; suma < horaFin; i++)
            {
                suma += bus.tiempo;
                cadena += bus.nombre.ToString() + " " + suma.ToString() + Environment.NewLine;
                bus = bus.siguiente;
            }
            return cadena;
        }
    }
}
