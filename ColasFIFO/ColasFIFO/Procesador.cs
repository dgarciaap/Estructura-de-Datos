using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Procesador
    {
        private static Random rnd;
        public Proceso inicio;

        public Procesador()
        {
            rnd = new Random(DateTime.Now.Millisecond);
        }

        public Proceso nuevoProceso()
        {
            int no = rnd.Next(0, 100);
            if(no <= 35)
            {
                Proceso nuevo = new Proceso();
                nuevo.Ciclos = rnd.Next(3,14);
                return nuevo;
            }
            return null;
        }


        public void agregar(Proceso nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                agregar(nuevo, inicio);
            }
        }

        private void agregar(Proceso nuevo, Proceso pos)
        {
            if(pos.Siguiente == null)
            {
                pos.Siguiente = nuevo;
            }
            else
            {
                agregar(nuevo, pos.Siguiente);
            }
        }

        public int restar()
        {
            if(inicio == null)
            {
                return 0;
            }
            else
            {
                if (inicio.Ciclos < 1)
                {
                    inicio = inicio.Siguiente;
                    inicio.Ciclos--;
                    return 1;
                }
                else
                {
                    inicio.Ciclos--;
                }
                return 2;
            }
            
        }

        public int procesosRestantes()
        {
            if(inicio == null)
            {
                return 0;
            }
            else
            {
                return procesosRestantes(inicio);
            }
        }

        public int procesosRestantes(Proceso proceso)
        {
            int suma = 1;
            if(proceso.Siguiente == null)
            {
                return 1;
            }
            else
            {
                return suma + procesosRestantes(proceso.Siguiente);
            }
        }

        public int ciclosRestantes()
        {
            if(inicio == null)
            {
                return 0;
            }
            else
            {
                return ciclosRestantes(inicio);
            }
        }

        public int ciclosRestantes(Proceso proceso)
        {
            int suma = proceso.Ciclos;
            if(proceso.Siguiente == null)
            {
                return proceso.Ciclos;
            }
            else
            {
                return suma + ciclosRestantes(proceso.Siguiente);
            }
        }
    }
}
