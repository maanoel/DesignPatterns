namespace DesignerPattern01
{
	public class ICMS : Imposto
	{

		public ICMS(Imposto outroImposto): base(outroImposto)
		{

		}

		public ICMS(): base()
		{

		}

		public override double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor + CalculoDoOutroImposto(orcamento);
		}
	}
}
