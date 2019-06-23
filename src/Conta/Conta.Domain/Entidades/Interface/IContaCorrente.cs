using Conta.Domain.Entidades.Interface.Base;
using System.Collections.Generic;

namespace Conta.Domain.Entidades.Interface
{
    /// <summary>
    /// Responsável pelos dados de Conta Corrente
    /// </summary>
    public interface IContaCorrente : IEntidadeBase
    {
        /// <summary>
        /// Numero da conta corrente
        /// </summary>
        string Numero { get; set; }
        /// <summary>
        /// Saldo da conta corrente
        /// </summary>
        decimal Saldo { get; set; }
        /// <summary>
        /// Histórico de lancamentos da conta
        /// </summary>
        IList<Lancamento> Lancamentos { get; set; }
    }
}
