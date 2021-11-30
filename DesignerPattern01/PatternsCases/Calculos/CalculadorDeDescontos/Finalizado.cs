using System;

namespace DesignerPattern01
{
	public class Finalizado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			new Exception("Orcamentos finalizados não recebem desconto");
		}

		public void Aprova(Orcamento orcamento)
		{
			new Exception("Já finalizado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			new Exception("Já finalizado");
		}

		public void Reprova(Orcamento orcamento)
		{
			new Exception("Já finalizado");
		}
	}
}
