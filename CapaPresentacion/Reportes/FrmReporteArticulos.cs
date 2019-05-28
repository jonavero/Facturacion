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
    public partial class FrmReporteArticulos : Form
    {
        private String _Texto;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        public FrmReporteArticulos()
        {
            InitializeComponent();
        }

        private void FrmReporteArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                this.spbuscar_articulo_nombreTableAdapter.Fill(this.dsPrincipal.spbuscar_articulo_nombre,Texto);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
                       
        }
    }
}
