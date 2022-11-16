using Estacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.View.Login;
using Estacionamento.Presenters.Conexao;


namespace Estacionamento
{    

    public partial class frmPrincipal : Form
    {
        Button botaoSelecionado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, EventArgs e)
        {
            botaoSelecionado = ((Button)sender);
            CarregaDadosVaga(int.Parse(botaoSelecionado.Tag.ToString()));
        }

        private void CarregaDadosVaga(int numeroVaga)
        {
            string veiculo = new Dados().BuscaVeiculoVaga(numeroVaga);
            gbDadosVeiculo.Enabled = true;
            gbDadosVeiculo.Text = "Vaga: " + botaoSelecionado.Tag.ToString();
            txtPlaca.Text = veiculo;
            txtPlaca.Enabled = veiculo == "";
            btnEstacionar.Enabled = veiculo == "";
            btnLiberarVaga.Enabled = veiculo != "";
            txtPlaca.Focus();
        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            var dados = new Dados();
            if (dados.VeiculoCadastrado(txtPlaca.Text))
            {
                if (dados.IncluirVeiculoNaVaga(txtPlaca.Text, int.Parse(botaoSelecionado.Tag.ToString())))
                {
                    PintaVagaUsada(botaoSelecionado, txtPlaca.Text);
                    gbDadosVeiculo.Enabled = false;
                    txtPlaca.Text = "";
                }
            }
            else
                MessageBox.Show("Veículo não encontrado.");
        }

        private void PintaVagaUsada(Button botaoSelecionado, string placaVeiculo)
        {
            botaoSelecionado.Text = "Vaga - " + botaoSelecionado.Tag.ToString() + "\n" + placaVeiculo;
            botaoSelecionado.BackColor = Color.Orange;
        }
        private void LiberaVaga(Button botaoSelecionado)
        {
            botaoSelecionado.Text = botaoSelecionado.Tag.ToString();
            botaoSelecionado.BackColor = Color.LightGray;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'estacionamentoDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.estacionamentoDataSet1.Cliente);
            
            MontarEstacionamento();
        }

        private void MontarEstacionamento()
        {
            var dados = new Dados();
            int qtdVagas = dados.RetornaQuantidadeDeVagas();
            painelEstacionamento.Controls.Clear();
            for (int i = 1; i <= qtdVagas; i++)
            {
                Button b = new Button();
                b.Text = "Vaga - " + i.ToString();
                b.Name = i.ToString();
                b.Size = new Size(143, 54);
                b.Click += B_Click;
                b.Tag = i.ToString();
                string placaNaVaga = dados.BuscaVeiculoVaga(i);
                if (!string.IsNullOrEmpty(placaNaVaga))
                    PintaVagaUsada(b, placaNaVaga);

                painelEstacionamento.Controls.Add(b);
            }
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {           
            var dados = new Dados();
            if (dados.CadastraVeiculo(txtPlacaCadastro.Text, txtDescricaoCadastro.Text, txCor.Text, int.Parse(cbxCliente.SelectedValue.ToString())))
            {
                dgVeiculos.DataSource = dados.RetornaVeiculosCadastrados();
                txtPlacaCadastro.Text = txtDescricaoCadastro.Text = txCor.Text =  "";
            }            
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            var dados1 = new Dados();
            if (dados1.CadastroCliente(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEndereco.Text))
            {
                dgClientes.DataSource = dados1.RetornaClientesCadastrados();
                txtNome.Text = txtCpf.Text = txtTelefone.Text = txtEndereco.Text = "";
            }
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcPrincipal.SelectedTab == tpVeiculos)
                dgVeiculos.DataSource = new Dados().RetornaVeiculosCadastrados();
            else if (tcPrincipal.SelectedTab == tpClientes)
                dgClientes.DataSource = new Dados().RetornaClientesCadastrados();
            else if (tcPrincipal.SelectedTab == tpHistorico)
                dgHistorico.DataSource = new Dados().RetornaHistorico(dataInicialHistorico.Value.Date, dataFinalHistorico.Value.Date);
        }

        private void btnLiberarVaga_Click(object sender, EventArgs e)
        {
            new Dados().LiberarVaga(int.Parse(botaoSelecionado.Tag.ToString()));
            LiberaVaga(botaoSelecionado);
            gbDadosVeiculo.Enabled = false;
            txtPlaca.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrarHistorico_Click(object sender, EventArgs e)
        {
            dgHistorico.DataSource = new Dados().RetornaHistorico(dataInicialHistorico.Value.Date, dataFinalHistorico.Value.Date);
        }

        private void dgVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txIdCliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //  var dt = GerarDadosRelatorio();
            //  using(var frm = new FrmRelatorio(dt))
            //  {
            //      frm.ShowDialog();
            //  }
  
          //  dgHistorico.DataSource = new Dados().RetornaHistorico(dataInicialHistorico.Value.Date, dataFinalHistorico.Value.Date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRelatorio f = new FrmRelatorio();
            f.ShowDialog();
            f.Dispose();
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlacaCadastro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }




        // private DataTable GerarDadosRelatorio()
        // {
        //     var dt = new DataTable();
        //     dt.Columns.Add("Id", typeof(int));
        //     dt.Columns.Add("Numero", typeof(int));
        //     dt.Columns.Add("VeiculoPlaca");
        //     dt.Columns.Add("Entrada", typeof(DateTime));
        //     dt.Columns.Add("Saida", typeof(DateTime));
        //
        //     foreach (DataGridViewRow item in dgHistorico.Rows)
        //     {
        //       dt.Rows.Add(item.Cells["@Id"].Value, item.Cells["Numero"].Value.ToString(), item.Cells["VeiculoPlaca"].Value.ToString(), item.Cells["Entrada"].Value.ToString(), item.Cells["Saida"].Value.ToString());
        //     }
        //
        //
        //
        //     return dt;
        // }
        //


    }
}