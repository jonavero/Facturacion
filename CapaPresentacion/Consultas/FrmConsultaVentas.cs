using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Consultas
{
    public partial class FrmConsultaVentas : Form
    {
        private bool IsNuevo = false;
        public int Idtrabajador;
        private DataTable dtDetalle;

        private decimal totalPagado = 0;
        public FrmConsultaVentas()
        {
            InitializeComponent();
            this.txtIdcliente.Visible = false;
            this.txtIdarticulo.Visible = false;
            this.txtCliente.ReadOnly = true;
            this.txtIdventa.ReadOnly = true;
            this.txtSerie.ReadOnly = true;
            this.txtCorrelativo.ReadOnly = true;
            this.txtIgv.ReadOnly = true;
            this.dtFecha.Enabled = false;
            this.cbTipo_Comprobante.Enabled = false;
        }
        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NVenta.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarFechas
        private void BuscarFechas()
        {
            this.dataListado.DataSource = NVenta.BuscarFechas(this.dtFecha1.Value.ToString("MM/dd/yyyy"),
                this.dtFecha2.Value.ToString("MM/dd/yyyy"));
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NVenta.MostrarDetalle(this.txtIdventa.Text);

        }
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("iddetalle_ingreso", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Impuesto", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dataListadoDetalle.DataSource = this.dtDetalle;

        }

        private void FrmConsultaVentas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.crearTabla();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idventa"].Value);
            this.txtCliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cliente"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbTipo_Comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
            this.lblTotal_Pagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
            this.txtIgv.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Impuesto"].Value);
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value).Equals("TICKET"))
            {
                Reportes.FrmComprobanteTicket frm = new Reportes.FrmComprobanteTicket();
                frm.Idventa = Convert.ToInt32(this.dataListado.CurrentRow.Cells["idventa"].Value);
                frm.ShowDialog();
            }
            else
            {
                FrmReporteFactura frm = new FrmReporteFactura();
                frm.Idventa = Convert.ToInt32(this.dataListado.CurrentRow.Cells["idventa"].Value);
                frm.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteVentas frm = new Reportes.FrmReporteVentas();
            frm.Texto = Convert.ToString(dtFecha1.Value);
            frm.Texto2 = Convert.ToString(dtFecha2.Value);
            frm.ShowDialog();
        }
    }
}
