namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public interface ITipoInvestimento
	{
		double Calcula(ContaBancaria conta);
	}
}
