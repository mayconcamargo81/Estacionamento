
namespace Estacionamento
{
    partial class FrmRelatorio
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
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoDt = new Estacionamento.EstacionamentoDt();
            this.vagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentods = new Estacionamento.Estacionamentods();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vagaTableAdapter = new Estacionamento.EstacionamentodsTableAdapters.VagaTableAdapter();
            this.veiculoTableAdapter = new Estacionamento.EstacionamentoDtTableAdapters.VeiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentods)).BeginInit();
            this.SuspendLayout();
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.estacionamentoDt;
            // 
            // estacionamentoDt
            // 
            this.estacionamentoDt.DataSetName = "EstacionamentoDt";
            this.estacionamentoDt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vagaBindingSource
            // 
            this.vagaBindingSource.DataMember = "Vaga";
            this.vagaBindingSource.DataSource = this.estacionamentods;
            // 
            // estacionamentods
            // 
            this.estacionamentods.DataSetName = "Estacionamentods";
            this.estacionamentods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.veiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Estacionamento.Relatorio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // vagaTableAdapter
            // 
            this.vagaTableAdapter.ClearBeforeFill = true;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorio";
            this.Text = "FrmRelatorio";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Estacionamentods estacionamentods;
        private System.Windows.Forms.BindingSource vagaBindingSource;
        private EstacionamentodsTableAdapters.VagaTableAdapter vagaTableAdapter;
        private EstacionamentoDt estacionamentoDt;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private EstacionamentoDtTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
    }
}