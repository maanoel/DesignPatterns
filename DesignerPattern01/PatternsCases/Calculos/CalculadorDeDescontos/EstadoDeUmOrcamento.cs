﻿namespace DesignerPattern01
{
	public interface IEstadoDeUmOrcamento
	{
		void AplicaDescontoExtra(Orcamento orcamento);
		void Aprova(Orcamento orcamento);
		void Reprova(Orcamento orcamento);
		void Finaliza(Orcamento orcamento);
	}
}
