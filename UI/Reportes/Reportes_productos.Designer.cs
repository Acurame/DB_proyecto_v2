
namespace UI.Reportes
{
    partial class Reportes_productos
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
            this.Listado_ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ProyectoDataSet1 = new UI.DB_ProyectoDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listadoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listado_ProductoTableAdapter = new UI.DB_ProyectoDataSet1TableAdapters.Listado_ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProyectoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Listado_ProductoBindingSource
            // 
            this.Listado_ProductoBindingSource.DataMember = "Listado_Producto";
            this.Listado_ProductoBindingSource.DataSource = this.dB_ProyectoDataSet1;
            // 
            // dB_ProyectoDataSet1
            // 
            this.dB_ProyectoDataSet1.DataSetName = "DB_ProyectoDataSet1";
            this.dB_ProyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ForeColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Listado_ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // listadoProductoBindingSource
            // 
            this.listadoProductoBindingSource.DataMember = "Listado_Producto";
            this.listadoProductoBindingSource.DataSource = this.dB_ProyectoDataSet1;
            // 
            // listado_ProductoTableAdapter
            // 
            this.listado_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes_productos";
            this.Text = "Reportes_productos";
            this.Load += new System.EventHandler(this.Reportes_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listado_ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProyectoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DB_ProyectoDataSet1 dB_ProyectoDataSet1;
        private System.Windows.Forms.BindingSource listadoProductoBindingSource;
        private DB_ProyectoDataSet1TableAdapters.Listado_ProductoTableAdapter listado_ProductoTableAdapter;
        private System.Windows.Forms.BindingSource Listado_ProductoBindingSource;
    }
}