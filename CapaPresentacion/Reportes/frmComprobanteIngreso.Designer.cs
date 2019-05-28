namespace CapaPresentacion.Reportes
{
    partial class frmComprobanteIngreso
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
            this.spreporteingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_ingresoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spreporte_ingresoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteingresoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporteingresoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptComprobanteIngreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(954, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporteingresoBindingSource
            // 
            this.spreporteingresoBindingSource.DataMember = "spreporte_ingreso";
            this.spreporteingresoBindingSource.DataSource = this.dsPrincipal;
            // 
            // spreporte_ingresoTableAdapter
            // 
            this.spreporte_ingresoTableAdapter.ClearBeforeFill = true;
            // 
            // frmComprobanteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 484);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmComprobanteIngreso";
            this.Text = ".: Comprobante Ingreso :.";
            this.Load += new System.EventHandler(this.frmComprobanteIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporteingresoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporteingresoBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spreporte_ingresoTableAdapter spreporte_ingresoTableAdapter;
    }
}