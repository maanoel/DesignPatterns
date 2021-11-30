using System;
using System.Collections.Generic;

namespace DesignerPattern01{ 
	public class CriadorDeNotaFiscal
	{
		public string RazaoSocial { get; private set; }
		public string Cnpj { get; private set; }

		public string Obs { get; private set; }
		public DateTime Data { get; private set; }

		private double valorTotal;
		private double impostos;
		private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

		private IList<IAcaoAposGerarNota> TodasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

		public NotaFiscal Constroi() {
			var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, TodosItens, Obs);

			foreach(IAcaoAposGerarNota acao in TodasAcoesASeremExecutadas) {
				acao.Executa(nf);
			}

			return nf;
		}

		public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial) {
			RazaoSocial = razaoSocial;
			return this;
		}

		public CriadorDeNotaFiscal ComCnpj(string cnpj) {
			Cnpj = cnpj;
			return this;
		}

		public CriadorDeNotaFiscal ComObs(string obs)
		{
			Obs = obs;
			return this;
		}

		public CriadorDeNotaFiscal NaDataAtual()
		{
			Data = DateTime.Now;
			return this;
		}

		public void Com(ItemDaNota item) {
			TodosItens.Add(item);
			valorTotal += item.Valor;
			impostos += item.Valor * 0.05;
		}

		public void AdicionaAcao(IAcaoAposGerarNota novaAcao) {
			this.TodasAcoesASeremExecutadas.Add(novaAcao);
		}
	}
}
