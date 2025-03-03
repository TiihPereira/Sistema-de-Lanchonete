using Sistema_de_Lanchonete.Model;

namespace Sistema_de_Lanchonete.View
{
	partial class FrmLanches
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabLanches = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnexcluir = new System.Windows.Forms.Button();
			this.btneditar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.dataGridIngridientes = new System.Windows.Forms.DataGridView();
			this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.txtpreco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridLanches = new System.Windows.Forms.DataGridView();
			this.btnpesquisar = new System.Windows.Forms.Button();
			this.txtpesquisa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel1.SuspendLayout();
			this.tabLanches.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngridientes)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanches)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(216, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Lanches";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 100);
			this.panel1.TabIndex = 2;
			// 
			// tabLanches
			// 
			this.tabLanches.Controls.Add(this.tabPage1);
			this.tabLanches.Controls.Add(this.tabPage2);
			this.tabLanches.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tabLanches.Location = new System.Drawing.Point(0, 106);
			this.tabLanches.Name = "tabLanches";
			this.tabLanches.SelectedIndex = 0;
			this.tabLanches.Size = new System.Drawing.Size(800, 343);
			this.tabLanches.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnexcluir);
			this.tabPage1.Controls.Add(this.btneditar);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.btnsalvar);
			this.tabPage1.Controls.Add(this.dataGridIngridientes);
			this.tabPage1.Controls.Add(this.txtpreco);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtnome);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 313);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Lanches";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnexcluir
			// 
			this.btnexcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnexcluir.ForeColor = System.Drawing.Color.White;
			this.btnexcluir.Location = new System.Drawing.Point(665, 34);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(103, 36);
			this.btnexcluir.TabIndex = 19;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = false;
			this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
			// 
			// btneditar
			// 
			this.btneditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btneditar.ForeColor = System.Drawing.Color.White;
			this.btneditar.Location = new System.Drawing.Point(526, 34);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(103, 36);
			this.btneditar.TabIndex = 18;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = false;
			this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(10, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 19);
			this.label2.TabIndex = 17;
			this.label2.Text = "Selecionar ingredientes:";
			// 
			// btnsalvar
			// 
			this.btnsalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnsalvar.ForeColor = System.Drawing.Color.White;
			this.btnsalvar.Location = new System.Drawing.Point(386, 34);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(103, 36);
			this.btnsalvar.TabIndex = 16;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = false;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click_1);
			// 
			// dataGridIngridientes
			// 
			this.dataGridIngridientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridIngridientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
			this.dataGridIngridientes.Location = new System.Drawing.Point(14, 107);
			this.dataGridIngridientes.Name = "dataGridIngridientes";
			this.dataGridIngridientes.Size = new System.Drawing.Size(768, 203);
			this.dataGridIngridientes.TabIndex = 15;
			this.dataGridIngridientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIngridientes_CellValueChanged);
			this.dataGridIngridientes.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridIngridientes_CurrentCellDirtyStateChanged);
			// 
			// Selecionar
			// 
			this.Selecionar.DataPropertyName = "Selecionar";
			this.Selecionar.HeaderText = "";
			this.Selecionar.Name = "Selecionar";
			// 
			// txtpreco
			// 
			this.txtpreco.Location = new System.Drawing.Point(78, 47);
			this.txtpreco.Name = "txtpreco";
			this.txtpreco.Size = new System.Drawing.Size(100, 23);
			this.txtpreco.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(10, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 19);
			this.label4.TabIndex = 14;
			this.label4.Text = "Preço:";
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(78, 11);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(260, 23);
			this.txtnome.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(10, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 13;
			this.label3.Text = "Nome:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridLanches);
			this.tabPage2.Controls.Add(this.btnpesquisar);
			this.tabPage2.Controls.Add(this.txtpesquisa);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 313);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Consulta";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridLanches
			// 
			this.dataGridLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLanches.Location = new System.Drawing.Point(331, 31);
			this.dataGridLanches.Name = "dataGridLanches";
			this.dataGridLanches.Size = new System.Drawing.Size(448, 250);
			this.dataGridLanches.TabIndex = 12;
			this.dataGridLanches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLanches_CellClick);
			// 
			// btnpesquisar
			// 
			this.btnpesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnpesquisar.ForeColor = System.Drawing.Color.White;
			this.btnpesquisar.Location = new System.Drawing.Point(102, 142);
			this.btnpesquisar.Name = "btnpesquisar";
			this.btnpesquisar.Size = new System.Drawing.Size(138, 48);
			this.btnpesquisar.TabIndex = 11;
			this.btnpesquisar.Text = "Pesquisar";
			this.btnpesquisar.UseVisualStyleBackColor = false;
			this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
			// 
			// txtpesquisa
			// 
			this.txtpesquisa.Location = new System.Drawing.Point(81, 86);
			this.txtpesquisa.Name = "txtpesquisa";
			this.txtpesquisa.Size = new System.Drawing.Size(197, 23);
			this.txtpesquisa.TabIndex = 10;
			this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(14, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Nome:";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// FrmLanches
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabLanches);
			this.Controls.Add(this.panel1);
			this.Name = "FrmLanches";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Lanches";
			this.Load += new System.EventHandler(this.FrmLanches_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabLanches.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngridientes)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanches)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabLanches;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnsalvar;
		private System.Windows.Forms.DataGridView dataGridIngridientes;
		private System.Windows.Forms.TextBox txtpreco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridLanches;
		private System.Windows.Forms.Button btnpesquisar;
		private System.Windows.Forms.TextBox txtpesquisa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
		private System.Windows.Forms.Button btnexcluir;
		private System.Windows.Forms.Button btneditar;
	}
}