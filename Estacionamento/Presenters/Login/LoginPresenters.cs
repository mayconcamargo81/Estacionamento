using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Presenters.Conexao;
using Estacionamento.Presenters.Login;

namespace Estacionamento.Presenters.Login
{
	 class LoginPresenters
	{
		public bool existe = false;
		public String mensagem = "";
		SqlCommand cmd = new SqlCommand();
	    Conexao.Conexao con = new Conexao.Conexao();
		SqlDataReader dr;

		public bool verificarLogin(String usuario, String senha)
		{
			//comando sql para verificar se 'existe' no banco
			cmd.CommandText = "select * from Usuarios where usuario = @usuario and senha = @senha";
			cmd.Parameters.AddWithValue("@usuario", usuario);
			cmd.Parameters.AddWithValue("@senha", senha);

			try
			{
				cmd.Connection = con.conectar();
				dr = cmd.ExecuteReader();
				if (dr.HasRows)//se foi encontrado
				{
					existe = true;
				}
				con.desconectar();
				dr.Close();
			}
			catch (SqlException)
			{
				this.mensagem = "Erro com Banco de dados!";
			}
			return existe;
		}

		public String cadastrar(String usuario, String senha, String confsenha)
		{
			existe = false;
			// comandos para inserir
			if (senha.Equals(confsenha))//verifica se as senhas conferem
			{
				cmd.CommandText = "insert into Usuarios values (@u,@s);";
				cmd.Parameters.AddWithValue("@u", usuario);
				cmd.Parameters.AddWithValue("@s", senha);

				try
				{
					cmd.Connection = con.conectar();
					cmd.ExecuteNonQuery();
					con.desconectar();
					this.mensagem = "Cadastrado com sucesso!";
					existe = true;

				}
				catch (SqlException)
				{
					this.mensagem = " Erro com banco de dados";
				}
			}
			else
			{
				this.mensagem = "Senhas não correspondem!";
			}

			return mensagem;
		}
	}
}
