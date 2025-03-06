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
			if (!double.TryParse(txtpreco.Text, out double preco))
			{
				MessageBox.Show("Preço inválido.");
				return;
			}
			ingredientes.Preco = preco;

			IngredientesBO ingredientesBO = new IngredientesBO();

			if(ingredientesBO.IngredienteExiste(ingredientes))
			{
				MessageBox.Show("Esse ingrediente já esta cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			ingredientesBO.CadastrarIngredientes(ingredientes);

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void FrmIngredientes_Load(object sender, EventArgs e)
		{
			IngredientesBO ingredientesBO = new IngredientesBO();

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();
		}

		private void dataGridIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtcod.Text = dataGridIngredientes.CurrentRow.Cells[0].Value.ToString();
			txtnome.Text = dataGridIngredientes.CurrentRow.Cells[1].Value.ToString();
			txtpreco.Text = dataGridIngredientes.CurrentRow.Cells[2].Value.ToString();

			tabCadastroIngredientes.SelectedTab = tabIngredientes;
		}

		private void btnexcluir_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();

			if (!ChecandoCampos())
				return;

			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();

			ingredientesBO.ExcluirIngredientes(ingredientes);

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			Ingredientes ingredientes = new Ingredientes();

			if (!ChecandoCampos())
				return;

			ingredientes.Nome = txtnome.Text;
			if (!double.TryParse(txtpreco.Text, out double preco))
			{
				MessageBox.Show("Preço inválido.");
				return;
			}
			ingredientes.Preco = preco;
			ingredientes.Id = int.Parse(txtcod.Text);

			IngredientesBO ingredientesBO = new IngredientesBO();
			ingredientesBO.AlterarIngredientes(ingredientes);

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();

			new Helpers().LimparTela(this);
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{
			string nome = txtpesquisa.Text;

			IngredientesBO ingredientesBO = new IngredientesBO();

			if (string.IsNullOrEmpty(txtpesquisa.Text))
			{
				dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();
				return;
			}

			dataGridIngredientes.DataSource = ingredientesBO.BuscarIngredientePorNome(nome);

			if(dataGridIngredientes.Rows.Count == 0)
			{
				dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientes();
			}

		}

		private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{

			IngredientesBO ingredientesBO = new IngredientesBO();

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientePorNome(txtpesquisa.Text);

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