
namespace DesignerPattern01
{
	public enum Formato
	{
		XML,
		CSV,
		PORCENTO
	}

	public class Requisicao
	{
		public Formato Formato { get; private set; }

		public Requisicao(Formato formato)
		{
			this.Formato = formato;
		}
	}
}
