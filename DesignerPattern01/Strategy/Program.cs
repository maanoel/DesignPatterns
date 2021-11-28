using DesignerPattern01.Strategy.RealizadorDeInvestimentos;

namespace DesignerPattern01
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Calculadora de  imposto
			Imposto iss = new ISS();
			Imposto icsm = new ICMS();
			Imposto icc = new ICCC();

			Orcamento orcamento = new Orcamento(500);

			new CalculadorDeImposto().RealizaCalculo(orcamento, iss);
			new CalculadorDeImposto().RealizaCalculo(orcamento, icsm);
			new CalculadorDeImposto().RealizaCalculo(orcamento, icc);

			//Realizador de Investimento
			ITipoInvestimento arrojador = new InvestimentoArrojado();
			ITipoInvestimento conservador = new InvestimentoConservador();
			ITipoInvestimento moderado = new InvestimentoModerado();

			ContaBancaria conta = new ContaBancaria();
			conta.Deposita(1900);

			new RealizadorDeInvestimentos().Calcular(conta, arrojador);
		}
	}
}