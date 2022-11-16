using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Model;

namespace Estacionamento.View.Usuario
{
	public partial class frmUsuario : Form
	{
		public frmUsuario()
		{
			InitializeComponent();
		}


		private void frmUsuario_Load(object sender, EventArgs e)
		{

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			LoginModel controle = new LoginModel();
			String mensagem = controle.cadastrar(txtUsuario.Text, txtSenha.Text, txtConfirmarSenha.Text);
			if (controle.existe)
			{
				MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(controle.mensagem);
			}
		}
	}
}
