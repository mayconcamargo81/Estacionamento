﻿namespace Estacionamento.View.Login
{
	partial class frmLogin
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
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(85, 111);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(175, 35);
			this.btnNovo.TabIndex = 14;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(185, 82);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 13;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(85, 82);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 12;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(85, 56);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(175, 20);
			this.txtSenha.TabIndex = 10;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(85, 28);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(175, 20);
			this.txtLogin.TabIndex = 8;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(38, 59);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 11;
			this.lblSenha.Text = "Senha:";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(43, 31);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 9;
			this.lblLogin.Text = "Login:";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(313, 182);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblLogin);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblLogin;
	}
}