using System;

namespace DesignerPattern01
{
	public class EnviadorDeEmail : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf) {
			Console.WriteLine("enviador de Email");
		}
	}
}
