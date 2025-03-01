using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Lanchonete.Model
{
	public class Helpers
	{
		public void LimparTela(Form tela)
		{
			foreach (Control crtPai in tela.Controls)
			{
				foreach (Control crt1 in crtPai.Controls)
				{
					if (crt1 is TabPage)
					{
						foreach (Control ctr2 in crt1.Controls)
						{
							if (ctr2 is TextBox)
							{
								(ctr2 as TextBox).Text = string.Empty;
							}
						}
					}
				}
			}
		}
	}
}
