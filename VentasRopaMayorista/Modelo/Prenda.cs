using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    abstract class Prenda
    {
        protected bool calidadPremium;
        protected float precioUnitario;
        protected int cantidadStock;
        protected string nombre;

        public bool CalidadPremium { get => calidadPremium;}
        public float PrecioUnitario { get => precioUnitario;}
        public int CantidadStock { get => cantidadStock;}
        public string Nombre { get => nombre; set => nombre = value;}

        public Prenda()
        {

        }

        public Prenda(bool calidadPremium, float precioUnitario)
        {
            this.calidadPremium = calidadPremium;
            this.precioUnitario = precioUnitario;
            nombre = PonerNombre();
        }

        public virtual float CalcularPrecio(float precio)
        {
            if (calidadPremium)
            {
                return precio * 1.3f;
            }
            return precio;
        }
        public virtual string PonerNombre()
        {
            return "Prenda sin nombre";
        }
    }
}
