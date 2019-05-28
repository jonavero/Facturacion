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
    public partial class frmStockArticulo : Form
    {
        public frmStockArticulo()
        {
            InitializeComponent();
        }

        private void frmStockArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                this.viewStockArticulosTableAdapter.Fill(this.dbventasDataSet.ViewStockArticulos);


                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void ViewStockArticulosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fill1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.viewStockArticulosTableAdapter.Fill1(this.dbventasDataSet.ViewStockArticulos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
