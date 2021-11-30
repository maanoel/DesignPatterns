using System;

namespace DesignerPattern01{
	public class Aprovado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento já aprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}
	}
}
