using System;

namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public class InvestimentoModerado : ITipoInvestimento
	{
		public double Calcula(ContaBancaria conta)
		{
			bool escolhido = new Random().Next(101) > 50;

			if(escolhido)
				return conta.Saldo * 0.025; //2.5%

			return conta.Saldo * 0.007; //0.7%

		}
	}
}
