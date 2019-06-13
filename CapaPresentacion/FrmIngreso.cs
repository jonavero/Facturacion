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

namespace CapaPresentacion
{
    public partial class FrmIngreso : Form
    {
        public int Idtrabajador;
        private bool IsNuevo;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private int idModificarArticulo = 0;
        private int idModificarDetalle = 0;

        private static FrmIngreso _instancia;

        public static FrmIngreso GetInstancia()
        {
            if(_instancia==null)
            {
                _instancia = new FrmIngreso();
            }
            return _instancia;
        }
        public void setProveedor(string idproveedor,string nombre)
        {
            this.txtIdproveedor.Text = idproveedor;
            this.txtProveedor.Text = nombre;
        }

        public void setArticulo (string idarticulo,string nombre)
        {
            this.txtIdarticulo.Text = idarticulo;
            this.txtArticulo.Text = nombre;
        }
        public FrmIngreso()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtProveedor,"Seleccione el Proveedor");
            this.ttMensaje.SetToolTip(this.txtSerie, "Ingrese la serie del comprobante");
            this.ttMensaje.SetToolTip(this.txtCorrelativo, "Ingrese el número del comprobante");
            this.ttMensaje.SetToolTip(this.txtStock, "Ingrese la cantidad de compra");
            this.ttMensaje.SetToolTip(this.txtArticulo, "Seleccione el Artículo de compra");
            this.txtIdproveedor.Visible = false;
            this.txtIdarticulo.Visible = false;
            this.txtProveedor.ReadOnly = true;
            this.txtArticulo.ReadOnly = true;

        }
        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdingreso.Text = string.Empty;
            this.txtIdproveedor.Text = string.Empty;
            this.txtProveedor.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty;
            this.txtIgv.Text = string.Empty;
            this.lblTotal_Pagado.Text = "0,0";
            this.txtIgv.Text = "18";
            this.crearTabla();
        }
        private void limpiarDetalle()
        {
            this.txtIdarticulo.Text = string.Empty;
            this.txtArticulo.Text = string.Empty;
            this.txtStock.Text = string.Empty;
            this.txtPrecio_Compra.Text = string.Empty;
            this.txtPrecio_Venta.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdingreso.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtCorrelativo.ReadOnly = !valor;
            this.txtIgv.ReadOnly = !valor;
            this.dtFecha.Enabled = valor;
            this.cbTipo_Comprobante.Enabled = valor;
            this.txtStock.ReadOnly = !valor;
            this.txtPrecio_Compra.ReadOnly = !valor;
            this.txtPrecio_Venta.ReadOnly = !valor;
            this.dtFecha_Produccion.Enabled = valor;
            this.dtFecha_Vencimiento.Enabled = valor;
            
            this.btnBuscarArticulo.Enabled = valor;
            this.btnBuscarProveedor.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo ) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

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
            this.dataListado.DataSource = NIngreso.Mostrar();
            this.dgvArticuloMod.DataSource = NIngreso.MostrarPorNombre("");
            this.dgvArticuloMod.Columns[0].Visible = false;
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarFechas
        private void BuscarFechas()
        {
            this.dataListado.DataSource = NIngreso.BuscarFechas(this.dtFecha1.Value.ToString("dd/MM/yyyy"),
                this.dtFecha2.Value.ToString("dd/MM/yyyy"));
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NIngreso.MostrarDetalle(this.txtIdingreso.Text);
            
        }
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("idarticulo",System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Impuesto", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dataListadoDetalle.DataSource = this.dtDetalle;

        }


        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();
        }

        private void FrmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor_Ingreso vista = new FrmVistaProveedor_Ingreso();
            vista.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmVistaArticulo_Ingreso vista = new FrmVistaArticulo_Ingreso();
            vista.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Rpta = "";

                    int indeceFila = dataListado.CurrentRow.Index;


                    if (indeceFila != null)
                    {
                        int idIngreso = Convert.ToInt32(dataListado.Rows[indeceFila].Cells[1].Value);

                        Rpta = NIngreso.Anular(Convert.ToInt32(idIngreso));

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Anuló Correctamente el Ingreso");
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }

                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtSerie.Focus();
            this.limpiarDetalle();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.limpiarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtIdproveedor.Text == string.Empty || this.txtSerie.Text == string.Empty
                    || this.txtCorrelativo.Text == string.Empty || this.txtIgv.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtIdproveedor, "Ingrese un Valor");
                    errorIcono.SetError(txtSerie, "Ingrese un Valor");
                    errorIcono.SetError(txtCorrelativo, "Ingrese un Valor");
                    errorIcono.SetError(txtIgv, "Ingrese un Valor");
                }
                else
                {
                    
                    if (this.IsNuevo)
                    {
                        rpta = NIngreso.Insertar(Idtrabajador, Convert.ToInt32(this.txtIdproveedor.Text),
                            dtFecha.Value,cbTipo_Comprobante.Text,txtSerie.Text,txtCorrelativo.Text,
                            Convert.ToDecimal(txtIgv.Text),"EMITIDO",dtDetalle);

                    }
                    

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        
                        
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();


                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.txtIdarticulo.Text == string.Empty || this.txtStock.Text == string.Empty
                    || this.txtPrecio_Compra.Text == string.Empty || this.txtPrecio_Venta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtIdarticulo, "Ingrese un Valor");
                    errorIcono.SetError(txtStock, "Ingrese un Valor");
                    errorIcono.SetError(txtPrecio_Compra, "Ingrese un Valor");
                    errorIcono.SetError(txtPrecio_Venta, "Ingrese un Valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["idarticulo"])==Convert.ToInt32(this.txtIdarticulo.Text))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra el artículo en el detalle");
                        }
                    }
                    if (registrar)
                    {

                        int ITBIS = rbSi.Checked ? 18 : 0;

                        decimal subTotal=Convert.ToDecimal(this.txtStock.Text)*Convert.ToDecimal(this.txtPrecio_Compra.Text);
                        totalPagado = totalPagado + subTotal;
                        this.lblTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["idarticulo"] = Convert.ToInt32(this.txtIdarticulo.Text);
                        row["articulo"] = this.txtArticulo.Text;
                        row["precio_compra"] = Convert.ToDecimal(this.txtPrecio_Compra.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPrecio_Venta.Text);
                        row["stock_inicial"] = Convert.ToInt32(this.txtStock.Text);
                        row["fecha_produccion"] = dtFecha_Produccion.Value;
                        row["fecha_vencimiento"] = dtFecha_Vencimiento.Value;
                        row["subtotal"] = subTotal;
                        row["impuesto"] = ITBIS;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();

                    }

                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuir el totalPAgado
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["subtotal"].ToString());
                this.lblTotal_Pagado.Text=totalPagado.ToString("#0.00#");
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdingreso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idingreso"].Value);
            this.txtProveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["proveedor"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbTipo_Comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
            this.lblTotal_Pagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
            this.txtIgv.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Impuesto"].Value);
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteCompras frm = new Reportes.FrmReporteCompras();
            frm.Texto = Convert.ToString(dtFecha1.Value);
            frm.Texto2 = Convert.ToString(dtFecha2.Value);
            frm.ShowDialog();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            Reportes.frmComprobanteIngreso frm = new Reportes.frmComprobanteIngreso();
            frm.Idingreso = Convert.ToInt32(this.dataListado.CurrentRow.Cells["idingreso"].Value);
            frm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataListadoDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarArticula_TextChanged(object sender, EventArgs e)
        {

            this.dgvArticuloMod.DataSource = NIngreso.MostrarPorNombre(this.txtBuscarArticula.Text.Trim());

        }

        private void LimpiarModificarArticulo()
        {
            this.idModificarArticulo = 0;
            this.txtNombreMod.Text = "";
            this.txtPrCompMod.Text = "";
            this.txtPrVentMod.Text = "";
            this.txtStockMod.Text = "";
            this.dtpFechaProdMod.Value = DateTime.Now;
            this.dtpFechaVencMod.Value = DateTime.Now;
            this.idModificarDetalle = 0;
            this.btnEditar.Enabled = false;
        }
        private void dgvArticuloMod_DoubleClick(object sender, EventArgs e)
        {
            this.idModificarArticulo = Convert.ToInt32(this.dgvArticuloMod.CurrentRow.Cells["idarticulo"].Value);
            this.txtNombreMod.Text = Convert.ToString(this.dgvArticuloMod.CurrentRow.Cells["Articulo"].Value);
            this.txtPrCompMod.Text = Convert.ToString(this.dgvArticuloMod.CurrentRow.Cells["precio_compra"].Value);
            this.txtPrVentMod.Text = Convert.ToString(this.dgvArticuloMod.CurrentRow.Cells["precio_venta"].Value);
            this.dtpFechaProdMod.Value = Convert.ToDateTime(this.dgvArticuloMod.CurrentRow.Cells["fecha_produccion"].Value);
            this.dtpFechaVencMod.Value = Convert.ToDateTime(this.dgvArticuloMod.CurrentRow.Cells["fecha_vencimiento"].Value);
            this.txtStockMod.Text = Convert.ToString(this.dgvArticuloMod.CurrentRow.Cells["stock_inicial"].Value);
            this.idModificarDetalle = Convert.ToInt32(this.dgvArticuloMod.CurrentRow.Cells["iddetalle_ingreso"].Value);
            this.btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreMod.Text == string.Empty || this.txtPrCompMod.Text == string.Empty
                   || this.txtPrVentMod.Text == string.Empty || this.txtStockMod.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos");
 
            }
            else
            {
                try
                {

                    int itbis = rbSiItbisMod.Checked ? 18 : 0;
                    string message = NIngreso.ModificarDetalle(idModificarDetalle, idModificarArticulo,
                        txtNombreMod.Text, Convert.ToDecimal(txtPrCompMod.Text), 
                        Convert.ToDecimal(txtPrVentMod.Text), Convert.ToInt32(txtStockMod.Text),
                        Convert.ToDateTime(dtpFechaProdMod.Value),Convert.ToDateTime(dtpFechaVencMod.Value), itbis);
                    LimpiarModificarArticulo();

                    MensajeOk(message);
                    this.dgvArticuloMod.DataSource = NIngreso.MostrarPorNombre(this.txtBuscarArticula.Text.Trim());
                }
                catch (Exception)
                {

                    MensajeError("Existen datos que no son validos");
                }
                
            }
            
        }

        private void btnAnularMod_Click(object sender, EventArgs e)
        {
            LimpiarModificarArticulo();
        }
    }
}
