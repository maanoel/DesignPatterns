namespace DesignerPattern01
{
	public interface IDesconto
	{
		double Desconta(Orcamento orcamento);
		IDesconto Proximo { get; set; }
	}
}
