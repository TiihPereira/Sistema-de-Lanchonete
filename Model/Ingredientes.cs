using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Lanchonete.Model
{
	public class Ingredientes
	{
		public Ingredientes()
		{
		}

		public Ingredientes(int id, string nome, double preco)
		{
			Id = id;
			Nome = nome;
			Preco = preco;
		}

		public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
