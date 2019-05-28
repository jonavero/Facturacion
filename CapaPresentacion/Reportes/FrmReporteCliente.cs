using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReporteCliente : Form
    {
        private String _Texto;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {

            try
            {
                this.spbuscar_cliente_apellidosTableAdapter.Fill(this.dsPrincipal.spbuscar_cliente_apellidos, Texto);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
