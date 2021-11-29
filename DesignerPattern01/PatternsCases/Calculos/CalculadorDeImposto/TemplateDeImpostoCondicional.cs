namespace DesignerPattern01.PatternsCases.Calculos.CalculadorDeImposto
{
	public abstract class TemplateDeImpostoCondicional : Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			if(DeveUsarMaximaTaxacao(orcamento)) {
				return MaximaTaxacao(orcamento);
			}

			return MinimaTaxacao(orcamento);
		}

		public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
		public abstract double MaximaTaxacao(Orcamento orcamento);
		public abstract double MinimaTaxacao(Orcamento orcamento);
	}
}
