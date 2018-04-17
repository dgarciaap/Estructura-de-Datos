using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Producto
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public double costo { get; set; }
        
        public Producto(string cod, string nom, int cant, double cos)
        {
            this.codigo = cod;
            this.nombre = nom;
            this.cantidad = cant;
            this.costo = cos;
        }

        public override string ToString()
        {
            string producto = "Código: " + codigo + " | " + "Nombre: " +
                nombre + " | " + "Cantidad: " + cantidad.ToString() + " | " +
                "$" + costo.ToString();
            return producto;
        }
    }
}
