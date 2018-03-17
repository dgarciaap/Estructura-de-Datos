using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Dado
    {
        private int _cara;
        private static Random rnd;

        public Dado()
        {
            rnd = new Random(DateTime.Now.Millisecond);
        }
        public int tirar()
        {
            int _cara = rnd.Next(1,7);
            return _cara;
        }
        /*
        public override string ToString()
        {
            tirar();
            return 
        }*/
    }
}
