
namespace DesignerPattern01.Strategy.RealizadorDeInvestimentos
{
	public class ContaBancaria
	{
		public double Saldo { get; private set; }

		public void Deposita(double valor) {
			Saldo += valor;
		}
	}
}
