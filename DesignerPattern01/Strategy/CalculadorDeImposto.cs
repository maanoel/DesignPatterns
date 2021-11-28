using System;

namespace DesignerPattern01
{
	public class CalculadorDeImposto
	{
		public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
		{
			double valor = imposto.Calcular(orcamento);
			Console.WriteLine(valor);
		}
	}
}

