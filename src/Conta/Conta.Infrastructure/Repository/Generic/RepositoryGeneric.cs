using Conta.Domain.Entidades;
using Conta.Domain.Entidades.Interface;
using Conta.Domain.Entidades.Interface.Base;
using System.Collections.Generic;

namespace Conta.Infrastucture.Repository.Generic
{
    public abstract class RepositoryGeneric<T> where T : IEntidadeBase
    {

        protected IList<IContaCorrente> _contasCorrentes;

        public RepositoryGeneric()
        {
            _contasCorrentes = new List<IContaCorrente>();
            _contasCorrentes.Add(new ContaCorrente { Numero = "11114", Saldo = 1000M });
            _contasCorrentes.Add(new ContaCorrente { Numero = "22228", Saldo = 100M });
        }

        public abstract void Salvar(T entidade);

        public abstract T Buscar(T entidade);
    }
}
