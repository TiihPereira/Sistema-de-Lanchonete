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
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void FrmMenu_Load(object sender, EventArgs e)
		{
			txtdata.Text = DateTime.Now.ToShortDateString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			txthora.Text = DateTime.Now.ToLongTimeString();
		}

		private void menuSair_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Você deseja sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
			
		}
		private void menuTrocarUsuario_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmLogin login = new FrmLogin();
			login.ShowDialog();
		}

		private void menuCadastroLanches_Click(object sender, EventArgs e)
		{
			FrmLanches frmLanches = new FrmLanches();
			frmLanches.ShowDialog();
		}

		private void menuConsultaLanches_Click(object sender, EventArgs e)
		{
			FrmLanches frmLanches = new FrmLanches();
			frmLanches.tabCadastroLanches.SelectedTab = frmLanches.tabLanchesConsulta;
			frmLanches.ShowDialog();
		}

		private void menuCadastroIngredientes_Click(object sender, EventArgs e)
		{
			FrmIngredientes frmingredientes = new FrmIngredientes();
			frmingredientes.ShowDialog();
		}

		private void menuConsultaIngredientes_Click(object sender, EventArgs e)
		{
			FrmIngredientes frmingredientes = new FrmIngredientes();
			frmingredientes.tabCadastroIngredientes.SelectedTab = frmingredientes.tabIngredientesConsulta;
			frmingredientes.ShowDialog();
		}

		private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmCardapio frmCardapio = new FrmCardapio();
			frmCardapio.ShowDialog();
		}

		private void menuHistoricoVenda_Click(object sender, EventArgs e)
		{
			FrmVendas frmVendas = new FrmVendas();
			frmVendas.ShowDialog();
		}
	}
}
