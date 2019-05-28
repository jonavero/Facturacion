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
    public partial class FrmReporteCategoria : Form
    {
        private String _Texto;

        public String Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public FrmReporteCategoria()
        {
            InitializeComponent();
        }

        private void FrmReporteCategoria_Load(object sender, EventArgs e)
        {

            try
            {
                this.spbuscar_categoriaTableAdapter.Fill(this.dsPrincipal.spbuscar_categoria, Texto);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
