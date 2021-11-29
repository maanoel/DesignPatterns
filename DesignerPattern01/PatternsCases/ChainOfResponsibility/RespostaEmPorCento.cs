using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{

	public class RespostaEmPorcento : IResposta
	{
		public IResposta OutraResposta { get; set; }

		public RespostaEmPorcento(IResposta resposta)
		{
			OutraResposta = resposta;
		}

		public RespostaEmPorcento()
		{
			OutraResposta = null;
		}

		public void Responde(Requisicao req, Conta conta)
		{
			if(req.Formato == Formato.PORCENTO)
			{
				Console.WriteLine(conta.Titular + "%" + conta.Saldo);
			}
			else
			{
				OutraResposta.Responde(req, conta);
			}
		}

	}
}

