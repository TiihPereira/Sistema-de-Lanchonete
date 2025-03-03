using MySql.Data.MySqlClient;
using Mysqlx;
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

		public void cadastrarLanches(Lanches lanches)
		{
			try
			{
				// INSERT NA TABELA DE LANCHE
				string sqlLanche = "INSERT INTO TB_LANCHES(NOME, PRECO) VALUES(@NOME, @PRECO)";

				MySqlCommand cmdlanche = new MySqlCommand(sqlLanche, conexao);
				cmdlanche.Parameters.AddWithValue("@NOME", lanches.Nome);
				cmdlanche.Parameters.AddWithValue("@PRECO", lanches.Preco);

				conexao.Open();
				cmdlanche.ExecuteNonQuery();

				int lancheId = (int)cmdlanche.LastInsertedId;

				// INSERT NA TABELA LANCHE/INGREDIENTE
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

		#region ExcluirLanches

		public void excluirLanches(Lanches lanches)
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

		public DataTable listarLanches()
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

		public List<int> buscarIngredientesDoLanche(int idLanche)
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

			#endregion
		}
	}
}
