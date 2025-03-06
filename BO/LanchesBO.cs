﻿using MySql.Data.MySqlClient;
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

		public void CadastrarLanche(Lanches lanche)
		{
			try
			{
				lanchesDAO.CadastrarLanches(lanche);
				return;
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}
		}

		public void AlterarLanche(Lanches lanche)
		{
			if (string.IsNullOrWhiteSpace(lanche.Nome))
				throw new Exception("Nome do lanche é obrigatório.");

			if (lanche.Preco <= 0)
				throw new Exception("Preço deve ser maior que zero.");

			if (lanche.Ingredientes == null || lanche.Ingredientes.Count == 0)
				throw new Exception("Selecione pelo menos um ingrediente.");

			LanchesDAO service = new LanchesDAO();
			service.AlterarLanches(lanche);
		}

		public void ExcluirLanches(Lanches lanches)
		{
			try
			{
				lanchesDAO.ExcluirLanches(lanches);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar excluir: " + error);
			}
		}

		//public DataTable ListarLanches()
		//{
		//	try
		//	{
		//		return lanchesDAO.ListarLanches();
		//	}
		//	catch (Exception error)
		//	{
		//		MessageBox.Show("Erro ao tentar listar: " + error);
		//		return null;
		//	}
		//
		//}

		public DataTable ListarLanchePorNome(string nome)
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

		public DataTable BuscarLanchePorNome(string nome)
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

		public List<int> BuscarIngredientesDoLanche(int idLanche)
		{
			LanchesDAO dao = new LanchesDAO();
			return dao.BuscarIngredientesDoLanche(idLanche);
		}

		public List<Ingredientes> ListarLanches()
		{
			DataTable dt = lanchesDAO.ListarLanches();

			List<Ingredientes> listaIngredientes = new List<Ingredientes>();

			foreach (DataRow row in dt.Rows)
			{
				Ingredientes ingrediente = new Ingredientes
				{
					Id = Convert.ToInt32(row["Id"]),
					Nome = row["Nome"].ToString(),
					Preco = Convert.ToDouble(row["Preco"])
				};

				listaIngredientes.Add(ingrediente);
			}

			return listaIngredientes;
		}

	}
}