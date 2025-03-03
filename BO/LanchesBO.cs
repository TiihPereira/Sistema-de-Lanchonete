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
	public class LanchesBO
	{
		private LanchesDAO lanchesDAO = new LanchesDAO();

		public void cadastrarLanche(Lanches lanche)
		{
			try
			{
				lanchesDAO.cadastrarLanches(lanche);
				return;
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}
		}

		public DataTable buscarLanchePorNome(string nome)
		{
			try
			{
				return lanchesDAO.BuscarLanchePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar buscar: " + error);
				return null;
			}
		}

		public void excluirLanches(Lanches lanches)
		{
			try
			{
				lanchesDAO.excluirLanches(lanches);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar excluir: " + error);
			}
		}

		public DataTable listarLanchePorNome(string nome)
		{
			try
			{
				nome = "%" + nome + "%";
				return lanchesDAO.ListarLanchePorNome(nome);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error);
				return null;
			}
		}

		public DataTable listarLanches()
		{
			try
			{
				return lanchesDAO.listarLanches();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar listar: " + error);
				return null;
			}

		}

		public List<int> buscarIngredientesDoLanche(int idLanche)
		{
			LanchesDAO dao = new LanchesDAO();
			return dao.buscarIngredientesDoLanche(idLanche);
		}

		public void alterarLancheComIngredientes(Lanches lanche)
		{
			
		}
}