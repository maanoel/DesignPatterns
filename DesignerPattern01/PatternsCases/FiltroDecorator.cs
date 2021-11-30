using System.Collections.Generic;

namespace DesignerPattern01
{
	public abstract class FiltroDecorator
	{
		public abstract FiltroDecorator OutroFiltro{ get;  set; }
		public abstract IList<Conta> Filtra(IList<Conta> contas);

		public FiltroDecorator(FiltroDecorator filtro)
		{
			OutroFiltro = filtro;
		}

		public FiltroDecorator()
		{
			OutroFiltro = null;
		}
	}
}
