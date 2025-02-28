using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Lanchonete.DBC
{
	public class ConnectionFactory
	{
		//Conexão com o banco de dados
		public MySqlConnection GetConnection()
		{
			string conexao = ConfigurationManager.ConnectionStrings["dblanchonete"].ConnectionString;

			return new MySqlConnection(conexao);
		}
	}
}
