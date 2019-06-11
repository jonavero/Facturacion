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
    public partial class FrmDevueltaFactura : Form
    {
        private decimal _Monto = 0;
        private decimal _TotalPagar = 0;

        public FrmDevueltaFactura()
        {
            InitializeComponent();
        }

        public void establecerTotal(decimal totalPagar)
        {
            _TotalPagar = totalPagar;
            txtTotalPagar.Text = _TotalPagar.ToString("#0.00#");
        }

        public void RealizarCalcDevuelta()
        {
            try
            {
                _Monto = Convert.ToDecimal(txtMonto.Text);
                decimal resta = _Monto - _TotalPagar;
                if (resta < 0)
                {
                    resta = 0;
                }

                
                lbDevuelta.Text = resta.ToString("#0.00#");
                if (lbDevuelta.Text == "0,00" && _Monto<_TotalPagar)
                {
                    btnCobrar.Enabled = false;
                }
                else { 
                btnCobrar.Enabled = true;
                }
            }
            catch 
            {
                MessageBox.Show("Este campo solo permite números");
                _Monto = 0;
                txtMonto.Text = "";
                btnCobrar.Enabled = false;

            }

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            RealizarCalcDevuelta();

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            FrmVenta venta = FrmVenta.GetInstancia();
            venta.setMonto(_Monto);
            this.Hide();

        }

        private void FrmDevueltaFactura_Load(object sender, EventArgs e)
        {
            btnCobrar.Enabled = false;
        }
    }
}
