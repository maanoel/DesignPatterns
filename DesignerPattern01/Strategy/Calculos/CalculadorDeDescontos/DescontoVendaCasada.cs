using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01.Strategy.Calculos.CalculadorDeDescontos
{
	public class DescontoVendaCasada : IDesconto
	{
    public IDesconto Proximo { get; set; }
    public double Desconta(Orcamento orcamento)
    {
      if(aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.05;
      else return Proximo.Desconta(orcamento);
    }

    private bool aconteceuVendaCasadaEm(Orcamento orcamento)
    {
      return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
    }

    private bool Existe(String nomeDoItem, Orcamento orcamento)
    {
      foreach(Item item in orcamento.Itens)
      {
        if(item.Nome.Equals(nomeDoItem)) return true;
      }
      return false;
    }
  }
}
}
