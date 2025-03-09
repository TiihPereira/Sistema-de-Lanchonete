namespace Sistema_de_Lanchonete.View
{
	partial class FrmVendas
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridVendas = new System.Windows.Forms.DataGridView();
			this.btnpesquisar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridLanchesVendidos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridIngredientesUsados = new System.Windows.Forms.DataGridView();
			this.panelIngredientes.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanchesVendidos)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngredientesUsados)).BeginInit();
			this.SuspendLayout();
			// 
			// panelIngredientes
			// 
			this.panelIngredientes.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panelIngredientes.Controls.Add(this.label1);
			this.panelIngredientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelIngredientes.Location = new System.Drawing.Point(0, 0);
			this.panelIngredientes.Name = "panelIngredientes";
			this.panelIngredientes.Size = new System.Drawing.Size(806, 74);
			this.panelIngredientes.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(267, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Histórico de Vendas";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridVendas);
			this.groupBox1.Controls.Add(this.btnpesquisar);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dtpDataFim);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpDataInicio);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 313);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Consulta";
			// 
			// dataGridVendas
			// 
			this.dataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridVendas.Location = new System.Drawing.Point(6, 54);
			this.dataGridVendas.Name = "dataGridVendas";
			this.dataGridVendas.Size = new System.Drawing.Size(788, 253);
			this.dataGridVendas.TabIndex = 18;
			// 
			// btnpesquisar
			// 
			this.btnpesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnpesquisar.ForeColor = System.Drawing.Color.White;
			this.btnpesquisar.Location = new System.Drawing.Point(680, 13);
			this.btnpesquisar.Name = "btnpesquisar";
			this.btnpesquisar.Size = new System.Drawing.Size(114, 35);
			this.btnpesquisar.TabIndex = 17;
			this.btnpesquisar.Text = "Pesquisar";
			this.btnpesquisar.UseVisualStyleBackColor = false;
			this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(348, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 19);
			this.label4.TabIndex = 16;
			this.label4.Text = "Data Fim:";
			// 
			// dtpDataFim
			// 
			this.dtpDataFim.Location = new System.Drawing.Point(436, 22);
			this.dtpDataFim.Name = "dtpDataFim";
			this.dtpDataFim.Size = new System.Drawing.Size(238, 21);
			this.dtpDataFim.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(1, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 19);
			this.label3.TabIndex = 15;
			this.label3.Text = "Data Inicio:";
			// 
			// dtpDataInicio
			// 
			this.dtpDataInicio.Location = new System.Drawing.Point(103, 22);
			this.dtpDataInicio.Name = "dtpDataInicio";
			this.dtpDataInicio.Size = new System.Drawing.Size(239, 21);
			this.dtpDataInicio.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridLanchesVendidos);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 397);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(397, 211);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lanches Mais Vendidos";
			// 
			// dataGridLanchesVendidos
			// 
			this.dataGridLanchesVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridLanchesVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLanchesVendidos.Location = new System.Drawing.Point(6, 19);
			this.dataGridLanchesVendidos.Name = "dataGridLanchesVendidos";
			this.dataGridLanchesVendidos.Size = new System.Drawing.Size(384, 186);
			this.dataGridLanchesVendidos.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridIngredientesUsados);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(403, 397);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(397, 211);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ingredientes Mais Utilizados";
			// 
			// dataGridIngredientesUsados
			// 
			this.dataGridIngredientesUsados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridIngredientesUsados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridIngredientesUsados.Location = new System.Drawing.Point(6, 19);
			this.dataGridIngredientesUsados.Name = "dataGridIngredientesUsados";
			this.dataGridIngredientesUsados.Size = new System.Drawing.Size(385, 186);
			this.dataGridIngredientesUsados.TabIndex = 0;
			// 
			// FrmVendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 620);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panelIngredientes);
			this.Name = "FrmVendas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmVendas";
			this.Load += new System.EventHandler(this.FrmVendas_Load);
			this.panelIngredientes.ResumeLayout(false);
			this.panelIngredientes.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridLanchesVendidos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridIngredientesUsados)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelIngredientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpDataFim;
		private System.Windows.Forms.DateTimePicker dtpDataInicio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnpesquisar;
		private System.Windows.Forms.DataGridView dataGridVendas;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridLanchesVendidos;
		private System.Windows.Forms.DataGridView dataGridIngredientesUsados;
	}
}