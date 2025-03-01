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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtpreco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// txtpreco
			// 
			this.txtpreco.Location = new System.Drawing.Point(84, 154);
			this.txtpreco.Name = "txtpreco";
			this.txtpreco.Size = new System.Drawing.Size(100, 20);
			this.txtpreco.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(16, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Preço:";
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(84, 118);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(260, 20);
			this.txtnome.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(16, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(20, 195);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(768, 243);
			this.dataGridView1.TabIndex = 9;
			// 
			// btnsalvar
			// 
			this.btnsalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnsalvar.ForeColor = System.Drawing.Color.White;
			this.btnsalvar.Location = new System.Drawing.Point(470, 130);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(120, 44);
			this.btnsalvar.TabIndex = 10;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = false;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
			// 
			// FrmLanches
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnsalvar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtpreco);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Name = "FrmLanches";
			this.Text = "Cadastro de Lanches";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtpreco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnsalvar;
	}
}