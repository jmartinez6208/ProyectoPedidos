
namespace PresentacionEscritorio
{
    partial class Reporte1
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
            this.PedidosBDDataSet1 = new PresentacionEscritorio.PedidosBDDataSet1();
            this.vw_ProductosTop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ProductosTop5TableAdapter = new PresentacionEscritorio.PedidosBDDataSet1TableAdapters.vw_ProductosTop5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ProductosTop5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Top5";
            reportDataSource1.Value = this.vw_ProductosTop5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionEscritorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(551, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // PedidosBDDataSet1
            // 
            this.PedidosBDDataSet1.DataSetName = "PedidosBDDataSet1";
            this.PedidosBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_ProductosTop5BindingSource
            // 
            this.vw_ProductosTop5BindingSource.DataMember = "vw_ProductosTop5";
            this.vw_ProductosTop5BindingSource.DataSource = this.PedidosBDDataSet1;
            // 
            // vw_ProductosTop5TableAdapter
            // 
            this.vw_ProductosTop5TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 611);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte1";
            this.Text = "Reporte1";
            this.Load += new System.EventHandler(this.Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ProductosTop5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_ProductosTop5BindingSource;
        private PedidosBDDataSet1 PedidosBDDataSet1;
        private PedidosBDDataSet1TableAdapters.vw_ProductosTop5TableAdapter vw_ProductosTop5TableAdapter;
    }
}