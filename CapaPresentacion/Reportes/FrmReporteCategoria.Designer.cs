namespace CapaPresentacion.Reportes
{
    partial class FrmReporteCategoria
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
            this.spbuscarcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spbuscar_categoriaTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.spbuscar_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscarcategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptCategoria.rdlc";
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
            // spbuscarcategoriaBindingSource
            // 
            this.spbuscarcategoriaBindingSource.DataMember = "spbuscar_categoria";
            this.spbuscarcategoriaBindingSource.DataSource = this.dsPrincipal;
            // 
            // spbuscar_categoriaTableAdapter
            // 
            this.spbuscar_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCategoria";
            this.Text = ".:: Reporte de Categorías ::.";
            this.Load += new System.EventHandler(this.FrmReporteCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscarcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscarcategoriaBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spbuscar_categoriaTableAdapter spbuscar_categoriaTableAdapter;


    }
}