using System;

namespace DesignerPattern01
{
	public class Program
	{
		static void Main(string[] args)
		{
			Imposto iss = new ISS();
			Imposto icsm = new ICMS();

			Orcamento orcamento = new Orcamento(500);

			new CalculadorDeImposto().RealizaCalculo(orcamento, iss);
			new CalculadorDeImposto().RealizaCalculo(orcamento, icsm);

		}
	}
}