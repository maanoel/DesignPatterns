namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public class InvestimentoConservador : ITipoInvestimento
	{
		public double Calcula(ContaBancaria conta)
		{
			return conta.Saldo * 0.08;
		}
	}
}
