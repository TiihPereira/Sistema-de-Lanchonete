namespace Sistema_de_Lanchonete.View
{
	partial class FrmIngredientes
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
			this.panelIngredientes = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tabCadastroIngredientes = new System.Windows.Forms.TabControl();
			this.tabIngredientes = new System.Windows.Forms.TabPage();
			this.btneditar = new System.Windows.Forms.Button();
			this.txtpreco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnexcluir = new System.Windows.Forms.Button();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.txtcod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabIngredientesConsulta = new System.Windows.Forms.TabPage();
			this.dataGridIngredientes = new System.Windows.Forms.DataGridView();
			this.btnpesquisar = new System.Windows.Forms.Button();
			this.txtpesquisa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panelIngredientes.SuspendLayout();
			this.tabCadastroIngredientes.SuspendLayout();
			this.tabIngredientes.SuspendLayout();
			this.tabIngredientesConsulta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngredientes)).BeginInit();
			this.SuspendLayout();
			// 
			// panelIngredientes
			// 
			this.panelIngredientes.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panelIngredientes.Controls.Add(this.label1);
			this.panelIngredientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelIngredientes.Location = new System.Drawing.Point(0, 0);
			this.panelIngredientes.Name = "panelIngredientes";
			this.panelIngredientes.Size = new System.Drawing.Size(811, 100);
			this.panelIngredientes.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(216, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Ingredientes";
			// 
			// tabCadastroIngredientes
			// 
			this.tabCadastroIngredientes.Controls.Add(this.tabIngredientes);
			this.tabCadastroIngredientes.Controls.Add(this.tabIngredientesConsulta);
			this.tabCadastroIngredientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCadastroIngredientes.Location = new System.Drawing.Point(0, 106);
			this.tabCadastroIngredientes.Name = "tabCadastroIngredientes";
			this.tabCadastroIngredientes.SelectedIndex = 0;
			this.tabCadastroIngredientes.Size = new System.Drawing.Size(800, 338);
			this.tabCadastroIngredientes.TabIndex = 1;
			// 
			// tabIngredientes
			// 
			this.tabIngredientes.Controls.Add(this.btneditar);
			this.tabIngredientes.Controls.Add(this.txtpreco);
			this.tabIngredientes.Controls.Add(this.label4);
			this.tabIngredientes.Controls.Add(this.btnexcluir);
			this.tabIngredientes.Controls.Add(this.txtnome);
			this.tabIngredientes.Controls.Add(this.label3);
			this.tabIngredientes.Controls.Add(this.btnsalvar);
			this.tabIngredientes.Controls.Add(this.txtcod);
			this.tabIngredientes.Controls.Add(this.label2);
			this.tabIngredientes.Location = new System.Drawing.Point(4, 26);
			this.tabIngredientes.Name = "tabIngredientes";
			this.tabIngredientes.Padding = new System.Windows.Forms.Padding(3);
			this.tabIngredientes.Size = new System.Drawing.Size(792, 308);
			this.tabIngredientes.TabIndex = 0;
			this.tabIngredientes.Text = "Ingredientes";
			this.tabIngredientes.UseVisualStyleBackColor = true;
			// 
			// btneditar
			// 
			this.btneditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btneditar.ForeColor = System.Drawing.Color.White;
			this.btneditar.Location = new System.Drawing.Point(259, 203);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(120, 44);
			this.btneditar.TabIndex = 9;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = false;
			this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
			// 
			// txtpreco
			// 
			this.txtpreco.Location = new System.Drawing.Point(94, 114);
			this.txtpreco.Name = "txtpreco";
			this.txtpreco.Size = new System.Drawing.Size(100, 23);
			this.txtpreco.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(30, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Preço:";
			// 
			// btnexcluir
			// 
			this.btnexcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnexcluir.ForeColor = System.Drawing.Color.White;
			this.btnexcluir.Location = new System.Drawing.Point(440, 203);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(120, 44);
			this.btnexcluir.TabIndex = 8;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = false;
			this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(94, 75);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(260, 23);
			this.txtnome.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(26, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nome:";
			// 
			// btnsalvar
			// 
			this.btnsalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnsalvar.ForeColor = System.Drawing.Color.White;
			this.btnsalvar.Location = new System.Drawing.Point(74, 203);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(120, 44);
			this.btnsalvar.TabIndex = 7;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = false;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
			// 
			// txtcod
			// 
			this.txtcod.Location = new System.Drawing.Point(94, 31);
			this.txtcod.Name = "txtcod";
			this.txtcod.Size = new System.Drawing.Size(260, 23);
			this.txtcod.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(17, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Código:";
			// 
			// tabIngredientesConsulta
			// 
			this.tabIngredientesConsulta.Controls.Add(this.dataGridIngredientes);
			this.tabIngredientesConsulta.Controls.Add(this.btnpesquisar);
			this.tabIngredientesConsulta.Controls.Add(this.txtpesquisa);
			this.tabIngredientesConsulta.Controls.Add(this.label5);
			this.tabIngredientesConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabIngredientesConsulta.Location = new System.Drawing.Point(4, 26);
			this.tabIngredientesConsulta.Name = "tabIngredientesConsulta";
			this.tabIngredientesConsulta.Padding = new System.Windows.Forms.Padding(3);
			this.tabIngredientesConsulta.Size = new System.Drawing.Size(792, 308);
			this.tabIngredientesConsulta.TabIndex = 1;
			this.tabIngredientesConsulta.Text = "Consulta";
			this.tabIngredientesConsulta.UseVisualStyleBackColor = true;
			// 
			// dataGridIngredientes
			// 
			this.dataGridIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridIngredientes.Location = new System.Drawing.Point(325, 29);
			this.dataGridIngredientes.Name = "dataGridIngredientes";
			this.dataGridIngredientes.Size = new System.Drawing.Size(448, 250);
			this.dataGridIngredientes.TabIndex = 8;
			this.dataGridIngredientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIngredientes_CellClick);
			// 
			// btnpesquisar
			// 
			this.btnpesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnpesquisar.ForeColor = System.Drawing.Color.White;
			this.btnpesquisar.Location = new System.Drawing.Point(96, 140);
			this.btnpesquisar.Name = "btnpesquisar";
			this.btnpesquisar.Size = new System.Drawing.Size(138, 48);
			this.btnpesquisar.TabIndex = 7;
			this.btnpesquisar.Text = "Pesquisar";
			this.btnpesquisar.UseVisualStyleBackColor = false;
			this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
			// 
			// txtpesquisa
			// 
			this.txtpesquisa.Location = new System.Drawing.Point(75, 84);
			this.txtpesquisa.Name = "txtpesquisa";
			this.txtpesquisa.Size = new System.Drawing.Size(197, 23);
			this.txtpesquisa.TabIndex = 5;
			this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(8, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Nome:";
			// 
			// FrmIngredientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 458);
			this.Controls.Add(this.tabCadastroIngredientes);
			this.Controls.Add(this.panelIngredientes);
			this.Name = "FrmIngredientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Ingredientes";
			this.Load += new System.EventHandler(this.FrmIngredientes_Load);
			this.panelIngredientes.ResumeLayout(false);
			this.panelIngredientes.PerformLayout();
			this.tabCadastroIngredientes.ResumeLayout(false);
			this.tabIngredientes.ResumeLayout(false);
			this.tabIngredientes.PerformLayout();
			this.tabIngredientesConsulta.ResumeLayout(false);
			this.tabIngredientesConsulta.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngredientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelIngredientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtcod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpreco;
		private System.Windows.Forms.Button btneditar;
		private System.Windows.Forms.Button btnexcluir;
		private System.Windows.Forms.Button btnsalvar;
		private System.Windows.Forms.DataGridView dataGridIngredientes;
		private System.Windows.Forms.Button btnpesquisar;
		private System.Windows.Forms.TextBox txtpesquisa;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TabControl tabCadastroIngredientes;
		public System.Windows.Forms.TabPage tabIngredientes;
		public System.Windows.Forms.TabPage tabIngredientesConsulta;
	}
}