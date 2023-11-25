using NetWork.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetWork.Vista
{
    public partial class FormFactura : Form
    {
        private FormGestionFacturas formGestionFacturas;
        private Facturas facturas;
        string formatoFecha = "dd-MM-yyyy";




        public FormFactura(string emailUsuario, FormGestionFacturas formGestionFacturas)
        {
            InitializeComponent();
            label9.Text = emailUsuario;
            this.formGestionFacturas = formGestionFacturas;
            facturas = new Facturas();
            CargarDatos();
        }

        private void CargarDatos()
        {
            label6.Text = formGestionFacturas.factura.CodigoReservas.ToString();
            label7.Text = formGestionFacturas.factura.IdCliente;
            label2.Text = formGestionFacturas.factura.FechaFactura.ToString(formatoFecha);
            label20.Text = formGestionFacturas.factura.TotalFactura.ToString("C");
            label27.Text = formGestionFacturas.factura.CodigoServicio.ToString();


            int codigoReservasFactura = formGestionFacturas.factura.CodigoReservas;
            Reservas reservaAsociada = ObtenerInformacionReservasPorCodigo(codigoReservasFactura);
            // Verificar si se encontró la Reserva
            if (reservaAsociada != null)
            {
                // Acceder a las propiedades de reservaAsociada
                DateTime fechaEntrada = reservaAsociada.FechaEntrada;
                DateTime fechaSalida = reservaAsociada.FechaSalida;

                label13.Text = fechaEntrada.ToString(formatoFecha);
                label14.Text = fechaSalida.ToString(formatoFecha);

            }

            int codigoServiciosFactura = formGestionFacturas.factura.CodigoServicio;
            Servicios servicioAsociado = ObtenerInformacionServiciosPorCodigo(codigoServiciosFactura);
            // Verificar si se encontró la Reserva
            if (servicioAsociado != null)
            {
                // Acceder a las propiedades de reservaAsociada
                int codigoSer = servicioAsociado.CodigoServicio;
                decimal precioServicio = servicioAsociado.Precio;

                label27.Text = codigoSer.ToString();
                label28.Text = precioServicio.ToString();
                label21.Text = precioServicio.ToString();


            }

            decimal totalServicios = Convert.ToDecimal(label28.Text);

            label24.Text = (totalServicios + formGestionFacturas.factura.TotalFactura).ToString("C");
            label4.Text = (totalServicios + formGestionFacturas.factura.TotalFactura).ToString("C");


            ObtenerYMostrarCodigoTipoAlojamiento(codigoReservasFactura, label16);
            ObtenerYMostrarDescripcionTipoAlojamiento(codigoReservasFactura, label17);





        }
        public Reservas ObtenerInformacionReservasPorCodigo(int codigoReservasFactura)
        {
            using (var db = new ConexionDB())
            {
                // Obtener la información de Reservas correspondiente al CodigoReservas de la Factura
                Reservas reservaAsociada = db.Reservas
                    .AsNoTracking()
                    .FirstOrDefault(r => r.CodigoReservas == codigoReservasFactura);

                return reservaAsociada;
            }
        }

        public Servicios ObtenerInformacionServiciosPorCodigo(int codigoServiciosFactura)
        {
            using (var db = new ConexionDB())
            {
                // Obtener la información de Reservas correspondiente al CodigoReservas de la Factura
                Servicios servicioAsociado = db.Servicios
                    .AsNoTracking()
                    .FirstOrDefault(s => s.CodigoServicio == codigoServiciosFactura);

                return servicioAsociado;
            }
        }
            
        public void ObtenerYMostrarCodigoTipoAlojamiento(int codigoReservaFactura, Label labelDescripcion)
            {
                using (var db = new ConexionDB())
                {
                    // Obtener el CodigoTipoAloj de db.TipoAlojamiento
                    int? codigoTipoAlojamiento = db.Facturas
                        .Where(f => f.CodigoReservas == codigoReservaFactura)
                        .Join(
                            db.Reservas,
                            facturas => facturas.CodigoReservas,
                            reservas => reservas.CodigoReservas,
                            (facturas, reservas) => new { Facturas = facturas, Reservas = reservas }
                        )
                        .Select(facturasReservas => facturasReservas.Reservas.CodigoTipoAloj)
                        .FirstOrDefault();

                    if (codigoTipoAlojamiento.HasValue)
                    {
                    // Mostrar el valor en el Label
                    labelDescripcion.Text = codigoTipoAlojamiento.ToString();
                    }
                    else
                    {
                    // Manejar el caso en el que no se encuentra coincidencia
                    labelDescripcion.Text = "No hay CodigoTipoAlojamiento";
                    }
                }
            }

        public void ObtenerYMostrarDescripcionTipoAlojamiento(int codigoReservaFactura, Label labelDescripcion)
        {
            using (var db = new ConexionDB())
            {
                // Obtener la Descripcion de db.TipoAlojamiento
                string descripcionTipoAlojamiento = db.Facturas
                    .Where(f => f.CodigoReservas == codigoReservaFactura)
                    .Join(
                        db.Reservas,
                        facturas => facturas.CodigoReservas,
                        reservas => reservas.CodigoReservas,
                        (facturas, reservas) => new { Facturas = facturas, Reservas = reservas }
                    )
                    .Join(
                        db.TipoAlojamiento,
                        facturasReservas => facturasReservas.Reservas.CodigoTipoAloj,
                        tipoAlojamiento => tipoAlojamiento.CodigoTipoAloj,
                        (facturasReservas, tipoAlojamiento) => tipoAlojamiento.Descripcion
                    )
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(descripcionTipoAlojamiento))
                {
                    // Mostrar la descripción en el Label
                    labelDescripcion.Text = descripcionTipoAlojamiento;
                }
                else
                {
                    // Manejar el caso en el que no se encuentra coincidencia
                    labelDescripcion.Text = "No hay Descripción";
                }
            }
        }
    }
 }

