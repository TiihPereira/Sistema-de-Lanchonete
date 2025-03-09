namespace Sistema_de_Lanchonete.View
{
	partial class FrmLogin
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
			this.txtsenha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnentrar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(76, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(343, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Autenticação do Sistema";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(503, 100);
			this.panel1.TabIndex = 1;
			// 
			// txtsenha
			// 
			this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsenha.Location = new System.Drawing.Point(162, 181);
			this.txtsenha.Name = "txtsenha";
			this.txtsenha.PasswordChar = '*';
			this.txtsenha.Size = new System.Drawing.Size(236, 26);
			this.txtsenha.TabIndex = 5;
			this.txtsenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsenha_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(66, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Senha:";
			// 
			// txtusuario
			// 
			this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusuario.Location = new System.Drawing.Point(162, 137);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(236, 26);
			this.txtusuario.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(66, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuario:";
			// 
			// btnentrar
			// 
			this.btnentrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnentrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.btnentrar.ForeColor = System.Drawing.Color.White;
			this.btnentrar.Location = new System.Drawing.Point(196, 223);
			this.btnentrar.Name = "btnentrar";
			this.btnentrar.Size = new System.Drawing.Size(120, 44);
			this.btnentrar.TabIndex = 9;
			this.btnentrar.Text = "Entrar";
			this.btnentrar.UseVisualStyleBackColor = false;
			this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 293);
			this.Controls.Add(this.btnentrar);
			this.Controls.Add(this.txtsenha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtsenha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnentrar;
	}
}