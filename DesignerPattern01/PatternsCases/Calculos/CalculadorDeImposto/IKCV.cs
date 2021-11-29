using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01.PatternsCases.Calculos.CalculadorDeImposto
{
	public class IKCV : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.1;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}

		private bool TemItemMaiorQue100Reais(Orcamento orcamento)
		{
			throw new NotImplementedException();
		}

	}
}
