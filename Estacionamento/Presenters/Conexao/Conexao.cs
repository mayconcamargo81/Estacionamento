﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.Presenters.Login;

namespace Estacionamento.Presenters.Conexao
{
	public class Conexao
	{
		SqlConnection con = new SqlConnection();
		public Conexao()
		{
			con.ConnectionString = @"Data Source=DESKTOP-4640NDD;Initial Catalog=Estacionamento;Persist Security Info=True;User ID=sa;Password=kb74Uwfcq/DRfmAGZd8pkghc52rMpXAGBZXVQOr4pkpIpsK5nt6pDCJE+EF+47wZY8aX87eqCtt/F9vjKBHMNk8jJ/2oVXOtGBcUEMn9cb1txI0Fiv7N+LFzgcfWGJuW";
		}

		public SqlConnection conectar()
		{
			if (con.State == System.Data.ConnectionState.Closed)
			{
				con.Open();
			}
			return con;
		}

		public void desconectar()
		{
			if (con.State == System.Data.ConnectionState.Open)
			{
				con.Close();
			}
		}

	}
}
