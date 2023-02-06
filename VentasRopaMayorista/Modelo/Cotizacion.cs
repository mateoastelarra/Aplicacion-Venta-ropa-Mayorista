using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    class Cotizacion
    {
        private int numeroId;
        private DateTime fechaHora;
        private int codigoVendedor;
        private string prendaCotizada;
        private int cantidadUnidades;
        private string resultadoCalculoCotizacion;

        public int NumeroId { get => numeroId; }
        public DateTime FechaHora { get => fechaHora; }
        public int CodigoVendedor { get => codigoVendedor;}
        public string PrendaCotizada { get => prendaCotizada; }
        public int CantidadUnidades { get => cantidadUnidades;}
        public string ResultadoCalculoCotizacion { get => resultadoCalculoCotizacion;}

        public Cotizacion(int numeroId, DateTime fechaHora, int codigoVendedor,
                          string prendaCotizada, int cantidadUnidades, 
                          string resultadoCalculoCotizacion)
        {
            this.numeroId = numeroId;
            this.fechaHora = fechaHora;
            this.codigoVendedor = codigoVendedor;
            this.prendaCotizada = prendaCotizada;
            this.cantidadUnidades = cantidadUnidades;
            this.resultadoCalculoCotizacion = resultadoCalculoCotizacion;
        }

        public string DetalleCotizacion()
        {
            string detalleCotizacion = $"Id: {numeroId} | " +
                                       $"Fecha: {fechaHora} | " +
                                       $"Vendedor: {codigoVendedor} | " +
                                       $"Prenda: {prendaCotizada} | " +
                                       $"Cantidad: {cantidadUnidades} | " +
                                       $"Cotización: {resultadoCalculoCotizacion}";
            return detalleCotizacion;
        }

    }
}
