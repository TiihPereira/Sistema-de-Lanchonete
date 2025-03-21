﻿using Sistema_de_Lanchonete.BO;
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

namespace Sistema_de_Lanchonete.View
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnentrar_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Usuario = txtusuario.Text;
			login.Senha = txtsenha.Text;

			LoginBO loginBO = new LoginBO();
			
			if (loginBO.EfetuarLogin(login))
			{
				this.Hide();
			}

		}

		private void txtsenha_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnentrar.PerformClick();
			}
		}

		private void pbMostrarSenha_Click(object sender, EventArgs e)
		{
			if (txtsenha.PasswordChar == '*')
			{
				txtsenha.PasswordChar = '\0';
				pbMostrarSenha.Image = Properties.Resources.crossed_eye;
			}
			else
			{
				txtsenha.PasswordChar = '*';
				pbMostrarSenha.Image = Properties.Resources.eye;
			}
		}
	}
}
