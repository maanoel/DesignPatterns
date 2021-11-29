using System;

namespace DesignerPattern01
{
	public class ISS : Imposto
	{
		public ISS(Imposto outroImposto) : base(outroImposto)
		{

		}

		public ISS(): base()
		{

		}

		public override double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.6  + CalculoDoOutroImposto(orcamento);
		}
	}
}
