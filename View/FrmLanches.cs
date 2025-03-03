using Sistema_de_Lanchonete.BO;
using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmLanches : Form
	{
		LanchesBO lanchesBO = new LanchesBO();
		public FrmLanches()
		{
			InitializeComponent();
			IngredientesBO ingredientesBO = new IngredientesBO();
			txtpreco.ReadOnly = true;

			dataGridIngridientes.DataSource = ingredientesBO.listarIngredientes();
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
				MessageBox.Show("O campo preço precisa numerico");
				return false;
			}

			return true;
		}

		private void dataGridIngridientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridIngridientes.Columns["Selecionar"].Index)
			{
				AtualizarTotal();
			}

		}

		private void AtualizarTotal()
		{
			Lanches lanche = new Lanches();

			decimal total = 0;

			foreach (DataGridViewRow row in dataGridIngridientes.Rows)
			{
				bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
				if (selecionado)
				{
					decimal preco = Convert.ToDecimal(row.Cells["Preco"].Value);
					total += preco;
				}
			}

			txtpreco.Text = total.ToString("F2");
		}

		private void dataGridIngridientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dataGridIngridientes.CurrentCell is DataGridViewCheckBoxCell)
			{
				dataGridIngridientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void btnsalvar_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool temIngredientes = false;

				if (!ChecandoCampos())
					return;

				Lanches lanche = new Lanches();
				lanche.Nome = txtnome.Text;
				lanche.Preco = Double.Parse(txtpreco.Text);

				// Adicionar os ingredientes selecionados
				foreach (DataGridViewRow row in dataGridIngridientes.Rows)
				{
					bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
					if (selecionado)
					{
						temIngredientes = true;
						Ingredientes ingrediente = new Ingredientes();
						ingrediente.Id = Convert.ToInt32(row.Cells["ID"].Value);
						lanche.Ingredientes.Add(ingrediente);
					}
				}
				if (temIngredientes)
				{
					LanchesBO bo = new LanchesBO();
					bo.cadastrarLanche(lanche);
				}
				else
				{
					MessageBox.Show("Desculpe, é necessário selecionar algum ingrediente");
				}

			}
			catch (Exception error)
			{
				MessageBox.Show("Ocorreu um erro ao cadastrar: " + error.Message);
			}

			dataGridLanches.DataSource = lanchesBO.listarLanches();
			new Helpers().LimparTela(this);
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{
			string nome = txtpesquisa.Text;

			LanchesBO lanchesBO = new LanchesBO();

			dataGridLanches.DataSource = lanchesBO.buscarLanchePorNome(nome);

			if (dataGridLanches.Rows.Count == 0)
			{
				dataGridLanches.DataSource = lanchesBO.buscarLanchePorNome(nome);
			}

			new Helpers().LimparTela(this);
		}

		private void FrmLanches_Load(object sender, EventArgs e)
		{
			LanchesBO lanchesBO = new LanchesBO();

			dataGridLanches.DataSource = lanchesBO.listarLanches();
		}

		private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			LanchesBO lanchesBO = new LanchesBO();

			dataGridLanches.DataSource = lanchesBO.listarLanchePorNome(txtpesquisa.Text);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			try
			{
				Lanches lanche = new Lanches();
				lanche.Nome = txtnome.Text;
				lanche.Preco = double.Parse(txtpreco.Text);

				lanche.Ingredientes = new List<Ingredientes>();

				foreach (DataGridViewRow row in dataGridIngridientes.Rows)
				{
					bool selecionado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
					if (selecionado)
					{
						Ingredientes ingrediente = new Ingredientes();
						ingrediente.Id = Convert.ToInt32(row.Cells["ID"].Value);
						lanche.Ingredientes.Add(ingrediente);
					}
				}

				LanchesBO lanchesbo = new LanchesBO();
				lanchesbo.alterarLancheComIngredientes(lanche);

				dataGridLanches.DataSource = bo.listarLanches();
				new Helpers().LimparTela(this);

				MessageBox.Show("Lanche alterado com sucesso!");
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro ao alterar lanche: " + erro.Message);
			}
		}

		private void btnexcluir_Click(object sender, EventArgs e)
		{
			Lanches lanches = new Lanches();

			lanches.Nome = txtnome.Text;

			LanchesBO lanchesBO = new LanchesBO();

			lanchesBO.excluirLanches(lanches);

			dataGridLanches.DataSource = lanchesBO.listarLanches();

			new Helpers().LimparTela(this);
		}

		private void dataGridLanches_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtnome.Text = dataGridLanches.CurrentRow.Cells[1].Value.ToString();
			txtpreco.Text = dataGridLanches.CurrentRow.Cells[2].Value.ToString();

			tabLanches.SelectedTab = tabPage1;

			CarregarIngredientesComSelecionados(idLanche);
		}

		private void CarregarIngredientesComSelecionados(int idLanche)
		{
			LanchesBO lanchesbo = new LanchesBO();
			List<Ingredientes> todosIngredientes = lanchesbo.listarLanches();
			List<int> idsIngredientesDoLanche = lanchesbo.buscarIngredientesDoLanche(idLanche);

			dataGridIngridientes.Rows.Clear();

			foreach (var ingrediente in todosIngredientes)
			{
				bool selecionado = idsIngredientesDoLanche.Contains(ingrediente.Id);
				dataGridIngridientes.Rows.Add(selecionado, ingrediente.Id, ingrediente.Nome, ingrediente.Preco);
			}
		}
	}
}
