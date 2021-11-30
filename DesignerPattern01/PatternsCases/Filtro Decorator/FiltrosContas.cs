using System.Collections.Generic;
using System.Linq;

namespace DesignerPattern01
{
	public class ContasMenorQue100 : FiltroDecorator
	{
		public override FiltroDecorator OutroFiltro { get; set; }

		public ContasMenorQue100(FiltroDecorator outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			return OutroFiltro.Filtra(contas.Where((conta) => conta.Saldo < 100).ToList());
		}

		public ContasMenorQue100():base()
		{
			OutroFiltro = null;
		}
	}
	public class ContasDataAbeturaMesCorrente : FiltroDecorator
	{
		public override FiltroDecorator OutroFiltro { get; set; }

		public ContasDataAbeturaMesCorrente(FiltroDecorator outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public ContasDataAbeturaMesCorrente() : base()
		{
			OutroFiltro = null;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			if(OutroFiltro == null) return contas;
			return OutroFiltro.Filtra(contas.Where((conta) => conta.DataCriacao.Month == System.DateTime.Now.Month).ToList());
		}

	}
	public class ContasMaiorQueQuinhetosMil : FiltroDecorator
	{
		public ContasMaiorQueQuinhetosMil() : base()
		{
			OutroFiltro = null;
		}

		public override FiltroDecorator OutroFiltro { get; set; }

		public ContasMaiorQueQuinhetosMil(FiltroDecorator outroFiltro) : base(outroFiltro)
		{
			OutroFiltro = outroFiltro;
		}

		public override IList<Conta> Filtra(IList<Conta> contas)
		{
			if(OutroFiltro == null) return contas;
			return OutroFiltro.Filtra(contas.Where((conta) => conta.Saldo > 500000).ToList());
		}
	}
}