using Sistema_de_Lanchonete.BO;
using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmIngredientes : Form
	{
		public FrmIngredientes()
		{
			InitializeComponent();
		}

		private void btnsalvar_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();
			ingredientes.Nome = txtnome.Text;
			ingredientes.Preco = double.Parse(txtpreco.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();
			ingredientesBO.cadastrarIngredientes(ingredientes);

			tabelaIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void FrmIngredientes_Load(object sender, EventArgs e)
		{
			IngredientesBO ingredientesBO = new IngredientesBO();

			tabelaIngredientes.DataSource = ingredientesBO.listarIngredientes();
		}

		private void tabelaIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtcod.Text = tabelaIngredientes.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = tabelaIngredientes.CurrentRow.Cells[1].Value.ToString();
			txtpreco.Text = tabelaIngredientes.CurrentRow.Cells[2].Value.ToString();

			tabIngredientes.SelectedTab = tabPage1;
		}

		private void btnexcluir_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();

			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();

			ingredientesBO.excluirIngredientes(ingredientes);

			tabelaIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();
			ingredientes.Nome = txtnome.Text;
			ingredientes.Preco = double.Parse(txtpreco.Text);
			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();
			ingredientesBO.alterarIngredientes(ingredientes);

			tabelaIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{
			string nome = txtpesquisa.Text;

			IngredientesBO ingredientesBO = new IngredientesBO();

			tabelaIngredientes.DataSource = ingredientesBO.buscarIngredientePorNome(nome);

			if(tabelaIngredientes.Rows.Count == 0)
			{
				tabelaIngredientes.DataSource = ingredientesBO.listarIngredientes();
			}

		}

		private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			string nome = "%" + txtpesquisa.Text + "%";

			IngredientesBO ingredientesBO = new IngredientesBO();

			tabelaIngredientes.DataSource = ingredientesBO.listarIngredientePorNome(nome);

		}
	}
}