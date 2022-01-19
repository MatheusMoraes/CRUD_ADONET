
using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace daoMySQL
{
	/// <summary>
	/// Classe que usa o padrão Singleton para obter 
	/// uma instãncia da conexão com o MySQL
	/// </summary>
	public class MySQLDao
	{
		private static readonly MySQLDao instanciaMySQL = new MySQLDao();

		private MySQLDao() { }

		public static MySQLDao getInstancia()
		{
			return instanciaMySQL;
		}

		public MySqlConnection getConexao()
		{
			string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			return new MySqlConnection(conn);
		}
	}
}
