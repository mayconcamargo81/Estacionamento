using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Presenters.Conexao;
using Estacionamento.Presenters.Login;

namespace Estacionamento.Model
{
	public class LoginModel
	{
		public bool existe;
		public String mensagem = "";

		public bool acessar(String usuario, String senha)
		{
			LoginPresenters loginDao = new LoginPresenters();
			existe = loginDao.verificarLogin(usuario, senha);
			if (!loginDao.mensagem.Equals(""))
			{
				this.mensagem = loginDao.mensagem;
			}
			return existe;
		}

		public String cadastrar(String usuario, String senha, String confsenha)
		{
			LoginPresenters loginDao = new LoginPresenters();
			this.mensagem = loginDao.cadastrar(usuario, senha, confsenha);
			if (loginDao.existe)// mensagem que vai vir e de sucesso
			{
				this.existe = true;
			}
			return mensagem;
		}
	}
}
