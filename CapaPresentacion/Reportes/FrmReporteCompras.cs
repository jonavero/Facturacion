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
    public partial class FrmReporteCompras : Form
    {
        private String _Texto;
        private String _Texto2;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public String Texto2
        {
            get { return _Texto2; }
            set { _Texto2 = value; }
        }

        public FrmReporteCompras()
        {
            InitializeComponent();
        }

        private void FrmReporteCompras_Load(object sender, EventArgs e)
        {

            try
            {
                this.spbuscar_ingreso_fechaTableAdapter.Fill(this.dsPrincipal.spbuscar_ingreso_fecha, Texto,Texto2);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
