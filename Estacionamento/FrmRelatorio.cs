using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class FrmRelatorio : Form
    {
        //DataTable dt = new DataTable();
        public FrmRelatorio()
        {
            InitializeComponent();
           // this.dt = dt;
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estacionamentoDt.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.estacionamentoDt.Veiculo);

            //  this.reportViewer1.LocalReport.DataSources.Clear();
            //  this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_rel", dt));

            this.reportViewer1.RefreshReport();
        }
    }
}
