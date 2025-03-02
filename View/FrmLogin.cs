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
	}
}
