using System.Collections.Generic;

namespace DesignerPattern01
{
	public abstract class Filtro
	{
		public abstract Filtro OutroFiltro{ get;  set; }
		public abstract IList<Conta> Filtra(IList<Conta> contas);

		public Filtro(Filtro filtro)
		{
			OutroFiltro = filtro;
		}

		public Filtro()
		{
			OutroFiltro = null;
		}

		protected IList<Conta> Proximo(IList<Conta> contas) {
			if(OutroFiltro != null) return OutroFiltro.Filtra(contas);

			return contas;
		}
	}
}
