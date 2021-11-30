using System;

namespace DesignerPattern01
{
	public class Finalizado : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			new Exception("Orcamentos finalizados não recebem desconto");
		}
	}
}
