using System;

namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public class RealizadorDeInvestimentos
	{
		public void Calcular(ContaBancaria conta, ITipoInvestimento investimento) 
		{
			Console.WriteLine("Calculo do investimento" + investimento.Calcula(conta) * 0.75);
			conta.Deposita(investimento.Calcula(conta) * 0.75);
		}
	}
}
