namespace CapaPresentacion
{
    partial class FrmEmpresas
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlistEmpresasRNC = new System.Windows.Forms.DataGridView();
            this.txtBuscarRNC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistEmpresasRNC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de empresas ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarEmpresa);
            this.groupBox1.Controls.Add(this.txtRNC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarEmpresa.Image = global::CapaPresentacion.Properties.Resources.disco;
            this.btnGuardarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(472, 29);
            this.btnGuardarEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(89, 27);
            this.btnGuardarEmpresa.TabIndex = 8;
            this.btnGuardarEmpresa.Text = "&Guardar";
            this.btnGuardarEmpresa.UseVisualStyleBackColor = false;
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardarEmpresa_Click);
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(282, 33);
            this.txtRNC.Margin = new System.Windows.Forms.Padding(2);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(133, 20);
            this.txtRNC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RNC:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // dlistEmpresasRNC
            // 
            this.dlistEmpresasRNC.AllowUserToAddRows = false;
            this.dlistEmpresasRNC.AllowUserToDeleteRows = false;
            this.dlistEmpresasRNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistEmpresasRNC.Location = new System.Drawing.Point(24, 232);
            this.dlistEmpresasRNC.Margin = new System.Windows.Forms.Padding(2);
            this.dlistEmpresasRNC.Name = "dlistEmpresasRNC";
            this.dlistEmpresasRNC.RowTemplate.Height = 24;
            this.dlistEmpresasRNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistEmpresasRNC.Size = new System.Drawing.Size(609, 174);
            this.dlistEmpresasRNC.TabIndex = 33;
            this.dlistEmpresasRNC.DoubleClick += new System.EventHandler(this.dlistEmpresasRNC_DoubleClick);
            // 
            // txtBuscarRNC
            // 
            this.txtBuscarRNC.Location = new System.Drawing.Point(40, 28);
            this.txtBuscarRNC.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarRNC.Name = "txtBuscarRNC";
            this.txtBuscarRNC.Size = new System.Drawing.Size(534, 20);
            this.txtBuscarRNC.TabIndex = 34;
            this.txtBuscarRNC.TextChanged += new System.EventHandler(this.txtBuscarRNC_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarRNC);
            this.groupBox2.Location = new System.Drawing.Point(24, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Burcar por RNC";
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dlistEmpresasRNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpresas";
            this.Text = "FrmEmpresas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistEmpresasRNC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardarEmpresa;
        private System.Windows.Forms.DataGridView dlistEmpresasRNC;
        private System.Windows.Forms.TextBox txtBuscarRNC;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}