using MySql.Data.MySqlClient;
using Mysqlx;
using Sistema_de_Lanchonete.BO;
using Sistema_de_Lanchonete.DBC;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.DAO
{
	public class LanchesDAO
	{
		private MySqlConnection conexao;
		public LanchesDAO()
		{
			this.conexao = new ConnectionFactory().GetConnection();
		}

		#region CadastrarLanche

		public void CadastrarLanches(Lanches lanches)
		{
			try
			{
				string sqlLanche = "INSERT INTO TB_LANCHES(NOME, PRECO) VALUES(@NOME, @PRECO)";

				MySqlCommand cmdlanche = new MySqlCommand(sqlLanche, conexao);
				cmdlanche.Parameters.AddWithValue("@NOME", lanches.Nome);
				cmdlanche.Parameters.AddWithValue("@PRECO", lanches.Preco);

				conexao.Open();
				cmdlanche.ExecuteNonQuery();

				int lancheId = (int)cmdlanche.LastInsertedId;

				string sqlLancheIngrediente = @"INSERT INTO TB_LANCHES_INGREDIENTES(ID_LANCHE, ID_INGREDIENTE)
												VALUES(@ID_LANCHE, @ID_INGREDIENTE)";

				foreach (var ingrediente in lanches.Ingredientes)
				{
					MySqlCommand cmdingrediente = new MySqlCommand(sqlLancheIngrediente, conexao);
					cmdingrediente.Parameters.AddWithValue("@ID_LANCHE", lancheId);
					cmdingrediente.Parameters.AddWithValue("@ID_INGREDIENTE", ingrediente.Id);

					cmdingrediente.ExecuteNonQuery();

				}

			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}

			MessageBox.Show("Lanche cadastrado com sucesso!");

			conexao.Close();
		}

		#endregion

		#region AlterarLanches

		public void AlterarLanches(Lanches lanches)
		{
			try
			{
				string sqlLanche = @"UPDATE TB_LANCHES 
							 SET PRECO = @PRECO
							 WHERE NOME = @NOME";

				MySqlCommand cmdlanche = new MySqlCommand(sqlLanche, conexao);
				cmdlanche.Parameters.AddWithValue("@NOME", lanches.Nome);
				cmdlanche.Parameters.AddWithValue("@PRECO", lanches.Preco);

				conexao.Open();
				cmdlanche.ExecuteNonQuery();

				// BUSCAR O ID DO LANCHE BASEADO NO NOME
				string sqlGetId = "SELECT ID FROM TB_LANCHES WHERE NOME = @NOME";
				MySqlCommand cmdGetId = new MySqlCommand(sqlGetId, conexao);
				cmdGetId.Parameters.AddWithValue("@NOME", lanches.Nome);

				int lancheId = Convert.ToInt32(cmdGetId.ExecuteScalar());

				// DELETE DOS INGREDIENTES ANTIGOS
				string sqlDeleteIngredientes = "DELETE FROM TB_LANCHES_INGREDIENTES WHERE ID_LANCHE = @ID_LANCHE";

				MySqlCommand cmdDelete = new MySqlCommand(sqlDeleteIngredientes, conexao);
				cmdDelete.Parameters.AddWithValue("@ID_LANCHE", lancheId);
				cmdDelete.ExecuteNonQuery();

				// INSERT DOS NOVOS INGREDIENTES
				string sqlLancheIngrediente = @"INSERT INTO TB_LANCHES_INGREDIENTES(ID_LANCHE, ID_INGREDIENTE)
										VALUES(@ID_LANCHE, @ID_INGREDIENTE)";

				foreach (var ingrediente in lanches.Ingredientes)
				{
					MySqlCommand cmdingrediente = new MySqlCommand(sqlLancheIngrediente, conexao);
					cmdingrediente.Parameters.AddWithValue("@ID_LANCHE", lancheId);
					cmdingrediente.Parameters.AddWithValue("@ID_INGREDIENTE", ingrediente.Id);
					cmdingrediente.ExecuteNonQuery();
				}

				MessageBox.Show("Lanche alterado com sucesso!");
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar alterar: " + error.Message);
			}

			conexao.Close();
		}

		#endregion

		#region ExcluirLanches

		public void ExcluirLanches(Lanches lanches)
		{
			try
			{
				string sql =  @"DELETE A,B FROM DBLANCHONETE.TB_LANCHES AS A
								INNER JOIN DBLANCHONETE.TB_LANCHES_INGREDIENTES AS B
								ON B.ID_LANCHE = A.ID
								WHERE A.NOME = @NOME";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@NOME", lanches.Nome);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MessageBox.Show("Lanche excluido com sucesso!");
				conexao.Close();
			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao tentar excluir: " + error);
			}
		}

		#endregion

		#region ListarLanches

		public DataTable ListarLanches()
		{
			try
			{

				DataTable tabelaLanches = new DataTable();

				string sql = "SELECT * FROM TB_LANCHES";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaLanches);

				conexao.Close();
				return tabelaLanches;

			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + error);
				return null;
			}
		}

		#endregion

		#region BuscarIngredientesDoLanchePorId
		public List<int> BuscarIngredientesDoLanchePorId(int idLanche)
		{
			List<int> ids = new List<int>();

			string sql = "SELECT ID_INGREDIENTE FROM TB_LANCHES_INGREDIENTES WHERE ID_LANCHE = @idLanche";

			MySqlCommand executacmd = new MySqlCommand(sql, conexao);
			executacmd.Parameters.AddWithValue("@idLanche", idLanche);

			conexao.Open();
			MySqlDataReader reader = executacmd.ExecuteReader();

			while (reader.Read())
			{
				ids.Add(Convert.ToInt32(reader["ID_INGREDIENTE"]));
			}

			return ids;
		}
		#endregion

		#region BuscarIngredientesDoLanche
		public List<Ingredientes> BuscarIngredientesDoLanche(int idLanche)
		{
			List<Ingredientes> ingredientes = new List<Ingredientes>();

			string sql = @"SELECT B.ID, B.NOME, B.PRECO FROM TB_LANCHES_INGREDIENTES A
							INNER JOIN TB_INGREDIENTES B ON A.ID_INGREDIENTE = B.ID 
								WHERE A.ID_LANCHE = @idLanche";

			MySqlCommand executacmd = new MySqlCommand(sql, conexao);
			executacmd.Parameters.AddWithValue("@idLanche", idLanche);

			conexao.Open();
			MySqlDataReader reader = executacmd.ExecuteReader();

			while (reader.Read())
			{
				Ingredientes ingrediente = new Ingredientes
				{
					Id = Convert.ToInt32(reader["ID"]),
					Nome = reader["NOME"].ToString(),
					Preco = Convert.ToDouble(reader["PRECO"])
				};

				ingredientes.Add(ingrediente);
			}

			return ingredientes;
		}
		#endregion

		#region BuscarLanchePorNome

		public DataTable BuscarLanchePorNome(string nome)
		{
			try
			{
				DataTable tabelalanche = new DataTable();
				string sql = "SELECT * FROM TB_LANCHES WHERE NOME = @NOME";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", nome);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelalanche);

				conexao.Close();
				return tabelalanche;

			}
			catch (Exception erro)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + erro);
				return null;
			}
		}

		#endregion

		#region ListarLanchePorNome
		public DataTable ListarLanchePorNome(string nome)
		{
			try
			{
				DataTable tabelalanche = new DataTable();
				string sql = "SELECT * FROM TB_LANCHES WHERE NOME LIKE @NOME";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", nome);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelalanche);

				conexao.Close();
				return tabelalanche;

			}
			catch (Exception erro)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + erro);
				return null;
			}
		}
		#endregion

		#region BuscarTodosLanches
		public List<Lanches> BuscarTodosLanches()
		{
			List<Lanches> lista = new List<Lanches>();

			string sql = "SELECT * FROM TB_LANCHES";

			MySqlCommand executacmd = new MySqlCommand(sql, conexao);
			conexao.Open();
			MySqlDataReader reader = executacmd.ExecuteReader();

			while (reader.Read())
			{
				Lanches lanche = new Lanches
				{
					Id = reader.GetInt32(reader.GetOrdinal("Id")),
					Nome = reader.GetString(reader.GetOrdinal("Nome")),
					Preco = reader.GetDouble(reader.GetOrdinal("Preco"))
				};

				lista.Add(lanche);
			}

			return lista;
		}

		#endregion

		#region LancheExiste
		public bool LancheExiste(Lanches lanches)
		{
			string sql = @"SELECT COUNT(*) FROM TB_LANCHES
							WHERE NOME = @NOME";

			MySqlCommand executacmd = new MySqlCommand(sql, conexao);
			executacmd.Parameters.AddWithValue("@NOME", lanches.Nome);

			conexao.Open();
			executacmd.ExecuteNonQuery();

			int count = Convert.ToInt32(executacmd.ExecuteScalar());
			conexao.Close();

			return count > 0;

			#endregion

		}
	}
}