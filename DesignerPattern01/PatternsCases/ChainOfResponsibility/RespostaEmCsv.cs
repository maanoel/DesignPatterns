using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{
  class RespostaEmCsv : IResposta
  {
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta)
    {
      if(req.Formato == Formato.CSV)
      {
        Console.WriteLine(conta.Titular + ";" + conta.Saldo);
      }
      else
      {
        OutraResposta.Responde(req, conta);
      }
    }
  }
}
