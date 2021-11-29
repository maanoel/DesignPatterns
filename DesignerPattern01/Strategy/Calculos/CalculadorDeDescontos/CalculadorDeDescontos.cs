using System;

namespace DesignerPattern01.Strategy.Calculos.CalculadorDeDescontos
{
	public class CalculadorDeDescontos 
	{
		public double Calcula(Orcamento orcamento)
		{
			IDesconto d1 = new DescontoSeMaiorQuinhetos();
			IDesconto d2 = new DescontoPorCincoItens();
			IDesconto d3 = new SemDesconto();

			d1.Proximo = d2;
			d2.Proximo = d3;

			Console.WriteLine("calculo desconto:" + d1.Desconta(orcamento));

			return d1.Desconta(orcamento);
		}
	}
}
