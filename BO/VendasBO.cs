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
	public class VendasBO
	{
		private VendasDAO vendasDAO = new VendasDAO();

		public bool SalvarVendas(int idLanche, double valorTotal, DateTime dataVenda, List<int> ingredientes)
		{
			return vendasDAO.CadastrarVenda(idLanche, valorTotal, dataVenda, ingredientes);
		}

		public DataTable BuscarVendasPorPeriodo(DateTime dataInicio, DateTime dataFim)
		{
			try
			{
				if (dataInicio > dataFim)
					throw new ArgumentException("A data de início não pode ser maior que a data de fim.");

				return vendasDAO.BuscarVendasPorPeriodo(dataInicio, dataFim);
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar vendas por período: " + error.Message);
				return null;
			}
		}

		public List<Tuple<string, int>> BuscarLancheMaisVendido()
		{
			try
			{
				return vendasDAO.BuscarLancheMaisVendido();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar lanches mais vendidos: " + error.Message);
				return null;
			}
		}

		public List<Tuple<string, int>> BuscarIngredientesMaisUtilizados()
		{
			try
			{
				return vendasDAO.BuscarIngredientesMaisUtilizados();
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar ingredientes mais utilizados: " + error.Message);
				return null;
			}
		}
	}
}
