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
    public partial class frmComprobanteIngreso : Form
    {
        private int _Idingreso;

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }
        public frmComprobanteIngreso()
        {
            InitializeComponent();
        }

        private void frmComprobanteIngreso_Load(object sender, EventArgs e)
        {

            try
            {
                this.spreporte_ingresoTableAdapter.Fill(this.dsPrincipal.spreporte_ingreso, Idingreso);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
