using Conta.Domain.Regras.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Regras.Interface
{
    /// <summary>
    /// Responsável pelos dados de Conta Corrente
    /// </summary>
    public interface IRegraContaCorrente : IRegraBase
    {
        /// <summary>
        /// Atualizar saldo na conta corrente
        /// </summary>
        void AtualizarSaldo();
        /// <summary>
        /// Atualizar saldo de conta corrente
        /// </summary>
        /// <param name="valor">Valor a ser adicionado à conta corrente</param>
        void AtualizarSaldo(decimal valor);
        /// <summary>
        /// Atualiza saldo de conta corrente
        /// </summary>
        /// <param name="valor">Valor a ser adicionado à conta corrente</param>
        /// <param name="descricao">Descrição adicionada ao evento de atualização de conta</param>
        void AtualizarSaldo(decimal valor, string descricao);

    }
}
