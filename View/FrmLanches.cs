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

			dataGridIngredientes.DataSource = ingredientesBO.ListarIngredientesDT();
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

		private void dataGridIngredientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataGridIngredientes.Columns["Selecionado"].Index)
			{
				AtualizarTotal();
			}

		}

		private void AtualizarTotal()
		{
			Lanches lanche = new Lanches();

			decimal total = 0;

			foreach (DataGridViewRow row in dataGridIngredientes.Rows)
			{
				bool selecionado = Convert.ToBoolean(row.Cells["Selecionado"].Value);
				if (selecionado)
				{
					decimal preco = Convert.ToDecimal(row.Cells["Preco"].Value);
					total += preco;
				}
			}

			txtpreco.Text = total.ToString("F2");
		}

		private void dataGridIngredientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dataGridIngredientes.CurrentCell is DataGridViewCheckBoxCell)
			{
				dataGridIngredientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
				lanche.Ingredientes = new List<Ingredientes>();
				lanche.Nome = txtnome.Text;
				if (!double.TryParse(txtpreco.Text, out double preco))
				{
					MessageBox.Show("Preço inválido.");
					return;
				}
				lanche.Preco = preco;

				foreach (DataGridViewRow row in dataGridIngredientes.Rows)
				{
					bool selecionado = Convert.ToBoolean(row.Cells["Selecionado"].Value);
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
					bo.CadastrarLanche(lanche);
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

			dataGridLanches.DataSource = lanchesBO.ListarLanches();
			new Helpers().LimparTela(this);
		}

		private void btnpesquisar_Click(object sender, EventArgs e)
		{

			string nome = txtpesquisa.Text;

			LanchesBO lanchesBO = new LanchesBO();

			if (string.IsNullOrEmpty(txtpesquisa.Text))
			{
				dataGridLanches.DataSource = lanchesBO.ListarLanches();
				return;
			}

			dataGridLanches.DataSource = lanchesBO.ListarLanchePorNome(nome);

			if (dataGridLanches.Rows.Count == 0)
			{
				dataGridLanches.DataSource = lanchesBO.ListarLanches();
			}

			new Helpers().LimparTela(this);
		}

		private void FrmLanches_Load(object sender, EventArgs e)
		{
			LanchesBO lanchesBO = new LanchesBO();

			dataGridLanches.DataSource = lanchesBO.ListarLanchesDT();
		}

		private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			LanchesBO lanchesBO = new LanchesBO();

			dataGridLanches.DataSource = lanchesBO.ListarLanchePorNome(txtpesquisa.Text);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			try
			{
				Lanches lanche = new Lanches
				{
					Nome = txtnome.Text,
					Preco = Convert.ToDouble(txtpreco.Text),
					Ingredientes = ObterIngredientesSelecionados()
				};

				LanchesBO bo = new LanchesBO();
				bo.AlterarLanche(lanche);

				MessageBox.Show("Lanche alterado com sucesso!");
			}
			catch (Exception error)
			{
				MessageBox.Show("Erro ao tentar alterar: " + error.Message);
			}

			new Helpers().LimparTela(this);
		}

		private void btnexcluir_Click(object sender, EventArgs e)
		{

			if (!ChecandoCampos())
				return;

			Lanches lanches = new Lanches();

			lanches.Nome = txtnome.Text;

			LanchesBO lanchesBO = new LanchesBO();

			lanchesBO.ExcluirLanches(lanches);

			dataGridLanches.DataSource = lanchesBO.ListarLanches();

			new Helpers().LimparTela(this);
		}

		private void dataGridLanches_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtnome.Text = dataGridLanches.CurrentRow.Cells[1].Value.ToString();
			txtpreco.Text = dataGridLanches.CurrentRow.Cells[2].Value.ToString();
			
			tabCadastroLanches.SelectedTab = tabLanches;
			int idLanche = Convert.ToInt32(dataGridLanches.CurrentRow.Cells[0].Value);
			
			CarregarIngredientesComSelecionados(idLanche);

		}

		private void CarregarIngredientesComSelecionados(int idLanche)
		{
			try
			{
				LanchesBO lanchesbo = new LanchesBO();
				List<Ingredientes> todosIngredientes = lanchesbo.ListarLanches();
				List<int> idsIngredientesDoLanche = lanchesbo.BuscarIngredientesDoLanchePorId(idLanche);
						
				foreach (var ingrediente in idsIngredientesDoLanche)
				{
					foreach (DataGridViewRow row in dataGridIngredientes.Rows)
					{

						if (idsIngredientesDoLanche.Contains(Convert.ToInt32(row.Cells[1].Value)))
						{
							row.Cells[0].Value = 1;
						}
					}
				}	
			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro ao carregar ingredientes: " + erro.Message);
			}
		}

		private List<Ingredientes> ObterIngredientesSelecionados()
		{
			var ingredientesSelecionados = new List<Ingredientes>();
			
			foreach (DataGridViewRow row in dataGridIngredientes.Rows)
			{
				bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
				if (isChecked)
				{
					int id = Convert.ToInt32(row.Cells[1].Value);
					string nome = row.Cells[2].Value.ToString();
			
					ingredientesSelecionados.Add(new Ingredientes
					{
						Id = id,
						Nome = nome
					});
				}
			}
			
			return ingredientesSelecionados;

		}
	}
}
