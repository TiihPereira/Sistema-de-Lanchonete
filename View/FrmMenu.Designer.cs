namespace Sistema_de_Lanchonete.View
{
	partial class FrmMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuLanches = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCadastroLanches = new System.Windows.Forms.ToolStripMenuItem();
			this.menuConsultaLanches = new System.Windows.Forms.ToolStripMenuItem();
			this.menuIngredientes = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCadastroIngredientes = new System.Windows.Forms.ToolStripMenuItem();
			this.menuConsultaIngredientes = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCardapio = new System.Windows.Forms.ToolStripMenuItem();
			this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
			this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanches,
            this.menuIngredientes,
            this.menuCardapio,
            this.menuVendas,
            this.menuConfiguracoes});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(714, 72);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuLanches
			// 
			this.menuLanches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menuLanches.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroLanches,
            this.menuConsultaLanches});
			this.menuLanches.Image = global::Sistema_de_Lanchonete.Properties.Resources.lanches_64px;
			this.menuLanches.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuLanches.Name = "menuLanches";
			this.menuLanches.Size = new System.Drawing.Size(126, 68);
			this.menuLanches.Text = "Lanches";
			// 
			// menuCadastroLanches
			// 
			this.menuCadastroLanches.Name = "menuCadastroLanches";
			this.menuCadastroLanches.Size = new System.Drawing.Size(183, 22);
			this.menuCadastroLanches.Text = "Cadastro de Lanches";
			this.menuCadastroLanches.Click += new System.EventHandler(this.menuCadastroLanches_Click);
			// 
			// menuConsultaLanches
			// 
			this.menuConsultaLanches.Name = "menuConsultaLanches";
			this.menuConsultaLanches.Size = new System.Drawing.Size(183, 22);
			this.menuConsultaLanches.Text = "Consulta de Lanches";
			this.menuConsultaLanches.Click += new System.EventHandler(this.menuConsultaLanches_Click);
			// 
			// menuIngredientes
			// 
			this.menuIngredientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroIngredientes,
            this.menuConsultaIngredientes});
			this.menuIngredientes.Image = global::Sistema_de_Lanchonete.Properties.Resources.ingredientes_64px;
			this.menuIngredientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuIngredientes.Name = "menuIngredientes";
			this.menuIngredientes.Size = new System.Drawing.Size(148, 68);
			this.menuIngredientes.Text = "Ingredientes";
			// 
			// menuCadastroIngredientes
			// 
			this.menuCadastroIngredientes.Name = "menuCadastroIngredientes";
			this.menuCadastroIngredientes.Size = new System.Drawing.Size(205, 22);
			this.menuCadastroIngredientes.Text = "Cadastro de Ingredientes";
			this.menuCadastroIngredientes.Click += new System.EventHandler(this.menuCadastroIngredientes_Click);
			// 
			// menuConsultaIngredientes
			// 
			this.menuConsultaIngredientes.Name = "menuConsultaIngredientes";
			this.menuConsultaIngredientes.Size = new System.Drawing.Size(205, 22);
			this.menuConsultaIngredientes.Text = "Consulta de Ingredientes";
			this.menuConsultaIngredientes.Click += new System.EventHandler(this.menuConsultaIngredientes_Click);
			// 
			// menuCardapio
			// 
			this.menuCardapio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardápioToolStripMenuItem});
			this.menuCardapio.Image = global::Sistema_de_Lanchonete.Properties.Resources.cardapio_64px;
			this.menuCardapio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuCardapio.Name = "menuCardapio";
			this.menuCardapio.Size = new System.Drawing.Size(131, 68);
			this.menuCardapio.Text = "Cardápio";
			// 
			// cardápioToolStripMenuItem
			// 
			this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
			this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cardápioToolStripMenuItem.Text = "Cardápio";
			this.cardápioToolStripMenuItem.Click += new System.EventHandler(this.cardápioToolStripMenuItem_Click);
			// 
			// menuVendas
			// 
			this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHistoricoVenda});
			this.menuVendas.Image = global::Sistema_de_Lanchonete.Properties.Resources.vendas_64px;
			this.menuVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuVendas.Name = "menuVendas";
			this.menuVendas.Size = new System.Drawing.Size(120, 68);
			this.menuVendas.Text = "Vendas";
			// 
			// menuHistoricoVenda
			// 
			this.menuHistoricoVenda.Name = "menuHistoricoVenda";
			this.menuHistoricoVenda.Size = new System.Drawing.Size(180, 22);
			this.menuHistoricoVenda.Text = "Histórico de Vendas";
			this.menuHistoricoVenda.Click += new System.EventHandler(this.menuHistoricoVenda_Click);
			// 
			// menuConfiguracoes
			// 
			this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocarUsuario,
            this.menuSair});
			this.menuConfiguracoes.Image = global::Sistema_de_Lanchonete.Properties.Resources.configuracoes_64px;
			this.menuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuConfiguracoes.Name = "menuConfiguracoes";
			this.menuConfiguracoes.Size = new System.Drawing.Size(160, 68);
			this.menuConfiguracoes.Text = "Configurações";
			// 
			// menuTrocarUsuario
			// 
			this.menuTrocarUsuario.Name = "menuTrocarUsuario";
			this.menuTrocarUsuario.Size = new System.Drawing.Size(180, 22);
			this.menuTrocarUsuario.Text = "Trocar de Usuário";
			this.menuTrocarUsuario.Click += new System.EventHandler(this.menuTrocarUsuario_Click);
			// 
			// menuSair
			// 
			this.menuSair.Name = "menuSair";
			this.menuSair.Size = new System.Drawing.Size(180, 22);
			this.menuSair.Text = "Sair";
			this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
			this.statusStrip1.Location = new System.Drawing.Point(0, 589);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(714, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
			this.toolStripStatusLabel1.Text = "Data:";
			// 
			// txtdata
			// 
			this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdata.Name = "txtdata";
			this.txtdata.Size = new System.Drawing.Size(73, 17);
			this.txtdata.Text = "01/03/2025";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
			this.toolStripStatusLabel3.Text = "Hora:";
			// 
			// txthora
			// 
			this.txthora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txthora.Name = "txthora";
			this.txthora.Size = new System.Drawing.Size(38, 17);
			this.txthora.Text = "22:00";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
			this.toolStripStatusLabel5.Text = "Usuário Logado:";
			// 
			// txtusuario
			// 
			this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(62, 17);
			this.txtusuario.Text = "Thiaguera";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sistema_de_Lanchonete.Properties.Resources.backgroud;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(714, 611);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu - Bala Artesanais";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuTrocarUsuario;
		private System.Windows.Forms.ToolStripMenuItem menuSair;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		public System.Windows.Forms.ToolStripMenuItem menuLanches;
		public System.Windows.Forms.ToolStripMenuItem menuIngredientes;
		public System.Windows.Forms.ToolStripMenuItem menuCardapio;
		public System.Windows.Forms.ToolStripMenuItem menuVendas;
		public System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
		public System.Windows.Forms.ToolStripMenuItem menuCadastroLanches;
		public System.Windows.Forms.ToolStripMenuItem menuConsultaLanches;
		public System.Windows.Forms.ToolStripMenuItem menuCadastroIngredientes;
		public System.Windows.Forms.ToolStripMenuItem menuConsultaIngredientes;
		public System.Windows.Forms.ToolStripMenuItem menuHistoricoVenda;
		public System.Windows.Forms.ToolStripStatusLabel txtdata;
		public System.Windows.Forms.ToolStripStatusLabel txthora;
		public System.Windows.Forms.ToolStripStatusLabel txtusuario;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
	}
}