
namespace PresentacionEscritorio
{
    partial class Reporte2
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
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.labelRepartidor = new System.Windows.Forms.Label();
            this.vw_RepartidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PedidosBDDataSet2 = new PresentacionEscritorio.PedidosBDDataSet2();
            this.vw_RepartidoresTableAdapter = new PresentacionEscritorio.PedidosBDDataSet2TableAdapters.vw_RepartidoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RepartidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.vw_RepartidoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionEscritorio.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(545, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnReporte2
            // 
            this.btnReporte2.Location = new System.Drawing.Point(384, 26);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(155, 23);
            this.btnReporte2.TabIndex = 1;
            this.btnReporte2.Text = "GENERAR REPORTE";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(183, 28);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(167, 20);
            this.txbNombre.TabIndex = 2;
            // 
            // labelRepartidor
            // 
            this.labelRepartidor.AutoSize = true;
            this.labelRepartidor.Location = new System.Drawing.Point(26, 31);
            this.labelRepartidor.Name = "labelRepartidor";
            this.labelRepartidor.Size = new System.Drawing.Size(151, 13);
            this.labelRepartidor.TabIndex = 3;
            this.labelRepartidor.Text = "INGRESE EL REPARTIDOR :";
            // 
            // vw_RepartidoresBindingSource
            // 
            this.vw_RepartidoresBindingSource.DataMember = "vw_Repartidores";
            this.vw_RepartidoresBindingSource.DataSource = this.PedidosBDDataSet2;
            // 
            // PedidosBDDataSet2
            // 
            this.PedidosBDDataSet2.DataSetName = "PedidosBDDataSet2";
            this.PedidosBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_RepartidoresTableAdapter
            // 
            this.vw_RepartidoresTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 611);
            this.Controls.Add(this.labelRepartidor);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte2";
            this.Text = "Reporte2";
            this.Load += new System.EventHandler(this.Reporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_RepartidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosBDDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_RepartidoresBindingSource;
        private PedidosBDDataSet2 PedidosBDDataSet2;
        private PedidosBDDataSet2TableAdapters.vw_RepartidoresTableAdapter vw_RepartidoresTableAdapter;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label labelRepartidor;
    }
}