using DesignerPattern01.PatternsCases.ChainOfResponsibility;

namespace DesignerPattern01
{
	public class CorrenteDeRequisicoes
	{
		public void EnviarRequisicoes(Requisicao requisicao, Conta conta)
		{
			IResposta csv = new RespostaEmCsv();
			IResposta xml = new RespostaEmXml();
			IResposta porCento = new RespostaEmPorcento();

			csv.OutraResposta = xml;
			xml.OutraResposta = porCento;

			csv.Responde(requisicao, conta);
		}
	}
}
