using System.Collections.Generic;		
using System.Linq;

namespace DesignerPattern01
{
	public class ContasMenorQue100 : Filtro
	{
		public override Filtro OutroFiltro { get; set; }

		public ContasMenorQue100(Filtro outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			return Proximo(contas.Where((conta) => conta.Saldo > 100).ToList());
		}

		public ContasMenorQue100():base()
		{
			OutroFiltro = null;
		}
	}
	public class ContasDataAbeturaMesCorrente : Filtro
	{
		public override Filtro OutroFiltro { get; set; }

		public ContasDataAbeturaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public ContasDataAbeturaMesCorrente() : base()
		{
			OutroFiltro = null;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			return Proximo(contas.Where((conta) => conta.DataCriacao.Month != System.DateTime.Now.Month).ToList());
		}
	}

	public class ContasMaiorQueQuinhetosMil : Filtro
	{
		public ContasMaiorQueQuinhetosMil() : base()
		{
			OutroFiltro = null;
		}

		public override Filtro OutroFiltro { get; set; }

		public ContasMaiorQueQuinhetosMil(Filtro outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			return Proximo(contas.Where((conta) => conta.Saldo <= 500000).ToList());
		}
	}
}