using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    static class Stock
    {
        public static int StockDisponiblePantalon(bool calidadPremium, bool esChupin)
        {
            if (calidadPremium)
            {
                if (esChupin)
                {
                    return 750;
                }
                else
                {
                    return 250;
                }
            }
            else
            {
                if (esChupin)
                {
                    return 750;
                }
                else
                {
                    return 250;
                }

            }
        }

        public static int StockDisponibleCamisa(bool calidadPremium, bool mangaCorta, bool cuelloMao)
        {
            if (calidadPremium)
            {
                if (mangaCorta && cuelloMao)
                {
                    return 100;
                }
                else if (mangaCorta)
                {
                    return 150;
                }
                else if(cuelloMao)
                {
                    return 75;
                }
                else
                {
                    return 175;
                }
            }
            else
            {
                if (mangaCorta && cuelloMao)
                {
                    return 100;
                }
                else if (mangaCorta)
                {
                    return 150;
                }
                else if (cuelloMao)
                {
                    return 75;
                }
                else
                {
                    return 175;
                }
            }
        }
    }
}
