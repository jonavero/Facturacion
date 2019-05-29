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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public string Idtrabajador = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";

        public frmPrincipal()
        {
            InitializeComponent();
            lbhoraPrincipal.Text = DateTime.Now.ToString();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frm = frmArticulo.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajador frm = new frmTrabajador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }

        private void GestionUsuario()
        {
            //COntrolar los accesos
            if (Acceso=="Administrador")
            {
                this.MnuAlmacen.Enabled = true;
                this.MnuCompras.Enabled = true;
                this.MnuVentas.Enabled = true;
                this.MnuMantenimiento.Enabled = true;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = true;
                this.TsVentas.Enabled = true;

            }
            else if (Acceso == "Vendedor")
            {
                this.MnuAlmacen.Enabled = false;
                this.MnuCompras.Enabled = false;
                this.MnuVentas.Enabled = true;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = false;
                this.TsVentas.Enabled = true;

            }
            else if (Acceso == "Almacenero")
            {
                this.MnuAlmacen.Enabled = true;
                this.MnuCompras.Enabled = true;
                this.MnuVentas.Enabled = false;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = true;
                this.MnuHerramientas.Enabled = true;
                this.TsCompras.Enabled = true;
                this.TsVentas.Enabled = false;

            }
            else
            {
                this.MnuAlmacen.Enabled = false;
                this.MnuCompras.Enabled = false;
                this.MnuVentas.Enabled = false;
                this.MnuMantenimiento.Enabled = false;
                this.MnuConsultas.Enabled = false;
                this.MnuHerramientas.Enabled = false;
                this.TsCompras.Enabled = false;
                this.TsVentas.Enabled = false;

            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = FrmIngreso.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta frm = FrmVenta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);

        }

        private void stockDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsulta_Stock_Articulos frm = new Consultas.FrmConsulta_Stock_Articulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void comprasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaCompras frm = new Consultas.FrmConsultaCompras();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
        }

        private void ventasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaVentas frm = new Consultas.FrmConsultaVentas();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
        }

        private void TsCompras_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = FrmIngreso.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
        }

        private void TsVentas_Click(object sender, EventArgs e)
        {
            FrmVenta frm = FrmVenta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhoraPrincipal.Text = DateTime.Now.ToString();

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lbhoraPrincipal.Text = DateTime.Now.ToString();

        }

        private void empresasRNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresas frm = new FrmEmpresas();
            frm.Show();
        }
    }
}
