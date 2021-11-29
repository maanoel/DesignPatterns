namespace DesignerPattern01.Strategy.Calculos.CalculadorDeDescontos
{
	public class DescontoSeMaiorQuinhetos : IDesconto
	{
		public IDesconto Proximo { get;  set; }

		public double Desconta(Orcamento orcamento)
		{
			if(orcamento.Valor > 500)
				return orcamento.Valor * 0.007;

			return Proximo.Desconta(orcamento);
		}
	}
}
