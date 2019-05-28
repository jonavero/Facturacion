namespace CapaPresentacion.Reportes
{
    partial class frmStockArticulo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewStockArticulosTableAdapter = new CapaPresentacion.dbventasDataSetTableAdapters.ViewStockArticulosTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.dbventasDataSetTableAdapters.TableAdapterManager();
            this.dbventasDataSet = new CapaPresentacion.dbventasDataSet();
            this.dbventasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewStockArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbventasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbventasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStockArticulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ViewStockArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(502, 338);
            this.reportViewer1.TabIndex = 1;
            // 
            // viewStockArticulosTableAdapter
            // 
            this.viewStockArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.dbventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dbventasDataSet
            // 
            this.dbventasDataSet.DataSetName = "dbventasDataSet";
            this.dbventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbventasDataSetBindingSource
            // 
            this.dbventasDataSetBindingSource.DataSource = this.dbventasDataSet;
            this.dbventasDataSetBindingSource.Position = 0;
            // 
            // ViewStockArticulosBindingSource
            // 
            this.ViewStockArticulosBindingSource.DataMember = "ViewStockArticulos";
            this.ViewStockArticulosBindingSource.DataSource = this.dbventasDataSet;
            this.ViewStockArticulosBindingSource.CurrentChanged += new System.EventHandler(this.ViewStockArticulosBindingSource_CurrentChanged);
            // 
            // frmStockArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 338);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmStockArticulo";
            this.Text = "frmStockArticulo";
            this.Load += new System.EventHandler(this.frmStockArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbventasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbventasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStockArticulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbventasDataSetBindingSource;
        private dbventasDataSet dbventasDataSet;
        private System.Windows.Forms.BindingSource ViewStockArticulosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbventasDataSetTableAdapters.ViewStockArticulosTableAdapter viewStockArticulosTableAdapter;
        private dbventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}