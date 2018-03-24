using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiebreTortuga
{
    abstract class Corredor
    {
        protected string _nombre;
        protected static Random rnd = new Random(DateTime.Now.Millisecond);

        public Corredor(string nombre)
        {
            _nombre = nombre;
        }

        public int correr()
        {
            return rnd.Next(1, 11);
        }
    }
}
