using Sistema_de_Lanchonete.BO;
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

			dataGridIngridientes.DataSource = ingredientesBO.listarIngredientes();
		}

		private void btnsalvar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("FAZ O L");
			try
			{
				Ingredientes ingredientes = new Ingredientes();
				Lanches lanche = new Lanches();
				bool temIngredientes = false;

				if (!ChecandoCampos())
					return;

				lanche.Nome = txtnome.Text.Trim();

				//AQUI PERCORRO TODOS OS CAMPOS DA GRID
				for (Int32 i = 0; i < dataGridIngridientes.Rows.Count; i++)
				{
					//VERIFICO QUAL ESTA SELECIONADO
					if (dataGridIngridientes.Rows[i].Cells[0].Value != null && dataGridIngridientes.Rows[i].Cells[0].Value.ToString() == "True")
					{
						Lanches lanchesAux = new Lanches();

						//VOU CRIAR UM NOVO OBJETO COM AS INFORMAÇÕES SELECIONADAS
						ingredientes.Id = Convert.ToInt32(dataGridIngridientes.Rows[i].Cells[1].Value.ToString());// coluna 3
																												   //ingredientes.Nome = DaataGridIngredientes.Rows[i].Cells[2].Value.ToString();// caso precise do nome
																												   //ingredientes.Preco = Convert.ToDouble(DaataGridIngredientes.Rows[i].Cells[1].Value.ToString());// caso precise do preço

						temIngredientes = true;
						//lanche.Ingredientes.Add(ingredientes);
						lanchesBO.cadastrarLanche(lanche);
					}
				}

				if (!temIngredientes)
				{
					MessageBox.Show("Desculpe, é necessário selecionar algum ingrediente");
					return;
				}

				lanchesBO.cadastrarLanche(lanche);
			}
			catch (Exception error)
			{
				MessageBox.Show("Ocorreu um erro ao cadastrar: " + error.Message);
			}
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
			MessageBox.Show("FAZ O L");
			try
			{
				Ingredientes ingredientes = new Ingredientes();
				Lanches lanche = new Lanches();
				bool temIngredientes = false;

				if (!ChecandoCampos())
					return;

				lanche.Nome = txtnome.Text.Trim();

				//AQUI PERCORRO TODOS OS CAMPOS DA GRID
				for (Int32 i = 0; i < dataGridIngridientes.Rows.Count; i++)
				{
					//VERIFICO QUAL ESTA SELECIONADO
					if (dataGridIngridientes.Rows[i].Cells[0].Value != null && dataGridIngridientes.Rows[i].Cells[0].Value.ToString() == "True")
					{
						Lanches lanchesAux = new Lanches();

						//VOU CRIAR UM NOVO OBJETO COM AS INFORMAÇÕES SELECIONADAS
						ingredientes.Id = Convert.ToInt32(dataGridIngridientes.Rows[i].Cells[1].Value.ToString());// coluna 3
																												  //ingredientes.Nome = DaataGridIngredientes.Rows[i].Cells[2].Value.ToString();// caso precise do nome
																												  //ingredientes.Preco = Convert.ToDouble(DaataGridIngredientes.Rows[i].Cells[1].Value.ToString());// caso precise do preço

						temIngredientes = true;
						//lanche.Ingredientes.Add(ingredientes);
						lanchesBO.cadastrarLanche(lanche);
					}
				}

				if (!temIngredientes)
				{
					MessageBox.Show("Desculpe, é necessário selecionar algum ingrediente");
					return;
				}

				lanchesBO.cadastrarLanche(lanche);
			}
			catch (Exception error)
			{
				MessageBox.Show("Ocorreu um erro ao cadastrar: " + error.Message);
			}
		}
	}
}
