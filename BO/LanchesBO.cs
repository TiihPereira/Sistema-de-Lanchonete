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
				//aqui vai ter que inserir o lanche e com o ID vai ter que inserir na tabela de lanche e igrediente, tem que percorrer a lista de ingrediente da classe Lanche
				lanchesDAO.cadastrarLanches(lanche);
				return;
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar cadastrar: " + error);
			}
		}
	}
}
