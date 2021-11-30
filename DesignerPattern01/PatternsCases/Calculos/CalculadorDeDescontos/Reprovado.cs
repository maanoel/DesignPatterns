using System;

namespace DesignerPattern01
{
	public class Reprovado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos reprovados não recebem desconto");
		}
	}
}
