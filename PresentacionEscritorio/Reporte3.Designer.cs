
namespace PresentacionEscritorio
{
    partial class Reporte3
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
            this.PedidosBDDataSet4 = new PresentacionEscritorio.PedidosBDDataSet4();
            this.TotalPorTiendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalPorTiendasTableAdapter = new PresentacionEscritorio.PedidosBDDataSet4TableAdapters.TotalPorTiendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPorTiendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.TotalPorTiendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionEscritorio.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(551, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // PedidosBDDataSet4
            // 
            this.PedidosBDDataSet4.DataSetName = "PedidosBDDataSet4";
            this.PedidosBDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalPorTiendasBindingSource
            // 
            this.TotalPorTiendasBindingSource.DataMember = "TotalPorTiendas";
            this.TotalPorTiendasBindingSource.DataSource = this.PedidosBDDataSet4;
            // 
            // TotalPorTiendasTableAdapter
            // 
            this.TotalPorTiendasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 611);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte3";
            this.Text = "Reporte3";
            this.Load += new System.EventHandler(this.Reporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPorTiendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalPorTiendasBindingSource;
        private PedidosBDDataSet4 PedidosBDDataSet4;
        private PedidosBDDataSet4TableAdapters.TotalPorTiendasTableAdapter TotalPorTiendasTableAdapter;
    }
}