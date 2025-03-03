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

			if (!ChecandoCampos())
				return;

			ingredientes.Nome = txtnome.Text;
			ingredientes.Preco = double.Parse(txtpreco.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();

			if(ingredientesBO.IngredienteExiste(ingredientes))
			{
				MessageBox.Show("Esse ingrediente já esta cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ingredientesBO.cadastrarIngredientes(ingredientes);

			DataGridIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void FrmIngredientes_Load(object sender, EventArgs e)
		{
			IngredientesBO ingredientesBO = new IngredientesBO();

			DataGridIngredientes.DataSource = ingredientesBO.listarIngredientes();
		}

		private void tabelaIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtcod.Text = DataGridIngredientes.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = DataGridIngredientes.CurrentRow.Cells[1].Value.ToString();
			txtpreco.Text = DataGridIngredientes.CurrentRow.Cells[2].Value.ToString();

			tabIngredientes.SelectedTab = tabPage1;
		}

		private void btnexcluir_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();

			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();

			ingredientesBO.excluirIngredientes(ingredientes);

			DataGridIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();

			if (!ChecandoCampos())
				return;

			ingredientes.Nome = txtnome.Text;
			ingredientes.Preco = double.Parse(txtpreco.Text);
			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();
			ingredientesBO.alterarIngredientes(ingredientes);

			DataGridIngredientes.DataSource = ingredientesBO.listarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{
			string nome = txtpesquisa.Text;

			IngredientesBO ingredientesBO = new IngredientesBO();

			DataGridIngredientes.DataSource = ingredientesBO.buscarIngredientePorNome(nome);

			if(DataGridIngredientes.Rows.Count == 0)
			{
				DataGridIngredientes.DataSource = ingredientesBO.listarIngredientes();
			}

		}

		private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{

			IngredientesBO ingredientesBO = new IngredientesBO();

			DataGridIngredientes.DataSource = ingredientesBO.listarIngredientePorNome(txtpesquisa.Text);

		}

		private bool ChecandoCampos()
		{
			if (string.IsNullOrEmpty(txtnome.Text))
			{
				MessageBox.Show("O campo nome é obrigatório");
				return false;
			}
			if (string.IsNullOrEmpty(txtpreco.Text))
			{
				MessageBox.Show("O campo preço é obrigatório");
				return false;
			}
			if (!double.TryParse(txtpreco.Text, out _))
			{
				MessageBox.Show("O campo preço precisa ser numérico");
				return false;
			}

			return true;
		}
	}
}