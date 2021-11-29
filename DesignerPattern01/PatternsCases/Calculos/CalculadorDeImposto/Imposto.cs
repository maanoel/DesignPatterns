namespace DesignerPattern01
{
	public abstract class Imposto
	{

		public Imposto OutroImposto{ get; set; }

		public Imposto(Imposto outroImposto)
		{
			OutroImposto = outroImposto;
		}

		public Imposto()
		{
			OutroImposto = null;
		}

		public abstract double Calcular(Orcamento orcamento);

		public double CalculoDoOutroImposto(Orcamento orcamento)
		{
			if(OutroImposto == null) return 0;
			return OutroImposto.Calcular(orcamento);
		}
	}
}
