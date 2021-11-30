using System;

namespace DesignerPattern01
{
	public class EnviadorDeSMS: IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf) {
			Console.WriteLine("SMS Enviado");
		}
	}
}
