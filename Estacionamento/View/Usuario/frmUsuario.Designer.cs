namespace Estacionamento.View.Usuario
{
	partial class frmUsuario
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
			this.btnNovoUsuario = new System.Windows.Forms.Button();
			this.txtIdUsuario = new System.Windows.Forms.TextBox();
			this.lblIdUsuario = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblConfirmarSenha = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNovoUsuario
			// 
			this.btnNovoUsuario.Location = new System.Drawing.Point(125, 147);
			this.btnNovoUsuario.Name = "btnNovoUsuario";
			this.btnNovoUsuario.Size = new System.Drawing.Size(66, 29);
			this.btnNovoUsuario.TabIndex = 16;
			this.btnNovoUsuario.Text = "Novo";
			this.btnNovoUsuario.UseVisualStyleBackColor = true;
			// 
			// txtIdUsuario
			// 
			this.txtIdUsuario.Location = new System.Drawing.Point(125, 43);
			this.txtIdUsuario.Name = "txtIdUsuario";
			this.txtIdUsuario.ReadOnly = true;
			this.txtIdUsuario.Size = new System.Drawing.Size(115, 20);
			this.txtIdUsuario.TabIndex = 8;
			// 
			// lblIdUsuario
			// 
			this.lblIdUsuario.AutoSize = true;
			this.lblIdUsuario.Location = new System.Drawing.Point(71, 46);
			this.lblIdUsuario.Name = "lblIdUsuario";
			this.lblIdUsuario.Size = new System.Drawing.Size(43, 13);
			this.lblIdUsuario.TabIndex = 17;
			this.lblIdUsuario.Text = "Código:";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(208, 147);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(68, 29);
			this.btnCadastrar.TabIndex = 15;
			this.btnCadastrar.Text = "Salvar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// txtConfirmarSenha
			// 
			this.txtConfirmarSenha.Location = new System.Drawing.Point(125, 121);
			this.txtConfirmarSenha.Name = "txtConfirmarSenha";
			this.txtConfirmarSenha.PasswordChar = '*';
			this.txtConfirmarSenha.Size = new System.Drawing.Size(151, 20);
			this.txtConfirmarSenha.TabIndex = 14;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(125, 95);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(151, 20);
			this.txtSenha.TabIndex = 12;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(125, 69);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(151, 20);
			this.txtUsuario.TabIndex = 10;
			// 
			// lblConfirmarSenha
			// 
			this.lblConfirmarSenha.AutoSize = true;
			this.lblConfirmarSenha.Location = new System.Drawing.Point(26, 124);
			this.lblConfirmarSenha.Name = "lblConfirmarSenha";
			this.lblConfirmarSenha.Size = new System.Drawing.Size(88, 13);
			this.lblConfirmarSenha.TabIndex = 13;
			this.lblConfirmarSenha.Text = "Confirmar Senha:";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(73, 98);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 11;
			this.lblSenha.Text = "Senha:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(68, 72);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(46, 13);
			this.lblUsuario.TabIndex = 9;
			this.lblUsuario.Text = "Usuario:";
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(324, 233);
			this.Controls.Add(this.btnNovoUsuario);
			this.Controls.Add(this.txtIdUsuario);
			this.Controls.Add(this.lblIdUsuario);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtConfirmarSenha);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblConfirmarSenha);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblUsuario);
			this.Name = "frmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Usuários";
			this.Load += new System.EventHandler(this.frmUsuario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNovoUsuario;
		private System.Windows.Forms.TextBox txtIdUsuario;
		private System.Windows.Forms.Label lblIdUsuario;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.TextBox txtConfirmarSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblConfirmarSenha;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
	}
}