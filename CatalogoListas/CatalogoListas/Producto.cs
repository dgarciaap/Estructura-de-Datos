using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoListas
{
    class Producto
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public double costo { get; set; }
        public Producto siguiente { get; set; }
        public Producto anterior { get; set; }

        public Producto(int cod, string nom, int cant, double cos)
        {
            this.codigo = cod;
            this.nombre = nom;
            this.cantidad = cant;
            this.costo = cos;
            siguiente = null;
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
