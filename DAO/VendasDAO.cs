using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Crud;
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
	public class VendasDAO
	{
		private MySqlConnection conexao;
		public VendasDAO()
		{
			this.conexao = new ConnectionFactory().GetConnection();
		}

		#region CadastrarVenda
		public bool CadastrarVenda(int idLanche, double valorTotal, DateTime dataVenda, List<int> ingredientes)
		{
			try
			{
				string sqlVenda = @"INSERT INTO TB_VENDAS (ID_LANCHE, VALOR_TOTAL, DATA_VENDA)
					 VALUES (@IdLanche, @valorTotal, @DataVenda)";

				MySqlCommand cmdVenda = new MySqlCommand(sqlVenda, conexao);
				cmdVenda.Parameters.AddWithValue("@IdLanche", idLanche);
				cmdVenda.Parameters.AddWithValue("@valorTotal", valorTotal);
				cmdVenda.Parameters.AddWithValue("@DataVenda", dataVenda);

				conexao.Open();
				cmdVenda.ExecuteNonQuery();

				int idVenda = (int)cmdVenda.LastInsertedId;

				string sqlDetails = @"INSERT INTO TB_VENDAS_DETAIL (ID_VENDA, ID_LANCHE, ID_INGREDIENTE)
										VALUES (@idVenda, @idLanche, @idIngrediente)";

				foreach (var idIngrediente in ingredientes)
				{
					MySqlCommand cmdDetail = new MySqlCommand(sqlDetails, conexao);
					cmdDetail.Parameters.AddWithValue("@idVenda", idVenda);
					cmdDetail.Parameters.AddWithValue("@idLanche", idLanche);
					cmdDetail.Parameters.AddWithValue("@idIngrediente", idIngrediente);
					cmdDetail.ExecuteNonQuery();
				}

				conexao.Close();
				return true;

			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar inserir: " + error.Message);
				return false;
			}
		}
		#endregion

		#region BuscarVendasPorPeriodo
		public DataTable BuscarVendasPorPeriodo(DateTime dataInicio, DateTime dataFim)
		{
			DataTable vendasDataTable = new DataTable();

			try
			{
				string dataInicioFormatada = dataInicio.ToString("yyyy-MM-dd HH:mm:ss");
				string dataFimFormatada = dataFim.Date.AddDays(1).AddMilliseconds(-1).ToString("yyyy-MM-dd HH:mm:ss");

				string sql = @"SELECT L.NOME, V.VALOR_TOTAL, V.DATA_VENDA
								FROM TB_VENDAS V
								INNER JOIN TB_LANCHES L ON V.ID_LANCHE = L.ID
								WHERE DATA_VENDA
								BETWEEN @DataInicio AND @DataFim
								ORDER BY V.DATA_VENDA DESC";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@DataInicio", dataInicioFormatada);
				executacmd.Parameters.AddWithValue("@DataFim", dataFimFormatada);

				conexao.Open();
				MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
				da.Fill(vendasDataTable);

				if (vendasDataTable.Rows.Count == 0)
				{
					MessageBox.Show("Nenhuma venda encontrada no período especificado.");
				}
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar vendas por período: " + error.Message);
			}

			conexao.Close();
			return vendasDataTable;
		}

		#endregion

		#region BuscarLancheMaisVendido
		public List<Tuple<string, int>> BuscarLancheMaisVendido()
		{

			List<Tuple<string, int>> lanchesMaisVendidos = new List<Tuple<string, int>>();

			try
			{
				string sql = @"SELECT L.NOME, COUNT(V.ID_LANCHE) AS QUANTIDADE 
                                 FROM TB_VENDAS V
                                 INNER JOIN TB_LANCHES L ON V.ID_LANCHE = L.ID
                                 GROUP BY V.ID_LANCHE
                                 ORDER BY QUANTIDADE DESC";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				conexao.Open();
				MySqlDataReader reader = executacmd.ExecuteReader();

				while (reader.Read())
				{
					lanchesMaisVendidos.Add(new Tuple<string, int>(reader.GetString("NOME"), reader.GetInt32("QUANTIDADE")));
				}

			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar lanches mais vendidos: " + error.Message);
			}

			conexao.Close();
			return lanchesMaisVendidos;
		}

		#endregion

		#region BuscarIngredientesMaisUtilizados
		public List<Tuple<string, int>> BuscarIngredientesMaisUtilizados()
		{
			List<Tuple<string, int>> ingredientesMaisUtilizados = new List<Tuple<string, int>>();

			try
			{
				string sql = @"SELECT I.NOME, COUNT(VD.ID_INGREDIENTE) AS QUANTIDADE
								FROM TB_VENDAS_DETAIL VD
								INNER JOIN TB_INGREDIENTES I ON VD.ID_INGREDIENTE = I.ID
								GROUP BY VD.ID_INGREDIENTE
								ORDER BY QUANTIDADE DESC";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				conexao.Open();
				MySqlDataReader reader = executacmd.ExecuteReader();

				while (reader.Read())
				{
					ingredientesMaisUtilizados.Add(new Tuple<string, int>(reader.GetString("NOME"), reader.GetInt32("QUANTIDADE")));
				}
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar ingredientes mais utilizados: " + error.Message);
			}

			conexao.Close();
			return ingredientesMaisUtilizados;
		}

		#endregion
	}
}