using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            this.dlistEmpresasRNC.DataSource = NEmpresasRNC.Mostrar();
        }

        private void MostrarPorRNC()
        {
            this.dlistEmpresasRNC.DataSource = NEmpresasRNC.BuscarPorRNC(txtBuscarRNC.Text);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || 
                string.IsNullOrEmpty(txtRNC.Text))
            {
                MensajeError("Falta ingresar algunos datos");
            }
            else
            {
                NEmpresasRNC.Insert(txtNombre.Text, txtRNC.Text);
                this.MensajeOk("Se Insertó de forma correcta el registro");
                txtNombre.Clear();
                txtRNC.Clear();
                Mostrar();
            }
        }

        private void txtBuscarRNC_TextChanged(object sender, EventArgs e)
        {
            MostrarPorRNC();
        }

        private void dlistEmpresasRNC_DoubleClick(object sender, EventArgs e)
        {
            FrmVenta form = FrmVenta.GetInstancia();

            int id  =  Convert.ToInt32(this.dlistEmpresasRNC.CurrentRow.Cells["ID"].Value);
            string empresa = Convert.ToString(this.dlistEmpresasRNC.CurrentRow.Cells["Empresa"].Value);
            string RNC = Convert.ToString(this.dlistEmpresasRNC.CurrentRow.Cells["RNC"].Value);
            form.setEmpresa(id, empresa, RNC);
            this.Hide();
        }
    }
}
