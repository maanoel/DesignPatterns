using System.Collections.Generic;
using System.Linq;

namespace DesignerPattern01.PatternsCases.Filtro_Decorator
{
	public class ContasMenorQue100 : FiltroDecorator
	{
		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			return contas.Where((conta) => conta.Saldo < 100).ToList();
		}

		public class ContasMaiorQueQuinhetosMil : FiltroDecorator
		{
			public override IList<Conta> Filtra(IList<Conta> contas)
			{
				return contas.Where((conta) => conta.Saldo > 500000).ToList();
			}
		}

		public class ContasDataAbeturaMesCorrente : FiltroDecorator
		{
			public override IList<Conta> Filtra(IList<Conta> contas)
			{
				return contas.Where((conta) => conta.DataCriacao.Month == System.DateTime.Now.Month).ToList();
			}
		}
	}
}