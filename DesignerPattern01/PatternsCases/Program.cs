using DesignerPattern01.Strategy.Calculos.CalculadorDeDescontos;
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

			///Chain of Responsibility
			CalculadorDeDescontos calculador = new CalculadorDeDescontos();

			Orcamento orcamentoDesconto = new Orcamento(500);
			orcamentoDesconto.AdicionarItem(new Item("Caneta", 1500));
			orcamentoDesconto.AdicionarItem(new Item("Lapis", 5100));
			orcamentoDesconto.AdicionarItem(new Item("Lapis1", 5100));
			orcamentoDesconto.AdicionarItem(new Item("Lapis2", 500));
			orcamentoDesconto.AdicionarItem(new Item("Lapis", 500));
			orcamentoDesconto.AdicionarItem(new Item("Lapis", 100));
			orcamentoDesconto.AdicionarItem(new Item("Lapis", 10));
			orcamentoDesconto.AdicionarItem(new Item("Lapis", 100));


			calculador.Calcula(orcamentoDesconto);

			CorrenteDeRequisicoes requisicoes = new CorrenteDeRequisicoes();
			Requisicao requisicao = new Requisicao(Formato.XML);
			Conta contaRequisicao = new Conta("Vitor", 500);

			requisicoes.EnviarRequisicoes(requisicao, contaRequisicao);

			//Tempalte method	
			Imposto ikcv = new IKCV();
		}
	}
}