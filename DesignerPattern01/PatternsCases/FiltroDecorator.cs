using System.Collections.Generic;

namespace DesignerPattern01.PatternsCases
{
	public abstract class FiltroDecorator
	{
		public abstract IList<Conta> Filtra(IList<Conta> contas);

	}
}
