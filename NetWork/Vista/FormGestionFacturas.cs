using NetWork.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetWork.Vista
{
    public partial class FormGestionFacturas : Form
    {
        public FormGestionFacturas(string emailUsuario)
        {
            InitializeComponent();
            EmailUsuario.Text = emailUsuario;
            cargarForm();
        }

        ConexionDB db;
        public Facturas factura = new Facturas();
        public Reservas reserva = new Reservas();


        public List<Facturas> Read()
        {
            try
            {
                using (db = new ConexionDB())
                {
                    return db.Facturas.ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

     /*   public void Delete(int numFactura)
        {
            {
                try

                {
                    using (db = new ConexionDB())
                    {
                        db.Facturas.Remove(db.Facturas.Single(Facturas => Facturas.NumFactura == numFactura));
                        db.SaveChanges();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }*/

        private void cargarDatos()
        {
            factura.NumFactura = Convert.ToInt32(textboxNumeroFactura.Text);
            factura.CodigoReservas = Convert.ToInt32(textBoxCodigoReservas1.Text);
            factura.CodigoServicio = Convert.ToInt32(textBoxCodigoServicio.Text);
            factura.IdCliente = textBoxIdCliente.Text;
            factura.TotalFactura = Convert.ToDecimal(textBoxTotalFactura.Text);
            factura.FechaFactura = Convert.ToDateTime(dateTimePickerFechaFactura.Text);



        }

        private void cargarGrid()
        {
            var Lst = Read();
            dgvGestionFacturas.DataSource = Lst;
        }

        private void cargarForm()
        {
            cargarGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal registroForm = new MenuPrincipal(EmailUsuario.Text);

            registroForm.Show();

            this.Close();
        }
        private void limpiarDatos()
        {
            textboxNumeroFactura.Text = string.Empty;
            textBoxCodigoReservas1.Text = string.Empty;
            textBoxCodigoServicio.Text = string.Empty;
            dateTimePickerFechaFactura.Text = string.Empty;
            textBoxIdCliente.Text = string.Empty;
            textBoxTotalFactura.Text = string.Empty;
            cargarGrid();
        }

        
        private void genFactura_Click(object sender, EventArgs e)
        {
            {
                // Abre el segundo formulario y transfiere el valor
                FormFactura factura = new FormFactura(EmailUsuario.Text, this);
                factura.Show();
            }
        }

        private void dgvGestionFacturas_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codigoFactura;
            {
                
                    codigoFactura = (int)dgvGestionFacturas.CurrentRow.Cells["NumFactura"].Value;
                    textboxNumeroFactura.Text = dgvGestionFacturas.CurrentRow.Cells["NumFactura"].Value.ToString();
                    textBoxIdCliente.Text = dgvGestionFacturas.CurrentRow.Cells["IdCliente"].Value.ToString();
                    textBoxCodigoReservas1.Text = dgvGestionFacturas.CurrentRow.Cells["CodigoReservas"].Value.ToString(); ;
                    textBoxCodigoServicio.Text = dgvGestionFacturas.CurrentRow.Cells["CodigoServicio"].Value.ToString();
                    dateTimePickerFechaFactura.Text = dgvGestionFacturas.CurrentRow.Cells["FechaFactura"].Value.ToString();
                    textBoxTotalFactura.Text = dgvGestionFacturas.CurrentRow.Cells["TotalFactura"].Value.ToString();
                    cargarDatos();
                
            }
        }

        //Las siguientes funciones sirven para almacenar datos y emplearlos después en factura
        public string valorTextBoxIdCliente
        {
            get { return textBoxIdCliente.Text; }
        }


    }
}
