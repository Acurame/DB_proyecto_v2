
namespace UI.Reportes
{
    partial class Reporte_Facturas
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
            this.dB_ProyectoDataSet2 = new UI.DB_ProyectoDataSet2();
            this.dBProyectoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Listado_FacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProyectoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_FacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Listado_FacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // dB_ProyectoDataSet2
            // 
            this.dB_ProyectoDataSet2.DataSetName = "DB_ProyectoDataSet2";
            this.dB_ProyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBProyectoDataSet2BindingSource
            // 
            this.dBProyectoDataSet2BindingSource.DataSource = this.dB_ProyectoDataSet2;
            this.dBProyectoDataSet2BindingSource.Position = 0;
            // 
            // Listado_FacturasBindingSource
            // 
            this.Listado_FacturasBindingSource.DataMember = "Listado_Facturas";
            this.Listado_FacturasBindingSource.DataSource = this.dB_ProyectoDataSet2;
            // 
            // Reporte_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_Facturas";
            this.Text = "Reporte_Facturas";
            this.Load += new System.EventHandler(this.Reporte_Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProyectoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listado_FacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Listado_FacturasBindingSource;
        private DB_ProyectoDataSet2 dB_ProyectoDataSet2;
        private System.Windows.Forms.BindingSource dBProyectoDataSet2BindingSource;
    }
}