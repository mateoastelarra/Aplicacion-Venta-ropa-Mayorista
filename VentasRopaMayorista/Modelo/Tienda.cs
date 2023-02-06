using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    class Tienda
    {
        string nombre;
        string direccion;
        List<Prenda> prendas = new List<Prenda>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> Prendas { get => prendas;}

        public Tienda(string nombre,string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public void AgregarPrenda(Prenda prenda)
        {
                prendas.Add(prenda);
        }

    }
}
