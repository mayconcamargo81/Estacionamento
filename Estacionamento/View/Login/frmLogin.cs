using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Estacionamento.Model;
using Estacionamento.View;
using Estacionamento.View.Usuario;



namespace Estacionamento.View.Login
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
	

		private void btnLogin_Click(object sender, EventArgs e)
		{
		
				LoginModel controle = new LoginModel();
				controle.acessar(txtLogin.Text, txtSenha.Text);
				if (controle.mensagem.Equals(""))
				{
					if (controle.existe)
					{
						MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
						frmPrincipal m = new frmPrincipal();
						m.Show();
					}
					else
					{
						MessageBox.Show("Login não Encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				else
				{
					MessageBox.Show(controle.mensagem);
				}
			}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			frmUsuario cad = new frmUsuario();
			cad.Show();
		}
	}
}
