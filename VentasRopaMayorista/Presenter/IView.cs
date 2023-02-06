using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentadorVentasRopaMayorista
{
    public interface IView
    {
        public void ShowCalculoCotizacion(string text);
        public void ShowErrorMessage(string message);
        public void ShowAvailableStock(int stock);
        public void ShowCotizacion(string historialCotizacion);
        
    }
}
