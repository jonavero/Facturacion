using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NTrabajador.Login(this.TxtUsuario.Text, this.TxtPassword.Text);
            //Evaluar si existe el Usuario

            if (Datos == null)
            {
                MessageBox.Show("No hay acceso a la Base de Datos del Sistema, por favor verificar!!!!");
            }

            else

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Idtrabajador = Datos.Rows[0][0].ToString();
                frm.Apellidos = Datos.Rows[0][1].ToString();
                frm.Nombre = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

            }
        }

        private void BtnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataTable Datos = CapaNegocio.NTrabajador.Login(this.TxtUsuario.Text, this.TxtPassword.Text);
                //Evaluar si existe el Usuario
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmPrincipal frm = new frmPrincipal();
                    frm.Idtrabajador = Datos.Rows[0][0].ToString();
                    frm.Apellidos = Datos.Rows[0][1].ToString();
                    frm.Nombre = Datos.Rows[0][2].ToString();
                    frm.Acceso = Datos.Rows[0][3].ToString();

                    frm.Show();
                    this.Hide();

                }
            }
        }

        private void BtnSalir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }
    }
}
