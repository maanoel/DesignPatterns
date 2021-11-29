using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01.PatternsCases.ChainOfResponsibility
{
  class RespostaEmXml : IResposta
  {
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta)
    {
      if(req.Formato == Formato.XML)
      {
        Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
      }
      else
      {
        OutraResposta.Responde(req, conta);
      }
    }
  }
}
