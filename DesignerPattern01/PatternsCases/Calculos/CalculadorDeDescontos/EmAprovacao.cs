namespace DesignerPattern01
{
	public class EmAprovacao : IEstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
		}
	}
}
