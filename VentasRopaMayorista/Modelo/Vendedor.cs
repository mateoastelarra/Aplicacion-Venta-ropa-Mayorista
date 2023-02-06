using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;
        private Tienda tienda;
        private List<Cotizacion> historialDeCotizaciones = new List<Cotizacion>();

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;}
        public int CodigoVendedor { get => codigoVendedor; }
        internal List<Cotizacion> HistorialDeCotizaciones { get => historialDeCotizaciones;}
        internal Tienda Tienda { get => tienda; set => tienda = value; }

        public Vendedor(string nombre, string apellido, int codigoVendedor, Tienda tienda)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
            this.tienda = tienda;
        }

        public float CotizarPrendas(Prenda prenda, int cantidad)
        {
            return prenda.CalcularPrecio(prenda.PrecioUnitario) * cantidad;
        }

        public void AgregarCotizacion(DateTime fechaHora, int codigoVendedor, 
                                      string prendaCotizada, int cantidadUnidades, 
                                      string resultadoCalculoCotizacion)
        {
            Cotizacion cotizacion = new Cotizacion(historialDeCotizaciones.Count + 1, fechaHora, codigoVendedor,
                                                   prendaCotizada, cantidadUnidades, resultadoCalculoCotizacion);
            historialDeCotizaciones.Add(cotizacion);
        }
    }
}
