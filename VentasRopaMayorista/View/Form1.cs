using ModeloVentasRopaMayorista;
using PresentadorVentasRopaMayorista;
using VentasRopaMayorista.Presenter;
using VentasRopaMayorista.View;

namespace ViewVentaRopaMayorista
{
    public partial class Form1 : Form, IView
    {
        private readonly Presentador presentador;
        private string historialDeCotizaciones;

        public Form1(String nombreTienda, string direccionTienda, string nombreVendedor, string apellidoVendedor, int idVendedor)
        {
            presentador = new Presentador(this, nombreTienda, direccionTienda, nombreVendedor, apellidoVendedor, idVendedor);
            InitializeComponent();
            labelNombreTienda.Text = nombreTienda;
            labelDireccionTienda.Text = direccionTienda;
            labelNombreApellidoVendedor.Text = $"{nombreVendedor} {apellidoVendedor} | {idVendedor}";
            RBstandard.Checked = true;
            Rbcamisa.Checked = true;
        }

        private void Rbcamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbcamisa.Checked)
            {
                CBcuelloMao.Enabled = true;
                CBmangaCorta.Enabled = true;
                CBchupin.Enabled = false;
                ShowAvailableStock(Stock.StockDisponibleCamisa(RBpremium.Checked, CBcuelloMao.Checked, CBcuelloMao.Checked)); 
            }
            else
            {
                CBcuelloMao.Enabled = false;
                CBmangaCorta.Enabled = false;
                CBchupin.Enabled = true;
                ShowAvailableStock(Stock.StockDisponiblePantalon(RBpremium.Checked, CBchupin.Checked));
            }
            CBcuelloMao.Checked = false;
            CBmangaCorta.Checked = false;
            CBchupin.Checked = false;
            
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            float precioUnitario;
            int cantidadStock;
            try
            {
                string precio = TBprecio.Text;
                precioUnitario = float.Parse(precio);
                cantidadStock = int.Parse(TBcantidad.Text);
                if (precio.LastIndexOf(".") != -1 && precio.LastIndexOf(".") > precio.LastIndexOf(','))
                {
                    ShowErrorMessage("Por favor separá centavos con una coma en vez de un punto");
                    return;
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Revisa Precio Unitario y/o cantidad de stock");
                return;
            }
            if (precioUnitario >= 0 && cantidadStock >= 0)
            {
                DecidirPrenda(precioUnitario, cantidadStock);
                presentador.Cotizar(cantidadStock);
            }
            else
            {
                ShowErrorMessage("Precio Unitario y cantidad de stock no pueden ser negativos");
            }
        }

        private void linkLabelHistorialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            presentador.MostrarHistorialCotizaciones();
            f2.RichTextBox1.Text = historialDeCotizaciones;
        }

        private void CBmangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            presentador.MostrarStockDisponible(Rbcamisa.Checked, RBpremium.Checked, CBmangaCorta.Checked,
                                               CBcuelloMao.Checked, CBchupin.Checked);
            ShowErrorMessage("");
        }

        private void RBstandard_CheckedChanged(object sender, EventArgs e)
        {
            presentador.MostrarStockDisponible(Rbcamisa.Checked, RBpremium.Checked, CBmangaCorta.Checked,
                                               CBcuelloMao.Checked, CBchupin.Checked);
            ShowErrorMessage("");
        }

        private void CBcuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            presentador.MostrarStockDisponible(Rbcamisa.Checked, RBpremium.Checked, CBmangaCorta.Checked,
                                               CBcuelloMao.Checked, CBchupin.Checked);
            ShowErrorMessage("");
        }

        private void CBchupin_CheckedChanged(object sender, EventArgs e)
        {
            presentador.MostrarStockDisponible(Rbcamisa.Checked, RBpremium.Checked, CBmangaCorta.Checked,
                                               CBcuelloMao.Checked, CBchupin.Checked);
            ShowErrorMessage("");
        }
    }
}