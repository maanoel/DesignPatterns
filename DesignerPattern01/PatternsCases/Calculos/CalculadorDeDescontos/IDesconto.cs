namespace DesignerPattern01.Strategy.Calculos.CalculadorDeDescontos
{
	public interface IDesconto
	{
		double Desconta(Orcamento orcamento);
		IDesconto Proximo { get; set; }
	}
}
