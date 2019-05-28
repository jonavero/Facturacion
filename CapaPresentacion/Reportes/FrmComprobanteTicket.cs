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
    public partial class FrmComprobanteTicket : Form
    {
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
        public FrmComprobanteTicket()
        {
            InitializeComponent();
        }

        private void FrmComprobanteTicket_Load(object sender, EventArgs e)
        {

            try
            {
                this.spreporte_facturaTableAdapter.Fill(this.dsPrincipal.spreporte_factura, Idventa);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
