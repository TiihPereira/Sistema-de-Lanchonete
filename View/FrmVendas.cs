using Sistema_de_Lanchonete.BO;
using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmVendas : Form
	{

		private VendasBO vendasBO = new VendasBO();

		public FrmVendas()
		{
			InitializeComponent();
		}

		private void FrmVendas_Load(object sender, EventArgs e)
		{
			PreencherLanchesMaisVendidos();
			PreencherIngredientesMaisUtilizados();
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime dataInicio = dtpDataInicio.Value.Date;
				DateTime dataFim = dtpDataFim.Value.Date;

				DataTable vendasDataTable = vendasBO.BuscarVendasPorPeriodo(dataInicio, dataFim);

				if (vendasDataTable.Rows.Count > 0)
				{
					dataGridVendas.DataSource = vendasDataTable;
				}
				else
				{
					MessageBox.Show("Nenhuma venda encontrada para o período selecionado.");
				}
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao buscar vendas: " + error.Message);
			}
		}

		private void PreencherLanchesMaisVendidos()
		{
			try
			{
				var lanchesMaisVendidos = vendasBO.BuscarLancheMaisVendido();

				var dtLanches = new DataTable();
				dtLanches.Columns.Add("Lanche");
				dtLanches.Columns.Add("Quantidade");

				foreach (var lanche in lanchesMaisVendidos)
				{
					dtLanches.Rows.Add(lanche.Item1, lanche.Item2);
				}

				dataGridLanchesVendidos.DataSource = dtLanches;
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao carregar lanches mais vendidos: " + error.Message);
			}
		}

		private void PreencherIngredientesMaisUtilizados()
		{
			try
			{
				var ingredientesMaisUtilizados = vendasBO.BuscarIngredientesMaisUtilizados();

				var dtIngredientes = new DataTable();
				dtIngredientes.Columns.Add("Ingrediente");
				dtIngredientes.Columns.Add("Quantidade");

				foreach (var ingrediente in ingredientesMaisUtilizados)
				{
					dtIngredientes.Rows.Add(ingrediente.Item1, ingrediente.Item2);
				}

				dataGridIngredientesUsados.DataSource = dtIngredientes;
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao carregar ingredientes mais utilizados: " + error.Message);
			}
		}
	}
}
