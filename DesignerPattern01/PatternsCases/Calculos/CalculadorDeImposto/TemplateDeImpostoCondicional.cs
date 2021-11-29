namespace DesignerPattern01
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

		protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
		protected abstract double MaximaTaxacao(Orcamento orcamento);
		protected abstract double MinimaTaxacao(Orcamento orcamento);
	}
}
