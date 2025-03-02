using MySql.Data.MySqlClient;
using Sistema_de_Lanchonete.DBC;
using Sistema_de_Lanchonete.Model;
using Sistema_de_Lanchonete.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.DAO
{
	public class LoginDAO
	{
		private MySqlConnection conexao;

		public LoginDAO()
		{
			this.conexao = new ConnectionFactory().GetConnection();
		}

		#region EfetuarLogin

		public bool EfetuarLogin(Login login)
		{
			try
			{
				string sql = @"SELECT * FROM TB_APP_USER
								WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

				MySqlCommand executacmd = new MySqlCommand(sql, conexao);
				executacmd.Parameters.AddWithValue("@USUARIO", login.Usuario);
				executacmd.Parameters.AddWithValue("@SENHA", login.Senha);

				conexao.Open();

				MySqlDataReader reader = executacmd.ExecuteReader();

				if (reader.Read())
				{

					string nome = reader.GetString("nome");
					string nivel = reader.GetString("nivel_acesso");

					MessageBox.Show("Login realizado com sucesso, Bem vindo: " + nome);

					FrmMenu telamenu = new FrmMenu();

					telamenu.txtusuario.Text = nome;

					if (nivel.Equals("Administrator"))
					{
						telamenu.Show();
					}

					else if (nivel.Equals("Vendedor"))
					{
						telamenu.menuCadastroLanches.Enabled = false;
						telamenu.menuCadastroIngredientes.Enabled = false;
						telamenu.menuHistoricoVenda.Enabled = false;
						telamenu.Show();
					}

					return true;
				}
				else
				{
					MessageBox.Show("Usuario ou senha incorreto!");
					return false;
				}

			}
			catch (Exception erro)
			{
				MessageBox.Show("Aconteceu o erro ao efetuar o login: " + erro);
				return false;
			}
		}

		#endregion

	}
}
