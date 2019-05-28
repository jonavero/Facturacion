namespace CapaPresentacion.Reportes
{
    partial class FrmReporteProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.spbuscarproveedorrazonsocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spbuscar_proveedor_razon_socialTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spbuscar_proveedor_razon_socialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarproveedorrazonsocialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscarproveedorrazonsocialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(947, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spbuscarproveedorrazonsocialBindingSource
            // 
            this.spbuscarproveedorrazonsocialBindingSource.DataMember = "spbuscar_proveedor_razon_social";
            this.spbuscarproveedorrazonsocialBindingSource.DataSource = this.dsPrincipal;
            // 
            // spbuscar_proveedor_razon_socialTableAdapter
            // 
            this.spbuscar_proveedor_razon_socialTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteProveedor";
            this.Text = ".:: Reporte de Proveedores ::.";
            this.Load += new System.EventHandler(this.FrmReporteProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarproveedorrazonsocialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscarproveedorrazonsocialBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spbuscar_proveedor_razon_socialTableAdapter spbuscar_proveedor_razon_socialTableAdapter;
    }
}