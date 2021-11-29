
using System;


namespace DesignerPattern01
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
			foreach(Item item in orcamento.Itens)
			{
				if(item.Valor > 100) return true;
			}

			return false;
		}

	}
}