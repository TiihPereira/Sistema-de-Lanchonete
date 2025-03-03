using Sistema_de_Lanchonete.DAO;
using Sistema_de_Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.BO
{
	public class LoginBO
	{
		private LoginDAO loginDAO = new LoginDAO();

		public bool EfetuarLogin(Login login)
		{
			try
			{
				return loginDAO.EfetuarLogin(login);

			}
			catch (Exception erro)
			{
				MessageBox.Show("Erro ao efetuar login: " + erro);
				return false;
			}
		}
	}
}
