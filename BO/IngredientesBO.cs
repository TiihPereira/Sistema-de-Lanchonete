using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.BO
{
	public class IngredientesBO
	{
		private IngredientesDAO ingredientesDAO = new IngredientesDAO();

		public void CadastrarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.CadastrarIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error.Message);
			}
		}

		public void AlterarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.AlterarIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar alterar: " + error.Message);
			}
		}
		public void ExcluirIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.ExcluirIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar excluir: " + error.Message);
			}
		}

		public DataTable ListarIngredientesDT()
		{
			try
			{
				return ingredientesDAO.ListarIngredientesDT();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error.Message);
				return null;
			}

		}

		public List<Ingredientes> ListarIngredientes()
		{
			try
			{
				return ingredientesDAO.ListarIngredientes();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error.Message);
				return null;
			}

		}

		public DataTable BuscarIngredientePorNome(string nome)
		{
			try
			{
				return ingredientesDAO.BuscarIngredientePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar buscar: " + error.Message);
				return null;
			}
		}

		public DataTable ListarIngredientePorNome(string nome)
		{
			try
			{
				nome = "%" + nome + "%";
				return ingredientesDAO.ListarIngredientePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error.Message);
				return null;
			}
		}

		public bool IngredienteExiste(Ingredientes ingredientes)
		{
			return ingredientesDAO.IngredienteExiste(ingredientes);
		}

	}
}
