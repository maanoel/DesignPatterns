using System;

namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public class InvestimentoArrojado : ITipoInvestimento
	{
		public double Calcula(ContaBancaria conta)
		{
			int random = new Random().Next(101);

			if(random > 20 && random <= 20 ) return conta.Saldo * 0.05;

			if(random > 30 && random <= 30) return conta.Saldo * 0.03;

			if(random >= 50) return conta.Saldo * 0.006;

			return 0;

		}
	}
}
