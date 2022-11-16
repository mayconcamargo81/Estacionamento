using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Presenters.Conexao;

namespace Estacionamento.Classes
{

    public class Dados
    {
        SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoEstacionamento"].ConnectionString);
		SqlCommand cmd = new SqlCommand();
		Conexao con = new Conexao();
		//SqlDataReader dr;
		public int RetornaQuantidadeDeVagas()
        {
            int vagas = 50;
            try
            {
                vagas = int.Parse(ConfigurationManager.AppSettings["QuantidadeVagas"].ToString());
            }
            catch
            {
                MessageBox.Show("Não foi possível ler a quantidade de vagas do banco de dados.");
            }
            return vagas;
        }
        //
        public string BuscaVeiculoVaga(int numeroVaga)
        {
            string placa = "";
            try
            {
				cmd.CommandText = "select VeiculoPlaca from Vaga where Numero = @Numero and Saida is null";
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = numeroVaga;
				con.conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    placa = dr[0].ToString();
                con.desconectar();
            }
            catch (Exception ex)
            {

            }
            return placa;
        }

        public DataTable RetornaVeiculosCadastrados()
        {
            var veiculos = new DataTable();
            try
            {
				
                SqlDataAdapter dr = new SqlDataAdapter("select * from Veiculo", con.ToString());
                dr.Fill(veiculos);
            }
            catch
            {
                MessageBox.Show("Não foi possível ler os veículos do banco de dados.");
            }
            return veiculos;
        }

        public DataTable RetornaClientesCadastrados()
        {
            var clientes = new DataTable();
            try
            {
                SqlDataAdapter dr = new SqlDataAdapter("select * from Cliente", con.ToString());
                dr.Fill(clientes);
            }
            catch
            {
                MessageBox.Show("Não foi possível ler os clientes do banco de dados.");
            }
            return clientes;
        }

        public bool IncluirVeiculoNaVaga(string placa, int numeroVaga)
        {
            bool incluidoNaVaga = false;
            try
            {
                var dhEntrada = DateTime.Now;
				cmd.CommandText = @"Insert into Vaga (Numero, VeiculoPlaca, Entrada) values
                                                                   (@Numero, @VeiculoPlaca, @Entrada)";
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = numeroVaga;
                cmd.Parameters.Add("@VeiculoPlaca", SqlDbType.VarChar).Value = placa;
                cmd.Parameters.Add("@Entrada", SqlDbType.DateTime).Value = dhEntrada;
				con.conectar();
                cmd.ExecuteNonQuery();
				con.desconectar();
				incluidoNaVaga = true;
                new Impressao().Recibo(placa, numeroVaga, dhEntrada, null);
            }
            catch
            {
                MessageBox.Show("Não foi possível incluir o veículo na vaga.");
            }
            return incluidoNaVaga;
        }

        public bool VeiculoCadastrado(string placa)
        {
            bool encontrado = false;
            try
            {
				cmd.CommandText = "select Placa from Veiculo where Placa = @Placa";
                cmd.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
				con.conectar();
				SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    encontrado = true;
				con.desconectar();
			}
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar a placa do veículo.");
            }
            return encontrado;
        }


        public bool CadastraVeiculo(string placa, string descricao, string cor, int idcliente)
        {
            bool cadastrado = false;
            if (placa.Length != 8)
            {
                MessageBox.Show("Placa inválida.");
                return cadastrado;
            }
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Informe uma descrição para o veículo.");
                return cadastrado;
            }

            try
            {
				cmd.CommandText = @"insert into Veiculo (Placa, Descricao, Cor, IdCliente) values
                                                                      (@Placa, @Descricao, @Cor, @IdCliente)";
                cmd.Parameters.Add("Placa", SqlDbType.VarChar).Value = placa;
                cmd.Parameters.Add("Descricao", SqlDbType.VarChar).Value = descricao;
                cmd.Parameters.Add("Cor", SqlDbType.VarChar).Value = cor;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idcliente;
				con.conectar();
				cmd.ExecuteNonQuery();
				con.desconectar();
				cadastrado = true;
            }
            // catch //(Exception e)
            // {
            //    MessageBox.Show("Não foi possível cadastrar o veículo.");
            //  }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception: " +ex.Message);
            }
            return cadastrado;
        }

        public bool CadastroCliente(string nome, string cpf, string telefone, string end)
        {
            
            bool cadastrado = false;
            if (cpf.Length != 14)
            {
                MessageBox.Show("CPF inválido.");
                return cadastrado;
            }
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Informe o cliente.");
                return cadastrado;
            }

            try
            {
                var dhCadastro = DateTime.Now;
				cmd.CommandText = @"insert into Cliente (Nome, CPF, Endereco, Telefone, Cadastro) values
                                                                      (@Nome, @CPF, @Endereco, @Telefone, @Cadastro)";
                cmd.Parameters.Add("Nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("CPF", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("Endereco", SqlDbType.VarChar).Value = end;
                cmd.Parameters.Add("Telefone", SqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@Cadastro", SqlDbType.DateTime).Value = dhCadastro;

				con.conectar();
				cmd.ExecuteNonQuery();
				con.desconectar();
				cadastrado = true;
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar o cliente.");
            }
            return cadastrado;
        }

        public DataTable RetornaHistorico(DateTime dataInicial, DateTime dataFinal)
        {
            var historico = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"select va.Numero, va.VeiculoPlaca, v.Descricao, va.Entrada, va.Saida,
                                                                DATEDIFF(minute, va.entrada, isnull(va.Saida, getdate())) 'Minutos na vaga' 
                                                         from Vaga va
                                                         left join veiculo v on v.Placa = va.VeiculoPlaca
                                                         where cast(va.Entrada as date) between @DataInicial and @DataFinal 
                                                         order by va.Id desc", con.ToString());
                da.SelectCommand.Parameters.Add("@DataInicial", SqlDbType.Date).Value = dataInicial;
                da.SelectCommand.Parameters.Add("@DataFinal", SqlDbType.Date).Value = dataFinal;
                da.Fill(historico);
            }
            catch
            {
                MessageBox.Show("Não foi possível ler os veículos do banco de dados.");
            }
            return historico;
        }

        public void LiberarVaga(int numeroVaga)
        {
            try
            {
                DataTable dtVaga = new DataTable();
                SqlDataAdapter daVaga = new SqlDataAdapter("select * from Vaga where Numero = @Numero and Saida is null", con.ToString());
                daVaga.SelectCommand.Parameters.Add("Numero", SqlDbType.Int).Value = numeroVaga;
                daVaga.Fill(dtVaga);
                if (dtVaga.Rows.Count != 0)
                {
                    var dhSaida = DateTime.Now;
					cmd.CommandText = "Update Vaga set Saida = @Saida where Id = @Id";
                    cmd.Parameters.Add("Id", SqlDbType.Int).Value = dtVaga.Rows[0]["Id"].ToString();
                    cmd.Parameters.Add("@Saida", SqlDbType.DateTime).Value = dhSaida;
					con.conectar();
					cmd.ExecuteNonQuery();
					con.desconectar();
					new Impressao().Recibo(dtVaga.Rows[0]["VeiculoPlaca"].ToString(),
                                           int.Parse(dtVaga.Rows[0]["Numero"].ToString()),
                                           DateTime.Parse(dtVaga.Rows[0]["Entrada"].ToString()),
                                           dhSaida);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao liberar vaga.");
            }
        }
    }
}
