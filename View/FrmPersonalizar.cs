using Sistema_de_Lanchonete.BO;
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
using System.Globalization;

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmPersonalizar : Form
	{
		public List<Ingredientes> IngredientesSelecionados { get; private set; }
		private List<Ingredientes> todosIngredientes;

		public FrmPersonalizar(Lanches lanche, List<Ingredientes> ingredientes)
		{
			Initialize();

			IngredientesSelecionados = ingredientes;
			var ingredientesBO = new IngredientesBO();
			todosIngredientes = ingredientesBO.ListarIngredientes();

			listBoxIngredientes.Items.AddRange(todosIngredientes.Select(i => i.Id + "- " + i.Nome + "- R$ " + i.Preco.ToString("F2")).ToArray());

			MarcarIngredientesSelecionados();
		}

		private void MarcarIngredientesSelecionados()
		{
			for (int i = 0; i < todosIngredientes.Count; i++)
			{
				if (IngredientesSelecionados.Any(sel => sel.Id == todosIngredientes[i].Id))
				{
					listBoxIngredientes.SetItemChecked(i, true);
				}
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			double precoTotalIngredientes = 0;

			// Limpar a lista de ingredientes selecionados
			IngredientesSelecionados.Clear();

			// Adicionar os ingredientes selecionados à lista
			for (int a = 0; a < listBoxIngredientes.CheckedItems.Count; a++)
			{
				var valueTable = listBoxIngredientes.CheckedItems[a].ToString();
				int firstHyphenIndex = valueTable.IndexOf('-');
				int secondHyphenIndex = valueTable.IndexOf('-', firstHyphenIndex + 1);

				if (secondHyphenIndex >= 0)
				{

					var id = Convert.ToInt32(valueTable.Substring(0, firstHyphenIndex).Trim());
					var nome = valueTable.Substring(firstHyphenIndex + 1, secondHyphenIndex - firstHyphenIndex - 1).Trim();
					var precoString = valueTable.Substring(secondHyphenIndex + 1).Trim();
					precoString = precoString.Replace("R$", "").Trim();
					precoString = precoString.Replace(",", ".");
					var precoIngrediente = Convert.ToDouble(precoString, CultureInfo.InvariantCulture);
					var ingrediente = new Ingredientes(id, nome, precoIngrediente);

					IngredientesSelecionados.Add(ingrediente);

					precoTotalIngredientes += ingrediente.Preco;
				}
			}

			DialogResult = DialogResult.OK;
			Close();

		}

		private CheckedListBox listBoxIngredientes;
		private Button btnSalvar;

		private void Initialize()
		{
			this.listBoxIngredientes = new CheckedListBox();
			this.btnSalvar = new Button();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;

			// Configurações do CheckedListBox
			this.listBoxIngredientes.CheckOnClick = true;
			this.listBoxIngredientes.FormattingEnabled = true;
			this.listBoxIngredientes.Location = new System.Drawing.Point(20, 40);
			this.listBoxIngredientes.Size = new System.Drawing.Size(250, 150);
			this.Controls.Add(this.listBoxIngredientes);
		
			// Configurações do Button "Salvar"
			this.btnSalvar.Location = new System.Drawing.Point(20, 210);
			this.btnSalvar.Size = new System.Drawing.Size(100, 30);
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.Click += new EventHandler(this.btnSalvar_Click);
			this.Controls.Add(this.btnSalvar);
		
			// Configurações do Formulário
			this.ClientSize = new System.Drawing.Size(300, 250);
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Personalizar Lanche";
		}
	}
}