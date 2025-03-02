using MySql.Data.MySqlClient;
using Mysqlx;
using Sistema_de_Lanchonete.DBC;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
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
				string sqlLanche = @"INSERT INTO TB_LANCHES(NOME, PRECO)
								VALUES(@NOME, @PRECO);
								SELECT SCOPE_IDENTITY();";

				int lancheId;

				MySqlCommand cmdlanche = new MySqlCommand(sqlLanche, conexao);
				cmdlanche.Parameters.AddWithValue("@NOME", lanches.Nome);
				cmdlanche.Parameters.AddWithValue("@PRECO", lanches.Preco);

				lancheId = Convert.ToInt32(cmdlanche.ExecuteScalar());

				// INSERT NA TABELA LANCHE/INGREDIENTE
				string sqlLancheIngrediente = @"INSERT INTO TB_LANCHES_INGREDIENTES(ID_LANCHE, ID_INGREDIENTE)
												VALUES(@ID_LANCHE, @ID_INGREDIENTE)";

				foreach (var ingrediente in lanches.Ingredientes)
				{
					MySqlCommand cmdingrediente = new MySqlCommand(sqlLancheIngrediente, conexao);
					cmdingrediente.Parameters.AddWithValue("@ID_LANCHE", lancheId);
					cmdingrediente.Parameters.AddWithValue("@ID_INGREDIENTE", ingrediente.Id);

					conexao.Open();
					cmdingrediente.ExecuteNonQuery();

					MessageBox.Show("Lanche cadastrado com sucesso!");
					conexao.Close();
				}
				
			}
			catch (Exception error)
			{

				MessageBox.Show("Erro ao tentar cadastrar: " + error); ;
			}
		}

		#endregion
	}
}
