using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVentasRopaMayorista
{
    class Camisa: Prenda
    {
        bool mangaCorta;
        bool cuelloMao;

        public Camisa(bool calidadPremium, float precioUnitario, bool mangaCorta, bool cuelloMao)
        {
            this.calidadPremium = calidadPremium;
            this.precioUnitario = precioUnitario;
            this.mangaCorta = mangaCorta;
            this.cuelloMao = cuelloMao;
            cantidadStock = Stock.StockDisponibleCamisa(calidadPremium, mangaCorta, CuelloMao);
            Nombre = PonerNombre();
        }

        public bool MangaCorta { get => mangaCorta;}
        public bool CuelloMao { get => cuelloMao; }

        public override float CalcularPrecio(float precio)
        {
            precio = PrecioUnitario;
            if (mangaCorta)
            {
                precio *= 0.9f;
            }
            if (cuelloMao)
            {
                precio *= 1.03f;
            }
            return base.CalcularPrecio(precio);
        }

        public override string PonerNombre()
        {
            if (calidadPremium)
            {
                if (mangaCorta && cuelloMao)
                {
                    return "Camisa Manga Corta Cuello Mao Premium";
                }
                else if (mangaCorta)
                {
                    return "Camisa Manga Corta Cuello Común Premium";
                }
                else if (cuelloMao)
                {
                    return "Camisa Manga Larga Cuello Mao Premium";
                }
                else
                {
                    return "Camisa Manga Larga Cuello Común Premium";
                }
            }
            else
            {
                if (mangaCorta && cuelloMao)
                {
                    return "Camisa Manga Corta Cuello Mao Estándar";
                }
                else if (mangaCorta)
                {
                    return "Camisa Manga Corta Cuello Común Estándar";
                }
                else if (cuelloMao)
                {
                    return "Camisa Manga Larga Cuello Mao Estándar";
                }
                else
                {
                    return "Camisa Manga Larga Cuello Común Estándar";
                }
            }
        }
    }
}
