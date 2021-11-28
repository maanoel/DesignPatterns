namespace DesignerPattern01
{
	public class ISS : Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.6;
		}
	}
}
