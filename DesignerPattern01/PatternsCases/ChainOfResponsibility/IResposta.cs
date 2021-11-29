﻿namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{
	public interface IResposta
	{
		void Responde(Requisicao req, Conta conta);
		IResposta OutraResposta { get; set; }
	}
}
