using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Lanchonete.Model
{
	public class Vendas
	{
        public int Id { get; set; }
        public int IdLanche { get; set; }
        public int IdIngredientes { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }

        public Vendas(int idLanche, int idIngredientes, double valorTotal)
        {
            IdLanche = idLanche;
            IdIngredientes = idIngredientes;
            ValorTotal = valorTotal;
            DataVenda = DateTime.Now;
        }

		public Vendas()
		{
		}
	}
}
