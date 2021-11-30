using System.Collections.Generic;

namespace DesignerPattern01
{
	public class Orcamento
	{
	
		public IEstadoDeUmOrcamento EstadoAtual { get; set; }

		public double Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public Orcamento(double valor, IEstadoDeUmOrcamento estado)
		{
			Valor = valor;
			Itens = new List<Item>();
			EstadoAtual = estado;
		}

		public void AdicionarItem(Item item)
		{
			Itens.Add(item);
		}

		public void AplicaDescontoExtra() {
			EstadoAtual.AplicaDescontoExtra(this);
		}
	}
}
