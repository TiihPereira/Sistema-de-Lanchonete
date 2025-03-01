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

		public void cadastrarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.cadastrarIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}
		}

		public void alterarIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.alterarIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar alterar: " + error);
			}
		}

		public DataTable listarIngredientes()
		{
			try
			{
				return ingredientesDAO.listarIngredientes();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error);
				return null;
			}

		}

		public void excluirIngredientes(Ingredientes ingredientes)
		{
			try
			{
				ingredientesDAO.excluirIngredientes(ingredientes);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar excluir: " + error);
			}
		}

		public void buscarIngredientePorNome(string nome)
		{
			try
			{
				ingredientesDAO.BuscarIngredientePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar buscar: " + error);
			}
		}

		public void listarIngredientePorNome(string nome)
		{
			try
			{
				ingredientesDAO.ListarIngredientePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error);
			}
		}
	}
}
