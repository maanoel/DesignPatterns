using System;

namespace DesignerPattern01
{
	public class Conta
	{
		public String Titular { get; private set; }
		public double Saldo { get; private set; }

		public DateTime DataCriacao{ get; private set; }

		public Conta(String titular, double saldo)
		{
			Titular = titular;
			Saldo = saldo;
			DataCriacao =  DateTime.Now;
		}
	}
}
