namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{
	public class FimRespostas : IResposta
	{
		public IResposta OutraResposta { get; set; }

		public void Responde(Requisicao req, Conta conta)
		{
			
		}
	}
}