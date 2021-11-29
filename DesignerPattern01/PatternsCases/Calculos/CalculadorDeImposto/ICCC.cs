using System;

namespace DesignerPattern01
{
	public class ICCC : Imposto
	{
		public override double Calcular(Orcamento orcamento)
		{
			if(orcamento.Valor < 1000)
				return orcamento.Valor * 0.05;

			if(orcamento.Valor >= 1000 && orcamento.Valor  <= 3000)
				return orcamento.Valor * 0.07;

			if(orcamento.Valor > 3000)
				return orcamento.Valor * 0.8 + 30;

			return 0;
		}
	}
}
