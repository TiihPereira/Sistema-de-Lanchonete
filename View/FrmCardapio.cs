using Sistema_de_Lanchonete.BO;
using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmCardapio : Form
	{
		private LanchesBO lanchesBO = new LanchesBO();
		private IngredientesBO ingredientesBO = new IngredientesBO();

		private List<Tuple<Lanches, List<Ingredientes>>> carrinho = new List<Tuple<Lanches, List<Ingredientes>>>();
		private FlowLayoutPanel painelLanches;
		private ListView listCarrinho;
		private Label lblTotal;
		private double totalPedido = 0;
		private double totalComDesconto = 0;

		public FrmCardapio()
		{
			InitializeComponent();
			CriarInterface();
			CarregarCardapio();
		}

		private void CriarInterface()
		{
			this.Text = "Cardápio - Bala Artesanais";
			this.Size = new Size(700, 600);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.BackColor = Color.White;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;

			Label titulo = new Label
			{
				Text = "🍔 Cardápio - Bala Artesanais",
				Font = new Font("Century Gothic", 24, FontStyle.Bold),
				ForeColor = Color.DarkBlue,
				AutoSize = true
			};
			Controls.Add(titulo);
			titulo.Location = new Point((ClientSize.Width - titulo.Width) / 2, 10);

			painelLanches = new FlowLayoutPanel
			{
				Size = new Size(650, 250),
				Location = new Point(25, 60),
				AutoScroll = true
			};
			Controls.Add(painelLanches);

			listCarrinho = new ListView
			{
				Size = new Size(650, 150),
				Location = new Point(25, 320),
				FullRowSelect = true,
				View = System.Windows.Forms.View.Details,
				GridLines = true
			};
			listCarrinho.Columns.Add("Lanche", 200);
			listCarrinho.Columns.Add("Ingredientes", 350);
			listCarrinho.Columns.Add("Preço", 100);
			listCarrinho.DoubleClick += PersonalizarLanche;

			var menuContexto = new ContextMenuStrip();
			menuContexto.Items.Add("❌ Remover", null, RemoverItemSelecionado);
			listCarrinho.ContextMenuStrip = menuContexto;
			listCarrinho.BorderStyle = BorderStyle.FixedSingle;
			listCarrinho.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listCarrinho.BackColor = Color.WhiteSmoke;
			listCarrinho.ForeColor = Color.DarkSlateGray;

			Controls.Add(listCarrinho);

			lblTotal = new Label
			{
				Text = "Total: R$ 0,00",
				Font = new Font("Century Gothic", 14, FontStyle.Bold),
				ForeColor = Color.DarkBlue,
				Location = new Point(25, 500),
				AutoSize = true
			};
			Controls.Add(lblTotal);

			Button btnFechar = new Button
			{
				Text = "Finalizar Pedido",
				Size = new Size(150, 40),
				Location = new Point(500, 500),
				BackColor = Color.DarkBlue,
				ForeColor = Color.White,
				FlatStyle = FlatStyle.Flat
			};
			btnFechar.Click += FinalizarPedido;
			Controls.Add(btnFechar);
		}

		private void CarregarCardapio()
		{
			var lanches = lanchesBO.BuscarTodosLanches();

			foreach (var lanche in lanches)
			{
				AdicionarLancheVisual(lanche);
			}
		}

		private void AdicionarLancheVisual(Lanches lanche)
		{
			Panel card = new Panel
			{
				Size = new Size(290, 100),
				BackColor = Color.WhiteSmoke,
				Margin = new Padding(10)
			};

			Label lblNome = new Label
			{
				Text = lanche.Nome,
				Font = new Font("Century Gothic", 14, FontStyle.Bold),
				Location = new Point(10, 10),
				AutoSize = true
			};

			Label lblPreco = new Label
			{
				Text = $"R$ {lanche.Preco:F2}",
				Location = new Point(10, 40),
				AutoSize = true
			};

			Button btnAdicionar = new Button
			{
				Text = "Adicionar",
				Location = new Point(200, 30),
				BackColor = Color.DarkBlue,
				ForeColor = Color.White,
				Tag = lanche
			};
			btnAdicionar.Click += AdicionarAoPedido;

			card.Controls.Add(lblNome);
			card.Controls.Add(lblPreco);
			card.Controls.Add(btnAdicionar);

			painelLanches.Controls.Add(card);
		}

		private void AdicionarAoPedido(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			var lanche = (Lanches)btn.Tag;

			var ingredientes = lanchesBO.BuscarIngredientesDoLanche(lanche.Id);

			carrinho.Add(Tuple.Create(lanche, ingredientes));
			AtualizarCarrinho();
		}

		private void AtualizarCarrinho()
		{
			listCarrinho.Items.Clear();
			totalPedido = 0;

			foreach (var (lanche, ingredientes) in carrinho)
			{
				var precoIngredientes = ingredientes.Sum(i => i.Preco);
				var precoTotal = precoIngredientes;

				var item = new ListViewItem(lanche.Nome);

				string detalhesIngredientes = ingredientes.Any()
					? string.Join(", ", ingredientes.Select(i => $"{i.Nome} (R$ {i.Preco:F2})"))
					: "Sem ingredientes adicionais";

				item.SubItems.Add(detalhesIngredientes);

				string precoDetalhado = $"R$ {precoTotal:F2}";
				item.SubItems.Add(precoDetalhado);
				item.Tag = Tuple.Create(lanche, ingredientes);

				listCarrinho.Items.Add(item);
				totalPedido += precoTotal;
			}

			double desconto = 0;
			int quantidadeLanches = carrinho.Count;

			if (quantidadeLanches == 2)
			{
				desconto = 0.03; // 3% de desconto
			}
			else if (quantidadeLanches >= 3 && quantidadeLanches < 5)
			{
				desconto = 0.05; // 5% de desconto
			}
			else if (quantidadeLanches >= 5)
			{
				desconto = 0.10; // 10% de desconto
			}

			double valorDesconto = totalPedido * desconto;
			totalComDesconto = totalPedido - valorDesconto;

			lblTotal.Text = $"Total: R$ {totalComDesconto:F2} (Desconto: R$ {valorDesconto:F2})";
		}

		private void PersonalizarLanche(object sender, EventArgs e)
		{
			if (listCarrinho.SelectedItems.Count == 0) return;

			var item = listCarrinho.SelectedItems[0];
			var (lanche, ingredientes) = (Tuple<Lanches, List<Ingredientes>>)item.Tag;

			var formPersonalizar = new FrmPersonalizar(lanche, ingredientes);
			if (formPersonalizar.ShowDialog() == DialogResult.OK)
			{
				var novoIngredientes = formPersonalizar.IngredientesSelecionados;

				var novoPreco = novoIngredientes.Sum(i => i.Preco);

				// Atualiza o carrinho com o novo lanche e ingredientes
				var index = carrinho.FindIndex(x => x.Item1.Id == lanche.Id);
				carrinho[index] = Tuple.Create(lanche, novoIngredientes);

				AtualizarCarrinho();
			}
		}

		private void RemoverItemDoCarrinho(int index)
		{
			if (index < 0 || index >= carrinho.Count)
				return;

			carrinho.RemoveAt(index);
			AtualizarCarrinho();
		}

		private void RemoverItemSelecionado(object sender, EventArgs e)
		{
			if (listCarrinho.SelectedItems.Count == 0)
			{
				MessageBox.Show("Selecione um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var itemSelecionado = listCarrinho.SelectedItems[0];
			var index = listCarrinho.Items.IndexOf(itemSelecionado);

			if (index >= 0)
			{
				var confirm = MessageBox.Show("Tem certeza que deseja remover este item do carrinho?",
											  "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirm == DialogResult.Yes)
				{
					RemoverItemDoCarrinho(index);
				}
			}
		}

		public List<string> ObterLanchesDoCarrinho()
		{
			List<string> lanches = new List<string>();

			foreach (ListViewItem item in listCarrinho.Items)
			{
				string nomeLanche = item.SubItems[0].Text;

				lanches.Add(nomeLanche);
			}

			return lanches;
		}

		private List<int> ObterIDLanchesSelecionados()
		{

			List<int> idsLanches = new List<int>();

			if (listCarrinho.Items.Count == 0)
			{
				throw new Exception("Nenhum lanche no carrinho!");
			}

			foreach (ListViewItem item in listCarrinho.Items)
			{
				var (lanche, _) = (Tuple<Lanches, List<Ingredientes>>)item.Tag;

				idsLanches.Add(lanche.Id);
			}

			return idsLanches;
		}

		private double CalcularValorTotal()
		{
			double total = 0;
			foreach (var (_, ingredientes) in carrinho)
			{
				total += ingredientes.Sum(i => i.Preco);
			}
			return total;
		}

		private List<int> ObterIngredientesSelecionados()
		{
			if (listCarrinho.Items.Count == 0)
			{
				throw new Exception("Nenhum lanche selecionado!");
			}

			var item = listCarrinho.Items[0];
			var (_, ingredientes) = (Tuple<Lanches, List<Ingredientes>>)item.Tag;
			return ingredientes.Select(i => i.Id).ToList();
		}

		public string ObterNomeLanchePeloID(int idLanche)
		{
			var lanche = lanchesBO.BuscarTodosLanches().FirstOrDefault(l => l.Id == idLanche);
			return lanche?.Nome ?? string.Empty;
		}

		public void SalvarPedido()
		{
			VendasBO vendasBO = new VendasBO();

			try
			{
				List<string> nomesLanches = ObterLanchesDoCarrinho();

				double valorTotal = CalcularValorTotal();

				DateTime dataVenda = DateTime.Now;

				List<int> ingredientesSelecionados = ObterIngredientesSelecionados();

				// Criar a lista de lanches com tuplas (idLanche, nomeLanche)
				List<(int idLanche, string nomeLanche)> lanches = new List<(int, string)>();

				// Obter todos os IDs dos lanches selecionados
				List<int> idsLanches = ObterIDLanchesSelecionados();

				// Preencher a lista de lanches com os nomes e IDs
				foreach (var idLanche in idsLanches)
				{
					string nomeLanche = nomesLanches.FirstOrDefault(n => n.Equals(ObterNomeLanchePeloID(idLanche)));
					lanches.Add((idLanche, nomeLanche));
				}

				// Criar a lista de ingredientes com tuplas (idLanche, idIngrediente)
				List<(int idLanche, int idIngrediente)> ingredientes = new List<(int, int)>();

				foreach (var idIngrediente in ingredientesSelecionados)
				{
					foreach (var lanche in lanches)
					{
						ingredientes.Add((lanche.idLanche, idIngrediente));
					}
				}

				bool sucesso = vendasBO.SalvarVendas(lanches, valorTotal, dataVenda, ingredientes);

				if (sucesso)
				{
					MessageBox.Show("Pedido salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Erro ao salvar pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void FinalizarPedido(object sender, EventArgs e)
		{
			if (carrinho.Count == 0)
			{
				MessageBox.Show("Seu carrinho está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SalvarPedido();

			MessageBox.Show($"Pedido finalizado!\nTotal: R$ {totalComDesconto:F2}", "Pedido Confirmado");

			listCarrinho.Items.Clear();
			carrinho.Clear();
			lblTotal.Text = "Total: R$ 0,00";
		}
	}
}