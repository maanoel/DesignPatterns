﻿
namespace DesignerPattern01
{
	public interface IResposta
	{
		void Responde(Requisicao req, Conta conta);
		IResposta OutraResposta { get; set; }
	}
}
