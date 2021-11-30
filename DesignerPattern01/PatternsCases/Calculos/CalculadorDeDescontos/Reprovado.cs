using System;

namespace DesignerPattern01
{
	public class Reprovado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos reprovados não recebem desconto");
		}

		public void Aprova(Orcamento orcamento)
		{
			new Exception("Já reprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			new Exception("Já reprovado");
		}

		public void Reprova(Orcamento orcamento)
		{
			new Exception("Já reprovado");
		}
	}
}
