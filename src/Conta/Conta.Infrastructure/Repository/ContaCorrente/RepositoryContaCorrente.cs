using System.Linq;
using Conta.Domain.Entidades;
using Conta.Domain.Entidades.Interface;
using Conta.Infrastucture.Repository.Generic;

namespace Infrastucture.Repository.ContaCorrente
{
    public class RepositoryContaCorrente : RepositoryGeneric<IContaCorrente>
    {
        private IContaCorrente _conta;

        public RepositoryContaCorrente(IContaCorrente conta)
        {
            _conta = conta;
        }

        public override IContaCorrente Buscar(IContaCorrente entidade)
        {
            return _contasCorrentes.FirstOrDefault(obj => string.Equals(obj.Numero, entidade.Numero));
        }

        public override void Salvar(IContaCorrente entidade)
        {
            var obj = Buscar(entidade);
            obj.Saldo = entidade.Saldo;
            if (entidade.Lancamentos != null)
                entidade.Lancamentos.ToList().ForEach(inner => obj.Lancamentos.Add(inner));

        }
    }

}
