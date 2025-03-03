using MySql.Data.MySqlClient;
using Mysqlx;
using Sistema_de_Lanchonete.DBC;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.DAO
{
	public class IngredientesDAO
	{
		private MySqlConnection conexao;
		public IngredientesDAO()
		{
			this.conexao = new ConnectionFactory().GetConnection();
		}

		#region CadastrarIngrediente
		public void cadastrarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				string sql = @"INSERT INTO TB_INGREDIENTES(NOME, PRECO)
								VALUES(@NOME, @PRECO)";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@NOME", ingredientes.Nome);
				executacmd.Parameters.AddWithValue("@PRECO", ingredientes.Preco);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MessageBox.Show("Ingrediente cadastrado com sucesso!");
				conexao.Close();
			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}
		}
		#endregion

		#region AlterarIngredientes

		public void alterarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				string sql = @"UPDATE TB_INGREDIENTES SET NOME = @NOME, PRECO = @PRECO
								WHERE ID = @ID";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@NOME", ingredientes.Nome);
				executacmd.Parameters.AddWithValue("@PRECO", ingredientes.Preco);
				executacmd.Parameters.AddWithValue("@ID", ingredientes.Id);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MessageBox.Show("Ingrediente alterado com sucesso!");
				conexao.Close();
			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao tentar alterar: " + error);
			}
		}

		#endregion

		#region ExcluirIngredientes

		public void excluirIngredientes(Ingredientes ingredientes)
		{
			try
			{
				string sql = @"DELETE FROM TB_INGREDIENTES WHERE ID = @ID";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@ID", ingredientes.Id);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MessageBox.Show("Ingrediente excluido com sucesso!");
				conexao.Close();
			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao tentar excluir: " + error);
			}
		}

		#endregion

		#region ListarIngredientes

		public DataTable listarIngredientes()
		{
			try
			{

				DataTable tabelaIngrediente = new DataTable();

				string sql = "SELECT * FROM TB_INGREDIENTES";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaIngrediente);

				conexao.Close();
				return tabelaIngrediente;

			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + error);
				return null;
			}
		}

		#endregion

		#region BuscarIngredientePorNome

		public DataTable BuscarIngredientePorNome(string nome)
		{
			try
			{
				DataTable tabelaingrediente = new DataTable();
				string sql = "SELECT * FROM TB_INGREDIENTES WHERE NOME = @NOME";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", nome);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaingrediente);

				conexao.Close();
				return tabelaingrediente;

			}
			catch (Exception erro)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + erro);
				return null;
			}
		}

		#endregion

		#region ListarIngredientePorNome
		public DataTable ListarIngredientePorNome(string nome)
		{
			try
			{
				DataTable tabelaingrediente = new DataTable();
				string sql = "SELECT * FROM TB_INGREDIENTES WHERE NOME LIKE @NOME";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@nome", nome);

				conexao.Open();
				executacmd.ExecuteNonQuery();

				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(tabelaingrediente);

				conexao.Close();
				return tabelaingrediente;

			}
			catch (Exception erro)
			{

				MessageBox.Show("Erro ao executar o comando sql: " + erro);
				return null;
			}
		}

		#endregion

		#region LancheExiste

		public bool IngredienteExiste(Ingredientes ingredientes)
		{
			string sql = @"SELECT COUNT(*) FROM TB_INGREDIENTES
								WHERE NOME = @NOME";

			MySqlCommand executacmd = new MySqlCommand(sql, conexao);
			executacmd.Parameters.AddWithValue("@NOME", ingredientes.Nome);

			conexao.Open();
			executacmd.ExecuteNonQuery();

			int count = Convert.ToInt32(executacmd.ExecuteScalar());
			conexao.Close();

			return count > 0;
		}

		#endregion
	}
}
