using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    class Pantalon: Prenda
    {
        bool esChupin;

        public Pantalon(bool calidadPremium, float precioUnitario, bool esChupin)
        {
            this.calidadPremium = calidadPremium;
            this.precioUnitario = precioUnitario;
            this.esChupin=esChupin;
            cantidadStock = Stock.StockDisponiblePantalon(calidadPremium, esChupin);
            Nombre = PonerNombre();
        }

        public bool EsChupin { get => esChupin;}

        public override float CalcularPrecio(float precio)
        {
            precio = PrecioUnitario;
            if (esChupin)
            {
                precio *= 0.88f;
            }
            return base.CalcularPrecio(precio);
        }

        public override string PonerNombre()
        {
            if (calidadPremium && esChupin)
            {
                return "Pantalón Premium Chupín";
            }
            else if (esChupin)
            {
                return "Pantalón Estandár Chupín";
            }
            else if (calidadPremium)
            {
                return "Pantalón Estándar Común";
            }
            else
            {
                return "Pantalón Premium Común";
            }
        }
    }
}
