using System;

namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{
	public class CorrenteDeRequisicoes
	{
		public void EnviarRequisicoes(Requisicao requisicao, Conta conta)
		{
			IResposta csv = new RespostaEmCsv();
			IResposta xml = new RespostaEmXml();
			IResposta porCento = new RespostaEmPorcento();
			IResposta semResposta = new FimRespostas();

			csv.OutraResposta = xml;
			xml.OutraResposta = porCento;
			porCento.OutraResposta = semResposta;

			csv.Responde(requisicao, conta);
		}
	}
}
