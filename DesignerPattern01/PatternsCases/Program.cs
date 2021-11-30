using DesignerPattern01.Strategy.RealizadorDeInvestimentos;
using System;
using System.Collections.Generic;

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
			//Eu utiliz o chain quando eu quero criar uma corrente de execução entre vários objetos.
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

			//Decorator 

			//Utilizo o decorator quando é preciso compor a regra de uma objeto outra
			//Para decorar uma objeto com outro eu posos passar ela por parâmetro

			Imposto imposto = new ISS(new ICMS(new IKCV()));

			Orcamento orcamentoTemplate = new Orcamento(500);

			double valor = imposto.Calcular(orcamentoTemplate);

			Console.WriteLine("TESTE VALOR:  " + valor);

			//Decorator com TDD
			//Filtro filtros = new ContasMenorQue100(new ContasMaiorQueQuinhetosMil(new ContasDataAbeturaMesCorrente()));
			Filtro filtros = new ContasMenorQue100(new ContasMaiorQueQuinhetosMil());

			var lista = new List<Conta> { new Conta("Vitor", 5000), new Conta("Vitor", 5000000), new Conta("Vitor", 500), new Conta("Vitor", 5) };

			var contas = filtros.Filtra(lista);

			Console.WriteLine("Contas filtradas: " + contas.Count);

			//

			Orcamento reforma = new Orcamento(500, new Aprovado());
			reforma.AplicaDescontoExtra();
		}
	}
}