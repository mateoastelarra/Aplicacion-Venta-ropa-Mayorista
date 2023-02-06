using ModeloVentasRopaMayorista;
using PresentadorVentasRopaMayorista;
using VentasRopaMayorista.Presenter;
using VentasRopaMayorista.View;

namespace ViewVentaRopaMayorista

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoPrenda = new System.Windows.Forms.GroupBox();
            this.CBchupin = new System.Windows.Forms.CheckBox();
            this.CBcuelloMao = new System.Windows.Forms.CheckBox();
            this.CBmangaCorta = new System.Windows.Forms.CheckBox();
            this.RBpantalon = new System.Windows.Forms.RadioButton();
            this.Rbcamisa = new System.Windows.Forms.RadioButton();
            this.tituloApp = new System.Windows.Forms.Label();
            this.GBcalidad = new System.Windows.Forms.GroupBox();
            this.RBpremium = new System.Windows.Forms.RadioButton();
            this.RBstandard = new System.Windows.Forms.RadioButton();
            this.GBprecioyCantidad = new System.Windows.Forms.GroupBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelSignoPlata = new System.Windows.Forms.Label();
            this.TBcantidad = new System.Windows.Forms.TextBox();
            this.TBprecio = new System.Windows.Forms.TextBox();
            this.labelNombreTienda = new System.Windows.Forms.Label();
            this.labelDireccionTienda = new System.Windows.Forms.Label();
            this.labelNombreApellidoVendedor = new System.Windows.Forms.Label();
            this.linkLabelHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.labelStockDisponible = new System.Windows.Forms.Label();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.infoPrenda.SuspendLayout();
            this.GBcalidad.SuspendLayout();
            this.GBprecioyCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPrenda
            // 
            this.infoPrenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPrenda.Controls.Add(this.CBchupin);
            this.infoPrenda.Controls.Add(this.CBcuelloMao);
            this.infoPrenda.Controls.Add(this.CBmangaCorta);
            this.infoPrenda.Controls.Add(this.RBpantalon);
            this.infoPrenda.Controls.Add(this.Rbcamisa);
            this.infoPrenda.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoPrenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.infoPrenda.Location = new System.Drawing.Point(12, 171);
            this.infoPrenda.Name = "infoPrenda";
            this.infoPrenda.Padding = new System.Windows.Forms.Padding(10);
            this.infoPrenda.Size = new System.Drawing.Size(680, 100);
            this.infoPrenda.TabIndex = 0;
            this.infoPrenda.TabStop = false;
            this.infoPrenda.Text = "Prenda";
            // 
            // CBchupin
            // 
            this.CBchupin.AutoSize = true;
            this.CBchupin.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBchupin.ForeColor = System.Drawing.Color.Black;
            this.CBchupin.Location = new System.Drawing.Point(244, 64);
            this.CBchupin.Name = "CBchupin";
            this.CBchupin.Size = new System.Drawing.Size(80, 22);
            this.CBchupin.TabIndex = 4;
            this.CBchupin.Text = "Chupín";
            this.CBchupin.UseVisualStyleBackColor = true;
            this.CBchupin.CheckedChanged += new System.EventHandler(this.CBchupin_CheckedChanged);
            // 
            // CBcuelloMao
            // 
            this.CBcuelloMao.AutoSize = true;
            this.CBcuelloMao.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBcuelloMao.ForeColor = System.Drawing.Color.Black;
            this.CBcuelloMao.Location = new System.Drawing.Point(487, 36);
            this.CBcuelloMao.Name = "CBcuelloMao";
            this.CBcuelloMao.Size = new System.Drawing.Size(112, 22);
            this.CBcuelloMao.TabIndex = 3;
            this.CBcuelloMao.Text = "Cuello Mao";
            this.CBcuelloMao.UseVisualStyleBackColor = true;
            this.CBcuelloMao.CheckedChanged += new System.EventHandler(this.CBcuelloMao_CheckedChanged);
            // 
            // CBmangaCorta
            // 
            this.CBmangaCorta.AutoSize = true;
            this.CBmangaCorta.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBmangaCorta.ForeColor = System.Drawing.Color.Black;
            this.CBmangaCorta.Location = new System.Drawing.Point(244, 36);
            this.CBmangaCorta.Name = "CBmangaCorta";
            this.CBmangaCorta.Size = new System.Drawing.Size(121, 22);
            this.CBmangaCorta.TabIndex = 2;
            this.CBmangaCorta.Text = "Manga Corta";
            this.CBmangaCorta.UseVisualStyleBackColor = true;
            this.CBmangaCorta.CheckedChanged += new System.EventHandler(this.CBmangaCorta_CheckedChanged);
            // 
            // RBpantalon
            // 
            this.RBpantalon.AutoSize = true;
            this.RBpantalon.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBpantalon.ForeColor = System.Drawing.Color.Black;
            this.RBpantalon.Location = new System.Drawing.Point(13, 64);
            this.RBpantalon.Name = "RBpantalon";
            this.RBpantalon.Size = new System.Drawing.Size(89, 22);
            this.RBpantalon.TabIndex = 1;
            this.RBpantalon.TabStop = true;
            this.RBpantalon.Text = "Pantalón";
            this.RBpantalon.UseVisualStyleBackColor = true;
            // 
            // Rbcamisa
            // 
            this.Rbcamisa.AutoSize = true;
            this.Rbcamisa.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rbcamisa.ForeColor = System.Drawing.Color.Black;
            this.Rbcamisa.Location = new System.Drawing.Point(13, 36);
            this.Rbcamisa.Name = "Rbcamisa";
            this.Rbcamisa.Size = new System.Drawing.Size(80, 22);
            this.Rbcamisa.TabIndex = 0;
            this.Rbcamisa.TabStop = true;
            this.Rbcamisa.Text = "Camisa";
            this.Rbcamisa.UseVisualStyleBackColor = true;
            this.Rbcamisa.CheckedChanged += new System.EventHandler(this.Rbcamisa_CheckedChanged);
            // 
            // tituloApp
            // 
            this.tituloApp.AutoSize = true;
            this.tituloApp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tituloApp.Font = new System.Drawing.Font("Stencil", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloApp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tituloApp.Location = new System.Drawing.Point(12, 9);
            this.tituloApp.Name = "tituloApp";
            this.tituloApp.Size = new System.Drawing.Size(680, 86);
            this.tituloApp.TabIndex = 1;
            this.tituloApp.Text = "Venta Mayorista";
            // 
            // GBcalidad
            // 
            this.GBcalidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GBcalidad.Controls.Add(this.RBpremium);
            this.GBcalidad.Controls.Add(this.RBstandard);
            this.GBcalidad.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBcalidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GBcalidad.Location = new System.Drawing.Point(12, 313);
            this.GBcalidad.Name = "GBcalidad";
            this.GBcalidad.Padding = new System.Windows.Forms.Padding(10);
            this.GBcalidad.Size = new System.Drawing.Size(323, 64);
            this.GBcalidad.TabIndex = 5;
            this.GBcalidad.TabStop = false;
            this.GBcalidad.Text = "Calidad";
            // 
            // RBpremium
            // 
            this.RBpremium.AutoSize = true;
            this.RBpremium.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBpremium.ForeColor = System.Drawing.Color.Black;
            this.RBpremium.Location = new System.Drawing.Point(194, 25);
            this.RBpremium.Name = "RBpremium";
            this.RBpremium.Size = new System.Drawing.Size(93, 22);
            this.RBpremium.TabIndex = 1;
            this.RBpremium.Text = "Premium";
            this.RBpremium.UseVisualStyleBackColor = true;
            // 
            // RBstandard
            // 
            this.RBstandard.AutoSize = true;
            this.RBstandard.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBstandard.ForeColor = System.Drawing.Color.Black;
            this.RBstandard.Location = new System.Drawing.Point(13, 25);
            this.RBstandard.Name = "RBstandard";
            this.RBstandard.Size = new System.Drawing.Size(90, 22);
            this.RBstandard.TabIndex = 0;
            this.RBstandard.Text = "Standard";
            this.RBstandard.UseVisualStyleBackColor = true;
            this.RBstandard.CheckedChanged += new System.EventHandler(this.RBstandard_CheckedChanged);
            // 
            // GBprecioyCantidad
            // 
            this.GBprecioyCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GBprecioyCantidad.Controls.Add(this.labelCantidad);
            this.GBprecioyCantidad.Controls.Add(this.labelSignoPlata);
            this.GBprecioyCantidad.Controls.Add(this.TBcantidad);
            this.GBprecioyCantidad.Controls.Add(this.TBprecio);
            this.GBprecioyCantidad.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBprecioyCantidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GBprecioyCantidad.Location = new System.Drawing.Point(369, 313);
            this.GBprecioyCantidad.Name = "GBprecioyCantidad";
            this.GBprecioyCantidad.Padding = new System.Windows.Forms.Padding(10);
            this.GBprecioyCantidad.Size = new System.Drawing.Size(323, 64);
            this.GBprecioyCantidad.TabIndex = 6;
            this.GBprecioyCantidad.TabStop = false;
            this.GBprecioyCantidad.Text = "Precio Unitario y Cantidad";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCantidad.ForeColor = System.Drawing.Color.Black;
            this.labelCantidad.Location = new System.Drawing.Point(126, 31);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(73, 18);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelSignoPlata
            // 
            this.labelSignoPlata.AutoSize = true;
            this.labelSignoPlata.BackColor = System.Drawing.Color.Transparent;
            this.labelSignoPlata.ForeColor = System.Drawing.Color.Black;
            this.labelSignoPlata.Location = new System.Drawing.Point(13, 28);
            this.labelSignoPlata.Name = "labelSignoPlata";
            this.labelSignoPlata.Size = new System.Drawing.Size(21, 22);
            this.labelSignoPlata.TabIndex = 2;
            this.labelSignoPlata.Text = "$";
            // 
            // TBcantidad
            // 
            this.TBcantidad.Location = new System.Drawing.Point(205, 25);
            this.TBcantidad.Name = "TBcantidad";
            this.TBcantidad.Size = new System.Drawing.Size(89, 30);
            this.TBcantidad.TabIndex = 1;
            // 
            // TBprecio
            // 
            this.TBprecio.Location = new System.Drawing.Point(36, 25);
            this.TBprecio.Name = "TBprecio";
            this.TBprecio.Size = new System.Drawing.Size(78, 30);
            this.TBprecio.TabIndex = 0;
            // 
            // labelNombreTienda
            // 
            this.labelNombreTienda.AutoSize = true;
            this.labelNombreTienda.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombreTienda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNombreTienda.Location = new System.Drawing.Point(18, 105);
            this.labelNombreTienda.Name = "labelNombreTienda";
            this.labelNombreTienda.Size = new System.Drawing.Size(164, 18);
            this.labelNombreTienda.TabIndex = 7;
            this.labelNombreTienda.Text = "Nombre de la Tienda";
            // 
            // labelDireccionTienda
            // 
            this.labelDireccionTienda.AutoSize = true;
            this.labelDireccionTienda.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDireccionTienda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDireccionTienda.Location = new System.Drawing.Point(484, 105);
            this.labelDireccionTienda.Name = "labelDireccionTienda";
            this.labelDireccionTienda.Size = new System.Drawing.Size(184, 18);
            this.labelDireccionTienda.TabIndex = 8;
            this.labelDireccionTienda.Text = "Direacción de la Tienda";
            // 
            // labelNombreApellidoVendedor
            // 
            this.labelNombreApellidoVendedor.AutoSize = true;
            this.labelNombreApellidoVendedor.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombreApellidoVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNombreApellidoVendedor.Location = new System.Drawing.Point(18, 139);
            this.labelNombreApellidoVendedor.Name = "labelNombreApellidoVendedor";
            this.labelNombreApellidoVendedor.Size = new System.Drawing.Size(290, 18);
            this.labelNombreApellidoVendedor.TabIndex = 9;
            this.labelNombreApellidoVendedor.Text = "Nombre y Apellido del Vendedor | ID";
            // 
            // linkLabelHistorialCotizaciones
            // 
            this.linkLabelHistorialCotizaciones.AutoSize = true;
            this.linkLabelHistorialCotizaciones.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelHistorialCotizaciones.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelHistorialCotizaciones.Location = new System.Drawing.Point(486, 139);
            this.linkLabelHistorialCotizaciones.Name = "linkLabelHistorialCotizaciones";
            this.linkLabelHistorialCotizaciones.Size = new System.Drawing.Size(192, 18);
            this.linkLabelHistorialCotizaciones.TabIndex = 10;
            this.linkLabelHistorialCotizaciones.TabStop = true;
            this.linkLabelHistorialCotizaciones.Text = "Historial de Cotizaciones";
            this.linkLabelHistorialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistorialCotizaciones_LinkClicked);
            // 
            // labelStockDisponible
            // 
            this.labelStockDisponible.AutoSize = true;
            this.labelStockDisponible.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStockDisponible.ForeColor = System.Drawing.Color.Black;
            this.labelStockDisponible.Location = new System.Drawing.Point(18, 283);
            this.labelStockDisponible.Name = "labelStockDisponible";
            this.labelStockDisponible.Size = new System.Drawing.Size(239, 18);
            this.labelStockDisponible.TabIndex = 11;
            this.labelStockDisponible.Text = "Unidades de Stock Dsiponibles:";
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCotizar.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCotizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCotizar.Location = new System.Drawing.Point(69, 383);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(188, 55);
            this.buttonCotizar.TabIndex = 12;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = false;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCotizacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCotizacion.Location = new System.Drawing.Point(405, 394);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(0, 31);
            this.labelCotizacion.TabIndex = 13;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(90, 441);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 22);
            this.labelErrorMessage.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 489);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.labelCotizacion);
            this.Controls.Add(this.buttonCotizar);
            this.Controls.Add(this.labelStockDisponible);
            this.Controls.Add(this.linkLabelHistorialCotizaciones);
            this.Controls.Add(this.labelNombreApellidoVendedor);
            this.Controls.Add(this.labelDireccionTienda);
            this.Controls.Add(this.labelNombreTienda);
            this.Controls.Add(this.GBprecioyCantidad);
            this.Controls.Add(this.GBcalidad);
            this.Controls.Add(this.tituloApp);
            this.Controls.Add(this.infoPrenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.infoPrenda.ResumeLayout(false);
            this.infoPrenda.PerformLayout();
            this.GBcalidad.ResumeLayout(false);
            this.GBcalidad.PerformLayout();
            this.GBprecioyCantidad.ResumeLayout(false);
            this.GBprecioyCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox infoPrenda;
        private Label tituloApp;
        private RadioButton RBpantalon;
        private RadioButton Rbcamisa;
        private CheckBox CBcuelloMao;
        private CheckBox CBmangaCorta;
        private CheckBox CBchupin;
        private GroupBox GBcalidad;
        private RadioButton RBpremium;
        private RadioButton RBstandard;
        private GroupBox GBprecioyCantidad;
        private Label labelCantidad;
        private Label labelSignoPlata;
        private TextBox TBcantidad;
        private TextBox TBprecio;
        private Label labelNombreTienda;
        private Label labelDireccionTienda;
        private Label labelNombreApellidoVendedor;
        private LinkLabel linkLabelHistorialCotizaciones;
        private Label labelStockDisponible;
        private Button buttonCotizar;
        private Label labelCotizacion;
        private Label labelErrorMessage;

        public void ShowCalculoCotizacion(string text)
        {
            labelCotizacion.Text = $"{text}";
            labelErrorMessage.Text = "";
        }

        public void ShowErrorMessage(string message)
        {
            labelErrorMessage.Text = message;
            labelCotizacion.Text = "";
        }

        public void ShowAvailableStock(int stock)
        {
            labelStockDisponible.Text = $"Unidades de Stock Disponibles: {stock}";
        }

        public void ShowCotizacion(string historialCotizacion)
        {
            historialDeCotizaciones = historialCotizacion;
        }

        private void DecidirPrenda(float precioUnitario, int cantidadStock)
        {
            if (RBpantalon.Checked)
            {
                presentador.CrearPantalon(RBpremium.Checked, precioUnitario, cantidadStock, CBchupin.Checked);
            }
            else if (Rbcamisa.Checked)
            {
                presentador.CrearCamisa(RBpremium.Checked, precioUnitario, cantidadStock, CBmangaCorta.Checked, CBcuelloMao.Checked);
            }
        }
    }
}