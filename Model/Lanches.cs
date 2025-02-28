using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Lanchonete.Model
{
	public class Lanches
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int idIngrediente { get; set; }
    }
}
