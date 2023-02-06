using ModeloVentasRopaMayorista;
using PresentadorVentasRopaMayorista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasRopaMayorista.Presenter
{
    class Presentador
    {
        private readonly Tienda tienda;
        private readonly Vendedor vendedor;
        private readonly IView view;
        private Prenda prendaActual;
        private bool hayStock;

        public Presentador(IView view, string nombreTienda, string direccionTienda, string nombreVendedor, string apellidoVendedor, int idVendedor)
        {
            this.view = view;
            tienda = new Tienda(nombreTienda, direccionTienda);
            vendedor = new Vendedor(nombreVendedor, apellidoVendedor, idVendedor, tienda);
        }

        public void CrearPantalon(bool calidadPremium, float precioUnitario, int cantidadStock, bool esChupin)
        {
            int stockDisponible = Stock.StockDisponiblePantalon(calidadPremium, esChupin);
            if (cantidadStock <= stockDisponible)
            {
                prendaActual = new Pantalon(calidadPremium, precioUnitario, esChupin);
                hayStock = true;
            }
            else
            {
                view.ShowErrorMessage("No Hay Stock suficiente de la prenda seleccionada");
                hayStock = false;
            }
            view.ShowAvailableStock(stockDisponible);

        }

        public void CrearCamisa(bool calidadPremium, float precioUnitario, int cantidadStock, bool mangaCorta, bool cuelloMao)
        {
            int stockDisponible = Stock.StockDisponibleCamisa(calidadPremium, mangaCorta, cuelloMao);
            if (cantidadStock <= stockDisponible)
            {
                prendaActual = new Camisa(calidadPremium, precioUnitario, mangaCorta, cuelloMao);
                hayStock = true;
            }
            else
            {
                view.ShowErrorMessage("No Hay Stock suficiente de la prenda seleccionada");
                hayStock = false;
            }
        }


        public void Cotizar(int cantidad)
        {
            if (hayStock)
            {
                string cotizacion = vendedor.CotizarPrendas(prendaActual, cantidad).ToString("c2");
                view.ShowCalculoCotizacion(cotizacion);
                vendedor.AgregarCotizacion(DateTime.Now, vendedor.CodigoVendedor, prendaActual.Nombre,
                                            cantidad, cotizacion);
            }  
        }

        public void MostrarHistorialCotizaciones()
        {
            string historialCotizaciones = "";
            foreach(Cotizacion cotizacion in vendedor.HistorialDeCotizaciones)
            {
                string detalleCotizacion = cotizacion.DetalleCotizacion();
                historialCotizaciones += detalleCotizacion + "\n";
            }
            view.ShowCotizacion(historialCotizaciones);
        }

        public void MostrarStockDisponible(bool esCamisa, bool esPremium, bool mangaCorta, bool cuelloMao, bool chupin)
        {
            int stock;
            if (esCamisa)
            {
                stock = Stock.StockDisponibleCamisa(esPremium, mangaCorta, cuelloMao);
            }
            else
            {
                stock = Stock.StockDisponiblePantalon(esPremium, chupin);
            }
            view.ShowAvailableStock(stock);
        }

    }
}
