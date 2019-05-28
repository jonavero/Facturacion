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
    public partial class FrmReporteTrabajador : Form
    {
        private String _Texto;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public FrmReporteTrabajador()
        {
            InitializeComponent();
        }

        private void FrmReporteTrabajador_Load(object sender, EventArgs e)
        {

            try
            {
                this.spbuscar_trabajador_apellidosTableAdapter.Fill(this.dsPrincipal.spbuscar_trabajador_apellidos, Texto);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
